namespace Picker
{
    using System.ComponentModel.DataAnnotations;

    internal abstract class Entity
    {
        public int Id { get; private set; }

        [Required]
        public string Name { get; set; }
    }
}