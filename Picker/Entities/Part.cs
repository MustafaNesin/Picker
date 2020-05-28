namespace Picker
{
    using System.ComponentModel;

    [DisplayName("parça")]
    internal abstract class Part : Entity
    {
        [DisplayName("Marka")]
        public Brand Brand { get; set; }
    }
}