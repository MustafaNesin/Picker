namespace Picker.Presenters
{
    using System;
    using System.Threading.Tasks;
    using System.Windows.Forms;
    using Models;
    using Views;

    internal interface IPresenter<TView, TEntity> : IAsyncDisposable
        where TView : Form, IView<TEntity>
        where TEntity : IEntity
    {
        TView View { get; }
        DialogResult ViewResult { get; }

        Task FormLoad();

        object Invoke(Action action);

        DialogResult ShowView();
    }
}