namespace Picker
{
    using System.ComponentModel;

    [DisplayName("par�a")]
    internal abstract class Part : Entity
    {
        [DisplayName("Marka")]
        public Brand Brand { get; set; }
    }
}