namespace Picker
{
    using System.Windows.Forms;

    internal partial class SocketView : Form, ISocketView
    {
        private readonly SocketPresenter _presenter;

        public SocketView(SocketPresenter presenter)
        {
            InitializeComponent();
            _presenter = presenter;
        }
    }
}