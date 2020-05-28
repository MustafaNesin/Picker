namespace Picker
{
    using System.ComponentModel;

    [DisplayName("soket")]
    internal class Socket : Part
    {
        [DisplayName("DDR2 Desteði")]
        public bool SupportsDDR2 { get; set; }

        [DisplayName("DDR3 Desteði")]
        public bool SupportsDDR3 { get; set; }

        [DisplayName("DDR4 Desteði")]
        public bool SupportsDDR4 { get; set; }
    }
}