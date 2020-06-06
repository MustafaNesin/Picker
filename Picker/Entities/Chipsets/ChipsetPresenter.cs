namespace Picker
{
    using System.Threading.Tasks;

    internal sealed class ChipsetPresenter : EntityPresenter<ChipsetView, Chipset>
    {
        public ChipsetPresenter(Chipset entity, bool adminMode) : base(entity, adminMode)
        {
            View.Text = string.IsNullOrEmpty(Entity.Name) ? "Yeni Yonga Seti" : Entity.Name;
            View.ChipsetBrand = entity.Brand;
        }

        protected override void UpdateEntity()
        {
            Entity.Brand = null;
            Entity.BrandId = View.ChipsetBrand.Id;
            base.UpdateEntity();
        }

        public bool Validate()
        {
            if (View.ChipsetBrand != null)
                return ValidateName();

            Utilities.ShowError("Lütfen bir marka seçin.");
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