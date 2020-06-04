namespace Picker
{
    internal interface IListView : IView
    {
        string EntityName { get; }
        int ItemPerPage { get; }
        int OrderIndex { get; set; }
        int PageCount { get; set; }
        int PageIndex { get; set; }

        void SetCountLabel(int itemCount, int totalItemCount);

        void UpdateNavigationButtonsStatus();
    }
}