namespace Picker
{
    using System.ComponentModel.DataAnnotations.Schema;

    internal abstract class Product : Part
    {
        public string Model { get; set; }

        [Column(TypeName = "money")]
        public decimal Price { get; set; } // USD
    }
}