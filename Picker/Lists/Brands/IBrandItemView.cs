namespace Picker
{
    using System.Drawing;

    internal interface IBrandItemView : IItemView<Brand>
    {
        Color BrandColor { get; set; }
        string BrandCountry { get; set; }
        Image BrandImage { get; set; }
        string BrandName { get; set; }
    }
}