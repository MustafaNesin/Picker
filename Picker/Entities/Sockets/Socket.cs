namespace Picker
{
    using System.Collections.Generic;
    using System.Diagnostics.CodeAnalysis;
    using System.IO;

    public class Socket : Part
    {
        protected override string ImagePath
            => _imagePath ??= Path.Combine(DatabaseUtilities.SocketImagesDirectory, Id + ".png");

        public virtual ICollection<Motherboard> Motherboards { get; set; }
        public virtual ICollection<Processor> Processors { get; set; }
        public bool SupportsDDR2 { get; set; }
        public bool SupportsDDR3 { get; set; }
        public bool SupportsDDR4 { get; set; }

        [SuppressMessage("ReSharper", "VirtualMemberCallInConstructor")]
        public Socket()
        {
            Motherboards = new HashSet<Motherboard>();
            Processors = new HashSet<Processor>();
        }
    }
}