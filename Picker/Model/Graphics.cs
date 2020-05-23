namespace Picker.Model
{
    using System.ComponentModel.DataAnnotations;

    public class Graphics : Product
    {
        [Required] public string Chipset { get; set; }
        public int Frequency { get; set; } // MHz
        public int Memory { get; set; } // GB
        [Required] public string MemoryType { get; set; }
        public int TurboFrequency { get; set; } // MHz
    }
}