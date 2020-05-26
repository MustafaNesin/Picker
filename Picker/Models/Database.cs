namespace Picker.Models
{
    using System.Data.Entity;

    internal class ComputerDatabaseContext : DbContext
    {
        public virtual DbSet<Brand> Brands { get; set; }
        public virtual DbSet<Build> Builds { get; set; }
        public virtual DbSet<Chipset> Chipsets { get; set; }
        public virtual DbSet<Graphics> Graphics { get; set; }
        public virtual DbSet<Memory> Memories { get; set; }
        public virtual DbSet<Motherboard> Motherboards { get; set; }
        public virtual DbSet<Processor> Processors { get; set; }
        public virtual DbSet<Socket> Sockets { get; set; }

        public ComputerDatabaseContext() : base("name=PickerDatabase")
        {
        }
    }
}