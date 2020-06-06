namespace Picker
{
    using System;
    using System.Windows.Forms;
    using Properties;

    internal partial class BrandItemView : UserControl, IBrandItemView
    {
        private readonly BrandListPresenter _presenter;
        private Brand _entity;

        public BrandItemView(BrandListPresenter presenter)
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

            await using var presenter = new BrandPresenter(_entity, false);
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

        public void UpdateView(Brand entity)
        {
            _entity = entity;
            nameLabel.Text = entity.Name;
            countryLabel.Text = entity.Country.GetDescription();

            itemPanel.BackColor = nameLabel.ForeColor = entity.Color;
            foreach (Button button in controlPanel.Controls)
                button.BackColor = entity.Color;

            imageBox.DisposeImage();
            imageBox.Image = entity.Image ?? Resources.FavIcon64;
        }
    }
}