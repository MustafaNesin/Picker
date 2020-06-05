namespace Picker
{
    using System.Collections.Generic;
    using System.Data.Entity;
    using System.Linq;
    using System.Runtime.InteropServices;
    using System.Threading.Tasks;

    internal sealed class ProcessorPresenter : EntityPresenter<ProcessorView, Processor>
    {
        public List<Chipset> Chipsets;

        public ProcessorPresenter(Processor entity, bool adminMode) : base(entity, adminMode)
        {
            View.Text = string.IsNullOrEmpty(Entity.Name) ? "Yeni İşlemci" : Entity.Name;
            View.ProcessorBrand = entity.Brand;
            View.ProcessorSocket = entity.Socket;
            View.ProcessorFamily = entity.Family;
            View.ProcessorModel = entity.Model;
            View.ProcessorPrice = entity.Price;
            View.ProcessorCores = entity.Cores;
            View.ProcessorThreads = entity.Threads;
            View.ProcessorCacheSize = entity.CacheSize;
            View.ProcessorFrequency = entity.Frequency;
            View.ProcessorTurboFrequency = entity.TurboFrequency;
            View.ProcessorMaxMemory = entity.MaxMemory;
            View.ProcessorMaxMemorySpeed = entity.MaxMemorySpeed;
            View.ProcessorIs64Bit = entity.Is64Bit;
            View.ProcessorSupportsECC = entity.SupportsECC;

            if (entity.Id == 0)
                View.ProcessorChipsets = new List<Chipset>();
            else
            {
                using var context = new ComputerDatabaseContext();
                View.ProcessorChipsets = context.ProcessorChipsets.Where(p => p.ProcessorId == entity.Id).Select(p => p.Chipset).ToList();
            }
        }

        protected override void UpdateEntity()
        {
            Chipsets = View.ProcessorChipsets;
            Entity.Socket = View.ProcessorSocket;
            Entity.Socket.Brand = null;
            Entity.Brand = View.ProcessorBrand;
            Entity.BrandId = View.ProcessorBrand.Id;
            Entity.SocketId = View.ProcessorSocket.Id;
            Entity.Family = View.ProcessorFamily;
            Entity.Model = View.ProcessorModel;
            Entity.Price = View.ProcessorPrice;
            Entity.Cores = View.ProcessorCores;
            Entity.Threads = View.ProcessorThreads;
            Entity.CacheSize = View.ProcessorCacheSize;
            Entity.Frequency = View.ProcessorFrequency;
            Entity.TurboFrequency = View.ProcessorTurboFrequency;
            Entity.MaxMemory = View.ProcessorMaxMemory;
            Entity.MaxMemorySpeed = View.ProcessorMaxMemorySpeed;
            Entity.Is64Bit = View.ProcessorIs64Bit;
            Entity.SupportsECC = View.ProcessorSupportsECC;

            base.UpdateEntity();
        }

        public bool Validate()
        {
            if (View.ProcessorBrand == null)
                Utilities.ShowError("Lütfen bir marka seçin.");
            else if (View.ProcessorSocket == null)
                Utilities.ShowError("Lütfen bir soket seçin.");
            else if (string.IsNullOrWhiteSpace(View.ProcessorFamily))
                Utilities.ShowError("Lütfen işlemci serisini girin.");
            else if (View.ProcessorPrice == decimal.Zero)
                Utilities.ShowError("Lütfen ürünün fiyatını girin.");
            else if (View.ProcessorCores == 0)
                Utilities.ShowError("Lütfen çekirdek sayısını girin.");
            else if (View.ProcessorThreads == 0)
                Utilities.ShowError("Lütfen iş parçacığı sayısını girin.");
            else if (View.ProcessorCacheSize == 0)
                Utilities.ShowError("Lütfen önbellek değerini girin.");
            else if (View.ProcessorFrequency == 0)
                Utilities.ShowError("Lütfen işlemci hızını girin.");
            else if (View.ProcessorTurboFrequency == 0)
                Utilities.ShowError("Lütfen işlemci maksimum hızını girin.");
            else if (View.ProcessorMaxMemory == 0)
                Utilities.ShowError("Lütfen maksimum bellek miktarını girin.");
            else if (View.ProcessorMaxMemorySpeed == 0)
                Utilities.ShowError("Lütfen maksimum bellek hızını girin.");
            else
                return ValidateName();

            return false;
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