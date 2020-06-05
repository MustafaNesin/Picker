using System.Collections.Generic;

namespace Picker
{
    internal interface IProcessorView : IEntityView
    {
        Brand ProcessorBrand { get; set; }
        string ProcessorFamily { get; set; }
        string ProcessorModel { get; set; }

        decimal ProcessorPrice { get; set; }

        int ProcessorCores { get; set; }
        int ProcessorThreads { get; set; }
        int ProcessorCacheSize { get; set; }

        int ProcessorFrequency { get; set; }
        int ProcessorTurboFrequency { get; set; }
        int ProcessorMaxMemory { get; set; }
        int ProcessorMaxMemorySpeed { get; set; }

        bool ProcessorIs64Bit { get; set; }
        bool ProcessorSupportsECC { get; set; }

        Socket ProcessorSocket { get; set; }
        List<Chipset> ProcessorChipsets { get; set; }
    }
}