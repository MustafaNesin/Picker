namespace Picker
{
    using System;
    using System.Collections.Generic;
    using System.Data.Entity;
    using System.Drawing;
    using System.IO;
    using System.Linq;
    using System.Threading.Tasks;
    using System.Windows.Forms;

    internal sealed class BrandListPresenter : ListPresenter<BrandListView, Brand>
    {
        public async Task AddItemAsync()
        {
            bool isImageChanged;
            Image image;

            // Yeni bir 'Marka' oluştur.
            var brand = new Brand
            {
                Color = Color.Green,
                Country = (Country)(-1)
            };

            // Oluşturulan markayı düzenle.
            await using (var presenter = new BrandPresenter(brand))
            {
                if (presenter.ShowView() == DialogResult.Cancel)
                    return;

                isImageChanged = presenter.IsImageChanged;
                image = presenter.EntityImage;
            }

            // Oluşturulan markayı veritabanına kaydet.
            using (var context = new ComputerDatabaseContext())
            {
                context.Entry(brand).State = EntityState.Added;
                await context.SaveChangesAsync();
            }

            // Yüklenen resmi kaydet.
            if (isImageChanged)
            {
                var imagePath = string.Format(Utilities.ImagePathFormat, "brands", brand.Id);
                if (File.Exists(imagePath))
                    File.Delete(imagePath);

                image.Save(imagePath);
            }

            image.Dispose();

            // Listeyi güncelle.
            await GenerateListAsync();
        }

        public async Task DeleteItemAsync(BrandItemView brandItemView, Brand brand)
        {
            // Markayı sil.
            using (var context = new ComputerDatabaseContext())
            {
                var entry = context.Entry(brand);

                if (Utilities.ShowWarning(
                    $"'{brand.Name}' markasına ait olan, veri tabanındaki tüm parçalar da " +
                    "(soketler, anakartlar vb.) silinecektir." + Environment.NewLine +
                    "Devam edilsin mi?", MessageBoxButtons.YesNo) == DialogResult.No)
                    return;

                entry.State = EntityState.Deleted;
                await context.SaveChangesAsync();
            }

            // Markanın resmini sil.
            var imagePath = string.Format(Utilities.ImagePathFormat, "brands", brand.Id);
            if (File.Exists(imagePath))
                File.Delete(imagePath);

            // Listeyi güncelle.
            await GenerateListAsync();
        }

        public async Task EditItemAsync(BrandItemView brandItemView, Brand brand)
        {
            bool isImageChanged;
            // Varolan markayı düzenle.
            await using (var presenter = new BrandPresenter(brand))
            {
                if (presenter.ShowView() == DialogResult.Cancel)
                    return;

                if (isImageChanged = presenter.IsImageChanged)
                {
                    brandItemView.BrandImage?.Dispose();
                    brandItemView.BrandImage = presenter.EntityImage;
                }
            }

            // Değiştirilen markayı veritabanına kaydet.
            using (var context = new ComputerDatabaseContext())
            {
                context.Entry(brand).State = EntityState.Modified;
                await context.SaveChangesAsync();
            }

            // Listedeki öğeyi güncelle.
            brandItemView.BrandName = brand.Name;
            brandItemView.BrandCountry = brand.Country;
            brandItemView.BrandColor = brand.Color;

            // Yüklenen resmi kaydet.
            if (isImageChanged)
            {
                var imagePath = string.Format(Utilities.ImagePathFormat, "brands", brand.Id);
                if (File.Exists(imagePath))
                    File.Delete(imagePath);

                brandItemView.BrandImage.Save(imagePath);
            }
        }

        public async Task GenerateListAsync(bool paging = false)
        {
            View.GeneratingList = true;

            foreach (BrandItemView brandItemView in View.listPanel.Controls)
                brandItemView.BrandImage?.Dispose();

            View.listPanel.Controls.Clear(true);

            List<Brand> brands;

            using (var context = new ComputerDatabaseContext())
            {
                var query = context.Brands.AsQueryable();

                if (View.BrandCountry != (Country)(-1))
                    query = query.Where(brand => brand.Country == View.BrandCountry);

                if (!string.IsNullOrWhiteSpace(View.BrandName))
                    query = query.Where(brand => brand.Name.Contains(View.BrandName));

                // ReSharper disable once ConvertSwitchStatementToSwitchExpression
                switch (View.OrderIndex)
                {
                    case 1: // Yeniden eskiye
                        query = query.OrderByDescending(brand => brand.Id);
                        break;
                    case 2: // İsme göre (A-Z)
                        query = query.OrderBy(brand => brand.Name);
                        break;
                    case 3: // İsme göre (Z-A)
                        query = query.OrderByDescending(brand => brand.Name);
                        break;
                    case 4: // Ülke ismine göre (A-Z)
                        query = query.OrderBy(brand => brand.Country);
                        break;
                    case 5: // Ülke ismine göre (Z-A)
                        query = query.OrderByDescending(brand => brand.Country);
                        break;
                    default: // Eskiden yeniye
                        query = query.OrderBy(brand => brand.Id);
                        break;
                }

                var totalItemCount = await query.CountAsync();
                var pageCount = totalItemCount / View.ItemPerPage;
                if (totalItemCount % View.ItemPerPage != 0)
                    pageCount++;

                View.PageCount = pageCount;
                if (!paging)
                    View.PageIndex = 0;

                brands = await query.Skip(View.PageIndex * View.ItemPerPage).Take(View.ItemPerPage)
                    .ToListAsync();

                View.SetCountLabel(brands.Count, totalItemCount);
                View.UpdateNavigationButtonsStatus();
            }

            // ReSharper disable once ForeachCanBePartlyConvertedToQueryUsingAnotherGetEnumerator
            foreach (var brand in brands)
            {
                var brandItemView = new BrandItemView(this, brand)
                {
                    Dock = DockStyle.Top,
                    BrandName = brand.Name,
                    BrandCountry = brand.Country,
                    BrandColor = brand.Color
                };

                var imagePath = string.Format(Utilities.ImagePathFormat, "brands", brand.Id);
                if (File.Exists(imagePath))
                {
                    brandItemView.BrandImage?.Dispose();
                    brandItemView.BrandImage = Utilities.LoadImage(imagePath);
                }

                View.listPanel.Controls.Add(brandItemView);
                brandItemView.BringToFront();
            }

            View.GeneratingList = false;
        }

        public override DialogResult ShowView()
        {
            var result = base.ShowView();

            foreach (BrandItemView brandItemView in View.listPanel.Controls)
                brandItemView.BrandImage?.Dispose();

            return result;
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