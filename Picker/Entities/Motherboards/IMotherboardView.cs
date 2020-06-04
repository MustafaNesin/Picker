namespace Picker
{
    internal interface IMotherboardView : IEntityView
    {
        Brand MotherboardBrand { get; set; }
        Chipset MotherboardChipset { get; set; }
        string MotherboardFormFactor { get; set; }
        int MotherboardMaxMemory { get; set; }
        int MotherboardMaxMemoryFrequency { get; set; }
        int MotherboardMemorySlots { get; set; }
        string MotherboardMemoryType { get; set; }
        string MotherboardModel { get; set; }
        decimal MotherboardPrice { get; set; }
        Socket MotherboardSocket { get; set; }
        bool MotherboardSupportsECC { get; set; }
    }
}