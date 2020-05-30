namespace Picker
{
    internal interface IItemView<TEntity> : IView<TEntity>
        where TEntity : Entity
    {
    }
}