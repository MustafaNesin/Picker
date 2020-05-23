namespace Picker.Model
{
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    public class Product : Part
    {
        [Required] public string Currency { get; set; }
        [Column(TypeName = "money")] public decimal Price { get; set; }
    }
}