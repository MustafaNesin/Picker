namespace Picker
{
    using System.Drawing;

    internal interface IBrandItemView : IItemView<Brand>
    {
        Color BrandColor { get; set; }
        Country BrandCountry { get; set; }
        Image BrandImage { get; set; }
        string BrandName { get; set; }
    }
}