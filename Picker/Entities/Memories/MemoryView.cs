﻿namespace Picker
{
    using System.Windows.Forms;

    internal partial class MemoryView : Form, IMemoryView
    {
        private readonly MemoryPresenter _presenter;

        public MemoryView(MemoryPresenter presenter)
        {
            InitializeComponent();
            _presenter = presenter;
        }
    }
}