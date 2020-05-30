namespace Picker
{
    using System.Data.Entity;
    using System.Linq;
    using System.Threading.Tasks;
    using System.Windows.Forms;

    internal sealed class BrandListPresenter : ListPresenter<BrandListView, Brand>
    {
        public async Task EditItem(BrandItemView brandItemView, Brand brand)
        {
            await using (var presenter = new BrandPresenter(brand))
                presenter.ShowView();

            UpdateItem(brandItemView, brand);
        }

        public async Task GenerateList()
        {
            using (var context = new ComputerDatabaseContext())
                EntityList = await context.Brands.AsQueryable().Take(5).ToListAsync();

            // ReSharper disable once ForeachCanBePartlyConvertedToQueryUsingAnotherGetEnumerator
            foreach (var brand in EntityList)
            {
                var brandItemView = new BrandItemView(this, brand) { Dock = DockStyle.Top };
                UpdateItem(brandItemView, brand);
                View.listPanel.Controls.Add(brandItemView);
                brandItemView.BringToFront();
            }
        }

        public void UpdateItem(BrandItemView brandItemView, Brand brand)
        {
            brandItemView.BrandName = brand.Name;
            brandItemView.BrandCountry = brand.Country;
            brandItemView.BrandColor = brand.Color;
            // TODO Use brandItemView.BrandImage
        }

        #region Disposing
        private bool _disposed;

        protected override async ValueTask DisposeAsync(bool disposing)
        {
            if (_disposed)
                return;

            if (disposing)
                ;

            _disposed = true;
            await base.DisposeAsync(disposing);
        }
        #endregion
    }
}