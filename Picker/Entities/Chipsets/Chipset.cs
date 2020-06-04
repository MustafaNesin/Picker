namespace Picker
{
    using System.Collections.Generic;
    using System.Diagnostics.CodeAnalysis;
    using System.IO;

    public class Chipset : Part
    {
        protected override string ImagePath
            => _imagePath ??= Path.Combine(DatabaseUtilities.ChipsetImagesDirectory, Id + ".png");

        public virtual ICollection<Motherboard> Motherboards { get; set; }
        public virtual ICollection<Processor> Processors { get; set; }

        [SuppressMessage("ReSharper", "VirtualMemberCallInConstructor")]
        public Chipset()
        {
            Motherboards = new HashSet<Motherboard>();
            Processors = new HashSet<Processor>();
        }
    }
}