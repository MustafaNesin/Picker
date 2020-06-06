namespace Picker
{
    using System.Collections.Generic;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    using System.Linq;
    using System.Threading.Tasks;
    using System.Windows.Forms;

    internal sealed class ProcessorListPresenter
        : ListPresenter<ProcessorListView, Processor, ProcessorPresenter, ProcessorView,
            ProcessorItemView>
    {
        protected override Panel ListPanel => View.listPanel;

        public ProcessorListPresenter(bool adminMode) : base(adminMode)
        {
        }

        protected override Processor CreateEmptyEntity()
            => new Processor
            {
                Model = string.Empty,
                Name = string.Empty,
                Family = string.Empty
            };

        protected override async Task<List<Processor>> GetEntitiesAsync(
            ComputerDatabaseContext context, bool paging)
        {
            var query = context.Processors.AsQueryable();
            var totalItemCount = await query.CountAsync();

            //if (BuildPresenter != null && View.OnlyCompatibles)
            //    query = query.Where(entity => BuildPresenter.IsCompatibleWith(entity));

            if (!string.IsNullOrWhiteSpace(View.EntityName))
                query = query.Where(entity => entity.Name.Contains(View.EntityName));

            if (!string.IsNullOrWhiteSpace(View.ProcessorBrand))
                query = query.Where(entity => entity.Brand.Name.Contains(View.ProcessorBrand));

            if (!string.IsNullOrWhiteSpace(View.ProcessorFamily))
                query = query.Where(entity => entity.Family.Contains(View.ProcessorFamily));

            if (!string.IsNullOrWhiteSpace(View.ProcessorSocket))
                query = query.Where(entity => entity.Socket.Name.Contains(View.ProcessorSocket));

            if (View.ProcessorMinPrice.HasValue)
                query = query.Where(entity => entity.Price >= View.ProcessorMinPrice.Value);

            if (View.ProcessorMaxPrice.HasValue)
                query = query.Where(entity => entity.Price <= View.ProcessorMaxPrice.Value);

            if (View.ProcessorMinCores.HasValue)
                query = query.Where(entity => entity.Cores >= View.ProcessorMinCores.Value);

            if (View.ProcessorMaxCores.HasValue)
                query = query.Where(entity => entity.Cores <= View.ProcessorMaxCores.Value);

            if (View.ProcessorMinThreads.HasValue)
                query = query.Where(entity => entity.Threads >= View.ProcessorMinThreads.Value);

            if (View.ProcessorMaxThreads.HasValue)
                query = query.Where(entity => entity.Threads <= View.ProcessorMaxThreads.Value);

            if (View.ProcessorMinCacheSize.HasValue)
                query = query.Where(entity => entity.CacheSize >= View.ProcessorMinCacheSize.Value);

            if (View.ProcessorMaxCacheSize.HasValue)
                query = query.Where(entity => entity.CacheSize <= View.ProcessorMaxCacheSize.Value);

            if (View.ProcessorMinFrequency.HasValue)
                query = query.Where(entity => entity.Frequency >= View.ProcessorMinFrequency.Value);

            if (View.ProcessorMaxFrequency.HasValue)
                query = query.Where(entity => entity.Frequency <= View.ProcessorMaxFrequency.Value);

            if (View.ProcessorMinTurboFrequency.HasValue)
                query = query.Where(entity
                    => entity.TurboFrequency >= View.ProcessorMinTurboFrequency.Value);

            if (View.ProcessorMaxTurboFrequency.HasValue)
                query = query.Where(entity
                    => entity.TurboFrequency <= View.ProcessorMaxTurboFrequency.Value);

            if (View.ProcessorMinMaxMemory.HasValue)
                query = query.Where(entity => entity.MaxMemory >= View.ProcessorMinMaxMemory.Value);

            if (View.ProcessorMaxMaxMemory.HasValue)
                query = query.Where(entity => entity.MaxMemory <= View.ProcessorMaxMaxMemory.Value);

            if (View.ProcessorMinMaxMemorySpeed.HasValue)
                query = query.Where(entity
                    => entity.MaxMemorySpeed >= View.ProcessorMinMaxMemorySpeed.Value);

            if (View.ProcessorMaxMaxMemorySpeed.HasValue)
                query = query.Where(entity
                    => entity.MaxMemorySpeed <= View.ProcessorMaxMaxMemorySpeed.Value);

            if (View.ProcessorSupportsECC != CheckState.Indeterminate)
                query = query.Where(entity
                    => entity.SupportsECC == (View.ProcessorSupportsECC == CheckState.Checked));

            if (View.ProcessorIs64Bit != CheckState.Indeterminate)
                query = query.Where(entity
                    => entity.Is64Bit == (View.ProcessorIs64Bit == CheckState.Checked));

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
                8 => query.OrderBy(entity => entity.Family), // Serisine göre (A-Z)
                9 => query.OrderByDescending(entity => entity.Family), // Serisine göre (Z-A)
                10 => query.OrderBy(entity => entity.Cores), // Çekirdek sayısına göre (En az)
                11 => query.OrderByDescending(entity
                    => entity.Cores), // Çekirdek sayısına göre (En çok)
                12 => query.OrderBy(entity => entity.Threads), // İş parçacığı sayısına göre (En az)
                13 => query.OrderByDescending(entity
                    => entity.Threads), // İş parçacığı sayısına göre (En çok)
                14 => query.OrderBy(entity => entity.CacheSize), // Önbellek boyutuna göre (En az)
                15 => query.OrderByDescending(entity
                    => entity.CacheSize), // Önbellek boyutuna göre (En çok)
                16 => query.OrderBy(entity => entity.Frequency), // Hızına göre (En yavaş)
                17 => query.OrderByDescending(entity => entity.Frequency), // Hızına göre (En hızlı)
                18 => query.OrderBy(entity
                    => entity.TurboFrequency), // Maks. hızına göre (En yavaş)
                19 => query.OrderByDescending(entity
                    => entity.TurboFrequency), // Maks. hızına göre (En hızlı)
                20 => query.OrderBy(entity
                    => entity.MaxMemory), // Maks. bellek boyutuna göre (En az)
                21 => query.OrderByDescending(entity
                    => entity.MaxMemory), // Maks. bellek boyutuna göre (En çok)
                22 => query.OrderBy(entity
                    => entity.MaxMemorySpeed), // Maks. bellek hızına göre (En yavaş)
                23 => query.OrderByDescending(entity
                    => entity.MaxMemorySpeed), // Maks. bellek hızına göre (En hızlı)
                _ => query.OrderBy(entity => entity.Id) // Eskiden yeniye
            };

            return await RunQueryAsync(query, totalItemCount, paging);
        }

        public override async Task LoadRelationsAsync(ComputerDatabaseContext context,
            DbEntityEntry<Processor> entry)
        {
            await entry.Reference(entity => entity.Brand).LoadAsync();
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