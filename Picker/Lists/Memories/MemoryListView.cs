namespace Picker
{
    using System;
    using System.Windows.Forms;

    internal partial class MemoryListView : Form, IMemoryListView
    {
        private readonly MemoryListPresenter _presenter;
        public string EntityName => nameBox.Text;

        public int ItemPerPage
            => int.Parse(itemPerPageBox
                .Items[itemPerPageBox.SelectedIndex == -1 ? 1 : itemPerPageBox.SelectedIndex]
                .ToString());

        public string MemoryBrand => brandBox.Text;

        public int? MemoryCount
        {
            get
            {
                if (int.TryParse(countBox.Text, out var count))
                    return count;

                countBox.Text = string.Empty;
                return null;
            }
        }

        public CheckState MemoryHasECC => eccBox.CheckState;
        public CheckState MemoryIsBuffered => bufferedBox.CheckState;

        public int? MemoryMaxCapacity
            => enableMaxCapacityBox.Checked ? (int?)maxCapacityBox.Value : null;

        public int? MemoryMaxFrequency
            => enableMaxFrequencyBox.Checked ? (int?)maxFrequencyBox.Value : null;

        public decimal? MemoryMaxPrice
            => enableMaxPriceBox.Checked ? (int?)maxPriceBox.Value : null;

        public int? MemoryMinCapacity
            => enableMinCapacityBox.Checked ? (int?)minCapacityBox.Value : null;

        public int? MemoryMinFrequency
            => enableMinFrequencyBox.Checked ? (int?)minFrequencyBox.Value : null;

        public decimal? MemoryMinPrice
            => enableMinPriceBox.Checked ? (int?)minPriceBox.Value : null;

        public string MemoryType => typeBox.Text;
        public bool OnlyCompatibles => compatiblesBox.Checked;

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

        public MemoryListView(MemoryListPresenter presenter)
        {
            InitializeComponent();
            _presenter = presenter;
            orderBox.SelectedIndex = 1;
            itemPerPageBox.SelectedIndex = 0;

            compatiblesBox.Visible = _presenter.BuildPresenter != null;

            if (_presenter.AdminMode)
                return;

            newButton.Visible = false;
            mainButton.Text = "İptal";
        }

        private async void clearFilterButton_Click(object sender, EventArgs e)
        {
            if (_presenter.GeneratingList)
                return;

            brandBox.Text = typeBox.Text = nameBox.Text = countBox.Text = string.Empty;
            enableMinPriceBox.Checked = enableMaxPriceBox.Checked = enableMinFrequencyBox.Checked =
                enableMaxFrequencyBox.Checked = enableMinCapacityBox.Checked =
                    enableMaxCapacityBox.Checked = false;

            bufferedBox.CheckState = eccBox.CheckState = CheckState.Indeterminate;

            await _presenter.GenerateListAsync();
        }

        private void enableMaxCapacityBox_CheckedChanged(object sender, EventArgs e)
        {
            maxCapacityBox.Enabled = enableMaxCapacityBox.Checked;
            maxCapacityBox.Value = 0M;
        }

        private void enableMaxFrequencyBox_CheckedChanged(object sender, EventArgs e)
        {
            maxFrequencyBox.Enabled = enableMaxFrequencyBox.Checked;
            maxFrequencyBox.Value = 0M;
        }

        private void enableMaxPriceBox_CheckedChanged(object sender, EventArgs e)
        {
            maxPriceBox.Enabled = enableMaxPriceBox.Checked;
            maxPriceBox.Value = 0M;
        }

        private void enableMinCapacityBox_CheckedChanged(object sender, EventArgs e)
        {
            minCapacityBox.Enabled = enableMinCapacityBox.Checked;
            minCapacityBox.Value = 0M;
        }

        private void enableMinFrequencyBox_CheckedChanged(object sender, EventArgs e)
        {
            minFrequencyBox.Enabled = enableMinFrequencyBox.Checked;
            minFrequencyBox.Value = 0M;
        }

        private void enableMinPriceBox_CheckedChanged(object sender, EventArgs e)
        {
            minPriceBox.Enabled = enableMinPriceBox.Checked;
            minPriceBox.Value = 0M;
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

        private async void MemoryListView_Load(object sender, EventArgs e)
        {
            await _presenter.GenerateListAsync();

            orderBox.SelectedIndexChanged += GenerateListAsyncEvent;
            itemPerPageBox.SelectedIndexChanged += GenerateListAsyncEvent;
            pageNumberBox.ValueChanged += pageBox_ValueChanged;
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