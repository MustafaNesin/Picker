namespace Picker
{
    using System;
    using System.Windows.Forms;

    internal partial class BuildListView : Form, IBuildListView
    {
        private readonly BuildListPresenter _presenter;
        public string EntityName => throw new InvalidOperationException();
        public int ItemPerPage => 5;

        public int OrderIndex
        {
            get => throw new InvalidOperationException();
            set => throw new InvalidOperationException();
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

        public BuildListView(BuildListPresenter presenter)
        {
            InitializeComponent();
            _presenter = presenter;
        }

        private async void BuildListView_Load(object sender, EventArgs e)
        {
            await _presenter.GenerateListAsync();
            pageNumberBox.ValueChanged += pageBox_ValueChanged;
        }

        private void firstPageButton_Click(object sender, EventArgs e) => pageNumberBox.Value = 1;

        private void lastPageButton_Click(object sender, EventArgs e)
            => pageNumberBox.Value = PageCount;

        private void mainButton_Click(object sender, EventArgs e)
        {
            if (_presenter.GeneratingList)
                DialogResult = DialogResult.None;
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
                $"{itemCount} tanesi listelenen, toplam {totalItemCount} bilgisayar var.";

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