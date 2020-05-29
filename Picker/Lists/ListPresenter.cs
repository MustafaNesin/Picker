﻿namespace Picker
{
    using System.Collections.Generic;
    using System.Threading.Tasks;
    using System.Windows.Forms;

    internal abstract class ListPresenter<TView, TEntity> : Presenter<TView>
        where TView : Form
        where TEntity : Entity
    {
        protected List<TEntity> EntityList { get; set; }

        #region Disposing
        private bool _disposed;

        protected override async ValueTask DisposeAsync(bool disposing)
        {
            if (_disposed)
                return;

            if (disposing)
                ;

            EntityList.Clear();
            _disposed = true;
            await base.DisposeAsync(disposing);
        }
        #endregion
    }
}