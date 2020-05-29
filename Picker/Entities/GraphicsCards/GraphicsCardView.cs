namespace Picker
{
    using System.Windows.Forms;

    internal partial class GraphicsCardView : Form, IGraphicsCardView
    {
        private readonly GraphicsCardPresenter _presenter;

        public GraphicsCardView(GraphicsCardPresenter presenter)
        {
            InitializeComponent();
            _presenter = presenter;
        }
    }
}