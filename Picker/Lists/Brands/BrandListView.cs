namespace Picker
{
    using System;
    using System.Windows.Forms;

    internal partial class BrandListView : Form, IBrandListView
    {
        private readonly BrandListPresenter _presenter;

        public BrandListView(BrandListPresenter presenter)
        {
            InitializeComponent();
            _presenter = presenter;
        }

        private async void BrandListView_Load(object sender, EventArgs e)
            => await _presenter.GenerateList();
    }
}