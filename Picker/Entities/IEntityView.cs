namespace Picker
{
    using System.Drawing;

    internal interface IEntityView : IView
    {
        Image EntityImage { get; set; }
        string EntityName { get; set; }
    }
}