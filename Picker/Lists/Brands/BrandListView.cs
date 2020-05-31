namespace Picker
{
    using System;
    using System.Windows.Forms;

    internal partial class BrandListView : Form, IBrandListView
    {
        private const string CountLabelFormat = "{0} tanesi listelenen, toplam {1} marka var.";
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
            => int.Parse(itemCountBox
                .Items[itemCountBox.SelectedIndex == -1 ? 1 : itemCountBox.SelectedIndex]
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
                pageBox.Minimum = value == 0 ? 0 : 1;
                pageBox.Maximum = value;
            }
        }

        public int PageIndex
        {
            get => PageCount == 0 ? 0 : (int)pageBox.Value - 1;
            set => pageBox.Value = PageCount == 0 ? 0 : value + 1;
        }

        public BrandListView(BrandListPresenter presenter)
        {
            InitializeComponent();
            _presenter = presenter;
        }

        private async void BrandListView_Load(object sender, EventArgs e)
        {
            orderBox.SelectedIndex = 1;
            itemCountBox.SelectedIndex = 1;

            await _presenter.GenerateListAsync();

            orderBox.SelectedIndexChanged += GenerateListAsyncEvent;
            itemCountBox.SelectedIndexChanged += GenerateListAsyncEvent;
            pageBox.ValueChanged += pageBox_ValueChanged;
        }

        private void firstPageButton_Click(object sender, EventArgs e) => pageBox.Value = 1;

        private async void GenerateListAsyncEvent(object sender, EventArgs e)
        {
            if (!GeneratingList)
                await _presenter.GenerateListAsync();
        }
        private async void newButton_Click(object sender, EventArgs e)
        {
            if (!GeneratingList)
                await _presenter.AddItemAsync();
        }
        private async void pageBox_ValueChanged(object sender, EventArgs e)
        {
            if (!GeneratingList)
                await _presenter.GenerateListAsync(true);
        }

        private void lastPageButton_Click(object sender, EventArgs e) => pageBox.Value = PageCount;


        private void nextPageButton_Click(object sender, EventArgs e) => pageBox.Value++;


        private void previousPageButton_Click(object sender, EventArgs e) => pageBox.Value--;

        public void UpdateNavigationButtonsStatus()
        {
            firstPageButton.Enabled = previousPageButton.Enabled = pageBox.Value > 1;
            lastPageButton.Enabled = nextPageButton.Enabled = pageBox.Value < PageCount;
        }

        public void SetCountLabel(int itemCount, int totalItemCount)
            => countLabel.Text = string.Format(CountLabelFormat, itemCount, totalItemCount);

        private async void deselectCountryButton_Click(object sender, EventArgs e)
        {
            if (GeneratingList)
                return;

            countryBox.SelectedIndex = -1;
            await _presenter.GenerateListAsync();
        }
    }
}