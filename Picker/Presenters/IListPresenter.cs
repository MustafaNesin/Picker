namespace Picker.Presenters
{
    using System.Collections.Generic;
    using System.Threading.Tasks;
    using System.Windows.Forms;
    using Models;
    using Views;

    internal interface IListPresenter<TListView, TEntity> : IPresenter<TListView, TEntity>
        where TListView : Form, IListView<TEntity>
        where TEntity : IEntity
    {
        Dictionary<TEntity, ListItemControl<TEntity>> Items { get; }

        void AddItem(TEntity entity);

        void ClearItems();

        Task LoadItems();
    }
}