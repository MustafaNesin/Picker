namespace Picker
{
    using System.ComponentModel;
    using System.ComponentModel.DataAnnotations;

    [DisplayName("ekran kartý")]
    internal class GraphicsCard : Product
    {
        [DisplayName("Bellek Veriyolu")]
        public int BusWidth { get; set; } // Bit

        [DisplayName("GPU Markasý")]
        public Brand ChipsetBrand { get; set; }

        [Required]
        [DisplayName("GPU Modeli")]
        public string ChipsetModel { get; set; }

        [DisplayName("Temel Frekans")]
        public int Frequency { get; set; } // MHz

        [DisplayName("Bellek Boyutu")]
        public int Memory { get; set; } // GB

        [DisplayName("Bellek Frekansý")]
        public int MemoryFrequency { get; set; } // MHz

        [Required]
        [DisplayName("Bellek Tipi")]
        public string MemoryType { get; set; }

        [DisplayName("Turbo Frekans")]
        public int TurboFrequency { get; set; } // MHz

        [DisplayName("Bant Geniþliði")]
        public int GetBandwidth() => GetEfficientMemoryFrequency() * BusWidth / 8; // MB/s

        [DisplayName("Efektif Bellek Frekansý")]
        public int GetEfficientMemoryFrequency()
            => MemoryFrequency * Utilities.GetPumpRate(MemoryType); // MHz
    }
}