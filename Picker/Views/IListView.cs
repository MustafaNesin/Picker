namespace Picker.Views
{
    using Models;

    internal interface IListView<TEntity> : IView<TEntity>
        where TEntity : IEntity
    {
    }
}