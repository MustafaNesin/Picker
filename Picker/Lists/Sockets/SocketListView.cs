namespace Picker
{
    using System.Windows.Forms;

    internal partial class SocketListView : Form, ISocketListView
    {
        private readonly SocketListPresenter _presenter;

        public SocketListView(SocketListPresenter presenter)
        {
            InitializeComponent();
            _presenter = presenter;
        }
    }
}