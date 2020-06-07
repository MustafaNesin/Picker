namespace Picker
{
    using System;
    using System.Windows.Forms;

    internal partial class ProcessorListView : Form, IProcessorListView
    {
        private readonly ProcessorListPresenter _presenter;
        public string EntityName => nameBox.Text;

        public int ItemPerPage
            => int.Parse(itemPerPageBox
                .Items[itemPerPageBox.SelectedIndex == -1 ? 1 : itemPerPageBox.SelectedIndex]
                .ToString());

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

        public string ProcessorBrand => brandBox.Text;
        public string ProcessorFamily => familyBox.Text;
        public CheckState ProcessorIs64Bit => is64BitBox.CheckState;

        public int? ProcessorMaxCacheSize
            => enableMaxCacheSizeBox.Checked ? (int?)maxCacheSizeBox.Value : null;

        public int? ProcessorMaxCores => enableMaxCoresBox.Checked ? (int?)maxCoresBox.Value : null;

        public int? ProcessorMaxFrequency
            => enableMaxFrequencyBox.Checked ? (int?)(maxFrequencyBox.Value * 1000) : null;

        public int? ProcessorMaxMaxMemory
            => enableMaxMaxMemoryBox.Checked ? (int?)maxMaxMemoryBox.Value : null;

        public int? ProcessorMaxMaxMemorySpeed
            => enableMaxMaxMemorySpeedBox.Checked ? (int?)maxMaxMemorySpeedBox.Value : null;

        public decimal? ProcessorMaxPrice
            => enableMaxPriceBox.Checked ? (int?)maxPriceBox.Value : null;

        public int? ProcessorMaxThreads
            => enableMaxThreadsBox.Checked ? (int?)maxThreadsBox.Value : null;

        public int? ProcessorMaxTurboFrequency
            => enableMaxTurboFrequencyBox.Checked
                ? (int?)(maxTurboFrequencyBox.Value * 1000)
                : null;

        public int? ProcessorMinCacheSize
            => enableMinCacheSizeBox.Checked ? (int?)minCacheSizeBox.Value : null;

        public int? ProcessorMinCores => enableMinCoresBox.Checked ? (int?)minCoresBox.Value : null;

        public int? ProcessorMinFrequency
            => enableMinFrequencyBox.Checked ? (int?)(minFrequencyBox.Value * 1000) : null;

        public int? ProcessorMinMaxMemory
            => enableMinMaxMemoryBox.Checked ? (int?)minMaxMemoryBox.Value : null;

        public int? ProcessorMinMaxMemorySpeed
            => enableMinMaxMemorySpeedBox.Checked ? (int?)minMaxMemorySpeedBox.Value : null;

        public decimal? ProcessorMinPrice
            => enableMinPriceBox.Checked ? (int?)minPriceBox.Value : null;

        public int? ProcessorMinThreads
            => enableMinThreadsBox.Checked ? (int?)minThreadsBox.Value : null;

        public int? ProcessorMinTurboFrequency
            => enableMinTurboFrequencyBox.Checked
                ? (int?)(minTurboFrequencyBox.Value * 1000)
                : null;

        public string ProcessorSocket => socketBox.Text;
        public CheckState ProcessorSupportsECC => eccBox.CheckState;

        public ProcessorListView(ProcessorListPresenter presenter)
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

            brandBox.Text = familyBox.Text = socketBox.Text = nameBox.Text = string.Empty;

            enableMinPriceBox.Checked = enableMaxPriceBox.Checked = enableMinCoresBox.Checked =
                enableMaxCoresBox.Checked = enableMinThreadsBox.Checked =
                    enableMaxThreadsBox.Checked = enableMinCacheSizeBox.Checked =
                        enableMaxCacheSizeBox.Checked = enableMinFrequencyBox.Checked =
                            enableMaxFrequencyBox.Checked = enableMinTurboFrequencyBox.Checked =
                                enableMaxTurboFrequencyBox.Checked = enableMinMaxMemoryBox.Checked =
                                    enableMaxMaxMemoryBox.Checked =
                                        enableMinMaxMemorySpeedBox.Checked =
                                            enableMaxMaxMemorySpeedBox.Checked = false;

            eccBox.CheckState = is64BitBox.CheckState = CheckState.Indeterminate;

            await _presenter.GenerateListAsync();
        }

        private void enableMaxCacheSizeBox_CheckedChanged(object sender, EventArgs e)
        {
            maxThreadsBox.Enabled = enableMaxThreadsBox.Checked;
            maxThreadsBox.Value = 0M;
        }

        private void enableMaxCoresBox_CheckedChanged(object sender, EventArgs e)
        {
            maxCoresBox.Enabled = enableMaxCoresBox.Checked;
            maxCoresBox.Value = 0M;
        }

        private void enableMaxFrequencyBox_CheckedChanged(object sender, EventArgs e)
        {
            maxFrequencyBox.Enabled = enableMaxFrequencyBox.Checked;
            maxFrequencyBox.Value = 0M;
        }

        private void enableMaxMaxMemoryBox_CheckedChanged(object sender, EventArgs e)
        {
            maxMaxMemoryBox.Enabled = enableMaxMaxMemoryBox.Checked;
            maxMaxMemoryBox.Value = 0M;
        }

        private void enableMaxMaxMemorySpeedBox_CheckedChanged(object sender, EventArgs e)
        {
            maxMaxMemorySpeedBox.Enabled = enableMaxMaxMemorySpeedBox.Checked;
            maxMaxMemorySpeedBox.Value = 0M;
        }

        private void enableMaxPriceBox_CheckedChanged(object sender, EventArgs e)
        {
            maxPriceBox.Enabled = enableMaxPriceBox.Checked;
            maxPriceBox.Value = 0M;
        }

        private void enableMaxThreadsBox_CheckedChanged(object sender, EventArgs e)
        {
            maxThreadsBox.Enabled = enableMaxThreadsBox.Checked;
            maxThreadsBox.Value = 0M;
        }

        private void enableMaxTurboFrequencyBox_CheckedChanged(object sender, EventArgs e)
        {
            maxTurboFrequencyBox.Enabled = enableMaxTurboFrequencyBox.Checked;
            maxTurboFrequencyBox.Value = 0M;
        }

        private void enableMinCacheSizeBox_CheckedChanged(object sender, EventArgs e)
        {
            minCacheSizeBox.Enabled = enableMinCacheSizeBox.Checked;
            minCacheSizeBox.Value = 0M;
        }

        private void enableMinCoresBox_CheckedChanged(object sender, EventArgs e)
        {
            minCoresBox.Enabled = enableMinCoresBox.Checked;
            minCoresBox.Value = 0M;
        }

        private void enableMinFrequencyBox_CheckedChanged(object sender, EventArgs e)
        {
            minFrequencyBox.Enabled = enableMinFrequencyBox.Checked;
            minFrequencyBox.Value = 0M;
        }

        private void enableMinMaxMemoryBox_CheckedChanged(object sender, EventArgs e)
        {
            minMaxMemoryBox.Enabled = enableMinMaxMemoryBox.Checked;
            minMaxMemoryBox.Value = 0M;
        }

        private void enableMinMaxMemorySpeedBox_CheckedChanged(object sender, EventArgs e)
        {
            minMaxMemorySpeedBox.Enabled = enableMinMaxMemorySpeedBox.Checked;
            minMaxMemorySpeedBox.Value = 0M;
        }

        private void enableMinPriceBox_CheckedChanged(object sender, EventArgs e)
        {
            minPriceBox.Enabled = enableMinPriceBox.Checked;
            minPriceBox.Value = 0M;
        }

        private void enableMinThreadsBox_CheckedChanged(object sender, EventArgs e)
        {
            minThreadsBox.Enabled = enableMinThreadsBox.Checked;
            minThreadsBox.Value = 0M;
        }

        private void enableMinTurboFrequencyBox_CheckedChanged(object sender, EventArgs e)
        {
            minTurboFrequencyBox.Enabled = enableMinTurboFrequencyBox.Checked;
            minTurboFrequencyBox.Value = 0M;
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

        private void nextPageButton_Click(object sender, EventArgs e)
        {
            if (!_presenter.GeneratingList)
                pageNumberBox.Value++;
        }

        private async void pageBox_ValueChanged(object sender, EventArgs e)
        {
            if (!_presenter.GeneratingList)
                await _presenter.GenerateListAsync(true);
        }

        private void previousPageButton_Click(object sender, EventArgs e)
        {
            if (!_presenter.GeneratingList)
                pageNumberBox.Value--;
        }

        private async void ProcessorListView_Load(object sender, EventArgs e)
        {
            await _presenter.GenerateListAsync();

            orderBox.SelectedIndexChanged += GenerateListAsyncEvent;
            itemPerPageBox.SelectedIndexChanged += GenerateListAsyncEvent;
            pageNumberBox.ValueChanged += pageBox_ValueChanged;
        }

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