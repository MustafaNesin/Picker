﻿namespace Picker
{
    using System.Threading.Tasks;

    internal sealed class MemoryPresenter : EntityPresenter<MemoryView, Memory>
    {
        public MemoryPresenter(Memory entity) : base(entity)
        {
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