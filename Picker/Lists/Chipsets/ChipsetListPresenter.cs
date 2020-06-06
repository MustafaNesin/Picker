namespace Picker
{
    using System.Collections.Generic;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    using System.Linq;
    using System.Threading.Tasks;
    using System.Windows.Forms;

    internal sealed class ChipsetListPresenter
        : ListPresenter<ChipsetListView, Chipset, ChipsetPresenter, ChipsetView, ChipsetItemView>
    {
        protected override Panel ListPanel => View.listPanel;

        public ChipsetListPresenter(bool adminMode) : base(adminMode)
        {
        }

        protected override Chipset CreateEmptyEntity() => new Chipset { Name = string.Empty };

        protected override async Task<List<Chipset>> GetEntitiesAsync(
            ComputerDatabaseContext context, bool paging)
        {
            var query = context.Chipsets.AsQueryable();
            var totalItemCount = await query.CountAsync();

            if (!string.IsNullOrWhiteSpace(View.EntityName))
                query = query.Where(entity => entity.Name.Contains(View.EntityName));

            if (!string.IsNullOrWhiteSpace(View.ChipsetBrand))
                query = query.Where(entity => entity.Brand.Name.Contains(View.ChipsetBrand));

            query = View.OrderIndex switch
            {
                1 => query.OrderByDescending(entity => entity.Id), // Yeniden eskiye
                2 => query.OrderBy(entity => entity.Name), // İsme göre (A-Z)
                3 => query.OrderByDescending(entity => entity.Name), // İsme göre (Z-A)
                4 => query.OrderBy(entity => entity.Brand.Name), // Marka ismine göre (A-Z)
                5 => query.OrderByDescending(entity
                    => entity.Brand.Name), // Marka ismine göre (Z-A)
                _ => query.OrderBy(entity => entity.Id) // Eskiden yeniye
            };

            return await RunQueryAsync(query, totalItemCount, paging);
        }

        public override async Task LoadRelationsAsync(ComputerDatabaseContext context,
            DbEntityEntry<Chipset> entry)
            => await entry.Reference(entity => entity.Brand).LoadAsync();

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