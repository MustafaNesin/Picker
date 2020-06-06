namespace Picker
{
    using System.Windows.Forms;

    internal interface IProcessorListView : IListView
    {
        bool OnlyCompatibles { get; }
        string ProcessorBrand { get; }
        string ProcessorFamily { get; }
        CheckState ProcessorIs64Bit { get; }
        int? ProcessorMaxCacheSize { get; }
        int? ProcessorMaxCores { get; }
        int? ProcessorMaxFrequency { get; }
        int? ProcessorMaxMaxMemory { get; }
        int? ProcessorMaxMaxMemorySpeed { get; }
        decimal? ProcessorMaxPrice { get; }
        int? ProcessorMaxThreads { get; }
        int? ProcessorMaxTurboFrequency { get; }
        int? ProcessorMinCacheSize { get; }
        int? ProcessorMinCores { get; }
        int? ProcessorMinFrequency { get; }
        int? ProcessorMinMaxMemory { get; }
        int? ProcessorMinMaxMemorySpeed { get; }
        decimal? ProcessorMinPrice { get; }
        int? ProcessorMinThreads { get; }
        int? ProcessorMinTurboFrequency { get; }
        string ProcessorSocket { get; }
        CheckState ProcessorSupportsECC { get; }
    }
}