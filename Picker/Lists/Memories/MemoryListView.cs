﻿namespace Picker
{
    using System;
    using System.Windows.Forms;

    internal partial class MemoryListView : Form, IMemoryListView
    {
        private readonly MemoryListPresenter _presenter;

        public bool GeneratingList
        {
            get => throw new NotImplementedException();
            set => throw new NotImplementedException();
        }

        public int ItemPerPage => throw new NotImplementedException();

        public int OrderIndex
        {
            get => throw new NotImplementedException();
            set => throw new NotImplementedException();
        }

        public int PageCount
        {
            get => throw new NotImplementedException();
            set => throw new NotImplementedException();
        }

        public int PageIndex
        {
            get => throw new NotImplementedException();
            set => throw new NotImplementedException();
        }

        public MemoryListView(MemoryListPresenter presenter)
        {
            InitializeComponent();
            _presenter = presenter;
        }

        public void SetCountLabel(int itemCount, int totalItemCount)
            => throw new NotImplementedException();

        public void UpdateNavigationButtonsStatus() => throw new NotImplementedException();
    }
}