namespace Picker.Models
{
    using System.ComponentModel;
    using System.ComponentModel.DataAnnotations.Schema;

    [DisplayName("ürün")]
    internal class Product : Part
    {
        public string Model { get; set; }
        [Column(TypeName = "money")] public decimal Price { get; set; } // USD
    }
}