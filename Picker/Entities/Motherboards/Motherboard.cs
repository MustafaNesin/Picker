namespace Picker
{
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.Diagnostics.CodeAnalysis;
    using System.IO;

    public class Motherboard : Product
    {
        public virtual ICollection<Build> Builds { get; set; }

        [Required]
        public virtual Chipset Chipset { get; set; }

        public int ChipsetId { get; set; }

        [Required]
        public string FormFactor { get; set; }

        protected override string ImagePath
            => _imagePath ??=
                Path.Combine(DatabaseUtilities.MotherboardImagesDirectory, Id + ".png");

        public int MaxMemory { get; set; } // GB
        public int MaxMemoryFrequency { get; set; } // MHz
        public int MemorySlots { get; set; }

        [Required]
        public string MemoryType { get; set; }

        [Required]
        public virtual Socket Socket { get; set; }

        public int SocketId { get; set; }
        public bool SupportsECC { get; set; }

        [SuppressMessage("ReSharper", "VirtualMemberCallInConstructor")]
        public Motherboard() => Builds = new HashSet<Build>();
    }
}