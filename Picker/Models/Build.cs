namespace Picker.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.ComponentModel.DataAnnotations;

    [DisplayName("bilgisayar")]
    internal class Build : IEntity
    {
        public DateTime Date { get; set; }
        public Graphics Graphics { get; set; }
        public int Id { get; private set; }
        public virtual ICollection<Memory> Memories { get; set; }
        public Motherboard Motherboard { get; set; }
        [Required] public string Name { get; set; }
        public Processor Processor { get; set; }
    }
}