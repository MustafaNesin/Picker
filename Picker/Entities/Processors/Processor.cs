namespace Picker
{
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.ComponentModel.DataAnnotations;

    [DisplayName("iþlemci")]
    internal class Processor : Product
    {
        [DisplayName("Önbellek")]
        public int CacheSize { get; set; }

        [DisplayName("Yonga Setleri")]
        public virtual ICollection<Chipset> Chipsets { get; set; }

        [DisplayName("Çekirdek Sayýsý")]
        public int Cores { get; set; }

        [DisplayName("Ýþlemci Ailesi")]
        [Required]
        public string Family { get; set; }

        [DisplayName("Temel Frekans")]
        public int Frequency { get; set; } // MHz

        [DisplayName("64 Bit Desteði")]
        public bool Is64Bit { get; set; }

        [DisplayName("Maksimum Bellek")]
        public int MaxMemory { get; set; } // GB

        [DisplayName("Max Bellek Hýzý")]
        public int MaxMemorySpeed { get; set; } // MHz

        [DisplayName("Soket")]
        public Socket Socket { get; set; }

        [DisplayName("ECC Desteði")]
        public bool SupportsECC { get; set; }

        [DisplayName("Ýþ Parçacýðý Sayýsý")]
        public int Threads { get; set; }

        [DisplayName("Turbo Frekans")]
        public int TurboFrequency { get; set; } // MHz
    }
}