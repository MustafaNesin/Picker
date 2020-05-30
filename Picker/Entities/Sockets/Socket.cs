namespace Picker
{
    using System.ComponentModel;

    [DisplayName("soket")]
    internal class Socket : Part
    {
        public bool SupportsDDR2 { get; set; }
        public bool SupportsDDR3 { get; set; }
        public bool SupportsDDR4 { get; set; }
    }
}