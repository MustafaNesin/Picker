namespace Picker.Model
{
    using System.Data.Entity;

    public class ComputerDbContext : DbContext
    {
        public ComputerDbContext() : base("name=PickerDatabase")
        {
        }

        public virtual DbSet<Build> Builds { get; set; }
    }
}