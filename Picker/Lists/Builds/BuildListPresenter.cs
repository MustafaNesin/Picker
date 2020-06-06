namespace Picker
{
    using System.Collections.Generic;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    using System.Linq;
    using System.Threading.Tasks;
    using System.Windows.Forms;

    internal sealed class BuildListPresenter
        : ListPresenter<BuildListView, Build, BuildPresenter, BuildView, BuildItemView>
    {
        protected override Panel ListPanel => View.listPanel;

        public BuildListPresenter(bool adminMode) : base(adminMode)
        {
        }

        protected override Build CreateEmptyEntity() => new Build { Name = string.Empty };

        protected override async Task<List<Build>> GetEntitiesAsync(ComputerDatabaseContext context,
            bool paging)
        {
            var query = context.Builds.AsQueryable();
            var totalItemCount = await query.CountAsync();
            query = query.OrderByDescending(entity => entity.Date);
            return await RunQueryAsync(query, totalItemCount, paging);
        }

        public override async Task LoadRelationsAsync(ComputerDatabaseContext context,
            DbEntityEntry<Build> entry)
        {
            if (entry.Entity.GraphicsCard != null)
            {
                await entry.Reference(entity => entity.GraphicsCard).LoadAsync();
                var graphicsCard = context.Entry(entry.Entity.GraphicsCard);
                await graphicsCard.Reference(entity => entity.Brand).LoadAsync();
                await graphicsCard.Reference(entity => entity.ChipsetBrand).LoadAsync();
            }

            if (entry.Entity.Motherboard != null)
            {
                await entry.Reference(entity => entity.Motherboard).LoadAsync();
                var motherboard = context.Entry(entry.Entity.Motherboard);
                await motherboard.Reference(entity => entity.Brand).LoadAsync();

                await motherboard.Reference(entity => entity.Chipset).LoadAsync();
                var chipset = context.Entry(entry.Entity.Motherboard.Chipset);
                await chipset.Reference(entity => entity.Brand).LoadAsync();

                await motherboard.Reference(entity => entity.Socket).LoadAsync();
                var socket = context.Entry(entry.Entity.Motherboard.Socket);
                await socket.Reference(entity => entity.Brand).LoadAsync();
            }

            if (entry.Entity.Processor != null)
            {
                await entry.Reference(entity => entity.Processor).LoadAsync();
                var processor = context.Entry(entry.Entity.Processor);
                await processor.Reference(entity => entity.Brand).LoadAsync();
                await processor.Reference(entity => entity.Socket).LoadAsync();
                await context.Entry(entry.Entity.Processor.Socket).Reference(entity => entity.Brand)
                    .LoadAsync();
            }
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