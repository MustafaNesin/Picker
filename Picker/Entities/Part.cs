namespace Picker
{
    using System.ComponentModel.DataAnnotations;

    public abstract class Part : Entity
    {
        public virtual Brand Brand { get; set; }

        public int BrandId { get; set; }
    }
}