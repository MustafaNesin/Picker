namespace Picker
{
    using System;
    using System.Drawing;
    using System.Windows.Forms;
    using Properties;

    internal partial class MotherboardView : Form, IMotherboardView
    {
        private readonly MotherboardPresenter _presenter;
        private Brand _brand;
        private Chipset _chipset;
        private Socket _socket;

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
            get => string.IsNullOrWhiteSpace(MotherboardModel)
                ? MotherboardModel
                : $"{MotherboardBrand.Name} {MotherboardChipset.Name} {MotherboardModel} " +
                  $"{MotherboardFormFactor} {MotherboardSocket.Name}";
            set => Text = value;
        }

        public Brand MotherboardBrand
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

        public Chipset MotherboardChipset
        {
            get => _chipset;
            set
            {
                if (value == null)
                    return;

                _chipset = value;
                chipsetButton.Text = value.Name;
                chipsetButton.BackColor = value.Brand.Color;
            }
        }

        public string MotherboardFormFactor
        {
            get => formFactorBox.Text;
            set => formFactorBox.Text = value;
        }

        public int MotherboardMaxMemory
        {
            get => (int)maxMemoryBox.Value;
            set => maxMemoryBox.Value = value;
        }

        public int MotherboardMaxMemoryFrequency
        {
            get => (int)maxMemoryFrequencyBox.Value;
            set => maxMemoryFrequencyBox.Value = value;
        }

        public int MotherboardMemorySlots
        {
            get => (int)memorySlotsBox.Value;
            set => memorySlotsBox.Value = value;
        }

        public string MotherboardMemoryType
        {
            get => memoryTypeBox.Text.ToUpper();
            set => memoryTypeBox.Text = value;
        }

        public string MotherboardModel
        {
            get => modelBox.Text;
            set => modelBox.Text = value;
        }

        public decimal MotherboardPrice
        {
            get => priceBox.Value;
            set => priceBox.Value = value;
        }

        public Socket MotherboardSocket
        {
            get => _socket;
            set
            {
                if (value == null)
                    return;

                _socket = value;
                socketButton.Text = value.Name;
                socketButton.BackColor = value.Brand.Color;
            }
        }

        public bool MotherboardSupportsECC
        {
            get => eccBox.Checked;
            set => eccBox.Checked = value;
        }

        public MotherboardView(MotherboardPresenter presenter)
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

                if (MotherboardBrand != null && MotherboardBrand.Id == presenter.SelectedEntity.Id)
                    return;

                (MotherboardBrand = presenter.SelectedEntity).DisposeImage();
            }
            else
            {
                await using var presenter = new BrandPresenter(MotherboardBrand, false);
                presenter.ShowView();
            }
        }

        private async void chipsetButton_Click(object sender, EventArgs e)
        {
            if (_presenter.AdminMode)
            {
                await using var presenter = new ChipsetListPresenter(false);
                if (presenter.ShowView() == DialogResult.Cancel)
                    return;

                if (MotherboardChipset != null && MotherboardChipset.Id == presenter.SelectedEntity.Id)
                    return;

                (MotherboardChipset = presenter.SelectedEntity).DisposeImage();
            }
            else
            {
                await using var presenter = new ChipsetPresenter(MotherboardChipset, false);
                presenter.ShowView();
            }
        }

        private void deleteImageButton_Click(object sender, EventArgs e) => EntityImage = null;

        private void MotherboardView_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (_presenter.AdminMode && DialogResult == DialogResult.OK)
                return;

            EntityImage = null;
        }

        private void MotherboardView_Load(object sender, EventArgs e)
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

        private async void socketButton_Click(object sender, EventArgs e)
        {
            if (_presenter.AdminMode)
            {
                await using var presenter = new SocketListPresenter(false);
                if (presenter.ShowView() == DialogResult.Cancel)
                    return;

                if (MotherboardSocket != null && MotherboardSocket.Id == presenter.SelectedEntity.Id)
                    return;

                (MotherboardSocket = presenter.SelectedEntity).DisposeImage();
            }
            else
            {
                await using var presenter = new SocketPresenter(MotherboardSocket, false);
                presenter.ShowView();
            }
        }
    }
}