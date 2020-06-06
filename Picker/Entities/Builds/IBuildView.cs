namespace Picker
{
    using System.Collections.Generic;

    internal interface IBuildView : IEntityView
    {
        public GraphicsCard BuildGraphicsCard { get; set; }
        public List<Memory> BuildMemories { get; set; }
        public Motherboard BuildMotherboard { get; set; }
        public Processor BuildProcessor { get; set; }
    }
}