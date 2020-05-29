namespace Picker
{
    using System.Windows.Forms;

    internal partial class ProcessorView : Form, IProcessorView
    {
        private readonly ProcessorPresenter _presenter;

        public ProcessorView(ProcessorPresenter presenter)
        {
            InitializeComponent();
            _presenter = presenter;
        }
    }
}