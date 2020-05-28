namespace Picker
{
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.ComponentModel.DataAnnotations;

    [DisplayName("i�lemci")]
    internal class Processor : Product
    {
        [DisplayName("�nbellek")]
        public int CacheSize { get; set; }

        [DisplayName("Yonga Setleri")]
        public virtual ICollection<Chipset> Chipsets { get; set; }

        [DisplayName("�ekirdek Say�s�")]
        public int Cores { get; set; }

        [DisplayName("��lemci Ailesi")]
        [Required]
        public string Family { get; set; }

        [DisplayName("Temel Frekans")]
        public int Frequency { get; set; } // MHz

        [DisplayName("64 Bit Deste�i")]
        public bool Is64Bit { get; set; }

        [DisplayName("Maksimum Bellek")]
        public int MaxMemory { get; set; } // GB

        [DisplayName("Max Bellek H�z�")]
        public int MaxMemorySpeed { get; set; } // MHz

        [DisplayName("Soket")]
        public Socket Socket { get; set; }

        [DisplayName("ECC Deste�i")]
        public bool SupportsECC { get; set; }

        [DisplayName("�� Par�ac��� Say�s�")]
        public int Threads { get; set; }

        [DisplayName("Turbo Frekans")]
        public int TurboFrequency { get; set; } // MHz
    }
}