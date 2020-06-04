namespace Picker
{
    using System;
    using System.Threading.Tasks;
    using System.Windows.Forms;

    internal abstract class Presenter<TView> : IAsyncDisposable
        where TView : Form, IView
    {
        public bool AdminMode { get; }
        protected TView View { get; }
        public DialogResult ViewResult { get; private set; }

        protected Presenter(bool adminMode)
        {
            AdminMode = adminMode;
            View = (TView)Activator.CreateInstance(typeof(TView), this);
        }

        public virtual DialogResult ShowView() => ViewResult = View.ShowDialog();

        #region Disposing
        private bool _disposed;

        public async ValueTask DisposeAsync() => await DisposeAsync(true);

        protected virtual ValueTask DisposeAsync(bool disposing)
        {
            if (_disposed)
                return default;

            if (disposing)
            {
                View.Close();
                View.Dispose();
            }

            _disposed = true;
            return default;
        }
        #endregion
    }
}