namespace Picker
{
    using System.Collections.Generic;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    using System.Linq;
    using System.Threading.Tasks;
    using System.Windows.Forms;

    internal sealed class MotherboardListPresenter
        : ListPresenter<MotherboardListView, Motherboard, MotherboardPresenter, MotherboardView,
            MotherboardItemView>
    {
        protected override Panel ListPanel => View.listPanel;

        public MotherboardListPresenter(bool adminMode) : base(adminMode)
        {
        }

        public MotherboardListPresenter(BuildPresenter buildPresenter) : base(buildPresenter)
        {
        }

        protected override Motherboard CreateEmptyEntity()
            => new Motherboard
            {
                Model = string.Empty,
                Name = string.Empty,
                FormFactor = string.Empty,
                MemoryType = string.Empty
            };

        protected override async Task<List<Motherboard>> GetEntitiesAsync(
            ComputerDatabaseContext context, bool paging)
        {
            var query = context.Motherboards.AsQueryable();
            var totalItemCount = await query.CountAsync();

            //if (BuildPresenter != null && View.OnlyCompatibles)
            //    query = query.Where(entity => BuildPresenter.IsCompatibleWith(entity));

            if (!string.IsNullOrWhiteSpace(View.EntityName))
                query = query.Where(entity => entity.Name.Contains(View.EntityName));

            if (!string.IsNullOrWhiteSpace(View.MotherboardBrand))
                query = query.Where(entity => entity.Brand.Name.Contains(View.MotherboardBrand));

            if (!string.IsNullOrWhiteSpace(View.MotherboardChipset))
                query = query.Where(entity
                    => entity.Chipset.Name.Contains(View.MotherboardChipset));

            if (!string.IsNullOrWhiteSpace(View.MotherboardSocket))
                query = query.Where(entity => entity.Socket.Name.Contains(View.MotherboardSocket));

            if (!string.IsNullOrWhiteSpace(View.MotherboardMemoryType))
                query = query.Where(
                    entity => entity.MemoryType.Contains(View.MotherboardMemoryType));

            if (!string.IsNullOrWhiteSpace(View.MotherboardFormFactor))
                query = query.Where(
                    entity => entity.MemoryType.Contains(View.MotherboardFormFactor));

            if (View.MotherboardMinMemorySlots.HasValue)
                query = query.Where(entity
                    => entity.MemorySlots >= View.MotherboardMinMemorySlots.Value);

            if (View.MotherboardMaxMemorySlots.HasValue)
                query = query.Where(entity
                    => entity.MemorySlots <= View.MotherboardMaxMemorySlots.Value);

            if (View.MotherboardMinMaxMemory.HasValue)
                query = query.Where(
                    entity => entity.MaxMemory >= View.MotherboardMinMaxMemory.Value);

            if (View.MotherboardMaxMaxMemory.HasValue)
                query = query.Where(
                    entity => entity.MaxMemory <= View.MotherboardMaxMaxMemory.Value);

            if (View.MotherboardMinMaxMemoryFrequency.HasValue)
                query = query.Where(entity
                    => entity.MaxMemoryFrequency >= View.MotherboardMinMaxMemoryFrequency.Value);

            if (View.MotherboardMaxMaxMemoryFrequency.HasValue)
                query = query.Where(entity
                    => entity.MaxMemoryFrequency <= View.MotherboardMaxMaxMemoryFrequency.Value);

            if (View.MotherboardMinPrice.HasValue)
                query = query.Where(entity => entity.Price >= View.MotherboardMinPrice.Value);

            if (View.MotherboardMaxPrice.HasValue)
                query = query.Where(entity => entity.Price <= View.MotherboardMaxPrice.Value);

            if (View.MotherboardSupportsECC != CheckState.Indeterminate)
                query = query.Where(entity
                    => entity.SupportsECC == (View.MotherboardSupportsECC == CheckState.Checked));

            query = View.OrderIndex switch
            {
                1 => query.OrderByDescending(entity => entity.Id), // Yeniden eskiye
                2 => query.OrderBy(entity => entity.Name), // İsme göre (A-Z)
                3 => query.OrderByDescending(entity => entity.Name), // İsme göre (Z-A)
                4 => query.OrderBy(entity => entity.Brand.Name), // Marka ismine göre (A-Z)
                5 => query.OrderByDescending(entity
                    => entity.Brand.Name), // Marka ismine göre (Z-A)
                6 => query.OrderBy(entity => entity.Price), // Fiyata göre (En ucuz)
                7 => query.OrderByDescending(entity => entity.Price), // Fiyata göre (En pahalı)
                8 => query.OrderBy(entity => entity.MemoryType), // Bellek tipine göre (A-Z)
                9 => query.OrderByDescending(entity
                    => entity.MemoryType), // Bellek tipine göre (Z-A)
                10 => query.OrderBy(entity
                    => entity.MemorySlots), // Bellek slot sayısına göre (En az)
                11 => query.OrderByDescending(entity
                    => entity.MemorySlots), // Bellek slot sayısına göre (En çok)
                12 => query.OrderBy(entity
                    => entity.MaxMemory), // Maks. bellek kapasitesine göre (En az)
                13 => query.OrderByDescending(entity
                    => entity.MaxMemory), //  Maks. bellek kapasitesine göre (En çok)
                14 => query.OrderBy(entity
                    => entity.MaxMemoryFrequency), // Maks. bellek hızına göre (En az)
                15 => query.OrderByDescending(entity
                    => entity.MaxMemoryFrequency), // Maks. bellek hızına göre (En çok)
                16 => query.OrderBy(entity => entity.FormFactor), // Form faktörüne göre (A-Z)
                17 => query.OrderByDescending(entity
                    => entity.FormFactor), // Form faktörüne göre (Z-A)
                _ => query.OrderBy(entity => entity.Id) // Eskiden yeniye
            };

            return await RunQueryAsync(query, totalItemCount, paging);
        }

        public override async Task LoadRelationsAsync(ComputerDatabaseContext context,
            DbEntityEntry<Motherboard> entry)
        {
            await entry.Reference(entity => entity.Brand).LoadAsync();
            await entry.Reference(entity => entity.Chipset).LoadAsync();
            await context.Entry(entry.Entity.Chipset).Reference(entity => entity.Brand).LoadAsync();
            await entry.Reference(entity => entity.Socket).LoadAsync();
            await context.Entry(entry.Entity.Socket).Reference(entity => entity.Brand).LoadAsync();
        }

        #region Disposing
        private bool _disposed;

        protected override async ValueTask DisposeAsync(bool disposing)
        {
            if (_disposed)
                return;

            // if (disposing) ;

            _disposed = true;
            await base.DisposeAsync(disposing);
        }
        #endregion
    }
}