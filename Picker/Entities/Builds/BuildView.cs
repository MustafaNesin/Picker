namespace Picker
{
    using System;
    using System.Collections.Generic;
    using System.Drawing;
    using System.Windows.Forms;
    using Properties;

    internal partial class BuildView : Form, IBuildView
    {
        private readonly BuildPresenter _presenter;
        private GraphicsCard _graphicsCard;
        private List<Memory> _memories;
        private Motherboard _motherboard;
        private Processor _processor;

        public GraphicsCard BuildGraphicsCard
        {
            get => _graphicsCard;
            set
            {
                _graphicsCard?.DisposeImage();
                graphicsCardImageBox.DisposeImage();

                if (value != null)
                {
                    graphicsCardPriceLabel.Text = $"Fiyat: {value.Price:C2}";
                    graphicsCardImageBox.Image = value.Image ?? Resources.FavIcon64;
                }

                graphicsCardNameLabel.Text =
                    value == null ? "Bir ekran kartı seçin..." : value.Name;

                SetGraphicsCardControlsColor(value?.Brand.Color ?? Color.Green);
                SetGraphicsCardControlsVisibility(value != null);
                _graphicsCard = value;
            }
        }

        public List<Memory> BuildMemories
        {
            get => throw new NotImplementedException();
            set => throw new NotImplementedException();
        }

        public Motherboard BuildMotherboard
        {
            get => _motherboard;
            set
            {
                _motherboard?.DisposeImage();
                motherboardImageBox.DisposeImage();

                if (value != null)
                {
                    motherboardPriceLabel.Text = $"Fiyat: {value.Price:C2}";
                    motherboardImageBox.Image = value.Image ?? Resources.FavIcon64;
                }

                motherboardNameLabel.Text = value == null ? "Bir anakart seçin..." : value.Name;
                SetMotherboardControlsColor(value?.Brand.Color ?? Color.Green);
                SetMotherboardControlsVisibility(value != null);
                _motherboard = value;
            }
        }

        public Processor BuildProcessor
        {
            get => throw new NotImplementedException();
            set => throw new NotImplementedException();
        }

        public Image EntityImage
        {
            get => null;
            set => throw new InvalidOperationException();
        }

        public string EntityName
        {
            get => nameBox.Text;
            set => Text = value;
        }

        public BuildView(BuildPresenter presenter)
        {
            InitializeComponent();
            _presenter = presenter;
        }

        private void acceptButton_Click(object sender, EventArgs e)
        {
            if (_presenter.AdminMode && !_presenter.Validate())
                DialogResult = DialogResult.None;
        }

        public void SetGraphicsCardControlsColor(Color color)
            => graphicsCardNameLabel.ForeColor = graphicsCardSelectButton.BackColor = color;

        public void SetGraphicsCardControlsVisibility(bool visible)
            => graphicsCardImageBox.Visible = graphicsCardPriceLabel.Visible =
                graphicsCardRemoveButton.Visible = visible;

        public void SetMemoryControlsColor(Color color)
            => memoryNameLabel.ForeColor = memorySelectButton.BackColor = color;

        public void SetMemoryControlsVisibility(bool visible)
            => memoryImageBox.Visible =
                memoryPriceLabel.Visible = memoryRemoveButton.Visible = visible;

        public void SetMotherboardControlsColor(Color color)
            => motherboardNameLabel.ForeColor = motherboardSelectButton.BackColor = color;

        public void SetMotherboardControlsVisibility(bool visible)
            => motherboardImageBox.Visible = motherboardPriceLabel.Visible =
                motherboardRemoveButton.Visible = visible;

        public void SetProcessorControlsColor(Color color)
            => processorNameLabel.ForeColor = processorSelectButton.BackColor = color;

        public void SetProcessorControlsVisibility(bool visible)
            => processorImageBox.Visible =
                processorPriceLabel.Visible = processorRemoveButton.Visible = visible;
    }
}