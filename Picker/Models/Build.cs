namespace Picker.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.ComponentModel.DataAnnotations;

    [DisplayName("bilgisayar")]
    internal class Build : IEntity
    {
        [DisplayName("Tarih")]
        public DateTime Date { get; set; }

        [DisplayName("Ekran Kartý")]
        public Graphics Graphics { get; set; }

        public int Id { get; private set; }

        [DisplayName("Bellekler")]
        public virtual ICollection<Memory> Memories { get; set; }

        [DisplayName("Anakart")]
        public Motherboard Motherboard { get; set; }

        [Required]
        [DisplayName("Ad")]
        public string Name { get; set; }

        [DisplayName("Ýþlemci")]
        public Processor Processor { get; set; }
    }
}