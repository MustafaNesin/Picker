namespace Picker
{
    using System.ComponentModel;
    using System.ComponentModel.DataAnnotations;

    internal abstract class Entity
    {
        public int Id { get; private set; }

        [Required]
        [DisplayName("Ad")]
        public string Name { get; set; }
    }
}