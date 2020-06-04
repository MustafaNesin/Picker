namespace Picker
{
    internal interface IGraphicsCardView : IEntityView
    {
        Brand GraphicsCardBrand { get; set; }
        int GraphicsCardBusWidth { get; set; }
        Brand GraphicsCardChipsetBrand { get; set; }
        string GraphicsCardChipsetModel { get; set; }
        int GraphicsCardFrequency { get; set; }
        int GraphicsCardMemory { get; set; }
        int GraphicsCardMemoryFrequency { get; set; }
        string GraphicsCardMemoryType { get; set; }
        string GraphicsCardModel { get; set; }
        decimal GraphicsCardPrice { get; set; }
        int GraphicsCardTurboFrequency { get; set; }
    }
}