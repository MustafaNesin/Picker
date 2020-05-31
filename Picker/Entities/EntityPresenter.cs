namespace Picker
{
    using System.Drawing;
    using System.Threading.Tasks;
    using System.Windows.Forms;

    internal abstract class EntityPresenter<TView, TEntity> : Presenter<TView>
        where TView : Form
        where TEntity : class
    {
        protected ComputerDatabaseContext Context { get; }
        public TEntity Entity { get; }
        public Image EntityImage { get; set; }
        public bool IsImageChanged { get; set; }

        protected EntityPresenter(TEntity entity)
        {
            Entity = entity;
            Context = new ComputerDatabaseContext();
        }

        #region Disposing
        private bool _disposed;

        protected override async ValueTask DisposeAsync(bool disposing)
        {
            if (_disposed)
                return;

            if (disposing)
            {
                if (ViewResult == DialogResult.OK)
                    await Context.SaveChangesAsync();

                Context.Dispose();
            }

            _disposed = true;
            await base.DisposeAsync(disposing);
        }
        #endregion
    }
}