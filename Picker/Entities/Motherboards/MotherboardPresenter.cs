namespace Picker
{
    using System.Threading.Tasks;

    internal sealed class MotherboardPresenter : EntityPresenter<MotherboardView, Motherboard>
    {
        public MotherboardPresenter(Motherboard entity, bool adminMode) : base(entity, adminMode)
        {
            View.Text = string.IsNullOrEmpty(Entity.Name) ? "Yeni Anakart" : Entity.Name;
            View.MotherboardBrand = entity.Brand;
            View.MotherboardChipset = entity.Chipset;
            View.MotherboardSocket = entity.Socket;
            View.MotherboardModel = entity.Model;
            View.MotherboardPrice = entity.Price;
            View.MotherboardFormFactor = entity.FormFactor;
            View.MotherboardMemoryType = entity.MemoryType;
            View.MotherboardMemorySlots = entity.MemorySlots;
            View.MotherboardSupportsECC = entity.SupportsECC;
            View.MotherboardMaxMemory = entity.MaxMemory;
            View.MotherboardMaxMemoryFrequency = entity.MaxMemoryFrequency;
        }

        protected override void UpdateEntity()
        {
            Entity.Chipset = null;
            Entity.Socket = null;
            Entity.Brand = null;
            Entity.BrandId = View.MotherboardBrand.Id;
            Entity.ChipsetId = View.MotherboardChipset.Id;
            Entity.SocketId = View.MotherboardSocket.Id;
            Entity.Model = View.MotherboardModel;
            Entity.Price = View.MotherboardPrice;
            Entity.FormFactor = View.MotherboardFormFactor;
            Entity.MemoryType = View.MotherboardMemoryType;
            Entity.MemorySlots = View.MotherboardMemorySlots;
            Entity.SupportsECC = View.MotherboardSupportsECC;
            Entity.MaxMemory = View.MotherboardMaxMemory;
            Entity.MaxMemoryFrequency = View.MotherboardMaxMemoryFrequency;
            base.UpdateEntity();
        }

        public bool Validate()
        {
            if (View.MotherboardBrand == null)
                Utilities.ShowError("Lütfen bir marka seçin.");
            else if (View.MotherboardPrice == decimal.Zero)
                Utilities.ShowError("Lütfen ürünün fiyatını girin.");
            else if (View.MotherboardChipset == null)
                Utilities.ShowError("Lütfen bir yonga seti seçin.");
            else if (View.MotherboardSocket == null)
                Utilities.ShowError("Lütfen bir soket seçin.");
            else if (string.IsNullOrWhiteSpace(View.MotherboardFormFactor))
                Utilities.ShowError("Lütfen form faktörünü girin.");
            else if (string.IsNullOrWhiteSpace(View.MotherboardMemoryType))
                Utilities.ShowError("Lütfen bellek tipini girin.");
            else if (View.MotherboardMemorySlots == 0)
                Utilities.ShowError("Lütfen bellek slotunu girin.");
            else if (View.MotherboardMaxMemory == 0)
                Utilities.ShowError("Lütfen maksimum bellek boyutunu girin.");
            else if (View.MotherboardMaxMemoryFrequency == 0)
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