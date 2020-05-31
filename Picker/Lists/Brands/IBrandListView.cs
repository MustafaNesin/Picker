namespace Picker
{
    internal interface IBrandListView : IListView<Brand>
    {
        Country BrandCountry { get; set; }
        string BrandName { get; set; }
    }
}