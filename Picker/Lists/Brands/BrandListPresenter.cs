namespace Picker
{
    using System.Collections.Generic;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    using System.Drawing;
    using System.Linq;
    using System.Threading.Tasks;
    using System.Windows.Forms;

    internal sealed class BrandListPresenter
        : ListPresenter<BrandListView, Brand, BrandPresenter, BrandView, BrandItemView>
    {
        protected override Panel ListPanel => View.listPanel;

        public BrandListPresenter(bool adminMode) : base(adminMode)
        {
        }

        protected override Brand CreateEmptyEntity()
            => new Brand
            {
                Color = Color.Green,
                Country = (Country)(-1),
                Name = string.Empty
            };

        protected override async Task<List<Brand>> GetEntitiesAsync(ComputerDatabaseContext context,
            bool paging)
        {
            var query = context.Brands.AsQueryable();
            var totalItemCount = await query.CountAsync();

            if (!string.IsNullOrWhiteSpace(View.EntityName))
                query = query.Where(entity => entity.Name.Contains(View.EntityName));

            if ((int)View.BrandCountry != -1)
                query = query.Where(entity => entity.Country == View.BrandCountry);

            query = View.OrderIndex switch
            {
                1 => query.OrderByDescending(entity => entity.Id), // Yeniden eskiye
                2 => query.OrderBy(entity => entity.Name), // İsme göre (A-Z)
                3 => query.OrderByDescending(entity => entity.Name), // İsme göre (Z-A)
                4 => query.OrderBy(entity => entity.Country), // Ülke ismine göre (A-Z)
                5 => query.OrderByDescending(entity => entity.Country), // Ülke ismine göre (Z-A)
                _ => query.OrderBy(entity => entity.Id) // Eskiden yeniye
            };

            return await RunQueryAsync(query, totalItemCount, paging);
        }

        protected override async Task LoadRelationsAsync(ComputerDatabaseContext context, DbEntityEntry<Brand> entry)
            => await Task.Delay(1);

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