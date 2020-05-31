namespace Picker
{
    using System.ComponentModel;
    using System.Data.Entity;

    internal class ComputerDatabaseContext : DbContext
    {
        [DisplayName("Markalar")]
        public virtual DbSet<Brand> Brands { get; set; }

        [DisplayName("Bilgisayarlar")]
        public virtual DbSet<Build> Builds { get; set; }

        [DisplayName("Yonga Setleri")]
        public virtual DbSet<Chipset> Chipsets { get; set; }

        [DisplayName("Ekran Kartlarý")]
        public virtual DbSet<GraphicsCard> GraphicsCards { get; set; }

        [DisplayName("Bellekler")]
        public virtual DbSet<Memory> Memories { get; set; }

        [DisplayName("Anakartlar")]
        public virtual DbSet<Motherboard> Motherboards { get; set; }

        [DisplayName("Ýþlemciler")]
        public virtual DbSet<Processor> Processors { get; set; }

        [DisplayName("Soketler")]
        public virtual DbSet<Socket> Sockets { get; set; }

        public ComputerDatabaseContext() : base("name=PickerDatabase")
        {
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
            => modelBuilder.Entity<Socket>().HasOptional(socket => socket.Brand)
                .WithOptionalDependent().WillCascadeOnDelete(true);
    }
}