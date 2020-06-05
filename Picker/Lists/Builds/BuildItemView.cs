namespace Picker
{
    using System;
    using System.Drawing;
    using System.Globalization;
    using System.Windows.Forms;
    using Properties;

    internal partial class BuildItemView : UserControl, IBuildItemView
    {
        private readonly BuildListPresenter _presenter;
        private Build _entity;

        public BuildItemView(BuildListPresenter presenter)
        {
            InitializeComponent();

            _presenter = presenter;
        }

        private async void deleteButton_Click(object sender, EventArgs e)
        {
            if (_presenter.GeneratingList)
                return;

            if (MessageBox.Show("Bu bilgisayarı silmek istediğinize emin misiniz?", _entity.Name,
                MessageBoxButtons.YesNo, MessageBoxIcon.Question,
                MessageBoxDefaultButton.Button2) == DialogResult.No)
                return;

            await _presenter.DeleteItemAsync(_entity);
        }

        private async void entity_Click(object sender, EventArgs e)
        {
            if (_presenter.GeneratingList)
                return;

            await using var presenter = new BuildPresenter(_entity, false);
            presenter.ShowView();
        }

        private async void mainButton_Click(object sender, EventArgs e)
        {
            if (!_presenter.GeneratingList)
                await _presenter.EditItemAsync(this, _entity);
        }

        public void UpdateView(Build entity)
        {
            _entity = entity;
            nameLabel.Text = entity.Name;
            dateLabel.Text = entity.Date.ToString(CultureInfo.GetCultureInfo("tr-TR"));
        }
    }
}