namespace Picker.Model
{
    using System.ComponentModel.DataAnnotations;

    public class Brand
    {
        [Required] public string Country { get; set; }
        public int Id { get; set; }
        [Required] public string Name { get; set; }
    }
}