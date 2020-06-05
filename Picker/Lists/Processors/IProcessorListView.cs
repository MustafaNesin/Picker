namespace Picker
{
    using System.Windows.Forms;

    internal interface IProcessorListView : IListView
    {
        string ProcessorBrand { get; }
        string ProcessorFamily { get; }
        string ProcessorSocket { get; }

        decimal? ProcessorMinPrice { get; }
        decimal? ProcessorMaxPrice { get; }

        int? ProcessorMinCores { get; }
        int? ProcessorMaxCores { get; }
        int? ProcessorMinThreads { get; }
        int? ProcessorMaxThreads { get; }
        int? ProcessorMinCacheSize { get; }
        int? ProcessorMaxCacheSize { get; }










        int? ProcessorMinFrequency { get; }
        int? ProcessorMaxFrequency { get; }
        int? ProcessorMinTurboFrequency { get; }
        int? ProcessorMaxTurboFrequency { get; }









        int? ProcessorMinMaxMemory { get; }
        int? ProcessorMaxMaxMemory { get; }
        int? ProcessorMinMaxMemorySpeed { get; }
        int? ProcessorMaxMaxMemorySpeed { get; }





        CheckState ProcessorSupportsECC { get; }
        CheckState ProcessorIs64Bit { get; }
        bool OnlyCompatibles { get; }
    }
}