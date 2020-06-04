namespace Picker
{
    using System.Threading.Tasks;

    internal sealed class SocketPresenter : EntityPresenter<SocketView, Socket>
    {
        public SocketPresenter(Socket entity, bool adminMode) : base(entity, adminMode)
        {
            View.Text = string.IsNullOrEmpty(Entity.Name) ? "Yeni Soket" : Entity.Name;
            View.SocketBrand = entity.Brand;
            View.SocketSupportsDDR2 = entity.SupportsDDR2;
            View.SocketSupportsDDR3 = entity.SupportsDDR3;
            View.SocketSupportsDDR4 = entity.SupportsDDR4;
        }

        protected override void UpdateEntity()
        {
            Entity.Brand = View.SocketBrand;
            Entity.BrandId = View.SocketBrand.Id;
            Entity.SupportsDDR2 = View.SocketSupportsDDR2;
            Entity.SupportsDDR3 = View.SocketSupportsDDR3;
            Entity.SupportsDDR4 = View.SocketSupportsDDR4;
            base.UpdateEntity();
        }

        public bool Validate()
        {
            if (View.SocketBrand != null)
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