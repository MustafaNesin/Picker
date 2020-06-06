namespace Picker
{
    using System.Threading.Tasks;

    internal sealed class MemoryPresenter : EntityPresenter<MemoryView, Memory>
    {
        public MemoryPresenter(Memory entity, bool adminMode) : base(entity, adminMode)
        {
            View.Text = string.IsNullOrEmpty(Entity.Name) ? "Yeni Bellek" : Entity.Name;
            View.MemoryBrand = entity.Brand;
            View.MemoryType = entity.Type;
            View.MemoryModel = entity.Model;
            View.MemoryPrice = entity.Price;
            View.MemoryCapacity = entity.Capacity;
            View.MemoryCount = entity.Count;
            View.MemoryFrequency = entity.Frequency;
            View.MemoryHasECC = entity.HasECC;
            View.MemoryIsBuffered = entity.IsBuffered;
        }

        protected override void UpdateEntity()
        {
            Entity.Brand = null;
            Entity.BrandId = View.MemoryBrand.Id;
            Entity.Type = View.MemoryType;
            Entity.Model = View.MemoryModel;
            Entity.Price = View.MemoryPrice;
            Entity.Capacity = View.MemoryCapacity;
            Entity.Count = View.MemoryCount;
            Entity.Frequency = View.MemoryFrequency;
            Entity.HasECC = View.MemoryHasECC;
            Entity.IsBuffered = View.MemoryIsBuffered;
            base.UpdateEntity();
        }

        public bool Validate()
        {
            if (View.MemoryBrand == null)
                Utilities.ShowError("Lütfen bir marka seçin.");
            else if (View.MemoryPrice == decimal.Zero)
                Utilities.ShowError("Lütfen ürünün fiyatını girin.");
            else if (string.IsNullOrWhiteSpace(View.MemoryType))
                Utilities.ShowError("Lütfen bir bellek tipi girin.");
            else if (View.MemoryCapacity == 0)
                Utilities.ShowError("Lütfen bellek modül kapasitesini girin.");
            else if (View.MemoryCount == 0)
                Utilities.ShowError("Lütfen bellek modül sayısını girin.");
            else if (View.MemoryFrequency == 0)
                Utilities.ShowError("Lütfen bellek hızını girin.");
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