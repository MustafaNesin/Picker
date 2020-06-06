namespace Picker
{
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.Diagnostics.CodeAnalysis;
    using System.IO;

    public class GraphicsCard : Product
    {
        public virtual ICollection<Build> Builds { get; set; }
        public int BusWidth { get; set; } // Bit
        public virtual Brand ChipsetBrand { get; set; }
        public int ChipsetBrandId { get; set; }

        [Required]
        public string ChipsetModel { get; set; }

        public int Frequency { get; set; } // MHz

        protected override string ImagePath
            => _imagePath ??=
                Path.Combine(DatabaseUtilities.GraphicsCardImagesDirectory, Id + ".png");

        public int Memory { get; set; } // GB
        public int MemoryFrequency { get; set; } // MHz

        [Required]
        public string MemoryType { get; set; }

        public int TurboFrequency { get; set; } // MHz

        [SuppressMessage("ReSharper", "VirtualMemberCallInConstructor")]
        public GraphicsCard() => Builds = new HashSet<Build>();

        public int GetBandwidth()
            => DatabaseUtilities.GetGraphicsCardBandwidth(MemoryFrequency, MemoryType,
                BusWidth); // MB/s

        public int GetEfficientMemoryFrequency()
            => MemoryFrequency * DatabaseUtilities.GetPumpRate(MemoryType); // MHz
    }
}