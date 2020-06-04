namespace Picker
{
    using System;
    using System.Windows.Forms;
    using Properties;

    internal partial class GraphicsCardItemView : UserControl, IGraphicsCardItemView
    {
        private readonly GraphicsCardListPresenter _presenter;
        private GraphicsCard _entity;

        public GraphicsCardItemView(GraphicsCardListPresenter presenter)
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

            await using var presenter = new GraphicsCardPresenter(_entity, false);
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

        public void UpdateView(GraphicsCard entity)
        {
            _entity = entity;
            nameLabel.Text = entity.Name;
            brandLabel.Text = entity.Brand.Name;
            priceLabel.Text = $"{entity.Price:C2}";
            chipsetLabel.Text = entity.ChipsetBrand.Name + " " + entity.ChipsetModel;
            memoryTypeLabel.Text = entity.MemoryType;
            memoryLabel.Text = entity.Memory + " GB";
            busWidthLabel.Text = entity.BusWidth + " Bit";
            memoryFrequencyLabel.Text = "Bellek Hızı: " + entity.MemoryFrequency + " MHz";
            frequencyLabel.Text = "Çekirdek Hızı: " + entity.Frequency + " MHz";
            turboFrequencyLabel.Text = "Maksimum Çekirdek Hızı: " + entity.TurboFrequency + " MHz";
            bandwidthLabel.Text = "Bant Genişliği: " +
                                  (entity.GetBandwidth() / 1000d).ToString("0.##") + " GB/s";

            itemPanel.BackColor = nameLabel.ForeColor = entity.Brand.Color;
            foreach (Button button in controlPanel.Controls)
                button.BackColor = entity.Brand.Color;

            imageBox.DisposeImage();
            imageBox.Image = entity.Image ?? Resources.FavIcon64;
        }
    }
}