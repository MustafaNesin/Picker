namespace Picker
{
    internal interface IMemoryView : IEntityView
    {
        Brand MemoryBrand { get; set; }
        string MemoryModel { get; set; }
        decimal MemoryPrice { get; set; }
        string MemoryType { get; set; }
        int MemoryCapacity { get; set; }
        int MemoryCount { get; set; }
        int MemoryFrequency { get; set; }
        bool MemoryHasECC { get; set; }
        bool MemoryIsBuffered { get; set; }
    }
}