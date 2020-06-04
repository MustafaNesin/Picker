namespace Picker
{
    using System;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Drawing;
    using System.IO;

    public abstract class Entity
    {
        private Image _image;
        protected string _imagePath;
        private bool _pendingImageSave;
        public int Id { get; set; }

        [NotMapped]
        public Image Image
        {
            get
            {
                if (Id == 0)
                    throw new InvalidOperationException(
                        "Veri tabanına eklenmemiş varlıkların resmi alınamaz.");

                if (_image == null && File.Exists(ImagePath))
                    _image = Utilities.LoadImage(ImagePath);

                return _image;
            }
            set
            {
                if (value == _image)
                    return;

                if (value == null)
                {
                    if (Id != 0 && File.Exists(ImagePath))
                        File.Delete(ImagePath);

                    _image?.Dispose();
                    _image = null;
                    return;
                }

                _image?.Dispose();
                _image = value;

                if (Id == 0)
                    _pendingImageSave = true;
                else
                {
                    if (File.Exists(ImagePath))
                        File.Delete(ImagePath);

                    _image.Save(ImagePath);
                }
            }
        }

        [NotMapped]
        protected abstract string ImagePath { get; }

        [Required]
        public string Name { get; set; }

        public void DisposeImage()
        {
            if (_pendingImageSave)
                throw new InvalidOperationException("Kaydedilmeyi bekleyen varlık resmi var.");

            _image?.Dispose();
            _image = null;
        }

        public void ReleasePendingImage()
        {
            if (!_pendingImageSave)
                return;

            _image.Dispose();
            _image = null;
            _pendingImageSave = false;
        }

        public void SaveImage()
        {
            if (Id == 0)
                throw new InvalidOperationException(
                    "Veri tabanına eklenmemiş varlıkların resmi kaydedilemez.");

            if (!_pendingImageSave)
                return;

            if (File.Exists(ImagePath))
                File.Delete(ImagePath);

            _image.Save(ImagePath);
            _pendingImageSave = false;
        }
    }
}