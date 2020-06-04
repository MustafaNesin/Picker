namespace Picker
{
    using System;
    using System.Drawing;
    using System.Windows.Forms;
    using Properties;

    internal partial class SocketView : Form, ISocketView
    {
        private readonly SocketPresenter _presenter;
        private Brand _brand;

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

        public Brand SocketBrand
        {
            get => _brand;
            set
            {
                if (value == null)
                    return;

                _brand = value;
                brandBox.Text = value.Name;
                brandBox.BackColor = selectImageButton.BackColor =
                    acceptButton.BackColor = cancelButton.BackColor = value.Color;
            }
        }

        public bool SocketSupportsDDR2
        {
            get => ddr2Box.Checked;
            set => ddr2Box.Checked = value;
        }

        public bool SocketSupportsDDR3
        {
            get => ddr3Box.Checked;
            set => ddr3Box.Checked = value;
        }

        public bool SocketSupportsDDR4
        {
            get => ddr4Box.Checked;
            set => ddr4Box.Checked = value;
        }

        public SocketView(SocketPresenter presenter)
        {
            InitializeComponent();
            _presenter = presenter;
        }

        private void acceptButton_Click(object sender, EventArgs e)
        {
            if (_presenter.AdminMode && !_presenter.Validate())
                DialogResult = DialogResult.None;
        }

        private async void brandBox_Click(object sender, EventArgs e)
        {
            if (_presenter.AdminMode)
            {
                await using var presenter = new BrandListPresenter(false);
                if (presenter.ShowView() == DialogResult.Cancel)
                    return;

                (SocketBrand = presenter.SelectedEntity).DisposeImage();
            }
            else
            {
                await using var presenter = new BrandPresenter(SocketBrand, false);
                presenter.ShowView();
            }
        }

        private void deleteImageButton_Click(object sender, EventArgs e) => EntityImage = null;

        private void selectImageButton_Click(object sender, EventArgs e)
        {
            string fileName;

            if ((fileName = DatabaseUtilities.ShowImageDialog()) == null)
                return;

            EntityImage = Utilities.TryLoadImage(fileName);
        }

        private void SocketView_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (_presenter.AdminMode && DialogResult == DialogResult.OK)
                return;

            EntityImage = null;
        }

        private void SocketView_Load(object sender, EventArgs e)
        {
            if (_presenter.AdminMode)
                return;

            selectImageButton.Visible = deleteImageButton.Visible = cancelButton.Visible = false;
            entityPanel.MakeReadOnly();
        }
    }
}