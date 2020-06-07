namespace Picker
{
    using System;
    using System.Drawing;
    using System.Windows.Forms;
    using Properties;

    internal partial class MemoryItemView : UserControl, IMemoryItemView
    {
        private readonly MemoryListPresenter _presenter;
        private Memory _entity;

        public MemoryItemView(MemoryListPresenter presenter)
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

            await using var presenter = new MemoryPresenter(_entity, false);
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
            if (_presenter.LeaveImage)
                return;

            _entity.DisposeImage();
            imageBox.DisposeImage();
        }

        public void UpdateView(Memory entity)
        {
            _entity = entity;
            nameLabel.Text = entity.Name;
            brandLabel.Text = entity.Brand.Name;
            priceLabel.Text = $"{entity.Price:C2}";
            countLabel.Text = entity.Count + " Modül";
            typeLabel.Text = entity.Type;
            capacityLabel.Text = entity.Capacity + " GB";
            frequencyLabel.Text = entity.Frequency + " MHz";
            bandwidthLabel.Text = "Bant Genişliği: " +
                                  (entity.GetBandwidth() / 1000d).ToString("0.##") + " GB/s";

            eccLabel.ForeColor = entity.HasECC ? Color.Green : Color.Red;
            eccLabel.Font = new Font(eccLabel.Font,
                entity.HasECC ? FontStyle.Regular : FontStyle.Strikeout);

            bufferedLabel.ForeColor = entity.IsBuffered ? Color.Green : Color.Red;
            bufferedLabel.Font = new Font(bufferedLabel.Font,
                entity.IsBuffered ? FontStyle.Regular : FontStyle.Strikeout);

            itemPanel.BackColor = nameLabel.ForeColor = entity.Brand.Color;
            foreach (Button button in controlPanel.Controls)
                button.BackColor = entity.Brand.Color;

            imageBox.DisposeImage();
            imageBox.Image = entity.Image ?? Resources.FavIcon64;
        }
    }
}