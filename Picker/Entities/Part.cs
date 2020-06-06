namespace Picker
{
    public abstract class Part : Entity
    {
        public virtual Brand Brand { get; set; }
        public int BrandId { get; set; }
    }
}