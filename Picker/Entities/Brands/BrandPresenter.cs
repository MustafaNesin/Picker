namespace Picker
{
    using System.Threading.Tasks;

    internal class BrandPresenter : EntityPresenter<BrandView, Brand>
    {
        public BrandPresenter(Brand entity, bool adminMode) : base(entity, adminMode)
        {
            View.Text = string.IsNullOrEmpty(Entity.Name) ? "Yeni Marka" : Entity.Name;
            View.BrandColor = Entity.Color;
            View.BrandCountry = Entity.Country;
        }

        protected override void UpdateEntity()
        {
            Entity.Color = View.BrandColor;
            Entity.Country = View.BrandCountry;
            base.UpdateEntity();
        }

        public bool Validate()
        {
            if ((int)View.BrandCountry != -1)
                return ValidateName();

            Utilities.ShowError("Lütfen bir ülke seçin.");
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