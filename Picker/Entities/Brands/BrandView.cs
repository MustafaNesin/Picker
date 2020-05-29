namespace Picker
{
    using System.Windows.Forms;

    internal partial class BrandView : Form, IBrandView
    {
        private readonly BrandPresenter _presenter;

        public BrandView(BrandPresenter presenter)
        {
            InitializeComponent();
            _presenter = presenter;
        }
    }
}