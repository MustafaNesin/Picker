namespace Picker.Models
{
    using System.Collections.Generic;
    using System.ComponentModel;

    [DisplayName("yonga seti")]
    internal class Chipset : Part
    {
        public virtual ICollection<Processor> Processors { get; set; }
    }
}