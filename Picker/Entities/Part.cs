namespace Picker
{
    using System.ComponentModel.DataAnnotations;

    public abstract class Part : Entity
    {
        [Required]
        public virtual Brand Brand { get; set; }

        public int BrandId { get; set; }
    }
}