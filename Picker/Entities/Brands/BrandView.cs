namespace Picker
{
    using System;
    using System.Drawing;
    using System.Windows.Forms;

    internal partial class BrandView : Form, IBrandView
    {
        private readonly BrandPresenter _presenter;

        public Color BrandColor
        {
            get => pickColorButton.BackColor;
            set => pickColorButton.BackColor = uploadImageButton.BackColor =
                acceptButton.BackColor = cancelButton.BackColor = value;
        }

        public Country BrandCountry
        {
            get => (Country)countryBox.SelectedIndex;
            set => countryBox.SelectedIndex = (int)value;
        }

        public Image BrandImage
        {
            get => imageBox.Image;
            set => imageBox.Image = value;
        }

        public string BrandName
        {
            get => nameBox.Text;
            set => nameBox.Text = value ?? string.Empty;
        }

        public BrandView(BrandPresenter presenter)
        {
            InitializeComponent();
            _presenter = presenter;
            countryBox.Items.AddRange(Utilities.GetCountryNames());
        }

        private void acceptButton_Click(object sender, EventArgs e)
        {
            if (!_presenter.Validate())
                DialogResult = DialogResult.None;
        }

        private void pickColorButton_Click(object sender, EventArgs e)
        {
            using var dialog = new ColorDialog();

            if (dialog.ShowDialog() == DialogResult.Cancel)
                return;

            BrandColor = dialog.Color;
        }

        private void uploadImageButton_Click(object sender, EventArgs e)
        {
            using var dialog = new OpenFileDialog
            {
                Title = "Bir resim dosyası seçin",
                Filter = "Resim dosyaları|*.png|Tüm dosyalar|*.*"
            };

            if (dialog.ShowDialog() == DialogResult.Cancel)
                return;

            try
            {
                BrandImage?.Dispose();
                BrandImage = Utilities.LoadImage(dialog.FileName);
                _presenter.IsImageChanged = true;
            }
            catch
            {
                Utilities.ShowError("Resim yüklenemedi.");
            }
        }
    }
}