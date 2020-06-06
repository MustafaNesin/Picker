namespace Picker
{
    using System.Collections.Generic;

    internal interface IProcessorView : IEntityView
    {
        Brand ProcessorBrand { get; set; }
        int ProcessorCacheSize { get; set; }
        List<Chipset> ProcessorChipsets { get; set; }
        int ProcessorCores { get; set; }
        string ProcessorFamily { get; set; }
        int ProcessorFrequency { get; set; }
        bool ProcessorIs64Bit { get; set; }
        int ProcessorMaxMemory { get; set; }
        int ProcessorMaxMemorySpeed { get; set; }
        string ProcessorModel { get; set; }
        decimal ProcessorPrice { get; set; }
        Socket ProcessorSocket { get; set; }
        bool ProcessorSupportsECC { get; set; }
        int ProcessorThreads { get; set; }
        int ProcessorTurboFrequency { get; set; }
    }
}