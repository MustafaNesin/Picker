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
        private readonly List<Memory> _memories = new List<Memory>();
        private Motherboard _motherboard;
        private Processor _processor;
        private int _selectedMemoryIndex;
        private decimal _total;

        public GraphicsCard BuildGraphicsCard
        {
            get => _graphicsCard;
            set => SelectGraphicsCard(value);
        }

        public List<Memory> BuildMemories
        {
            get => _memories;
            set
            {
                while (_memories.Count > 0)
                    RemoveMemory(0);

                _memories.Clear();

                if (value != null)
                    foreach (var memory in value)
                        AddMemory(memory, false);

                if (_memories.Count > 0)
                    SelectMemory(0);
            }
        }

        public Motherboard BuildMotherboard
        {
            get => _motherboard;
            set => SelectMotherboard(value);
        }

        public Processor BuildProcessor
        {
            get => _processor;
            set => SelectProcessor(value);
        }

        public Image EntityImage
        {
            get => throw new InvalidOperationException();
            set => throw new InvalidOperationException();
        }

        public string EntityName
        {
            get => nameBox.Text;
            set => nameBox.Text = value;
        }

        private Memory SelectedMemory
            => _selectedMemoryIndex == -1 ? null : BuildMemories[_selectedMemoryIndex];

        public decimal Total
        {
            get => _total;
            set => totalLabel.Text = $"Toplam tutar: {_total = value:C2}";
        }

        public BuildView(BuildPresenter presenter)
        {
            InitializeComponent();
            _presenter = presenter;
        }

        private void acceptButton_Click(object sender, EventArgs e)
        {
            if (!_presenter.Validate())
                DialogResult = DialogResult.None;
        }

        public void AddMemory(Memory memory, bool select = true)
        {
            Total += memory.Price;
            _memories.Add(memory);
            if (select)
                SelectMemory(_memories.Count - 1);
        }

        private void BuildView_Load(object sender, EventArgs e)
        {
        }

        private async void graphicsCardNameLabel_Click(object sender, EventArgs e)
        {
            if (BuildGraphicsCard == null)
                return;

            await using var presenter = new GraphicsCardPresenter(BuildGraphicsCard, false);
            presenter.ShowView();
        }

        private void graphicsCardRemoveButton_Click(object sender, EventArgs e)
            => BuildGraphicsCard = null;

        private async void graphicsCardSelectButton_Click(object sender, EventArgs e)
        {
            await using (var presenter = new GraphicsCardListPresenter(false))
            {
                if (presenter.ShowView() == DialogResult.Cancel)
                    return;

                (BuildGraphicsCard = presenter.SelectedEntity).DisposeImage();
            }

            graphicsCardImageBox.Image = BuildGraphicsCard.Image ?? Resources.FavIcon64;
        }

        private async void memoryNameLabel_Click(object sender, EventArgs e)
        {
            if (BuildMemories.Count == 0)
                return;

            await using var presenter = new MemoryPresenter(SelectedMemory, false);
            presenter.ShowView();
        }

        private void memoryRemoveButton_Click(object sender, EventArgs e)
        {
            if (BuildMemories.Count != 0)
                RemoveMemory(_selectedMemoryIndex);
        }

        private async void memorySelectButton_Click(object sender, EventArgs e)
        {
            await using (var presenter = new MemoryListPresenter(false))
            {
                if (presenter.ShowView() == DialogResult.Cancel)
                    return;

                presenter.SelectedEntity.DisposeImage();
                AddMemory(presenter.SelectedEntity);
            }

            memoryImageBox.Image = SelectedMemory.Image ?? Resources.FavIcon64;
        }

        private async void motherboardNameLabel_Click(object sender, EventArgs e)
        {
            if (BuildMotherboard == null)
                return;

            await using var presenter = new MotherboardPresenter(BuildMotherboard, false);
            presenter.ShowView();
        }

        private void motherboardRemoveButton_Click(object sender, EventArgs e)
            => BuildMotherboard = null;

        private async void motherboardSelectButton_Click(object sender, EventArgs e)
        {
            await using (var presenter = new MotherboardListPresenter(false))
            {
                if (presenter.ShowView() == DialogResult.Cancel)
                    return;

                (BuildMotherboard = presenter.SelectedEntity).DisposeImage();
            }

            motherboardImageBox.Image = BuildMotherboard.Image ?? Resources.FavIcon64;
        }

        private void nextMemoryButton_Click(object sender, EventArgs e)
            => SelectMemory(_selectedMemoryIndex + 1);

        private void previousMemoryButton_Click(object sender, EventArgs e)
            => SelectMemory(_selectedMemoryIndex - 1);

        private async void processorNameLabel_Click(object sender, EventArgs e)
        {
            if (BuildProcessor == null)
                return;

            await using var presenter = new ProcessorPresenter(BuildProcessor, false);
            presenter.ShowView();
        }

        private void processorRemoveButton_Click(object sender, EventArgs e)
            => BuildProcessor = null;

        private async void processorSelectButton_Click(object sender, EventArgs e)
        {
            await using (var presenter = new ProcessorListPresenter(false))
            {
                if (presenter.ShowView() == DialogResult.Cancel)
                    return;

                (BuildProcessor = presenter.SelectedEntity).DisposeImage();
            }

            processorImageBox.Image = BuildProcessor.Image ?? Resources.FavIcon64;
        }

        public void RemoveMemory(int index)
        {
            memoryImageBox.Image = null;
            var memory = _memories[index];
            memory.DisposeImage();
            Total -= memory.Price;
            _memories.RemoveAt(index);
            SelectMemory(index == _memories.Count ? index - 1 : index);
        }

        public void SelectGraphicsCard(GraphicsCard graphicsCard)
        {
            if (_graphicsCard?.Id == graphicsCard?.Id)
                return;

            if (_graphicsCard != null)
            {
                Total -= _graphicsCard.Price;
                graphicsCardImageBox.Image = null;
                _graphicsCard.DisposeImage();
            }

            if (graphicsCard != null)
            {
                graphicsCardPriceLabel.Text = $"Fiyat: {graphicsCard.Price:C2}";
                Total += graphicsCard.Price;
            }

            graphicsCardNameLabel.Text = graphicsCard?.Name ?? "Bir ekran kartı seçin...";
            graphicsCardNameLabel.ForeColor = graphicsCardSelectButton.BackColor =
                graphicsCard?.Brand.Color ?? Color.Green;

            graphicsCardPriceLabel.Visible =
                graphicsCardRemoveButton.Visible = graphicsCard != null;

            _graphicsCard = graphicsCard;
        }

        public void SelectMemory(int index)
        {
            Memory memory = null;
            if (index == -1)
            {
                memoryImageBox.Image = null;
                memoryNameLabel.Text = "Bir bellek seçin...";
            }
            else
            {
                memory = _memories[index];
                memoryNameLabel.Text = memory.Name;
                memoryPriceLabel.Text = $"Fiyat: {memory.Price:C2}";
            }

            previousMemoryButton.Enabled = index > 0;
            nextMemoryButton.Enabled = index + 1 < _memories.Count;
            memoryLabel.Text = index + 1 + " / " + _memories.Count;
            memoryNameLabel.ForeColor =
                memorySelectButton.BackColor = memory?.Brand.Color ?? Color.Green;

            memoryPriceLabel.Visible = memoryRemoveButton.Visible = index != -1;
            _selectedMemoryIndex = index;
        }

        public void SelectMotherboard(Motherboard motherboard)
        {
            if (_motherboard?.Id == motherboard?.Id)
                return;

            if (_motherboard != null)
            {
                Total -= _motherboard.Price;
                motherboardImageBox.Image = null;
                _motherboard.DisposeImage();
            }

            if (motherboard != null)
            {
                motherboardPriceLabel.Text = $"Fiyat: {motherboard.Price:C2}";
                Total += motherboard.Price;
            }

            motherboardNameLabel.Text = motherboard?.Name ?? "Bir anakart seçin...";
            motherboardNameLabel.ForeColor = motherboardSelectButton.BackColor =
                motherboard?.Brand.Color ?? Color.Green;

            motherboardPriceLabel.Visible = motherboardRemoveButton.Visible = motherboard != null;
            _motherboard = motherboard;
        }

        public void SelectProcessor(Processor processor)
        {
            if (_processor?.Id == processor?.Id)
                return;

            if (_processor != null)
            {
                Total -= _processor.Price;
                processorImageBox.Image = null;
                _processor.DisposeImage();
            }

            if (processor != null)
            {
                processorPriceLabel.Text = $"Fiyat: {processor.Price:C2}";
                Total += processor.Price;
            }

            processorNameLabel.Text = processor?.Name ?? "Bir işlemci seçin...";
            processorNameLabel.ForeColor = processorSelectButton.BackColor =
                processor?.Brand.Color ?? Color.Green;

            processorPriceLabel.Visible = processorRemoveButton.Visible = processor != null;
            _processor = processor;
        }
    }
}