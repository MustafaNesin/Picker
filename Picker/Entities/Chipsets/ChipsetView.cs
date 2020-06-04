namespace Picker
{
    using System;
    using System.Drawing;
    using System.Windows.Forms;
    using Properties;

    internal partial class ChipsetView : Form, IChipsetView
    {
        private readonly ChipsetPresenter _presenter;
        private Brand _brand;

        public Brand ChipsetBrand
        {
            get => _brand;
            set
            {
                if (value == null)
                    return;

                _brand = value;
                brandButton.Text = value.Name;
                brandButton.BackColor = selectImageButton.BackColor =
                    acceptButton.BackColor = cancelButton.BackColor = value.Color;
            }
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

        public ChipsetView(ChipsetPresenter presenter)
        {
            InitializeComponent();
            _presenter = presenter;
        }

        private void acceptButton_Click(object sender, EventArgs e)
        {
            if (_presenter.AdminMode && !_presenter.Validate())
                DialogResult = DialogResult.None;
        }

        private async void brandButton_Click(object sender, EventArgs e)
        {
            if (_presenter.AdminMode)
            {
                await using var presenter = new BrandListPresenter(false);
                if (presenter.ShowView() == DialogResult.Cancel)
                    return;

                (ChipsetBrand = presenter.SelectedEntity).DisposeImage();
            }
            else
            {
                await using var presenter = new BrandPresenter(ChipsetBrand, false);
                presenter.ShowView();
            }
        }

        private void ChipsetView_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (_presenter.AdminMode && DialogResult == DialogResult.OK)
                return;

            EntityImage = null;
        }

        private void ChipsetView_Load(object sender, EventArgs e)
        {
            if (_presenter.AdminMode)
                return;

            selectImageButton.Visible = deleteImageButton.Visible = cancelButton.Visible = false;
            entityPanel.MakeReadOnly();
        }

        private void deleteImageButton_Click(object sender, EventArgs e) => EntityImage = null;

        private void selectImageButton_Click(object sender, EventArgs e)
        {
            string fileName;

            if ((fileName = DatabaseUtilities.ShowImageDialog()) == null)
                return;

            EntityImage = Utilities.TryLoadImage(fileName);
        }
    }
}