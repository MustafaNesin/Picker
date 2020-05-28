namespace Picker
{
    using System.Windows.Forms;

    internal partial class BrandListView : Form, IBrandListView
    {
        private BrandListPresenter _presenter;

        public BrandListView(BrandListPresenter presenter)
        {
            InitializeComponent();
            _presenter = presenter;
        }
    }
}