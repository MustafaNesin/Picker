namespace Picker
{
    using System.Windows.Forms;

    internal partial class BuildListView : Form, IBuildListView
    {
        private readonly BuildListPresenter _presenter;

        public BuildListView(BuildListPresenter presenter)
        {
            InitializeComponent();
            _presenter = presenter;
        }

        public bool GeneratingList
        {
            get => throw new System.NotImplementedException();
            set => throw new System.NotImplementedException();
        }

        public int ItemPerPage => throw new System.NotImplementedException();

        public int OrderIndex
        {
            get => throw new System.NotImplementedException();
            set => throw new System.NotImplementedException();
        }

        public int PageCount
        {
            get => throw new System.NotImplementedException();
            set => throw new System.NotImplementedException();
        }

        public int PageIndex
        {
            get => throw new System.NotImplementedException();
            set => throw new System.NotImplementedException();
        }

        public void UpdateNavigationButtonsStatus() => throw new System.NotImplementedException();

        public void SetCountLabel(int itemCount, int totalItemCount) => throw new System.NotImplementedException();
    }
}