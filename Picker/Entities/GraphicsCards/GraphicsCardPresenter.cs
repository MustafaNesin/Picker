namespace Picker
{
    using System.Threading.Tasks;

    internal sealed class GraphicsCardPresenter : EntityPresenter<GraphicsCardView, GraphicsCard>
    {
        public GraphicsCardPresenter(GraphicsCard entity, bool adminMode) : base(entity, adminMode)
        {
            View.Text = string.IsNullOrEmpty(Entity.Name) ? "Yeni Ekran Kartı" : Entity.Name;
            View.GraphicsCardBrand = entity.Brand;
            View.GraphicsCardBusWidth = entity.BusWidth;
            View.GraphicsCardChipsetBrand = entity.ChipsetBrand;
            View.GraphicsCardChipsetModel = entity.ChipsetModel;
            View.GraphicsCardFrequency = entity.Frequency;
            View.GraphicsCardMemory = entity.Memory;
            View.GraphicsCardMemoryFrequency = entity.MemoryFrequency;
            View.GraphicsCardMemoryType = entity.MemoryType;
            View.GraphicsCardModel = entity.Model;
            View.GraphicsCardPrice = entity.Price;
            View.GraphicsCardTurboFrequency = entity.TurboFrequency;
        }

        protected override void UpdateEntity()
        {
            Entity.Brand = View.GraphicsCardBrand;
            Entity.BrandId = View.GraphicsCardBrand.Id;
            Entity.ChipsetBrand = null;
            Entity.ChipsetBrandId = View.GraphicsCardChipsetBrand.Id;
            Entity.BusWidth = View.GraphicsCardBusWidth;
            Entity.ChipsetModel = View.GraphicsCardChipsetModel;
            Entity.Frequency = View.GraphicsCardFrequency;
            Entity.Memory = View.GraphicsCardMemory;
            Entity.MemoryFrequency = View.GraphicsCardMemoryFrequency;
            Entity.MemoryType = View.GraphicsCardMemoryType;
            Entity.Model = View.GraphicsCardModel;
            Entity.Price = View.GraphicsCardPrice;
            Entity.TurboFrequency = View.GraphicsCardTurboFrequency;
            base.UpdateEntity();
        }

        public bool Validate()
        {
            if (View.GraphicsCardBrand == null)
                Utilities.ShowError("Lütfen bir marka seçin.");
            else if (View.GraphicsCardPrice == decimal.Zero)
                Utilities.ShowError("Lütfen ürünün fiyatını girin.");
            else if (View.GraphicsCardChipsetBrand == null)
                Utilities.ShowError("Lütfen bir yonga seti markası seçin.");
            else if (string.IsNullOrWhiteSpace(View.GraphicsCardChipsetModel))
                Utilities.ShowError("Lütfen bir yonga seti modeli girin.");
            else if (View.GraphicsCardBusWidth == 0)
                Utilities.ShowError("Lütfen veri yolu genişliğini girin.");
            else if (View.GraphicsCardFrequency == 0)
                Utilities.ShowError("Lütfen çekirdek hızını girin.");
            else if (View.GraphicsCardMemory == 0)
                Utilities.ShowError("Lütfen bellek kapasitesini girin.");
            else if (View.GraphicsCardMemoryFrequency == 0)
                Utilities.ShowError("Lütfen bellek hızını girin.");
            else if (string.IsNullOrWhiteSpace(View.GraphicsCardMemoryType))
                Utilities.ShowError("Lütfen bir bellek tipi girin.");
            else if (View.GraphicsCardTurboFrequency == 0)
                Utilities.ShowError("Lütfen maksimum çekirdek hızını girin.");
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