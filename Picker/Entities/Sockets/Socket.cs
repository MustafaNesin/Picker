namespace Picker
{
    using System.ComponentModel;

    [DisplayName("soket")]
    internal class Socket : Part
    {
        [DisplayName("DDR2 Deste�i")]
        public bool SupportsDDR2 { get; set; }

        [DisplayName("DDR3 Deste�i")]
        public bool SupportsDDR3 { get; set; }

        [DisplayName("DDR4 Deste�i")]
        public bool SupportsDDR4 { get; set; }
    }
}