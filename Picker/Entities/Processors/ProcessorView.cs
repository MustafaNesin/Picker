namespace Picker
{
    using System;
    using System.Collections.Generic;
    using System.Drawing;
    using System.Windows.Forms;
    using Properties;

    internal partial class ProcessorView : Form, IProcessorView
    {
        private readonly ProcessorPresenter _presenter;
        private Brand _brand;
        private List<Chipset> _chipsets;
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
            get => string.IsNullOrWhiteSpace(ProcessorModel)
                ? ProcessorModel
                : $"{ProcessorBrand.Name} {ProcessorFamily}-{ProcessorModel} " +
                  $"{ProcessorFrequency / 1000d: 0.##} GHz {ProcessorCores} Çekirdek {ProcessorCacheSize} MB Önbellek"
            ;
            set => Text = value;
        }

        public Brand ProcessorBrand
        {
            get => _brand;
            set
            {
                if (value == null)
                    return;

                _brand = value;
                brandButton.Text = value.Name;
                brandButton.BackColor = selectImageButton.BackColor = addChipsetButton.BackColor =
                    acceptButton.BackColor = cancelButton.BackColor = value.Color;
            }
        }

        public int ProcessorCacheSize
        {
            get => (int)cacheSizeBox.Value;
            set => cacheSizeBox.Value = value;
        }

        public List<Chipset> ProcessorChipsets
        {
            get => _chipsets;
            set
            {
                _chipsets = value ?? new List<Chipset>();

                foreach (var chipset in _chipsets)
                    chipsetsBox.Items.Add(chipset.Name);

                if (_chipsets.Count > 0)
                    chipsetsBox.SelectedIndex = 0;
            }
        }

        public int ProcessorCores
        {
            get => (int)coresBox.Value;
            set => coresBox.Value = value;
        }

        public string ProcessorFamily
        {
            get => familyBox.Text;
            set => familyBox.Text = value;
        }

        public int ProcessorFrequency
        {
            get => (int)(frequencyBox.Value * 1000);
            set => frequencyBox.Value = value / 1000M;
        }

        public bool ProcessorIs64Bit
        {
            get => is64BitBox.Checked;
            set => is64BitBox.Checked = value;
        }

        public int ProcessorMaxMemory
        {
            get => (int)maxMemoryBox.Value;
            set => maxMemoryBox.Value = value;
        }

        public int ProcessorMaxMemorySpeed
        {
            get => (int)maxMemorySpeedBox.Value;
            set => maxMemorySpeedBox.Value = value;
        }

        public string ProcessorModel
        {
            get => modelBox.Text;
            set => modelBox.Text = value;
        }

        public decimal ProcessorPrice
        {
            get => priceBox.Value;
            set => priceBox.Value = value;
        }

        public Socket ProcessorSocket
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

        public bool ProcessorSupportsECC
        {
            get => eccBox.Checked;
            set => eccBox.Checked = value;
        }

        public int ProcessorThreads
        {
            get => (int)threadsBox.Value;
            set => threadsBox.Value = value;
        }

        public int ProcessorTurboFrequency
        {
            get => (int)(turboFrequencyBox.Value * 1000);
            set => turboFrequencyBox.Value = value / 1000M;
        }

        public ProcessorView(ProcessorPresenter presenter)
        {
            InitializeComponent();
            _presenter = presenter;
        }

        private void acceptButton_Click(object sender, EventArgs e)
        {
            if (_presenter.AdminMode && !_presenter.Validate())
                DialogResult = DialogResult.None;
        }

        private async void addChipsetButton_Click(object sender, EventArgs e)
        {
            await using var presenter = new ChipsetListPresenter(false);
            if (presenter.ShowView() == DialogResult.Cancel)
                return;

            var existing =
                ProcessorChipsets.FindIndex(entity => entity.Id == presenter.SelectedEntity.Id);

            if (existing != -1)
            {
                chipsetsBox.SelectedIndex = existing;
                return;
            }

            ProcessorChipsets.Add(presenter.SelectedEntity);
            chipsetsBox.SelectedIndex = chipsetsBox.Items.Add(presenter.SelectedEntity.Name);
            presenter.SelectedEntity.DisposeImage();
        }

        private async void brandButton_Click(object sender, EventArgs e)
        {
            if (_presenter.AdminMode)
            {
                await using var presenter = new BrandListPresenter(false);
                if (presenter.ShowView() == DialogResult.Cancel)
                    return;

                if (ProcessorBrand != null && ProcessorBrand.Id == presenter.SelectedEntity.Id)
                    return;

                (ProcessorBrand = presenter.SelectedEntity).DisposeImage();
            }
            else
            {
                await using var presenter = new BrandPresenter(ProcessorBrand, false);
                presenter.ShowView();
            }
        }

        private async void chipsetsBox_DoubleClick(object sender, EventArgs e)
        {
            if (chipsetsBox.SelectedIndex == -1)
                return;

            await using var presenter =
                new ChipsetPresenter(ProcessorChipsets[chipsetsBox.SelectedIndex], false);

            presenter.ShowView();
        }

        private void chipsetsBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (_presenter.AdminMode)
                removeChipsetButton.Visible = chipsetsBox.SelectedIndex != -1;
        }

        private void deleteImageButton_Click(object sender, EventArgs e) => EntityImage = null;

        private void ProcessorView_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (_presenter.AdminMode && DialogResult == DialogResult.OK)
                return;

            EntityImage = null;
        }

        private void ProcessorView_Load(object sender, EventArgs e)
        {
            if (_presenter.AdminMode)
                return;

            selectImageButton.Visible = deleteImageButton.Visible = cancelButton.Visible =
                removeChipsetButton.Visible = addChipsetButton.Visible = false;

            entityPanel.MakeReadOnly();
        }

        private void removeChipsetButton_Click(object sender, EventArgs e)
        {
            if (chipsetsBox.SelectedIndex == -1)
                return;

            ProcessorChipsets.RemoveAt(chipsetsBox.SelectedIndex);
            chipsetsBox.Items.RemoveAt(chipsetsBox.SelectedIndex);
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

                if (ProcessorSocket != null && ProcessorSocket.Id == presenter.SelectedEntity.Id)
                    return;

                (ProcessorSocket = presenter.SelectedEntity).DisposeImage();
            }
            else
            {
                await using var presenter = new SocketPresenter(ProcessorSocket, false);
                presenter.ShowView();
            }
        }
    }
}