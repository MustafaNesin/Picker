namespace Picker
{
    internal interface IMotherboardView : IEntityView
    {
        Brand MotherboardBrand { get; set; }
        string MotherboardModel { get; set; }
        decimal MotherboardPrice { get; set; }

        string MotherboardFormFactor { get; set; }

        Chipset MotherboardChipset { get; set; }
        Socket MotherboardSocket { get; set; }

        string MotherboardMemoryType { get; set; }
        int MotherboardMemorySlots { get; set; }
        bool MotherboardSupportsECC { get; set; }

        int MotherboardMaxMemory { get; set; }
        int MotherboardMaxMemoryFrequency { get; set; }
    }
}