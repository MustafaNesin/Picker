namespace Picker
{
    internal interface IListView<TEntity> : IView<TEntity>
        where TEntity : Entity
    {
    }
}