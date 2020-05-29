namespace Picker
{
    using System.Windows.Forms;

    internal partial class BrandItemView : UserControl
    {
        private readonly BrandListPresenter _presenter;

        public BrandItemView(BrandListPresenter presenter, Brand entity)
        {
            InitializeComponent();

            // TEST KODLARI -- SİLİNECEK
            _presenter = presenter;
            nameLabel.Text = entity.Name;
            countryLabel.Text = entity.Country;
            BackColor = entity.Color;
        }
    }
}