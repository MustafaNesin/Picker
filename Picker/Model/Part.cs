namespace Picker.Model
{
    using System.ComponentModel.DataAnnotations;

    public class Part
    {
        public Brand Brand { get; set; }
        public int Id { get; set; }
        [Required] public string Name { get; set; }
    }
}