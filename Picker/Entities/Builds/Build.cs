namespace Picker
{
    using System;
    using System.Collections.Generic;
    using System.Diagnostics.CodeAnalysis;
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

        public bool IsCompatibleWith(Motherboard motherboard)
            => IsCompatibleWith(motherboard, out var messages);

        public bool IsCompatibleWith(Motherboard motherboard, out List<CompabilityNote> issues)
        {
            issues = new List<CompabilityNote>();
            return true;
        }

        public bool IsCompatibleWith(Processor processor)
            => IsCompatibleWith(processor, out var messages);

        public bool IsCompatibleWith(Processor processor, out List<CompabilityNote> issues)
        {
            issues = new List<CompabilityNote>();
            return true;
        }

        public bool IsCompatibleWith(GraphicsCard graphicsCard)
            => IsCompatibleWith(graphicsCard, out var messages);

        public bool IsCompatibleWith(GraphicsCard graphicsCard, out List<CompabilityNote> issues)
        {
            issues = new List<CompabilityNote>();
            return true;
        }

        public bool IsCompatibleWith(Memory memory) => IsCompatibleWith(memory, out var messages);

        public bool IsCompatibleWith(Memory memory, out List<CompabilityNote> issues)
        {
            issues = new List<CompabilityNote>();
            return true;
        }
    }
}