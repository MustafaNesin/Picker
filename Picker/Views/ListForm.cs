namespace Picker.Views
{
    using System;
    using System.Windows.Forms;
    using Models;
    using Presenters;

    internal partial class ListForm<TEntity> : Form, IListView<TEntity>
        where TEntity : IEntity
    {
        private readonly IListPresenter<ListForm<TEntity>, TEntity> _presenter;

        public ListForm(IListPresenter<ListForm<TEntity>, TEntity> presenter)
        {
            InitializeComponent();
            _presenter = presenter;
        }

        public async void FormLoad(object sender, EventArgs e) => await _presenter.FormLoad();
    }
}