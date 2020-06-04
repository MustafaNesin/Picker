namespace Picker
{
    using System.Collections.Generic;

    internal interface IBuildView : IEntityView
    {
        GraphicsCard BuildGraphicsCard { get; set; }
        List<Memory> BuildMemories { get; set; }
        Motherboard BuildMotherboard { get; set; }
        Processor BuildProcessor { get; set; }
    }
}