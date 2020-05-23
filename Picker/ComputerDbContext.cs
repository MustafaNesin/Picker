namespace Picker
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity;

    public class ComputerDbContext : DbContext
    {
        public ComputerDbContext() : base("name=PickerDatabase")
        {
        }

        public virtual DbSet<Build> Builds { get; set; }
    }

    public class Build
    {
        public DateTime Date { get; set; }
        public Graphics Graphics { get; set; }
        public int Id { get; set; }
        public virtual ICollection<Memory> Memories { get; set; }
        public Motherboard Motherboard { get; set; }
        [Required] public string Name { get; set; }
        public Processor Processor { get; set; }
    }

    public class Brand
    {
        [Required] public string Country { get; set; }
        public int Id { get; set; }
        [Required] public string Name { get; set; }
    }

    public class Part
    {
        public Brand Brand { get; set; }
        public int Id { get; set; }
        [Required] public string Name { get; set; }
    }

    public class Product : Part
    {
        [Required] public string Currency { get; set; }
        [Column(TypeName = "money")] public decimal Price { get; set; }
    }

    public class Chipset : Part
    {
        public virtual ICollection<Processor> Processors { get; set; }
    }

    public class Socket : Part
    {
        public bool SupportsDDR2 { get; set; }
        public bool SupportsDDR3 { get; set; }
        public bool SupportsDDR4 { get; set; }
    }

    public class Motherboard : Product
    {
        public Chipset Chipset { get; set; }
        public int MaxMemory { get; set; } // GB
        public int MaxMemorySpeed { get; set; } // MHz
        public int MemorySlots { get; set; }
        [Required] public string MemoryType { get; set; }
        public Socket Socket { get; set; }
        public bool SupportsECC { get; set; }
    }

    public class Processor : Product
    {
        public int CacheSize { get; set; }
        public virtual ICollection<Chipset> Chipsets { get; set; }
        public int Cores { get; set; }
        [Required] public string Family { get; set; }
        public int Frequency { get; set; } // MHz
        public bool Is64Bit { get; set; }
        public int MaxMemory { get; set; } // GB
        public int MaxMemorySpeed { get; set; } // MHz
        [Required] public string Model { get; set; }
        public Socket Socket { get; set; }
        public bool SupportsECC { get; set; }
        public int Threads { get; set; }
        public int TurboFrequency { get; set; } // MHz
    }

    public class Memory : Product
    {
        public virtual ICollection<Build> Builds { get; set; }
        public int Capacity { get; set; } // GB
        public int Count { get; set; }
        public int Frequency { get; set; } // MHz
        public bool HasECC { get; set; }
        public bool IsBuffered { get; set; }
        [Required] public string Type { get; set; }
    }

    public class Graphics : Product
    {
        [Required] public string Chipset { get; set; }
        public int Frequency { get; set; } // MHz
        public int Memory { get; set; } // GB
        [Required] public string MemoryType { get; set; }
        public int TurboFrequency { get; set; } // MHz
    }
}