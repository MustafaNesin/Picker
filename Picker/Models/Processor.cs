namespace Picker.Models
{
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.ComponentModel.DataAnnotations;

    [DisplayName("iþlemci")]
    internal class Processor : Product
    {
        public int CacheSize { get; set; }
        public virtual ICollection<Chipset> Chipsets { get; set; }
        public int Cores { get; set; }
        [Required] public string Family { get; set; }
        public int Frequency { get; set; } // MHz
        public bool Is64Bit { get; set; }
        public int MaxMemory { get; set; } // GB
        public int MaxMemorySpeed { get; set; } // MHz
        public Socket Socket { get; set; }
        public bool SupportsECC { get; set; }
        public int Threads { get; set; }
        public int TurboFrequency { get; set; } // MHz
    }
}