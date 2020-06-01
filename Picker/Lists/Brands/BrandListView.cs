namespace Picker
{
    using System;
    using System.Windows.Forms;

    internal partial class BrandListView : Form, IBrandListView
    {
        private readonly BrandListPresenter _presenter;

        public Country BrandCountry
        {
            get => (Country)countryBox.SelectedIndex;
            set => countryBox.SelectedIndex = (int)value;
        }

        public string BrandName
        {
            get => nameBox.Text;
            set => nameBox.Text = value ?? string.Empty;
        }

        public bool GeneratingList { get; set; }

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

        public BrandListView(BrandListPresenter presenter)
        {
            InitializeComponent();
            _presenter = presenter;
            countryBox.Items.AddRange(Utilities.GetCountryNames());
            orderBox.SelectedIndex = 1;
            itemPerPageBox.SelectedIndex = 0;
        }

        private async void BrandListView_Load(object sender, EventArgs e)
        {
            await _presenter.GenerateListAsync();

            countryBox.SelectedIndexChanged += GenerateListAsyncEvent;
            orderBox.SelectedIndexChanged += GenerateListAsyncEvent;
            itemPerPageBox.SelectedIndexChanged += GenerateListAsyncEvent;
            pageNumberBox.ValueChanged += pageBox_ValueChanged;
        }

        private void deselectCountryButton_Click(object sender, EventArgs e)
            => countryBox.SelectedIndex = -1;

        private void firstPageButton_Click(object sender, EventArgs e) => pageNumberBox.Value = 1;

        private async void GenerateListAsyncEvent(object sender, EventArgs e)
        {
            if (!GeneratingList)
                await _presenter.GenerateListAsync();
        }

        private void lastPageButton_Click(object sender, EventArgs e) => pageNumberBox.Value = PageCount;

        private async void newButton_Click(object sender, EventArgs e)
        {
            if (!GeneratingList)
                await _presenter.AddItemAsync();
        }

        private void nextPageButton_Click(object sender, EventArgs e) => pageNumberBox.Value++;

        private async void pageBox_ValueChanged(object sender, EventArgs e)
        {
            if (!GeneratingList)
                await _presenter.GenerateListAsync(true);
        }

        private void previousPageButton_Click(object sender, EventArgs e) => pageNumberBox.Value--;

        public void SetCountLabel(int itemCount, int totalItemCount)
            => countLabel.Text =
                $"{itemCount} tanesi listelenen, toplam {totalItemCount} marka var.";

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