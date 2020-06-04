namespace Picker
{
    using System;
    using System.Drawing;
    using System.Windows.Forms;
    using Properties;

    internal partial class MotherboardItemView : UserControl, IMotherboardItemView
    {
        private readonly MotherboardListPresenter _presenter;
        private Motherboard _entity;

        public MotherboardItemView(MotherboardListPresenter presenter)
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

            await using var presenter = new MotherboardPresenter(_entity, false);
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

        public void UpdateView(Motherboard entity)
        {
            _entity = entity;
            nameLabel.Text = entity.Name;
            brandLabel.Text = entity.Brand.Name;
            priceLabel.Text = $"{entity.Price:C2}";
            chipsetLabel.Text = entity.Chipset.Name;
            socketLabel.Text = entity.Socket.Name;
            formFactorLabel.Text = entity.FormFactor;
            memoryTypeLabel.Text = entity.MemoryType;
            memorySlotsLabel.Text = entity.MemorySlots + " bellek";
            maxMemoryLabel.Text = "Max " + entity.MaxMemory + " GB bellek";
            maxMemoryFrequencyLabel.Text = "Max " + entity.MaxMemoryFrequency + " MHz bellek";
            eccLabel.ForeColor = entity.SupportsECC ? Color.Green : Color.Red;

            itemPanel.BackColor = nameLabel.ForeColor = entity.Brand.Color;
            foreach (Button button in controlPanel.Controls)
                button.BackColor = entity.Brand.Color;

            imageBox.DisposeImage();
            imageBox.Image = entity.Image ?? Resources.FavIcon64;
        }
    }
}