namespace Picker
{
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.Diagnostics.CodeAnalysis;
    using System.IO;

    public class Processor : Product
    {
        public virtual ICollection<Build> Builds { get; set; }
        public int CacheSize { get; set; }
        public int Cores { get; set; }

        [Required]
        public string Family { get; set; }

        public int Frequency { get; set; } // MHz

        protected override string ImagePath
            => _imagePath ??= Path.Combine(DatabaseUtilities.ProcessorImagesDirectory, Id + ".png");

        public bool Is64Bit { get; set; }
        public int MaxMemory { get; set; } // GB
        public int MaxMemorySpeed { get; set; } // MHz

        [Required]
        public virtual Socket Socket { get; set; }

        public int SocketId { get; set; }
        public bool SupportsECC { get; set; }
        public int Threads { get; set; }
        public int TurboFrequency { get; set; } // MHz

        [SuppressMessage("ReSharper", "VirtualMemberCallInConstructor")]
        public Processor() => Builds = new HashSet<Build>();
    }
}