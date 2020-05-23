namespace Picker.Model
{
    using System.Collections.Generic;

    public class Chipset : Part
    {
        public virtual ICollection<Processor> Processors { get; set; }
    }
}