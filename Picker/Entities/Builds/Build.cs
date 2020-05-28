namespace Picker
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;

    [DisplayName("bilgisayar")]
    internal class Build : Entity
    {
        [DisplayName("Tarih")]
        public DateTime Date { get; set; }

        [DisplayName("Ekran Kartý")]
        public GraphicsCard GraphicsCard { get; set; }

        [DisplayName("Bellekler")]
        public virtual ICollection<Memory> Memories { get; set; }

        [DisplayName("Anakart")]
        public Motherboard Motherboard { get; set; }

        [DisplayName("Ýþlemci")]
        public Processor Processor { get; set; }
    }
}