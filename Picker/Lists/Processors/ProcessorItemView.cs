namespace Picker
{
    using System;
    using System.Drawing;
    using System.Windows.Forms;
    using Properties;

    internal partial class ProcessorItemView : UserControl, IProcessorItemView
    {
        private readonly ProcessorListPresenter _presenter;
        private Processor _entity;

        public ProcessorItemView(ProcessorListPresenter presenter)
        {
            InitializeComponent();
            Disposed += OnDispose;

            _presenter = presenter;

            if (presenter.AdminMode)
                return;

            mainButton.Text = "Seç";
            deleteButton.Visible = false;
        }

        private async void deleteButton_Click(object sender, EventArgs e)
        {
            if (_presenter.GeneratingList)
                return;

            if (MessageBox.Show("Bu kaydı silmek istediğinize emin misiniz?", _entity.Name,
                MessageBoxButtons.YesNo, MessageBoxIcon.Question,
                MessageBoxDefaultButton.Button2) == DialogResult.No)
                return;

            await _presenter.DeleteItemAsync(_entity);
        }

        private async void entity_Click(object sender, EventArgs e)
        {
            if (_presenter.GeneratingList)
                return;

            await using var presenter = new ProcessorPresenter(_entity, false);
            presenter.ShowView();
        }

        private async void mainButton_Click(object sender, EventArgs e)
        {
            if (_presenter.GeneratingList)
                return;

            if (_presenter.AdminMode)
                await _presenter.EditItemAsync(this, _entity);
            else
                _presenter.SelectEntity(_entity);
        }

        private void OnDispose(object sender, EventArgs e)
        {
            _entity.DisposeImage();
            imageBox.DisposeImage();
        }

        public void UpdateView(Processor entity)
        {
            _entity = entity;
            nameLabel.Text = entity.Name;
            brandLabel.Text = entity.Brand.Name;
            priceLabel.Text = $"{entity.Price:C2}";
            familyLabel.Text = entity.Family;
            coresLabel.Text = entity.Cores + " çekirdek";
            threadsLabel.Text = entity.Threads + " iş parçacığı";
            cacheSizeLabel.Text = entity.CacheSize + " MB önbellek";
            frequencyLabel.Text = (entity.Frequency / 1000d).ToString("0.##") + " GHz";
            turboFrequencyLabel.Text =
                "Turbo: " + (entity.TurboFrequency / 1000d).ToString("0.##") + " GHz";

            maxMemoryLabel.Text = "Max " + entity.MaxMemory + " GB bellek";
            maxMemorySpeedLabel.Text = "Max " + entity.MaxMemorySpeed + " MHz bellek";
            socketLabel.Text = entity.Socket.Name;
            eccLabel.ForeColor = entity.SupportsECC ? Color.Green : Color.Red;
            is64BitLabel.ForeColor = entity.Is64Bit ? Color.Green : Color.Red;

            itemPanel.BackColor = nameLabel.ForeColor = entity.Brand.Color;
            foreach (Button button in controlPanel.Controls)
                button.BackColor = entity.Brand.Color;

            imageBox.DisposeImage();
            imageBox.Image = entity.Image ?? Resources.FavIcon64;
        }
    }
}