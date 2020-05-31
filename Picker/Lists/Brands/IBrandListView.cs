namespace Picker
{
    internal interface IBrandListView : IListView<Brand>
    {
        Country BrandCountry { get; set; }
        string BrandName { get; set; }
        int ItemPerPage { get; }
        int OrderIndex { get; set; }
        int PageCount { get; set; }
        int PageIndex { get; set; }

        void SetCountLabel(int itemCount, int totalItemCount);
    }
}