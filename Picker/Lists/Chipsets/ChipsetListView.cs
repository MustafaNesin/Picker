namespace Picker
{
    using System;
    using System.Windows.Forms;

    internal partial class ChipsetListView : Form, IChipsetListView
    {
        private readonly ChipsetListPresenter _presenter;
        public string ChipsetBrand => brandBox.Text;
        public string EntityName => nameBox.Text;

        public int ItemPerPage
            => int.Parse(itemPerPageBox
                .Items[itemPerPageBox.SelectedIndex == -1 ? 1 : itemPerPageBox.SelectedIndex]
                .ToString());

        public int OrderIndex
        {
            get => orderBox.SelectedIndex == -1 ? 1 : orderBox.SelectedIndex;
            set => orderBox.SelectedIndex = value;
        }

        public int PageCount
        {
            get => int.Parse(pageCountLabel.Text.Substring(1));
            set
            {
                pageCountLabel.Text = "/ " + value;
                pageNumberBox.Minimum = value == 0 ? 0 : 1;
                pageNumberBox.Maximum = value;
            }
        }

        public int PageIndex
        {
            get => PageCount == 0 ? 0 : (int)pageNumberBox.Value - 1;
            set => pageNumberBox.Value = PageCount == 0 ? 0 : value + 1;
        }

        public ChipsetListView(ChipsetListPresenter presenter)
        {
            InitializeComponent();
            _presenter = presenter;
            orderBox.SelectedIndex = 1;
            itemPerPageBox.SelectedIndex = 0;

            if (_presenter.AdminMode)
                return;

            controlGroup.Visible = false;
            mainButton.Text = "İptal";
        }

        private async void ChipsetListView_Load(object sender, EventArgs e)
        {
            await _presenter.GenerateListAsync();

            orderBox.SelectedIndexChanged += GenerateListAsyncEvent;
            itemPerPageBox.SelectedIndexChanged += GenerateListAsyncEvent;
            pageNumberBox.ValueChanged += pageBox_ValueChanged;
        }

        private void firstPageButton_Click(object sender, EventArgs e) => pageNumberBox.Value = 1;

        private async void GenerateListAsyncEvent(object sender, EventArgs e)
        {
            if (!_presenter.GeneratingList)
                await _presenter.GenerateListAsync();
        }

        private void lastPageButton_Click(object sender, EventArgs e)
            => pageNumberBox.Value = PageCount;

        private void mainButton_Click(object sender, EventArgs e)
        {
            if (_presenter.GeneratingList)
                DialogResult = DialogResult.None;
            else if (!_presenter.AdminMode)
                DialogResult = DialogResult.Cancel;
        }

        private async void newButton_Click(object sender, EventArgs e)
        {
            if (!_presenter.GeneratingList)
                await _presenter.AddItemAsync();
        }

        private void nextPageButton_Click(object sender, EventArgs e) => pageNumberBox.Value++;

        private async void pageBox_ValueChanged(object sender, EventArgs e)
        {
            if (!_presenter.GeneratingList)
                await _presenter.GenerateListAsync(true);
        }

        private void previousPageButton_Click(object sender, EventArgs e) => pageNumberBox.Value--;

        public void SetCountLabel(int itemCount, int totalItemCount)
            => countLabel.Text =
                $"{itemCount} tanesi listelenen, toplam {totalItemCount} kayıt var.";

        public void UpdateNavigationButtonsStatus()
        {
            firstPageButton.Enabled = previousPageButton.Enabled = pageNumberBox.Value > 1;
            lastPageButton.Enabled = nextPageButton.Enabled = pageNumberBox.Value < PageCount;
        }

        #region
        private const int WS_EX_COMPOSITED = 0x02000000;

        protected override CreateParams CreateParams
        {
            get
            {
                var cp = base.CreateParams;
                cp.ExStyle |= WS_EX_COMPOSITED;
                return cp;
            }
        }
        #endregion
    }
}