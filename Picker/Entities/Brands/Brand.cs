namespace Picker
{
    using System.ComponentModel;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Drawing;

    [DisplayName("marka")]
    internal class Brand : Entity
    {
        [Required]
        public int Argb
        {
            get => Color.ToArgb();
            set => Color = Color.FromArgb(value);
        }

        [NotMapped]
        [DisplayName("Renk")]
        public Color Color { get; set; }

        [Required]
        [DisplayName("Ülke")]
        public string Country { get; set; }
    }
}