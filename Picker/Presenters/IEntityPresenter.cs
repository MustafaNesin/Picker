namespace Picker.Presenters
{
    using System.Windows.Forms;
    using Models;
    using Views;

    internal interface IEntityPresenter<TEntityView, TEntity> : IPresenter<TEntityView, TEntity>
        where TEntityView : Form, IEntityView<TEntity>
        where TEntity : class, IEntity
    {
        ComputerDatabaseContext Context { get; }
        TEntity Entity { get; }
    }
}