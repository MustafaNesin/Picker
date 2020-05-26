namespace Picker.Views
{
    using System.Windows.Forms;
    using Models;

    internal partial class ListItemControl<TEntity> : UserControl
        where TEntity : IEntity
    {
        private readonly bool _adminMode;
        private readonly TEntity _entity;

        public ListItemControl(TEntity entity, bool adminMode)
        {
            InitializeComponent();
            _entity = entity;
            _adminMode = adminMode;
        }
    }
}