namespace Picker
{
    using System;
    using System.Drawing;
    using System.Windows.Forms;

    internal partial class BrandItemView : UserControl, IBrandItemView
    {
        private readonly Brand _brand;
        private readonly BrandListPresenter _presenter;
        private Country _country;

        public Color BrandColor
        {
            get => BackColor;
            set
            {
                BackColor = value;

                foreach (var control in itemPanel.Controls)
                    switch (control)
                    {
                        case Button button:
                            button.BackColor = value;
                            break;
                        case Label label:
                            label.ForeColor = value;
                            break;
                    }
            }
        }

        public Country BrandCountry
        {
            get => _country;
            set => countryLabel.Text = (_country = value).GetDescription();
        }

        public Image BrandImage
        {
            get => imageBox.Image;
            set => imageBox.Image = value;
        }

        public string BrandName
        {
            get => nameLabel.Text;
            set => nameLabel.Text = value;
        }

        public BrandItemView(BrandListPresenter presenter, Brand brand)
        {
            InitializeComponent();

            _brand = brand;
            _presenter = presenter;
        }

        private async void deleteButton_Click(object sender, EventArgs e)
            => await _presenter.DeleteItemAsync(this, _brand);

        private async void editButton_Click(object sender, EventArgs e)
            => await _presenter.EditItemAsync(this, _brand);
    }
}