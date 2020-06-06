namespace Picker
{
    using System;
    using System.Collections.Generic;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    using System.Linq;
    using System.Threading.Tasks;
    using System.Windows.Forms;

    internal abstract class ListPresenter
        <TListView, TEntity, TEntityPresenter, TEntityView, TItemView> : Presenter<TListView>
        where TListView : Form, IListView
        where TEntity : Entity
        where TEntityPresenter : EntityPresenter<TEntityView, TEntity>
        where TEntityView : Form, IEntityView
        where TItemView : UserControl, IItemView<TEntity>
    {
        public BuildPresenter BuildPresenter { get; }
        public bool GeneratingList { get; private set; }
        protected abstract Panel ListPanel { get; }
        public TEntity SelectedEntity { get; private set; }

        protected ListPresenter(bool adminMode) : base(adminMode)
        {
        }

        protected ListPresenter(BuildPresenter buildPresenter) : base(buildPresenter == null)
            => BuildPresenter = buildPresenter;

        public async Task AddItemAsync()
        {
            List<Chipset> chipsets = null;
            var entity = CreateEmptyEntity();
            List<Memory> memories = null;

            await using (var presenter = CreateEntityPresenter(entity))
                if (presenter.ShowView() == DialogResult.Cancel)
                {
                    entity.ReleasePendingImage();
                    entity.Image = null;
                    return;
                }
                else if (presenter is ProcessorPresenter processorPresenter)
                    chipsets = processorPresenter.Chipsets;
                else if (presenter is BuildPresenter buildPresenter)
                    memories = buildPresenter.Memories;

            using (var context = new ComputerDatabaseContext())
            {
                if (chipsets != null)
                    foreach (var chipset in chipsets)
                        context.ProcessorChipsets.Add(new ProcessorChipset
                        {
                            ProcessorId = entity.Id,
                            ChipsetId = chipset.Id
                        });

                if (memories != null)
                    foreach (var memory in memories)
                        context.BuildMemories.Add(new BuildMemory
                        {
                            BuildId = entity.Id,
                            MemoryId = memory.Id
                        });

                var entry = context.Entry(entity);
                entry.State = EntityState.Added;
                context.ClearTrackingEntities(entity);
                await context.SaveChangesAsync();
            }

            entity.SaveImage();
            entity.DisposeImage();
            await GenerateListAsync();
        }

        protected abstract TEntity CreateEmptyEntity();

        public TItemView CreateEntityItemView(TEntity entity)
        {
            var itemView = (TItemView)Activator.CreateInstance(typeof(TItemView), this);
            itemView.Dock = DockStyle.Top;
            itemView.UpdateView(entity);
            return itemView;
        }

        public TEntityPresenter CreateEntityPresenter(TEntity entity)
            => (TEntityPresenter)Activator.CreateInstance(typeof(TEntityPresenter), entity, true);

        public async Task DeleteItemAsync(TEntity entity)
        {
            using (var context = new ComputerDatabaseContext())
            {
                var entry = context.Entry(entity);
                entry.State = EntityState.Unchanged;

                if (!await context.EnsureRelationshipsAsync(entry))
                    return;

                switch (entity)
                {
                    case Processor processor:
                    {
                        var relations = context.ProcessorChipsets.Where(relation
                            => relation.ProcessorId == processor.Id);

                        foreach (var relation in relations)
                            context.Entry(relation).State = EntityState.Deleted;

                        break;
                    }

                    case Chipset chipset:
                    {
                        var relations = context.ProcessorChipsets.Where(relation
                            => relation.ChipsetId == chipset.Id);

                        foreach (var relation in relations)
                            context.Entry(relation).State = EntityState.Deleted;

                        break;
                    }

                    case Build build:
                    {
                        var relations =
                            context.BuildMemories.Where(relation => relation.BuildId == build.Id);

                        foreach (var relation in relations)
                            context.Entry(relation).State = EntityState.Deleted;

                        break;
                    }

                    case Memory memory:
                    {
                        var relations =
                            context.BuildMemories.Where(relation => relation.MemoryId == memory.Id);

                        foreach (var relation in relations)
                            context.Entry(relation).State = EntityState.Deleted;

                        break;
                    }
                }

                entry.State = EntityState.Deleted;
                await context.SaveChangesAsync();
            }

            entity.Image = null;
            await GenerateListAsync();
        }

        public async Task EditItemAsync(TItemView itemView, TEntity entity)
        {
            List<Chipset> chipsets = null;
            List<Memory> memories = null;

            await using (var presenter = CreateEntityPresenter(entity))
                if (presenter.ShowView() == DialogResult.Cancel)
                    return;
                else
                    switch (presenter)
                    {
                        case ProcessorPresenter processorPresenter:
                            chipsets = processorPresenter.Chipsets;
                            break;
                        case BuildPresenter buildPresenter:
                            memories = buildPresenter.Memories;
                            break;
                    }

            using (var context = new ComputerDatabaseContext())
            {
                if (chipsets != null)
                {
                    var relations = context.ProcessorChipsets.Where(p => p.ProcessorId == entity.Id)
                        .ToList();

                    foreach (var relation in relations)
                        if (!chipsets.Exists(chipset => chipset.Id == relation.ChipsetId))
                            context.Entry(relation).State = EntityState.Deleted;

                    foreach (var chipset in chipsets)
                        if (!relations.Exists(relation => chipset.Id == relation.ChipsetId))
                            context.ProcessorChipsets.Add(new ProcessorChipset
                            {
                                ProcessorId = entity.Id,
                                ChipsetId = chipset.Id
                            });
                }

                if (memories != null)
                {
                    foreach (var relation in context.BuildMemories.Where(
                        p => p.BuildId == entity.Id))
                        context.Entry(relation).State = EntityState.Deleted;

                    foreach (var memory in memories)
                        context.BuildMemories.Add(new BuildMemory
                        {
                            BuildId = entity.Id,
                            MemoryId = memory.Id
                        });
                }

                var entry = context.Entry(entity);
                entry.State = EntityState.Modified;
                await LoadRelationsAsync(context, entry);
                context.ClearTrackingEntities(entity);
                await context.SaveChangesAsync();
            }

            itemView.UpdateView(entity);
        }

        public async Task GenerateListAsync(bool paging = false)
        {
            GeneratingList = true;

            ListPanel.Controls.Clear(true);

            List<TEntity> entities;
            using (var context = new ComputerDatabaseContext())
                foreach (var entity in entities = await GetEntitiesAsync(context, paging))
                    await LoadRelationsAsync(context, context.Entry(entity));

            foreach (var itemView in entities.Select(CreateEntityItemView))
            {
                ListPanel.Controls.Add(itemView);
                itemView.BringToFront();
                View.Update();
            }

            GeneratingList = false;
        }

        protected abstract Task<List<TEntity>> GetEntitiesAsync(ComputerDatabaseContext context,
            bool paging);

        public abstract Task LoadRelationsAsync(ComputerDatabaseContext context,
            DbEntityEntry<TEntity> entry);

        public async Task<List<TEntity>> RunQueryAsync(IQueryable<TEntity> query,
            int totalItemCount, bool paging)
        {
            var itemCount = await query.CountAsync();
            var pageCount = itemCount / View.ItemPerPage;
            if (itemCount % View.ItemPerPage != 0)
                pageCount++;

            View.PageCount = pageCount;
            if (!paging)
                View.PageIndex = 0;

            var entities = await query.Skip(View.PageIndex * View.ItemPerPage)
                .Take(View.ItemPerPage).ToListAsync();

            View.SetCountLabel(entities.Count, totalItemCount);
            View.UpdateNavigationButtonsStatus();
            return entities;
        }

        public void SelectEntity(TEntity entity)
        {
            SelectedEntity = entity;
            View.DialogResult = DialogResult.OK;
        }

        #region Disposing
        private bool _disposed;

        protected override async ValueTask DisposeAsync(bool disposing)
        {
            if (_disposed)
                return;

            // if (disposing) ;

            _disposed = true;
            await base.DisposeAsync(disposing);
        }
        #endregion
    }
}