namespace Picker
{
    using System;
    using System.IO;

    public class Build : Entity
    {
        public DateTime Date { get; set; }
        public virtual GraphicsCard GraphicsCard { get; set; }
        public int? GraphicsCardId { get; set; }

        protected override string ImagePath
            => _imagePath ??= Path.Combine(DatabaseUtilities.BuildImagesDirectory, Id + ".png");

        public virtual Motherboard Motherboard { get; set; }
        public int? MotherboardId { get; set; }
        public virtual Processor Processor { get; set; }
        public int? ProcessorId { get; set; }
    }
}