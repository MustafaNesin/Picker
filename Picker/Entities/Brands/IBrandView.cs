namespace Picker
{
    using System.Drawing;

    internal interface IBrandView : IEntityView
    {
        Color BrandColor { get; set; }
        Country BrandCountry { get; set; }
    }
}