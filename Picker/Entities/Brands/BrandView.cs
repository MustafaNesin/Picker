namespace Picker
{
    using System;
    using System.Drawing;
    using System.Windows.Forms;

    internal partial class BrandView : Form, IBrandView
    {
        private readonly BrandPresenter _presenter;
        public Color BrandColor { get; set; }
        public string BrandCountry { get; set; }
        public Image BrandImage { get; set; }
        public string BrandName { get; set; }

        public BrandView(BrandPresenter presenter)
        {
            InitializeComponent();
            _presenter = presenter;
        }

        private void acceptButton_Click(object sender, EventArgs e) => Close();
    }
}