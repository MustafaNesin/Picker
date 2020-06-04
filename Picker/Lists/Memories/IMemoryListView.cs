namespace Picker
{
    using System.Windows.Forms;

    internal interface IMemoryListView : IListView
    {
        string MemoryBrand { get; }
        int? MemoryCount { get; }
        CheckState MemoryHasECC { get; }
        CheckState MemoryIsBuffered { get; }
        int? MemoryMaxCapacity { get; }
        int? MemoryMaxFrequency { get; }
        decimal? MemoryMaxPrice { get; }
        int? MemoryMinCapacity { get; }
        int? MemoryMinFrequency { get; }
        decimal? MemoryMinPrice { get; }
        string MemoryType { get; }
        bool OnlyCompatibles { get; }
    }
}