namespace Picker
{
    public class ProcessorChipset
    {
        public Chipset Chipset { get; set; }
        public int ChipsetId { get; set; }
        public int Id { get; private set; }
        public Processor Processor { get; set; }
        public int ProcessorId { get; set; }
    }
}