namespace Picker
{
    using System.Collections.Generic;

    internal class Chipset : Part
    {
        public virtual ICollection<Processor> Processors { get; set; }
    }
}