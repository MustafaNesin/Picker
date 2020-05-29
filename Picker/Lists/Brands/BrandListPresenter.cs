namespace Picker
{
    using System.Data.Entity;
    using System.Linq;
    using System.Threading.Tasks;
    using System.Windows.Forms;

    internal sealed class BrandListPresenter : ListPresenter<BrandListView, Brand>
    {
        public async Task GenerateList()
        {
            using var context = new ComputerDatabaseContext();

            EntityList = await context.Brands.AsQueryable().Take(5).ToListAsync();

            foreach (var entity in EntityList)
                View.listPanel.Controls.Add(new BrandItemView(this, entity) { Dock = DockStyle.Top });
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