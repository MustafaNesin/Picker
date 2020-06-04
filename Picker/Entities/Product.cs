namespace Picker
{
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    public abstract class Product : Part
    {
        [Required]
        public string Model { get; set; }

        [Column(TypeName = "money")]
        public decimal Price { get; set; } // USD
    }
}