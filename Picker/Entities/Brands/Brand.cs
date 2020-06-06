namespace Picker
{
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Diagnostics.CodeAnalysis;
    using System.Drawing;
    using System.IO;

    public class Brand : Entity
    {
        public int Argb
        {
            get => Color.ToArgb();
            set => Color = Color.FromArgb(value);
        }

        public virtual ICollection<Chipset> Chipsets { get; set; }

        [NotMapped]
        public Color Color { get; set; }

        [Range((int)Country.VI, (int)Country.ZW)]
        public Country Country { get; set; }

        public virtual ICollection<GraphicsCard> GraphicsCards { get; set; }

        protected override string ImagePath
            => _imagePath ??= Path.Combine(DatabaseUtilities.BrandImagesDirectory, Id + ".png");

        public virtual ICollection<Memory> Memories { get; set; }
        public virtual ICollection<Motherboard> Motherboards { get; set; }
        public virtual ICollection<Processor> Processors { get; set; }
        public virtual ICollection<Socket> Sockets { get; set; }

        [SuppressMessage("ReSharper", "VirtualMemberCallInConstructor")]
        public Brand()
        {
            Chipsets = new HashSet<Chipset>();
            GraphicsCards = new HashSet<GraphicsCard>();
            Memories = new HashSet<Memory>();
            Motherboards = new HashSet<Motherboard>();
            Processors = new HashSet<Processor>();
            Sockets = new HashSet<Socket>();
        }
    }
}