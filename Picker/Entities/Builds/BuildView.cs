namespace Picker
{
    using System.Windows.Forms;

    internal partial class BuildView : Form, IBuildView
    {
        private BuildPresenter _presenter;

        public BuildView(BuildPresenter presenter)
        {
            InitializeComponent();
            _presenter = presenter;
        }
    }
}