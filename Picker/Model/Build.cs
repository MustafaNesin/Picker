namespace Picker.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    public class Build
    {
        public DateTime Date { get; set; }
        public Graphics Graphics { get; set; }
        public int Id { get; set; }
        public virtual ICollection<Memory> Memories { get; set; }
        public Motherboard Motherboard { get; set; }
        [Required] public string Name { get; set; }
        public Processor Processor { get; set; }
    }
}