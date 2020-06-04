namespace Picker
{
    using System;
    using System.Drawing;
    using System.Windows.Forms;
    using Properties;

    internal partial class MemoryView : Form, IMemoryView
    {
        private readonly MemoryPresenter _presenter;
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
            get => string.IsNullOrWhiteSpace(MemoryModel) 
                ? MemoryModel
                : $"{MemoryBrand.Name} {MemoryModel} {MemoryCapacity * MemoryCount} GB " +
                  $"({MemoryCount} x {MemoryCapacity} GB) {MemoryType}-{MemoryFrequency}";
            set => Text = value;
        }

        public Brand MemoryBrand
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

        public string MemoryModel
        {
            get => modelBox.Text;
            set => modelBox.Text = value;
        }

        public decimal MemoryPrice
        {
            get => priceBox.Value;
            set => priceBox.Value = value;
        }

        public string MemoryType
        {
            get => typeBox.Text.ToUpper();
            set => typeBox.Text = value;
        }

        public int MemoryCapacity
        {
            get => (int)capacityBox.Value;
            set => capacityBox.Value = value;
        }

        public int MemoryCount
        {
            get => (int)countBox.Value;
            set => countBox.Value = value;
        }

        public int MemoryFrequency
        {
            get => (int)frequencyBox.Value;
            set => frequencyBox.Value = value;
        }

        public bool MemoryHasECC
        {
            get => eccBox.Checked;
            set => eccBox.Checked = value;
        }

        public bool MemoryIsBuffered
        {
            get => bufferedBox.Checked;
            set => bufferedBox.Checked = value;
        }

        public MemoryView(MemoryPresenter presenter)
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

                (MemoryBrand = presenter.SelectedEntity).DisposeImage();
            }
            else
            {
                await using var presenter = new BrandPresenter(MemoryBrand, false);
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

        private void MemoryView_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (_presenter.AdminMode && DialogResult == DialogResult.OK)
                return;

            EntityImage = null;
        }

        private void MemoryView_Load(object sender, EventArgs e)
        {
            if (_presenter.AdminMode)
                return;

            selectImageButton.Visible = deleteImageButton.Visible = cancelButton.Visible = false;
            entityPanel.MakeReadOnly();
        }

        private void frequencyBox_ValueChanged(object sender, EventArgs e)
            => bandwidthLabel.Text = "MHz, Bant Genişliği: " +
                                     DatabaseUtilities.GetBandwidth((int)frequencyBox.Value, 64) +
                                     " MB/s";

        private void kit_ValueChanged(object sender, EventArgs e)
            => capacityLabel.Text = "GB = " + (int)countBox.Value * (int)capacityBox.Value + " GB";
    }
}