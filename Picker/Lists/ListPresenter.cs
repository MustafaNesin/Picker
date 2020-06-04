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
        public bool GeneratingList { get; private set; }
        protected abstract Panel ListPanel { get; }
        protected Build Build { get; }
        public TEntity SelectedEntity { get; private set; }

        protected ListPresenter(bool adminMode) : base(adminMode)
        {
        }

        protected ListPresenter(Build build) : base(build == null)
        {
            Build = build;
        }

        public async Task AddItemAsync()
        {
            var entity = CreateEmptyEntity();

            await using (var presenter = CreateEntityPresenter(entity))
                if (presenter.ShowView() == DialogResult.Cancel)
                {
                    entity.ReleasePendingImage();
                    entity.Image = null;
                    return;
                }

            using (var context = new ComputerDatabaseContext())
            {
                var entry = context.Entry(entity);
                entry.State = EntityState.Added;
                StateRelationsUnchanged(context, entity);
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

                entry.State = EntityState.Deleted;
                await context.SaveChangesAsync();
            }

            entity.Image = null;
            await GenerateListAsync();
        }

        public async Task EditItemAsync(TItemView itemView, TEntity entity)
        {
            await using (var presenter = CreateEntityPresenter(entity))
                if (presenter.ShowView() == DialogResult.Cancel)
                    return;

            using (var context = new ComputerDatabaseContext())
            {
                var entry = context.Entry(entity);
                entry.State = EntityState.Modified;
                await LoadRelationsAsync(entry);
                StateRelationsUnchanged(context, entity);
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
                    await LoadRelationsAsync(context.Entry(entity));

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

        protected abstract Task LoadRelationsAsync(DbEntityEntry<TEntity> entry);

        public async Task<List<TEntity>> RunQueryAsync(IQueryable<TEntity> query, int totalItemCount, bool paging)
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

        protected abstract void StateRelationsUnchanged(ComputerDatabaseContext context,
            TEntity entity);

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