namespace Picker
{
    using System.Windows.Forms;

    internal partial class ChipsetView : Form, IChipsetView
    {
        private ChipsetPresenter _presenter;

        public ChipsetView(ChipsetPresenter presenter)
        {
            InitializeComponent();
            _presenter = presenter;
        }
    }
}