namespace Picker
{
    internal interface IItemView<in TEntity> : IView
        where TEntity : Entity
    {
        void UpdateView(TEntity entity);
    }
}