namespace Picker
{
    using System.Windows.Forms;

    internal partial class MotherboardListView : Form, IMotherboardListView
    {
        private readonly MotherboardListPresenter _presenter;

        public MotherboardListView(MotherboardListPresenter presenter)
        {
            InitializeComponent();
            _presenter = presenter;
        }
    }
}