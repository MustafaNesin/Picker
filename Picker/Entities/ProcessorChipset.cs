using System.ComponentModel.DataAnnotations;

namespace Picker
{
    public class ProcessorChipset
    {
        public int Id { get; private set; }
        public int ProcessorId { get; set; }
        public Processor Processor { get; set; }
        public int ChipsetId { get; set; }
        public Chipset Chipset { get; set; }
    }
}