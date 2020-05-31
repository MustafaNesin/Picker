namespace Picker
{
    using System.Threading.Tasks;

    internal sealed class BuildPresenter : EntityPresenter<BuildView, Build>
    {
        public BuildPresenter(Build entity) : base(entity)
        {
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