namespace Picker
{
    using System.Windows.Forms;

    internal partial class GraphicsCardListView : Form, IGraphicsCardListView
    {
        private readonly GraphicsCardListPresenter _presenter;

        public GraphicsCardListView(GraphicsCardListPresenter presenter)
        {
            InitializeComponent();
            _presenter = presenter;
        }
    }
}