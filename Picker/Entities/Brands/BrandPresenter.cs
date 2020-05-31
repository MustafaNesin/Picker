namespace Picker
{
    using System.IO;
    using System.Linq;
    using System.Threading.Tasks;
    using System.Windows.Forms;

    internal class BrandPresenter : EntityPresenter<BrandView, Brand>
    {
        public BrandPresenter(Brand entity) : base(entity)
        {
            View.BrandColor = entity.Color;
            View.BrandName = entity.Name;
            View.BrandCountry = entity.Country;

            var imagePath = string.Format(Utilities.ImagePathFormat, "brands", entity.Id);
            if (File.Exists(imagePath))
            {
                View.BrandImage?.Dispose();
                View.BrandImage = Utilities.LoadImage(imagePath);
            }

            View.Text = string.IsNullOrEmpty(View.BrandName) ? "Yeni Marka" : View.BrandName;
        }

        public bool IsBrandExist(string newName)
            => Context.Brands.Any(brand
                => string.IsNullOrEmpty(Entity.Name)
                    ? brand.Name == newName
                    : newName != Entity.Name && brand.Name == newName);

        public override DialogResult ShowView()
        {
            var result = base.ShowView();

            if (result == DialogResult.Cancel)
            {
                View.BrandImage?.Dispose();
                return result;
            }

            Entity.Color = View.BrandColor;
            Entity.Name = View.BrandName;
            Entity.Country = View.BrandCountry;
            EntityImage = View.BrandImage;

            return result;
        }

        public bool Validate()
        {
            if (string.IsNullOrWhiteSpace(View.BrandName))
                Utilities.ShowError("Lütfen bir ad girin.");

            else if (IsBrandExist(View.BrandName))
                Utilities.ShowError("Aynı adda bir marka zaten var.");

            else if ((int)View.BrandCountry == -1)
                Utilities.ShowError("Lütfen bir ülke seçin.");

            else
                return true;

            return false;
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