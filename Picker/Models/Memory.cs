namespace Picker.Models
{
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.ComponentModel.DataAnnotations;

    [DisplayName("bellek")]
    internal class Memory : Product
    {
        public virtual ICollection<Build> Builds { get; set; }
        public int Capacity { get; set; } // GB
        public int Count { get; set; }
        public int Frequency { get; set; } // MHz
        public bool HasECC { get; set; }
        public bool IsBuffered { get; set; }
        [Required] public string Type { get; set; }

        public int GetBandwidth() => Frequency * 8; // MB/s
    }
}