namespace Picker.Model
{
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    public class Processor : Product
    {
        public int CacheSize { get; set; }
        public virtual ICollection<Chipset> Chipsets { get; set; }
        public int Cores { get; set; }
        [Required] public string Family { get; set; }
        public int Frequency { get; set; } // MHz
        public bool Is64Bit { get; set; }
        public int MaxMemory { get; set; } // GB
        public int MaxMemorySpeed { get; set; } // MHz
        [Required] public string Model { get; set; }
        public Socket Socket { get; set; }
        public bool SupportsECC { get; set; }
        public int Threads { get; set; }
        public int TurboFrequency { get; set; } // MHz
    }
}