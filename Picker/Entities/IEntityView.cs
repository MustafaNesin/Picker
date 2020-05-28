namespace Picker
{
    internal interface IEntityView<TEntity> : IView<TEntity>
        where TEntity : Entity
    {
    }
}