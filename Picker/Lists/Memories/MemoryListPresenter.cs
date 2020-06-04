namespace Picker
{
    using System.Collections.Generic;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    using System.Linq;
    using System.Threading.Tasks;
    using System.Windows.Forms;

    internal sealed class MemoryListPresenter
        : ListPresenter<MemoryListView, Memory, MemoryPresenter, MemoryView, MemoryItemView>
    {
        protected override Panel ListPanel => View.listPanel;

        public MemoryListPresenter(bool adminMode) : base(adminMode)
        {
        }

        public MemoryListPresenter(Build build) : base(build)
        {
        }

        protected override Memory CreateEmptyEntity()
            => new Memory
            {
                Model = string.Empty,
                Name = string.Empty,
                Type = string.Empty
            };

        protected override async Task<List<Memory>> GetEntitiesAsync(
            ComputerDatabaseContext context, bool paging)
        {
            var query = context.Memories.AsQueryable();
            var totalItemCount = await query.CountAsync();

            if (Build != null)
            {
                foreach (var memory in Build.Memories)
                    query = query.Where(entity => entity.Id != memory.Id);

                if (View.OnlyCompatibles)
                    query = query.Where(entity => Build.IsCompatibleWith(entity));
            }

            if (!string.IsNullOrWhiteSpace(View.EntityName))
                query = query.Where(entity => entity.Name.Contains(View.EntityName));

            if (!string.IsNullOrWhiteSpace(View.MemoryBrand))
                query = query.Where(entity => entity.Brand.Name.Contains(View.MemoryBrand));

            if (!string.IsNullOrWhiteSpace(View.MemoryType))
                query = query.Where(entity => entity.Type.Contains(View.MemoryType));

            if (View.MemoryCount.HasValue)
                query = query.Where(entity => entity.Count == View.MemoryCount.Value);

            if (View.MemoryMinCapacity.HasValue)
                query = query.Where(entity
                    => entity.Capacity * entity.Count >= View.MemoryMinCapacity.Value);

            if (View.MemoryMaxCapacity.HasValue)
                query = query.Where(entity
                    => entity.Capacity * entity.Count <= View.MemoryMaxCapacity.Value);

            if (View.MemoryMinFrequency.HasValue)
                query = query.Where(entity => entity.Frequency >= View.MemoryMinFrequency.Value);

            if (View.MemoryMaxFrequency.HasValue)
                query = query.Where(entity => entity.Frequency <= View.MemoryMaxFrequency.Value);

            if (View.MemoryMinPrice.HasValue)
                query = query.Where(entity => entity.Price >= View.MemoryMinPrice.Value);

            if (View.MemoryMaxPrice.HasValue)
                query = query.Where(entity => entity.Price <= View.MemoryMaxPrice.Value);

            if (View.MemoryHasECC != CheckState.Indeterminate)
                query = query.Where(entity
                    => entity.HasECC == (View.MemoryHasECC == CheckState.Checked));

            if (View.MemoryIsBuffered != CheckState.Indeterminate)
                query = query.Where(entity
                    => entity.IsBuffered == (View.MemoryIsBuffered == CheckState.Checked));

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
                8 => query.OrderBy(entity => entity.Type), // Tipe göre (A-Z)
                9 => query.OrderByDescending(entity => entity.Type), // Tipe göre (Z-A)
                10 => query.OrderBy(entity
                    => entity.Frequency), // Hıza/Bant Genişliğine göre (En yavaş)
                11 => query.OrderByDescending(entity
                    => entity.Frequency), // Hıza/Bant Genişliğine göre (En hızlı)
                12 => query.OrderBy(entity
                    => entity.Capacity * entity.Count), // Kapasiteye göre (En az)
                13 => query.OrderByDescending(entity
                    => entity.Capacity * entity.Count), // Kapasiteye göre (En çok)
                14 => query.OrderBy(entity => entity.Count), // Modül sayısına göre (En az)
                15 => query.OrderByDescending(entity
                    => entity.Count), // Modül sayısına göre (En çok)
                _ => query.OrderBy(entity => entity.Id) // Eskiden yeniye
            };

            return await RunQueryAsync(query, totalItemCount, paging);
        }

        protected override async Task LoadRelationsAsync(DbEntityEntry<Memory> entry)
            => await entry.Reference(entity => entity.Brand).LoadAsync();

        protected override void StateRelationsUnchanged(ComputerDatabaseContext context,
            Memory entity)
            => context.Entry(entity.Brand).State = EntityState.Unchanged;

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