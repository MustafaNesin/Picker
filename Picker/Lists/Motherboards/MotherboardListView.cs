namespace Picker
{
    using System;
    using System.Windows.Forms;

    internal partial class MotherboardListView : Form, IMotherboardListView
    {
        private readonly MotherboardListPresenter _presenter;
        public string EntityName => nameBox.Text;

        public int ItemPerPage
            => int.Parse(itemPerPageBox
                .Items[itemPerPageBox.SelectedIndex == -1 ? 1 : itemPerPageBox.SelectedIndex]
                .ToString());

        public string MotherboardBrand => brandBox.Text;
        public string MotherboardChipset => chipsetBox.Text;
        public string MotherboardFormFactor => formFactorBox.Text;

        public int? MotherboardMaxMaxMemory
            => enableMaxMaxMemoryBox.Checked ? (int?)maxMaxMemoryBox.Value : null;

        public int? MotherboardMaxMaxMemoryFrequency
            => enableMaxMaxMemoryFrequencyBox.Checked ? (int?)maxMaxMemoryFrequencyBox.Value : null;

        public int? MotherboardMaxMemorySlots
            => enableMaxMemorySlotsBox.Checked ? (int?)maxMemorySlotsBox.Value : null;

        public decimal? MotherboardMaxPrice
            => enableMaxPriceBox.Checked ? (int?)maxPriceBox.Value : null;

        public string MotherboardMemoryType => memoryTypeBox.Text;

        public int? MotherboardMinMaxMemory
            => enableMinMaxMemoryBox.Checked ? (int?)minMaxMemoryBox.Value : null;

        public int? MotherboardMinMaxMemoryFrequency
            => enableMinMaxMemoryFrequencyBox.Checked ? (int?)minMaxMemoryFrequencyBox.Value : null;

        public int? MotherboardMinMemorySlots
            => enableMinMemorySlotsBox.Checked ? (int?)minMemorySlotsBox.Value : null;

        public decimal? MotherboardMinPrice
            => enableMinPriceBox.Checked ? (int?)minPriceBox.Value : null;

        public string MotherboardSocket => socketBox.Text;
        public CheckState MotherboardSupportsECC => eccBox.CheckState;
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

        public MotherboardListView(MotherboardListPresenter presenter)
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

            brandBox.Text = memoryTypeBox.Text = nameBox.Text =
                socketBox.Text = chipsetBox.Text = formFactorBox.Text = string.Empty;

            enableMinPriceBox.Checked = enableMaxPriceBox.Checked =
                enableMinMaxMemoryFrequencyBox.Checked = enableMaxMaxMemoryFrequencyBox.Checked =
                    enableMinMaxMemoryBox.Checked = enableMaxMaxMemoryBox.Checked =
                        enableMinMemorySlotsBox.Checked = enableMaxMemorySlotsBox.Checked = false;

            eccBox.CheckState = CheckState.Indeterminate;

            await _presenter.GenerateListAsync();
        }

        private void enableMaxMaxMemoryBox_CheckedChanged(object sender, EventArgs e)
        {
            maxMaxMemoryBox.Enabled = enableMaxMaxMemoryBox.Checked;
            maxMaxMemoryBox.Value = 0M;
        }

        private void enableMaxMaxMemoryFrequencyBox_CheckedChanged(object sender, EventArgs e)
        {
            maxMaxMemoryFrequencyBox.Enabled = enableMaxMaxMemoryFrequencyBox.Checked;
            maxMaxMemoryFrequencyBox.Value = 0M;
        }

        private void enableMaxMemorySlotsBox_CheckedChanged(object sender, EventArgs e)
        {
            maxMemorySlotsBox.Enabled = enableMaxMemorySlotsBox.Checked;
            maxMemorySlotsBox.Value = 0M;
        }

        private void enableMaxPriceBox_CheckedChanged(object sender, EventArgs e)
        {
            maxPriceBox.Enabled = enableMaxPriceBox.Checked;
            maxPriceBox.Value = 0M;
        }

        private void enableMinMaxMemoryBox_CheckedChanged(object sender, EventArgs e)
        {
            minMaxMemoryBox.Enabled = enableMinMaxMemoryBox.Checked;
            minMaxMemoryBox.Value = 0M;
        }

        private void enableMinMaxMemoryFrequencyBox_CheckedChanged(object sender, EventArgs e)
        {
            minMaxMemoryFrequencyBox.Enabled = enableMinMaxMemoryFrequencyBox.Checked;
            minMaxMemoryFrequencyBox.Value = 0M;
        }

        private void enableMinMemorySlotsBox_CheckedChanged(object sender, EventArgs e)
        {
            minMemorySlotsBox.Enabled = enableMinMemorySlotsBox.Checked;
            minMemorySlotsBox.Value = 0M;
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

        private async void MotherboardListView_Load(object sender, EventArgs e)
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