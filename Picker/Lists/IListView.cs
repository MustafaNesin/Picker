namespace Picker
{
    internal interface IListView<TEntity> : IView<TEntity>
        where TEntity : Entity
    {
        bool GeneratingList { get; set; }
        int ItemPerPage { get; }
        int OrderIndex { get; set; }
        int PageCount { get; set; }
        int PageIndex { get; set; }

        void SetCountLabel(int itemCount, int totalItemCount);

        void UpdateNavigationButtonsStatus();
    }
}