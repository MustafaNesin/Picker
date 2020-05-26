namespace Picker.Views
{
    using System;
    using System.Windows.Forms;
    using Presenters;

    internal partial class BuildForm : Form, IBuildView
    {
        private readonly BuildPresenter _presenter;

        public BuildForm(BuildPresenter presenter)
        {
            InitializeComponent();
            _presenter = presenter;
        }

        public void FormLoad(object sender, EventArgs e) => throw new NotImplementedException();
    }
}