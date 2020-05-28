namespace Picker
{
    using System.ComponentModel;
    using System.ComponentModel.DataAnnotations;

    [DisplayName("anakart")]
    internal class Motherboard : Product
    {
        [DisplayName("Yonga Seti")]
        public Chipset Chipset { get; set; }

        [Required]
        [DisplayName("Form Faktör")]
        public string FormFactor { get; set; }

        [DisplayName("Maksimum Bellek")]
        public int MaxMemory { get; set; } // GB

        [DisplayName("Max Bellek Hýzý")]
        public int MaxMemorySpeed { get; set; } // MHz

        [DisplayName("Bellek Slotlarý")]
        public int MemorySlots { get; set; }

        [Required]
        [DisplayName("Bellek Tipi")]
        public string MemoryType { get; set; }

        [DisplayName("Soket")]
        public Socket Socket { get; set; }

        [DisplayName("ECC Desteði")]
        public bool SupportsECC { get; set; }
    }
}