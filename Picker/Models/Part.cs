namespace Picker.Models
{
    using System.ComponentModel;
    using System.ComponentModel.DataAnnotations;

    [DisplayName("parça")]
    internal class Part : IEntity
    {
        public Brand Brand { get; set; }
        public int Id { get; private set; }
        [Required] public string Name { get; set; }
    }
}