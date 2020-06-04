namespace Picker
{
    using System.Threading.Tasks;

    internal sealed class BuildPresenter : EntityPresenter<BuildView, Build>
    {
        public BuildPresenter(Build entity, bool adminMode) : base(entity, adminMode)
            => View.Text = string.IsNullOrEmpty(Entity.Name) ? "Yeni Bilgisayar" : Entity.Name;

        /*  View.BuildBrand = entity.Brand;
            View.BuildType = entity.Type;
            View.BuildModel = entity.Model;
            View.BuildPrice = entity.Price;
            View.BuildCapacity = entity.Capacity;
            View.BuildCount = entity.Count;
            View.BuildFrequency = entity.Frequency;
            View.BuildHasECC = entity.HasECC;
            View.BuildIsBuffered = entity.IsBuffered;*/
        protected override void UpdateEntity()
            =>
                /*    Entity.Brand = View.BuildBrand;
                Entity.BrandId = View.BuildBrand.Id;
                Entity.Type = View.BuildType;
                Entity.Model = View.BuildModel;
                Entity.Price = View.BuildPrice;
                Entity.Capacity = View.BuildCapacity;
                Entity.Count = View.BuildCount;
                Entity.Frequency = View.BuildFrequency;
                Entity.HasECC = View.BuildHasECC;
                Entity.IsBuffered = View.BuildIsBuffered;*/
                base.UpdateEntity();

        public bool Validate()
            =>
                /*   if (View.BuildBrand == null)
                    Utilities.ShowError("Lütfen bir marka seçin.");
                else if (View.BuildPrice == decimal.Zero)
                    Utilities.ShowError("Lütfen ürünün fiyatını girin.");
                else if (string.IsNullOrWhiteSpace(View.BuildType))
                    Utilities.ShowError("Lütfen bir bellek tipi girin.");
                else if (View.BuildCapacity == 0)
                    Utilities.ShowError("Lütfen bellek modül kapasitesini girin.");
                else if (View.BuildCount == 0)
                    Utilities.ShowError("Lütfen bellek modül sayısını girin.");
                else if (View.BuildFrequency == 0)
                    Utilities.ShowError("Lütfen bellek hızını girin.");
                else
                    return ValidateName();*/
                false;

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