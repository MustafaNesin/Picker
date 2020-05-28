namespace Picker
{
    using System.ComponentModel;
    using System.ComponentModel.DataAnnotations.Schema;

    [DisplayName("ürün")]
    internal abstract class Product : Part
    {
        [DisplayName("Model")]
        public string Model { get; set; }

        [Column(TypeName = "money")]
        [DisplayName("Fiyat")]
        public decimal Price { get; set; } // USD
    }
}