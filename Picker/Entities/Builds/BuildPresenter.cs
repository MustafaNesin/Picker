namespace Picker
{
    using System;
    using System.Collections.Generic;
    using System.Data.Entity;
    using System.Linq;
    using System.Threading.Tasks;

    internal sealed class BuildPresenter : EntityPresenter<BuildView, Build>
    {
        public List<Memory> Memories { get; set; }

        public BuildPresenter(Build entity, bool adminMode) : base(entity, adminMode)
        {
            View.Text = string.IsNullOrEmpty(Entity.Name) ? "Yeni Bilgisayar" : Entity.Name;
            View.BuildMotherboard = entity.Motherboard;
            View.BuildProcessor = entity.Processor;
            View.BuildGraphicsCard = entity.GraphicsCard;

            using var context = new ComputerDatabaseContext();
            View.BuildMemories = entity.Id == 0
                ? null
                : context.BuildMemories.Where(p => p.BuildId == entity.Id).Select(p => p.Memory)
                    .Include(p => p.Brand).ToList();
        }

        protected override void UpdateEntity()
        {
            View.BuildMotherboard?.DisposeImage();
            View.BuildProcessor?.DisposeImage();
            View.BuildGraphicsCard?.DisposeImage();

            if ((Entity.Motherboard = View.BuildMotherboard) != null)
            {
                Entity.MotherboardId = Entity.Motherboard.Id;
                Entity.Motherboard.Brand = null;
                Entity.Motherboard.Chipset = null;
                Entity.Motherboard.Socket = null;
            }

            if ((Entity.Processor = View.BuildProcessor) != null)
            {
                Entity.ProcessorId = Entity.Processor.Id;
                Entity.Processor.Brand = null;
                Entity.Processor.Socket = null;
            }

            if ((Entity.GraphicsCard = View.BuildGraphicsCard) != null)
            {
                Entity.GraphicsCardId = Entity.GraphicsCard.Id;
                Entity.GraphicsCard.Brand = null;
                Entity.GraphicsCard.ChipsetBrand = null;
            }

            foreach (var memory in Memories = View.BuildMemories)
                memory.DisposeImage();

            Entity.Date = DateTime.Now;
            base.UpdateEntity();
        }

        public bool Validate() => ValidateName();

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