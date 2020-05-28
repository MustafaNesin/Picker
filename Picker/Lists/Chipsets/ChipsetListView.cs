namespace Picker
{
    using System.Windows.Forms;

    internal partial class ChipsetListView : Form, IChipsetListView
    {
        private ChipsetListPresenter _presenter;

        public ChipsetListView(ChipsetListPresenter presenter)
        {
            InitializeComponent();
            _presenter = presenter;
        }
    }
}