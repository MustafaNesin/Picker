namespace Picker
{
    using System.Collections.Generic;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    using System.Linq;
    using System.Threading.Tasks;
    using System.Windows.Forms;

    internal sealed class GraphicsCardListPresenter
        : ListPresenter<GraphicsCardListView, GraphicsCard, GraphicsCardPresenter, GraphicsCardView,
            GraphicsCardItemView>
    {
        protected override Panel ListPanel => View.listPanel;

        public GraphicsCardListPresenter(bool adminMode) : base(adminMode)
        {
        }

        public GraphicsCardListPresenter(Build build) : base(build)
        {
        }

        protected override GraphicsCard CreateEmptyEntity()
            => new GraphicsCard
            {
                Model = string.Empty,
                Name = string.Empty,
                ChipsetModel = string.Empty,
                MemoryType = string.Empty
            };

        protected override async Task<List<GraphicsCard>> GetEntitiesAsync(
            ComputerDatabaseContext context, bool paging)
        {
            var query = context.GraphicsCards.AsQueryable();
            var totalItemCount = await query.CountAsync();

            if (Build != null)
            {
                query = query.Where(entity => entity.Id != Build.GraphicsCardId);

                if (View.OnlyCompatibles)
                    query = query.Where(entity => Build.IsCompatibleWith(entity));
            }

            if (!string.IsNullOrWhiteSpace(View.EntityName))
                query = query.Where(entity => entity.Name.Contains(View.EntityName));

            if (!string.IsNullOrWhiteSpace(View.GraphicsCardChipsetModel))
                query = query.Where(entity
                    => entity.ChipsetModel.Contains(View.GraphicsCardChipsetModel));

            if (!string.IsNullOrWhiteSpace(View.GraphicsCardBrand))
                query = query.Where(entity => entity.Brand.Name.Contains(View.GraphicsCardBrand));

            if (!string.IsNullOrWhiteSpace(View.GraphicsCardChipsetBrand))
                query = query.Where(entity
                    => entity.ChipsetBrand.Name.Contains(View.GraphicsCardChipsetBrand));

            if (!string.IsNullOrWhiteSpace(View.GraphicsCardMemoryType))
                query = query.Where(entity
                    => entity.MemoryType.Contains(View.GraphicsCardMemoryType));

            if (View.GraphicsCardMinPrice.HasValue)
                query = query.Where(entity => entity.Price >= View.GraphicsCardMinPrice.Value);

            if (View.GraphicsCardMaxPrice.HasValue)
                query = query.Where(entity => entity.Price <= View.GraphicsCardMaxPrice.Value);

            if (View.GraphicsCardMinFrequency.HasValue)
                query = query.Where(entity
                    => entity.Frequency >= View.GraphicsCardMinFrequency.Value);

            if (View.GraphicsCardMaxFrequency.HasValue)
                query = query.Where(entity
                    => entity.Frequency <= View.GraphicsCardMaxFrequency.Value);

            if (View.GraphicsCardMinTurboFrequency.HasValue)
                query = query.Where(entity
                    => entity.TurboFrequency >= View.GraphicsCardMinTurboFrequency.Value);

            if (View.GraphicsCardMaxTurboFrequency.HasValue)
                query = query.Where(entity
                    => entity.TurboFrequency <= View.GraphicsCardMaxTurboFrequency.Value);

            if (View.GraphicsCardMinMemoryFrequency.HasValue)
                query = query.Where(entity
                    => entity.MemoryFrequency >= View.GraphicsCardMinMemoryFrequency.Value);

            if (View.GraphicsCardMaxMemoryFrequency.HasValue)
                query = query.Where(entity
                    => entity.MemoryFrequency <= View.GraphicsCardMaxMemoryFrequency.Value);

            if (View.GraphicsCardMinBusWidth.HasValue)
                query = query.Where(entity
                    => entity.BusWidth >= View.GraphicsCardMinBusWidth.Value);

            if (View.GraphicsCardMaxBusWidth.HasValue)
                query = query.Where(entity
                    => entity.BusWidth <= View.GraphicsCardMaxBusWidth.Value);

            if (View.GraphicsCardMinMemory.HasValue)
                query = query.Where(entity => entity.Memory >= View.GraphicsCardMinMemory.Value);

            if (View.GraphicsCardMaxMemory.HasValue)
                query = query.Where(entity => entity.Memory <= View.GraphicsCardMaxMemory.Value);

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
                8 => query.OrderBy(entity => entity.ChipsetModel), // Yonga setine göre (A-Z)
                9 => query.OrderByDescending(entity
                    => entity.ChipsetModel), // Yonga setine göre (Z-A)
                10 => query.OrderBy(entity
                    => entity.ChipsetBrand.Name), // Yonga seti markasına göre (A-Z)
                11 => query.OrderByDescending(entity
                    => entity.ChipsetBrand.Name), // Yonga seti markasına göre (Z-A)
                12 => query.OrderBy(entity => entity.MemoryType), // Bellek tipine göre (A-Z)
                13 => query.OrderByDescending(entity
                    => entity.MemoryType), // Bellek tipine göre (Z-A)
                14 => query.OrderBy(entity => entity.Memory), // Bellek kapasitesine göre (En az)
                15 => query.OrderByDescending(entity
                    => entity.Memory), // Bellek kapasitesine göre (En çok)
                16 => query.OrderBy(entity
                    => entity.MemoryFrequency), // Bellek hızına göre (En yavaş)
                17 => query.OrderByDescending(entity
                    => entity.MemoryFrequency), // Bellek hızına göre (En hızlı)
                18 => query.OrderBy(entity => entity.Frequency), // Çekirdek hızına göre (En yavaş)
                19 => query.OrderByDescending(entity
                    => entity.Frequency), // Çekirdek hızına göre (En hızlı)
                20 => query.OrderBy(entity
                    => entity.TurboFrequency), // Maks. çekirdek hızına göre (En yavaş)
                21 => query.OrderByDescending(entity
                    => entity.TurboFrequency), // Maks. çekirdek hızına göre (En hızlı)
                22 => query.OrderBy(entity
                    => entity.BusWidth), // Veri yolu genişliğine göre (En az)
                23 => query.OrderByDescending(entity
                    => entity.BusWidth), // Veri yolu genişliğine göre (En çok)
                _ => query.OrderBy(entity => entity.Id) // Eskiden yeniye
            };

            return await RunQueryAsync(query, totalItemCount, paging);
        }

        protected override async Task LoadRelationsAsync(ComputerDatabaseContext context, DbEntityEntry<GraphicsCard> entry)
        {
            await entry.Reference(entity => entity.Brand).LoadAsync();
            await entry.Reference(entity => entity.ChipsetBrand).LoadAsync();
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