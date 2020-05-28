namespace Picker
{
    using System.Collections.Generic;
    using System.ComponentModel;

    [DisplayName("yonga seti")]
    internal class Chipset : Part
    {
        [DisplayName("Ýþlemciler")]
        public virtual ICollection<Processor> Processors { get; set; }
    }
}