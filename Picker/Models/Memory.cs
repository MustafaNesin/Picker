namespace Picker.Models
{
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.ComponentModel.DataAnnotations;

    [DisplayName("bellek")]
    internal class Memory : Product
    {
        [DisplayName("Bilgisayarlar")]
        public virtual ICollection<Build> Builds { get; set; }

        [DisplayName("Kapasite")]
        public int Capacity { get; set; } // GB

        [DisplayName("Mod�ller")]
        public int Count { get; set; }

        [DisplayName("Frekans")]
        public int Frequency { get; set; } // MHz

        [DisplayName("ECC Deste�i")]
        public bool HasECC { get; set; }

        [DisplayName("Ara Bellekleme")]
        public bool IsBuffered { get; set; }

        [Required]
        [DisplayName("Tip")]
        public string Type { get; set; }

        [DisplayName("Bant Geni�li�i")]
        public int GetBandwidth() => Frequency * 8; // MB/s
    }
}