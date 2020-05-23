namespace Picker.Model
{
    using System.ComponentModel.DataAnnotations;

    public class Motherboard : Product
    {
        public Chipset Chipset { get; set; }
        public int MaxMemory { get; set; } // GB
        public int MaxMemorySpeed { get; set; } // MHz
        public int MemorySlots { get; set; }
        [Required] public string MemoryType { get; set; }
        public Socket Socket { get; set; }
        public bool SupportsECC { get; set; }
    }
}