namespace Picker
{
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Drawing;

    internal class Brand : Entity
    {
        public int Argb
        {
            get => Color.ToArgb();
            set => Color = Color.FromArgb(value);
        }

        [NotMapped]
        public Color Color { get; set; }

        public Country Country { get; set; }
    }
}