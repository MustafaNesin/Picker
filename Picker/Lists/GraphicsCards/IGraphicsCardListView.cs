namespace Picker
{
    internal interface IGraphicsCardListView : IListView
    {
        string GraphicsCardBrand { get; }
        string GraphicsCardChipsetBrand { get; }
        string GraphicsCardChipsetModel { get; }
        int? GraphicsCardMaxBusWidth { get; }
        int? GraphicsCardMaxFrequency { get; }
        int? GraphicsCardMaxMemory { get; }
        int? GraphicsCardMaxMemoryFrequency { get; }
        decimal? GraphicsCardMaxPrice { get; }
        int? GraphicsCardMaxTurboFrequency { get; }
        string GraphicsCardMemoryType { get; }
        int? GraphicsCardMinBusWidth { get; }
        int? GraphicsCardMinFrequency { get; }
        int? GraphicsCardMinMemory { get; }
        int? GraphicsCardMinMemoryFrequency { get; }
        decimal? GraphicsCardMinPrice { get; }
        int? GraphicsCardMinTurboFrequency { get; }
        bool OnlyCompatibles { get; }
    }
}