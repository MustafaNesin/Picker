namespace Picker
{
    using System.Windows.Forms;

    internal partial class MemoryListView : Form, IMemoryListView
    {
        private readonly MemoryListPresenter _presenter;

        public MemoryListView(MemoryListPresenter presenter)
        {
            InitializeComponent();
            _presenter = presenter;
        }
    }
}