namespace Picker
{
    using System.Windows.Forms;

    internal interface IMotherboardListView : IListView
    {
        string MotherboardBrand { get; }
        decimal? MotherboardMinPrice { get; }
        decimal? MotherboardMaxPrice { get; }

        string MotherboardFormFactor { get; }

        string MotherboardChipset { get; }
        string MotherboardSocket { get; }

        string MotherboardMemoryType { get; }
        int? MotherboardMinMemorySlots { get; }
        int? MotherboardMaxMemorySlots { get; }
        CheckState MotherboardSupportsECC { get; }

        int? MotherboardMinMaxMemory { get; }
        int? MotherboardMaxMaxMemory { get; }
        int? MotherboardMinMaxMemoryFrequency { get; }
        int? MotherboardMaxMaxMemoryFrequency { get; }

        bool OnlyCompatibles { get; }
    }
}