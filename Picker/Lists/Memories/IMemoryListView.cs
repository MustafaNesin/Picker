using System.Windows.Forms;

namespace Picker
{
    internal interface IMemoryListView : IListView
    {
        string MemoryBrand { get; }
        string MemoryType { get; }
        int? MemoryCount { get; }
        int? MemoryMinCapacity { get; }
        int? MemoryMaxCapacity { get; }
        int? MemoryMinFrequency { get; }
        int? MemoryMaxFrequency { get; }
        decimal? MemoryMinPrice { get; }
        decimal? MemoryMaxPrice { get; }
        CheckState MemoryHasECC { get; }
        CheckState MemoryIsBuffered { get; }
        bool OnlyCompatibles { get; }
    }
}