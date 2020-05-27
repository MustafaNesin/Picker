namespace Picker.Models
{
    using System.ComponentModel;
    using System.ComponentModel.DataAnnotations;

    [DisplayName("parça")]
    internal class Part : IEntity
    {
        [DisplayName("Marka")]
        public Brand Brand { get; set; }

        public int Id { get; private set; }

        [Required]
        [DisplayName("Ad")]
        public string Name { get; set; }
    }
}