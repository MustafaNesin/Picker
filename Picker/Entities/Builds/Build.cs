namespace Picker
{
    using System;
    using System.Collections.Generic;

    internal class Build : Entity
    {
        public DateTime Date { get; set; }
        public GraphicsCard GraphicsCard { get; set; }
        public virtual ICollection<Memory> Memories { get; set; }
        public Motherboard Motherboard { get; set; }
        public Processor Processor { get; set; }
    }
}