namespace Picker
{
    using System.Windows.Forms;

    internal partial class ProcessorListView : Form, IProcessorListView
    {
        private ProcessorListPresenter _presenter;

        public ProcessorListView(ProcessorListPresenter presenter)
        {
            InitializeComponent();
            _presenter = presenter;
        }
    }
}