namespace Picker
{
    using System;
    using System.Windows.Forms;

    internal partial class BrandListView : Form, IBrandListView
    {
        private const string CountLabelFormat = "{0} listelenen toplam {1} marka var.";
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
                pageIndexBox.Minimum = value == 0 ? 0 : 1;
                pageIndexBox.Maximum = value;
            }
        }

        public int PageIndex
        {
            get => PageCount == 0 ? 0 : (int)pageIndexBox.Value - 1;
            set => pageIndexBox.Value = PageCount == 0 ? 0 : value + 1;
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

            await _presenter.GenerateList();

            orderBox.SelectedIndexChanged += GenerateListEvent;
            itemCountBox.SelectedIndexChanged += GenerateListEvent;
            pageIndexBox.ValueChanged += pageIndexBox_ValueChanged;
        }

        private async void GenerateListEvent(object sender, EventArgs e)
            => await _presenter.GenerateList();

        private async void newButton_Click(object sender, EventArgs e)
            => await _presenter.AddItemAsync();

        private async void pageIndexBox_ValueChanged(object sender, EventArgs e)
            => await _presenter.GenerateList(true);

        public void SetCountLabel(int itemCount, int totalItemCount)
            => countLabel.Text = string.Format(CountLabelFormat, itemCount, totalItemCount);
    }
}