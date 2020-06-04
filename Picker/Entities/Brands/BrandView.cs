namespace Picker
{
    using System;
    using System.Drawing;
    using System.Windows.Forms;
    using Properties;

    internal partial class BrandView : Form, IBrandView
    {
        private readonly BrandPresenter _presenter;

        public Color BrandColor
        {
            get => pickColorButton.BackColor;
            set => pickColorButton.BackColor = selectImageButton.BackColor =
                acceptButton.BackColor = cancelButton.BackColor = value;
        }

        public Country BrandCountry
        {
            get => (Country)countryBox.SelectedIndex;
            set => countryBox.SelectedIndex = (int)value;
        }

        public Image EntityImage
        {
            get => imageBox.Image;
            set
            {
                imageBox.DisposeImage();

                if (!_presenter.AdminMode)
                {
                    imageBox.Image = value ?? Resources.FavIcon64;
                    return;
                }

                imageBox.Dock = value == null ? DockStyle.None : DockStyle.Top;
                imageBox.Visible = deleteImageButton.Visible = value != null;
                imageBox.Image = value;
            }
        }

        public string EntityName
        {
            get => nameBox.Text;
            set => nameBox.Text = value;
        }

        public BrandView(BrandPresenter presenter)
        {
            InitializeComponent();
            _presenter = presenter;
            countryBox.Items.AddRange(Utilities.GetCountryNames());
        }

        private void acceptButton_Click(object sender, EventArgs e)
        {
            if (_presenter.AdminMode && !_presenter.Validate())
                DialogResult = DialogResult.None;
        }

        private void BrandView_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (_presenter.AdminMode && DialogResult == DialogResult.OK)
                return;

            EntityImage = null;
        }

        private void BrandView_Load(object sender, EventArgs e)
        {
            if (_presenter.AdminMode)
                return;

            Height = 160;
            label3.Visible = pickColorButton.Visible = selectImageButton.Visible =
                deleteImageButton.Visible = cancelButton.Visible = false;

            entityPanel.MakeReadOnly();
        }

        private void deleteImageButton_Click(object sender, EventArgs e) => EntityImage = null;

        private void pickColorButton_Click(object sender, EventArgs e)
        {
            using var dialog = new ColorDialog();

            if (dialog.ShowDialog() == DialogResult.Cancel)
                return;

            BrandColor = dialog.Color;
        }

        private void selectImageButton_Click(object sender, EventArgs e)
        {
            string fileName;

            if ((fileName = DatabaseUtilities.ShowImageDialog()) == null)
                return;

            EntityImage = Utilities.TryLoadImage(fileName);
        }
    }
}