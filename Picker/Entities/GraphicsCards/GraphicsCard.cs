namespace Picker
{
    using System.ComponentModel;
    using System.ComponentModel.DataAnnotations;

    [DisplayName("ekran kart�")]
    internal class GraphicsCard : Product
    {
        [DisplayName("Bellek Veriyolu")]
        public int BusWidth { get; set; } // Bit

        [DisplayName("GPU Markas�")]
        public Brand ChipsetBrand { get; set; }

        [Required]
        [DisplayName("GPU Modeli")]
        public string ChipsetModel { get; set; }

        [DisplayName("Temel Frekans")]
        public int Frequency { get; set; } // MHz

        [DisplayName("Bellek Boyutu")]
        public int Memory { get; set; } // GB

        [DisplayName("Bellek Frekans�")]
        public int MemoryFrequency { get; set; } // MHz

        [Required]
        [DisplayName("Bellek Tipi")]
        public string MemoryType { get; set; }

        [DisplayName("Turbo Frekans")]
        public int TurboFrequency { get; set; } // MHz

        [DisplayName("Bant Geni�li�i")]
        public int GetBandwidth() => GetEfficientMemoryFrequency() * BusWidth / 8; // MB/s

        [DisplayName("Efektif Bellek Frekans�")]
        public int GetEfficientMemoryFrequency()
            => MemoryFrequency * Utilities.GetPumpRate(MemoryType); // MHz
    }
}