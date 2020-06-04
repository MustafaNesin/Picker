namespace Picker
{
    using System.Windows.Forms;

    internal interface IMotherboardListView : IListView
    {
        string MotherboardBrand { get; }
        string MotherboardChipset { get; }
        string MotherboardFormFactor { get; }
        int? MotherboardMaxMaxMemory { get; }
        int? MotherboardMaxMaxMemoryFrequency { get; }
        int? MotherboardMaxMemorySlots { get; }
        decimal? MotherboardMaxPrice { get; }
        string MotherboardMemoryType { get; }
        int? MotherboardMinMaxMemory { get; }
        int? MotherboardMinMaxMemoryFrequency { get; }
        int? MotherboardMinMemorySlots { get; }
        decimal? MotherboardMinPrice { get; }
        string MotherboardSocket { get; }
        CheckState MotherboardSupportsECC { get; }
        bool OnlyCompatibles { get; }
    }
}