namespace Picker.Views
{
    using Models;

    internal interface IEntityView<TEntity> : IView<TEntity>
        where TEntity : IEntity
    {
    }
}