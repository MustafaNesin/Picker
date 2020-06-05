namespace Picker
{
    using System.Collections.Generic;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    using System.Linq;
    using System.Threading.Tasks;
    using System.Windows.Forms;

    internal sealed class BuildListPresenter
        : ListPresenter<BuildListView, Build, BuildPresenter, BuildView,
            BuildItemView>
    {
        protected override Panel ListPanel => View.listPanel;

        public BuildListPresenter(bool adminMode) : base(adminMode)
        {
        }

        public BuildListPresenter(Build build) : base(build)
        {
        }

        protected override Build CreateEmptyEntity()
            => new Build
            {
                Name = string.Empty
            };

        protected override async Task<List<Build>> GetEntitiesAsync(
            ComputerDatabaseContext context, bool paging)
        {
            var query = context.Builds.AsQueryable();
            var totalItemCount = await query.CountAsync();
            return await RunQueryAsync(query, totalItemCount, paging);
        }

        protected override async Task LoadRelationsAsync(ComputerDatabaseContext context, DbEntityEntry<Build> entry)
        {
            await entry.Reference(entity => entity.GraphicsCard).LoadAsync();
            await entry.Reference(entity => entity.Motherboard).LoadAsync();
            await entry.Reference(entity => entity.Processor).LoadAsync();
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