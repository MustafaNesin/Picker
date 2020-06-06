namespace Picker
{
    using System.Drawing;
    using System.Threading.Tasks;
    using System.Windows.Forms;

    internal abstract class EntityPresenter<TView, TEntity> : Presenter<TView>
        where TView : Form, IEntityView
        where TEntity : Entity
    {
        public TEntity Entity { get; }

        protected EntityPresenter(TEntity entity, bool adminMode) : base(adminMode)
        {
            Entity = entity;
            View.EntityName = Entity.Name;
            if (!(Entity is Build))
                View.EntityImage = Entity.Id == 0 ? null : (Image)Entity.Image?.Clone();
        }

        public override DialogResult ShowView()
        {
            var result = base.ShowView();

            if (AdminMode && result == DialogResult.OK)
                UpdateEntity();

            return result;
        }

        protected virtual void UpdateEntity()
        {
            if (!(Entity is Build))
                Entity.Image = View.EntityImage;

            Entity.Name = View.EntityName;
        }

        public bool ValidateName()
        {
            if (!string.IsNullOrWhiteSpace(View.EntityName))
                return true;

            Utilities.ShowError("Lütfen bir ad girin.");
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