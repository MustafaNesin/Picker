namespace Picker.Model
{
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    public class Memory : Product
    {
        public virtual ICollection<Build> Builds { get; set; }
        public int Capacity { get; set; } // GB
        public int Count { get; set; }
        public int Frequency { get; set; } // MHz
        public bool HasECC { get; set; }
        public bool IsBuffered { get; set; }
        [Required] public string Type { get; set; }
    }
}