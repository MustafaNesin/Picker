namespace Picker
{
    using System.ComponentModel.DataAnnotations;

    internal class Motherboard : Product
    {
        public Chipset Chipset { get; set; }

        [Required]
        public string FormFactor { get; set; }

        public int MaxMemory { get; set; } // GB
        public int MaxMemorySpeed { get; set; } // MHz
        public int MemorySlots { get; set; }

        [Required]
        public string MemoryType { get; set; }

        public Socket Socket { get; set; }
        public bool SupportsECC { get; set; }
    }
}