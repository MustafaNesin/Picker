namespace Picker
{
    using System;
    using System.Windows.Forms;

    internal partial class GraphicsCardListView : Form, IGraphicsCardListView
    {
        private readonly GraphicsCardListPresenter _presenter;
        public string EntityName => nameBox.Text;
        public string GraphicsCardBrand => brandBox.Text;
        public string GraphicsCardChipsetBrand => chipsetBrandBox.Text;
        public string GraphicsCardChipsetModel => chipsetModelBox.Text;

        public int? GraphicsCardMaxBusWidth
            => enableMaxBusWidthBox.Checked ? (int?)maxBusWidthBox.Value : null;

        public int? GraphicsCardMaxFrequency
            => enableMaxFrequencyBox.Checked ? (int?)maxFrequencyBox.Value : null;

        public int? GraphicsCardMaxMemory
            => enableMaxMemoryBox.Checked ? (int?)maxMemoryBox.Value : null;

        public int? GraphicsCardMaxMemoryFrequency
            => enableMaxMemoryFrequencyBox.Checked ? (int?)maxMemoryFrequencyBox.Value : null;

        public decimal? GraphicsCardMaxPrice
            => enableMaxPriceBox.Checked ? (int?)maxPriceBox.Value : null;

        public int? GraphicsCardMaxTurboFrequency
            => enableMaxTurboFrequencyBox.Checked ? (int?)maxTurboFrequencyBox.Value : null;

        public string GraphicsCardMemoryType => memoryTypeBox.Text;

        public int? GraphicsCardMinBusWidth
            => enableMinBusWidthBox.Checked ? (int?)minBusWidthBox.Value : null;

        public int? GraphicsCardMinFrequency
            => enableMinFrequencyBox.Checked ? (int?)minFrequencyBox.Value : null;

        public int? GraphicsCardMinMemory
            => enableMinMemoryBox.Checked ? (int?)minMemoryBox.Value : null;

        public int? GraphicsCardMinMemoryFrequency
            => enableMinMemoryFrequencyBox.Checked ? (int?)minMemoryFrequencyBox.Value : null;

        public decimal? GraphicsCardMinPrice
            => enableMinPriceBox.Checked ? (int?)minPriceBox.Value : null;

        public int? GraphicsCardMinTurboFrequency
            => enableMinTurboFrequencyBox.Checked ? (int?)minTurboFrequencyBox.Value : null;

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

        public GraphicsCardListView(GraphicsCardListPresenter presenter)
        {
            InitializeComponent();
            _presenter = presenter;
            orderBox.SelectedIndex = 1;
            itemPerPageBox.SelectedIndex = 0;

            compatiblesBox.Visible = _presenter.Build != null;
            if (_presenter.AdminMode)
                return;

            newButton.Visible = false;
            mainButton.Text = "İptal";
        }

        private async void clearFilterButton_Click(object sender, EventArgs e)
        {
            if (_presenter.GeneratingList)
                return;

            brandBox.Text = memoryTypeBox.Text =
                nameBox.Text = chipsetBrandBox.Text = chipsetModelBox.Text = string.Empty;

            enableMinPriceBox.Checked = enableMaxPriceBox.Checked = enableMinBusWidthBox.Checked =
                enableMaxBusWidthBox.Checked = enableMinFrequencyBox.Checked =
                    enableMaxFrequencyBox.Checked = enableMinMemoryFrequencyBox.Checked =
                        enableMaxMemoryFrequencyBox.Checked = enableMinTurboFrequencyBox.Checked =
                            enableMaxTurboFrequencyBox.Checked = enableMinMemoryBox.Checked =
                                enableMaxMemoryBox.Checked = false;

            await _presenter.GenerateListAsync();
        }

        private void enableMaxBusWidthBox_CheckedChanged(object sender, EventArgs e)
        {
            maxBusWidthBox.Enabled = enableMaxBusWidthBox.Checked;
            maxBusWidthBox.Value = 0M;
        }

        private void enableMaxFrequencyBox_CheckedChanged(object sender, EventArgs e)
        {
            maxFrequencyBox.Enabled = enableMaxFrequencyBox.Checked;
            maxFrequencyBox.Value = 0M;
        }

        private void enableMaxMemoryBox_CheckedChanged(object sender, EventArgs e)
        {
            maxMemoryBox.Enabled = enableMaxMemoryBox.Checked;
            maxMemoryBox.Value = 0M;
        }

        private void enableMaxMemoryFrequencyBox_CheckedChanged(object sender, EventArgs e)
        {
            maxMemoryFrequencyBox.Enabled = enableMaxMemoryFrequencyBox.Checked;
            maxMemoryFrequencyBox.Value = 0M;
        }

        private void enableMaxPriceBox_CheckedChanged(object sender, EventArgs e)
        {
            maxPriceBox.Enabled = enableMaxPriceBox.Checked;
            maxPriceBox.Value = 0M;
        }

        private void enableMaxTurboFrequencyBox_CheckedChanged(object sender, EventArgs e)
        {
            maxTurboFrequencyBox.Enabled = enableMaxTurboFrequencyBox.Checked;
            maxTurboFrequencyBox.Value = 0M;
        }

        private void enableMinBusWidthBox_CheckedChanged(object sender, EventArgs e)
        {
            minBusWidthBox.Enabled = enableMinBusWidthBox.Checked;
            minBusWidthBox.Value = 0M;
        }

        private void enableMinFrequencyBox_CheckedChanged(object sender, EventArgs e)
        {
            minFrequencyBox.Enabled = enableMinFrequencyBox.Checked;
            minFrequencyBox.Value = 0M;
        }

        private void enableMinMemoryBox_CheckedChanged(object sender, EventArgs e)
        {
            minMemoryBox.Enabled = enableMinMemoryBox.Checked;
            minMemoryBox.Value = 0M;
        }

        private void enableMinMemoryFrequencyBox_CheckedChanged(object sender, EventArgs e)
        {
            minMemoryFrequencyBox.Enabled = enableMinMemoryFrequencyBox.Checked;
            minMemoryFrequencyBox.Value = 0M;
        }

        private void enableMinPriceBox_CheckedChanged(object sender, EventArgs e)
        {
            minPriceBox.Enabled = enableMinPriceBox.Checked;
            minPriceBox.Value = 0M;
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

        private async void GraphicsCardListView_Load(object sender, EventArgs e)
        {
            await _presenter.GenerateListAsync();

            orderBox.SelectedIndexChanged += GenerateListAsyncEvent;
            itemPerPageBox.SelectedIndexChanged += GenerateListAsyncEvent;
            pageNumberBox.ValueChanged += pageBox_ValueChanged;
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