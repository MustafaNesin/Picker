namespace Picker
{
    using System;
    using System.Drawing;
    using System.Windows.Forms;
    using Properties;

    internal partial class GraphicsCardView : Form, IGraphicsCardView
    {
        private readonly GraphicsCardPresenter _presenter;
        private Brand _brand;
        private Brand _chipsetBrand;

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
            get => string.IsNullOrWhiteSpace(GraphicsCardModel)
                ? GraphicsCardModel
                : $"{GraphicsCardBrand.Name} {GraphicsCardChipsetModel} {GraphicsCardModel} " +
                  $"{GraphicsCardMemory} GB {GraphicsCardMemoryType} {GraphicsCardBusWidth} Bit";
            set => Text = value;
        }

        public Brand GraphicsCardBrand
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

        public int GraphicsCardBusWidth
        {
            get => (int)busWidthBox.Value;
            set => busWidthBox.Value = value;
        }

        public Brand GraphicsCardChipsetBrand
        {
            get => _chipsetBrand;
            set
            {
                if (value == null)
                    return;

                _chipsetBrand = value;
                chipsetBrandButton.Text = value.Name;
                chipsetBrandButton.BackColor = value.Color;
            }
        }

        public string GraphicsCardChipsetModel
        {
            get => chipsetModelBox.Text;
            set => chipsetModelBox.Text = value;
        }

        public int GraphicsCardFrequency
        {
            get => (int)frequencyBox.Value;
            set => frequencyBox.Value = value;
        }

        public int GraphicsCardMemory
        {
            get => (int)memoryBox.Value;
            set => memoryBox.Value = value;
        }

        public int GraphicsCardMemoryFrequency
        {
            get => (int)memoryFrequencyBox.Value;
            set => memoryFrequencyBox.Value = value;
        }

        public string GraphicsCardMemoryType
        {
            get => memoryTypeBox.Text.ToUpper();
            set => memoryTypeBox.Text = value;
        }

        public string GraphicsCardModel
        {
            get => modelBox.Text;
            set => modelBox.Text = value;
        }

        public decimal GraphicsCardPrice
        {
            get => priceBox.Value;
            set => priceBox.Value = value;
        }

        public int GraphicsCardTurboFrequency
        {
            get => (int)turboFrequencyBox.Value;
            set => turboFrequencyBox.Value = value;
        }

        public GraphicsCardView(GraphicsCardPresenter presenter)
        {
            InitializeComponent();
            _presenter = presenter;
        }

        private void acceptButton_Click(object sender, EventArgs e)
        {
            if (_presenter.AdminMode && !_presenter.Validate())
                DialogResult = DialogResult.None;
        }

        private void bandwidth_Changed(object sender, EventArgs e)
        {
            var bandwidth = 0;
            if (memoryTypeBox.Items.Contains(memoryTypeBox.Text))
                bandwidth = DatabaseUtilities.GetGraphicsCardBandwidth(
                    (int)memoryFrequencyBox.Value, memoryTypeBox.Text, (int)busWidthBox.Value);

            bandwidthLabel.Text = $"Bant Genişliği: {bandwidth / 1000d:0.##} GB/s";
        }

        private async void brandButton_Click(object sender, EventArgs e)
        {
            if (_presenter.AdminMode)
            {
                await using var presenter = new BrandListPresenter(false);
                if (presenter.ShowView() == DialogResult.Cancel)
                    return;

                if (GraphicsCardBrand != null &&
                    GraphicsCardBrand.Id == presenter.SelectedEntity.Id)
                    return;

                (GraphicsCardBrand = presenter.SelectedEntity).DisposeImage();
            }
            else
            {
                await using var presenter = new BrandPresenter(GraphicsCardBrand, false);
                presenter.ShowView();
            }
        }

        private async void chipsetBrandButton_Click(object sender, EventArgs e)
        {
            if (_presenter.AdminMode)
            {
                await using var presenter = new BrandListPresenter(false);
                if (presenter.ShowView() == DialogResult.Cancel)
                    return;

                if (GraphicsCardChipsetBrand != null &&
                    GraphicsCardChipsetBrand.Id == presenter.SelectedEntity.Id)
                    return;

                (GraphicsCardChipsetBrand = presenter.SelectedEntity).DisposeImage();
            }
            else
            {
                await using var presenter = new BrandPresenter(GraphicsCardChipsetBrand, false);
                presenter.ShowView();
            }
        }

        private void deleteImageButton_Click(object sender, EventArgs e) => EntityImage = null;

        private void GraphicsCardView_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (_presenter.AdminMode && DialogResult == DialogResult.OK)
                return;

            EntityImage = null;
        }

        private void GraphicsCardView_Load(object sender, EventArgs e)
        {
            if (_presenter.AdminMode)
                return;

            selectImageButton.Visible = deleteImageButton.Visible = cancelButton.Visible = false;
            entityPanel.MakeReadOnly();
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