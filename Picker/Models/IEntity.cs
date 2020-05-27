namespace Picker.Models
{
    using System.ComponentModel;

    public interface IEntity
    {
        int Id { get; }

        [DisplayName("Ad")]
        string Name { get; }
    }
}