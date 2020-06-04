namespace Picker
{
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.Diagnostics.CodeAnalysis;
    using System.IO;

    public class Memory : Product
    {
        public virtual ICollection<Build> Builds { get; set; }
        public int Capacity { get; set; } // GB
        public int Count { get; set; }
        public int Frequency { get; set; } // MHz
        public bool HasECC { get; set; }

        protected override string ImagePath
            => _imagePath ??= Path.Combine(DatabaseUtilities.MemoryImagesDirectory, Id + ".png");

        public bool IsBuffered { get; set; }

        [Required]
        public string Type { get; set; }

        [SuppressMessage("ReSharper", "VirtualMemberCallInConstructor")]
        public Memory() => Builds = new HashSet<Build>();

        public int GetBandwidth() => DatabaseUtilities.GetBandwidth(Frequency, 64); // MB/s
    }
}