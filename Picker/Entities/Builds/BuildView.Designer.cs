namespace Picker
{
    partial class BuildView
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BuildView));
            this.controlPanel = new System.Windows.Forms.Panel();
            this.totalLabel = new System.Windows.Forms.Label();
            this.nameLabel = new System.Windows.Forms.Label();
            this.nameBox = new System.Windows.Forms.TextBox();
            this.cancelButton = new System.Windows.Forms.Button();
            this.acceptButton = new System.Windows.Forms.Button();
            this.container = new System.Windows.Forms.SplitContainer();
            this.memoriesPanel = new System.Windows.Forms.Panel();
            this.memoryBox = new System.Windows.Forms.GroupBox();
            this.memoryPriceLabel = new System.Windows.Forms.Label();
            this.memoryRemoveButton = new System.Windows.Forms.Button();
            this.memorySelectButton = new System.Windows.Forms.Button();
            this.memoryNameLabel = new System.Windows.Forms.Label();
            this.memoryImageBox = new System.Windows.Forms.PictureBox();
            this.memoryNavigationPanel = new System.Windows.Forms.Panel();
            this.memoryLabel = new System.Windows.Forms.Label();
            this.nextMemoryButton = new System.Windows.Forms.Button();
            this.previousMemoryButton = new System.Windows.Forms.Button();
            this.graphicsCardBox = new System.Windows.Forms.GroupBox();
            this.graphicsCardPriceLabel = new System.Windows.Forms.Label();
            this.graphicsCardRemoveButton = new System.Windows.Forms.Button();
            this.graphicsCardSelectButton = new System.Windows.Forms.Button();
            this.graphicsCardNameLabel = new System.Windows.Forms.Label();
            this.graphicsCardImageBox = new System.Windows.Forms.PictureBox();
            this.processorBox = new System.Windows.Forms.GroupBox();
            this.processorPriceLabel = new System.Windows.Forms.Label();
            this.processorRemoveButton = new System.Windows.Forms.Button();
            this.processorSelectButton = new System.Windows.Forms.Button();
            this.processorNameLabel = new System.Windows.Forms.Label();
            this.processorImageBox = new System.Windows.Forms.PictureBox();
            this.motherboardBox = new System.Windows.Forms.GroupBox();
            this.motherboardPriceLabel = new System.Windows.Forms.Label();
            this.motherboardRemoveButton = new System.Windows.Forms.Button();
            this.motherboardSelectButton = new System.Windows.Forms.Button();
            this.motherboardNameLabel = new System.Windows.Forms.Label();
            this.motherboardImageBox = new System.Windows.Forms.PictureBox();
            this.compabilityBox = new System.Windows.Forms.ListBox();
            this.controlPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.container)).BeginInit();
            this.container.Panel1.SuspendLayout();
            this.container.Panel2.SuspendLayout();
            this.container.SuspendLayout();
            this.memoriesPanel.SuspendLayout();
            this.memoryBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.memoryImageBox)).BeginInit();
            this.memoryNavigationPanel.SuspendLayout();
            this.graphicsCardBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.graphicsCardImageBox)).BeginInit();
            this.processorBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.processorImageBox)).BeginInit();
            this.motherboardBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.motherboardImageBox)).BeginInit();
            this.SuspendLayout();
            // 
            // controlPanel
            // 
            this.controlPanel.Controls.Add(this.totalLabel);
            this.controlPanel.Controls.Add(this.nameLabel);
            this.controlPanel.Controls.Add(this.nameBox);
            this.controlPanel.Controls.Add(this.cancelButton);
            this.controlPanel.Controls.Add(this.acceptButton);
            this.controlPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.controlPanel.Location = new System.Drawing.Point(0, 529);
            this.controlPanel.Name = "controlPanel";
            this.controlPanel.Size = new System.Drawing.Size(984, 32);
            this.controlPanel.TabIndex = 2;
            // 
            // totalLabel
            // 
            this.totalLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.totalLabel.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.totalLabel.Location = new System.Drawing.Point(89, 0);
            this.totalLabel.Name = "totalLabel";
            this.totalLabel.Padding = new System.Windows.Forms.Padding(0, 0, 6, 0);
            this.totalLabel.Size = new System.Drawing.Size(494, 32);
            this.totalLabel.TabIndex = 4;
            this.totalLabel.Text = "Toplam tutar: $0.00";
            this.totalLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // nameLabel
            // 
            this.nameLabel.Dock = System.Windows.Forms.DockStyle.Right;
            this.nameLabel.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.nameLabel.Location = new System.Drawing.Point(583, 0);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(97, 32);
            this.nameLabel.TabIndex = 3;
            this.nameLabel.Text = "Bilgisayar Adı:";
            this.nameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // nameBox
            // 
            this.nameBox.Dock = System.Windows.Forms.DockStyle.Right;
            this.nameBox.Font = new System.Drawing.Font("Segoe UI", 13.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.nameBox.ForeColor = System.Drawing.Color.Black;
            this.nameBox.Location = new System.Drawing.Point(680, 0);
            this.nameBox.Name = "nameBox";
            this.nameBox.Size = new System.Drawing.Size(215, 31);
            this.nameBox.TabIndex = 2;
            // 
            // cancelButton
            // 
            this.cancelButton.BackColor = System.Drawing.Color.Green;
            this.cancelButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cancelButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.cancelButton.Dock = System.Windows.Forms.DockStyle.Left;
            this.cancelButton.FlatAppearance.BorderSize = 0;
            this.cancelButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cancelButton.ForeColor = System.Drawing.Color.White;
            this.cancelButton.Location = new System.Drawing.Point(0, 0);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(89, 32);
            this.cancelButton.TabIndex = 1;
            this.cancelButton.Text = "İptal";
            this.cancelButton.UseVisualStyleBackColor = false;
            // 
            // acceptButton
            // 
            this.acceptButton.BackColor = System.Drawing.Color.Green;
            this.acceptButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.acceptButton.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.acceptButton.Dock = System.Windows.Forms.DockStyle.Right;
            this.acceptButton.FlatAppearance.BorderSize = 0;
            this.acceptButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.acceptButton.ForeColor = System.Drawing.Color.White;
            this.acceptButton.Location = new System.Drawing.Point(895, 0);
            this.acceptButton.Name = "acceptButton";
            this.acceptButton.Size = new System.Drawing.Size(89, 32);
            this.acceptButton.TabIndex = 0;
            this.acceptButton.Text = "Tamam";
            this.acceptButton.UseVisualStyleBackColor = false;
            this.acceptButton.Click += new System.EventHandler(this.acceptButton_Click);
            // 
            // container
            // 
            this.container.Dock = System.Windows.Forms.DockStyle.Fill;
            this.container.Location = new System.Drawing.Point(0, 0);
            this.container.Name = "container";
            this.container.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // container.Panel1
            // 
            this.container.Panel1.Controls.Add(this.memoriesPanel);
            this.container.Panel1.Controls.Add(this.graphicsCardBox);
            this.container.Panel1.Controls.Add(this.processorBox);
            this.container.Panel1.Controls.Add(this.motherboardBox);
            this.container.Panel1.Padding = new System.Windows.Forms.Padding(10);
            this.container.Panel1MinSize = 400;
            // 
            // container.Panel2
            // 
            this.container.Panel2.Controls.Add(this.compabilityBox);
            this.container.Panel2.Padding = new System.Windows.Forms.Padding(10);
            this.container.Panel2MinSize = 100;
            this.container.Size = new System.Drawing.Size(984, 529);
            this.container.SplitterDistance = 400;
            this.container.TabIndex = 5;
            // 
            // memoriesPanel
            // 
            this.memoriesPanel.Controls.Add(this.memoryBox);
            this.memoriesPanel.Controls.Add(this.memoryNavigationPanel);
            this.memoriesPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.memoriesPanel.Location = new System.Drawing.Point(10, 295);
            this.memoriesPanel.Name = "memoriesPanel";
            this.memoriesPanel.Size = new System.Drawing.Size(964, 95);
            this.memoriesPanel.TabIndex = 11;
            // 
            // memoryBox
            // 
            this.memoryBox.Controls.Add(this.memoryPriceLabel);
            this.memoryBox.Controls.Add(this.memoryRemoveButton);
            this.memoryBox.Controls.Add(this.memorySelectButton);
            this.memoryBox.Controls.Add(this.memoryNameLabel);
            this.memoryBox.Controls.Add(this.memoryImageBox);
            this.memoryBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.memoryBox.Location = new System.Drawing.Point(50, 0);
            this.memoryBox.Name = "memoryBox";
            this.memoryBox.Padding = new System.Windows.Forms.Padding(8);
            this.memoryBox.Size = new System.Drawing.Size(914, 95);
            this.memoryBox.TabIndex = 0;
            this.memoryBox.TabStop = false;
            this.memoryBox.Text = "Bellek";
            // 
            // memoryPriceLabel
            // 
            this.memoryPriceLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.memoryPriceLabel.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.memoryPriceLabel.ForeColor = System.Drawing.Color.Black;
            this.memoryPriceLabel.Location = new System.Drawing.Point(72, 58);
            this.memoryPriceLabel.Name = "memoryPriceLabel";
            this.memoryPriceLabel.Padding = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.memoryPriceLabel.Size = new System.Drawing.Size(740, 29);
            this.memoryPriceLabel.TabIndex = 3;
            this.memoryPriceLabel.Text = "Fiyat: $0.00";
            this.memoryPriceLabel.Visible = false;
            // 
            // memoryRemoveButton
            // 
            this.memoryRemoveButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.memoryRemoveButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.memoryRemoveButton.Dock = System.Windows.Forms.DockStyle.Right;
            this.memoryRemoveButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.memoryRemoveButton.ForeColor = System.Drawing.Color.White;
            this.memoryRemoveButton.Location = new System.Drawing.Point(812, 58);
            this.memoryRemoveButton.Name = "memoryRemoveButton";
            this.memoryRemoveButton.Size = new System.Drawing.Size(47, 29);
            this.memoryRemoveButton.TabIndex = 1;
            this.memoryRemoveButton.Text = "Kaldır";
            this.memoryRemoveButton.UseVisualStyleBackColor = false;
            this.memoryRemoveButton.Visible = false;
            // 
            // memorySelectButton
            // 
            this.memorySelectButton.BackColor = System.Drawing.Color.Green;
            this.memorySelectButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.memorySelectButton.Dock = System.Windows.Forms.DockStyle.Right;
            this.memorySelectButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.memorySelectButton.ForeColor = System.Drawing.Color.White;
            this.memorySelectButton.Location = new System.Drawing.Point(859, 58);
            this.memorySelectButton.Name = "memorySelectButton";
            this.memorySelectButton.Size = new System.Drawing.Size(47, 29);
            this.memorySelectButton.TabIndex = 0;
            this.memorySelectButton.Text = "Ekle...";
            this.memorySelectButton.UseVisualStyleBackColor = false;
            // 
            // memoryNameLabel
            // 
            this.memoryNameLabel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.memoryNameLabel.Dock = System.Windows.Forms.DockStyle.Top;
            this.memoryNameLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.memoryNameLabel.ForeColor = System.Drawing.Color.Green;
            this.memoryNameLabel.Location = new System.Drawing.Point(72, 23);
            this.memoryNameLabel.Name = "memoryNameLabel";
            this.memoryNameLabel.Padding = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.memoryNameLabel.Size = new System.Drawing.Size(834, 35);
            this.memoryNameLabel.TabIndex = 2;
            this.memoryNameLabel.Text = "Bir bellek seçin...";
            this.memoryNameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // memoryImageBox
            // 
            this.memoryImageBox.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.memoryImageBox.Dock = System.Windows.Forms.DockStyle.Left;
            this.memoryImageBox.Image = ((System.Drawing.Image)(resources.GetObject("memoryImageBox.Image")));
            this.memoryImageBox.Location = new System.Drawing.Point(8, 23);
            this.memoryImageBox.Name = "memoryImageBox";
            this.memoryImageBox.Size = new System.Drawing.Size(64, 64);
            this.memoryImageBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.memoryImageBox.TabIndex = 4;
            this.memoryImageBox.TabStop = false;
            // 
            // memoryNavigationPanel
            // 
            this.memoryNavigationPanel.Controls.Add(this.memoryLabel);
            this.memoryNavigationPanel.Controls.Add(this.nextMemoryButton);
            this.memoryNavigationPanel.Controls.Add(this.previousMemoryButton);
            this.memoryNavigationPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.memoryNavigationPanel.Location = new System.Drawing.Point(0, 0);
            this.memoryNavigationPanel.Name = "memoryNavigationPanel";
            this.memoryNavigationPanel.Padding = new System.Windows.Forms.Padding(4, 10, 4, 10);
            this.memoryNavigationPanel.Size = new System.Drawing.Size(50, 95);
            this.memoryNavigationPanel.TabIndex = 1;
            // 
            // memoryLabel
            // 
            this.memoryLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.memoryLabel.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.memoryLabel.Location = new System.Drawing.Point(4, 33);
            this.memoryLabel.Name = "memoryLabel";
            this.memoryLabel.Size = new System.Drawing.Size(42, 29);
            this.memoryLabel.TabIndex = 1;
            this.memoryLabel.Text = "0 / 0";
            this.memoryLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // nextMemoryButton
            // 
            this.nextMemoryButton.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.nextMemoryButton.Enabled = false;
            this.nextMemoryButton.Location = new System.Drawing.Point(4, 62);
            this.nextMemoryButton.Name = "nextMemoryButton";
            this.nextMemoryButton.Size = new System.Drawing.Size(42, 23);
            this.nextMemoryButton.TabIndex = 2;
            this.nextMemoryButton.Text = "▼";
            this.nextMemoryButton.UseVisualStyleBackColor = true;
            // 
            // previousMemoryButton
            // 
            this.previousMemoryButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.previousMemoryButton.Enabled = false;
            this.previousMemoryButton.Location = new System.Drawing.Point(4, 10);
            this.previousMemoryButton.Name = "previousMemoryButton";
            this.previousMemoryButton.Size = new System.Drawing.Size(42, 23);
            this.previousMemoryButton.TabIndex = 0;
            this.previousMemoryButton.Text = "▲";
            this.previousMemoryButton.UseVisualStyleBackColor = true;
            // 
            // graphicsCardBox
            // 
            this.graphicsCardBox.Controls.Add(this.graphicsCardPriceLabel);
            this.graphicsCardBox.Controls.Add(this.graphicsCardRemoveButton);
            this.graphicsCardBox.Controls.Add(this.graphicsCardSelectButton);
            this.graphicsCardBox.Controls.Add(this.graphicsCardNameLabel);
            this.graphicsCardBox.Controls.Add(this.graphicsCardImageBox);
            this.graphicsCardBox.Dock = System.Windows.Forms.DockStyle.Top;
            this.graphicsCardBox.Location = new System.Drawing.Point(10, 200);
            this.graphicsCardBox.Name = "graphicsCardBox";
            this.graphicsCardBox.Padding = new System.Windows.Forms.Padding(8);
            this.graphicsCardBox.Size = new System.Drawing.Size(964, 95);
            this.graphicsCardBox.TabIndex = 10;
            this.graphicsCardBox.TabStop = false;
            this.graphicsCardBox.Text = "Ekran Kartı";
            // 
            // graphicsCardPriceLabel
            // 
            this.graphicsCardPriceLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.graphicsCardPriceLabel.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.graphicsCardPriceLabel.ForeColor = System.Drawing.Color.Black;
            this.graphicsCardPriceLabel.Location = new System.Drawing.Point(72, 58);
            this.graphicsCardPriceLabel.Name = "graphicsCardPriceLabel";
            this.graphicsCardPriceLabel.Padding = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.graphicsCardPriceLabel.Size = new System.Drawing.Size(790, 29);
            this.graphicsCardPriceLabel.TabIndex = 3;
            this.graphicsCardPriceLabel.Text = "Fiyat: $0.00";
            this.graphicsCardPriceLabel.Visible = false;
            // 
            // graphicsCardRemoveButton
            // 
            this.graphicsCardRemoveButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.graphicsCardRemoveButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.graphicsCardRemoveButton.Dock = System.Windows.Forms.DockStyle.Right;
            this.graphicsCardRemoveButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.graphicsCardRemoveButton.ForeColor = System.Drawing.Color.White;
            this.graphicsCardRemoveButton.Location = new System.Drawing.Point(862, 58);
            this.graphicsCardRemoveButton.Name = "graphicsCardRemoveButton";
            this.graphicsCardRemoveButton.Size = new System.Drawing.Size(47, 29);
            this.graphicsCardRemoveButton.TabIndex = 1;
            this.graphicsCardRemoveButton.Text = "Kaldır";
            this.graphicsCardRemoveButton.UseVisualStyleBackColor = false;
            this.graphicsCardRemoveButton.Visible = false;
            // 
            // graphicsCardSelectButton
            // 
            this.graphicsCardSelectButton.BackColor = System.Drawing.Color.Green;
            this.graphicsCardSelectButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.graphicsCardSelectButton.Dock = System.Windows.Forms.DockStyle.Right;
            this.graphicsCardSelectButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.graphicsCardSelectButton.ForeColor = System.Drawing.Color.White;
            this.graphicsCardSelectButton.Location = new System.Drawing.Point(909, 58);
            this.graphicsCardSelectButton.Name = "graphicsCardSelectButton";
            this.graphicsCardSelectButton.Size = new System.Drawing.Size(47, 29);
            this.graphicsCardSelectButton.TabIndex = 0;
            this.graphicsCardSelectButton.Text = "Seç...";
            this.graphicsCardSelectButton.UseVisualStyleBackColor = false;
            // 
            // graphicsCardNameLabel
            // 
            this.graphicsCardNameLabel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.graphicsCardNameLabel.Dock = System.Windows.Forms.DockStyle.Top;
            this.graphicsCardNameLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.graphicsCardNameLabel.ForeColor = System.Drawing.Color.Green;
            this.graphicsCardNameLabel.Location = new System.Drawing.Point(72, 23);
            this.graphicsCardNameLabel.Name = "graphicsCardNameLabel";
            this.graphicsCardNameLabel.Padding = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.graphicsCardNameLabel.Size = new System.Drawing.Size(884, 35);
            this.graphicsCardNameLabel.TabIndex = 2;
            this.graphicsCardNameLabel.Text = "Bir ekran kartı seçin...";
            this.graphicsCardNameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // graphicsCardImageBox
            // 
            this.graphicsCardImageBox.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.graphicsCardImageBox.Dock = System.Windows.Forms.DockStyle.Left;
            this.graphicsCardImageBox.Image = ((System.Drawing.Image)(resources.GetObject("graphicsCardImageBox.Image")));
            this.graphicsCardImageBox.Location = new System.Drawing.Point(8, 23);
            this.graphicsCardImageBox.Name = "graphicsCardImageBox";
            this.graphicsCardImageBox.Size = new System.Drawing.Size(64, 64);
            this.graphicsCardImageBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.graphicsCardImageBox.TabIndex = 4;
            this.graphicsCardImageBox.TabStop = false;
            // 
            // processorBox
            // 
            this.processorBox.Controls.Add(this.processorPriceLabel);
            this.processorBox.Controls.Add(this.processorRemoveButton);
            this.processorBox.Controls.Add(this.processorSelectButton);
            this.processorBox.Controls.Add(this.processorNameLabel);
            this.processorBox.Controls.Add(this.processorImageBox);
            this.processorBox.Dock = System.Windows.Forms.DockStyle.Top;
            this.processorBox.Location = new System.Drawing.Point(10, 105);
            this.processorBox.Name = "processorBox";
            this.processorBox.Padding = new System.Windows.Forms.Padding(8);
            this.processorBox.Size = new System.Drawing.Size(964, 95);
            this.processorBox.TabIndex = 9;
            this.processorBox.TabStop = false;
            this.processorBox.Text = "İşlemci";
            // 
            // processorPriceLabel
            // 
            this.processorPriceLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.processorPriceLabel.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.processorPriceLabel.ForeColor = System.Drawing.Color.Black;
            this.processorPriceLabel.Location = new System.Drawing.Point(72, 58);
            this.processorPriceLabel.Name = "processorPriceLabel";
            this.processorPriceLabel.Padding = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.processorPriceLabel.Size = new System.Drawing.Size(790, 29);
            this.processorPriceLabel.TabIndex = 3;
            this.processorPriceLabel.Text = "Fiyat: $0.00";
            this.processorPriceLabel.Visible = false;
            // 
            // processorRemoveButton
            // 
            this.processorRemoveButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.processorRemoveButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.processorRemoveButton.Dock = System.Windows.Forms.DockStyle.Right;
            this.processorRemoveButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.processorRemoveButton.ForeColor = System.Drawing.Color.White;
            this.processorRemoveButton.Location = new System.Drawing.Point(862, 58);
            this.processorRemoveButton.Name = "processorRemoveButton";
            this.processorRemoveButton.Size = new System.Drawing.Size(47, 29);
            this.processorRemoveButton.TabIndex = 1;
            this.processorRemoveButton.Text = "Kaldır";
            this.processorRemoveButton.UseVisualStyleBackColor = false;
            this.processorRemoveButton.Visible = false;
            // 
            // processorSelectButton
            // 
            this.processorSelectButton.BackColor = System.Drawing.Color.Green;
            this.processorSelectButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.processorSelectButton.Dock = System.Windows.Forms.DockStyle.Right;
            this.processorSelectButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.processorSelectButton.ForeColor = System.Drawing.Color.White;
            this.processorSelectButton.Location = new System.Drawing.Point(909, 58);
            this.processorSelectButton.Name = "processorSelectButton";
            this.processorSelectButton.Size = new System.Drawing.Size(47, 29);
            this.processorSelectButton.TabIndex = 0;
            this.processorSelectButton.Text = "Seç...";
            this.processorSelectButton.UseVisualStyleBackColor = false;
            // 
            // processorNameLabel
            // 
            this.processorNameLabel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.processorNameLabel.Dock = System.Windows.Forms.DockStyle.Top;
            this.processorNameLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.processorNameLabel.ForeColor = System.Drawing.Color.Green;
            this.processorNameLabel.Location = new System.Drawing.Point(72, 23);
            this.processorNameLabel.Name = "processorNameLabel";
            this.processorNameLabel.Padding = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.processorNameLabel.Size = new System.Drawing.Size(884, 35);
            this.processorNameLabel.TabIndex = 2;
            this.processorNameLabel.Text = "Bir işlemci seçin...";
            this.processorNameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // processorImageBox
            // 
            this.processorImageBox.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.processorImageBox.Dock = System.Windows.Forms.DockStyle.Left;
            this.processorImageBox.Image = ((System.Drawing.Image)(resources.GetObject("processorImageBox.Image")));
            this.processorImageBox.Location = new System.Drawing.Point(8, 23);
            this.processorImageBox.Name = "processorImageBox";
            this.processorImageBox.Size = new System.Drawing.Size(64, 64);
            this.processorImageBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.processorImageBox.TabIndex = 4;
            this.processorImageBox.TabStop = false;
            // 
            // motherboardBox
            // 
            this.motherboardBox.Controls.Add(this.motherboardPriceLabel);
            this.motherboardBox.Controls.Add(this.motherboardRemoveButton);
            this.motherboardBox.Controls.Add(this.motherboardSelectButton);
            this.motherboardBox.Controls.Add(this.motherboardNameLabel);
            this.motherboardBox.Controls.Add(this.motherboardImageBox);
            this.motherboardBox.Dock = System.Windows.Forms.DockStyle.Top;
            this.motherboardBox.Location = new System.Drawing.Point(10, 10);
            this.motherboardBox.Name = "motherboardBox";
            this.motherboardBox.Padding = new System.Windows.Forms.Padding(8);
            this.motherboardBox.Size = new System.Drawing.Size(964, 95);
            this.motherboardBox.TabIndex = 8;
            this.motherboardBox.TabStop = false;
            this.motherboardBox.Text = "Anakart";
            // 
            // motherboardPriceLabel
            // 
            this.motherboardPriceLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.motherboardPriceLabel.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.motherboardPriceLabel.ForeColor = System.Drawing.Color.Black;
            this.motherboardPriceLabel.Location = new System.Drawing.Point(72, 58);
            this.motherboardPriceLabel.Name = "motherboardPriceLabel";
            this.motherboardPriceLabel.Padding = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.motherboardPriceLabel.Size = new System.Drawing.Size(790, 29);
            this.motherboardPriceLabel.TabIndex = 3;
            this.motherboardPriceLabel.Text = "Fiyat: $0.00";
            this.motherboardPriceLabel.Visible = false;
            // 
            // motherboardRemoveButton
            // 
            this.motherboardRemoveButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.motherboardRemoveButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.motherboardRemoveButton.Dock = System.Windows.Forms.DockStyle.Right;
            this.motherboardRemoveButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.motherboardRemoveButton.ForeColor = System.Drawing.Color.White;
            this.motherboardRemoveButton.Location = new System.Drawing.Point(862, 58);
            this.motherboardRemoveButton.Name = "motherboardRemoveButton";
            this.motherboardRemoveButton.Size = new System.Drawing.Size(47, 29);
            this.motherboardRemoveButton.TabIndex = 1;
            this.motherboardRemoveButton.Text = "Kaldır";
            this.motherboardRemoveButton.UseVisualStyleBackColor = false;
            this.motherboardRemoveButton.Visible = false;
            // 
            // motherboardSelectButton
            // 
            this.motherboardSelectButton.BackColor = System.Drawing.Color.Green;
            this.motherboardSelectButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.motherboardSelectButton.Dock = System.Windows.Forms.DockStyle.Right;
            this.motherboardSelectButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.motherboardSelectButton.ForeColor = System.Drawing.Color.White;
            this.motherboardSelectButton.Location = new System.Drawing.Point(909, 58);
            this.motherboardSelectButton.Name = "motherboardSelectButton";
            this.motherboardSelectButton.Size = new System.Drawing.Size(47, 29);
            this.motherboardSelectButton.TabIndex = 0;
            this.motherboardSelectButton.Text = "Seç...";
            this.motherboardSelectButton.UseVisualStyleBackColor = false;
            // 
            // motherboardNameLabel
            // 
            this.motherboardNameLabel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.motherboardNameLabel.Dock = System.Windows.Forms.DockStyle.Top;
            this.motherboardNameLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.motherboardNameLabel.ForeColor = System.Drawing.Color.Green;
            this.motherboardNameLabel.Location = new System.Drawing.Point(72, 23);
            this.motherboardNameLabel.Name = "motherboardNameLabel";
            this.motherboardNameLabel.Padding = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.motherboardNameLabel.Size = new System.Drawing.Size(884, 35);
            this.motherboardNameLabel.TabIndex = 2;
            this.motherboardNameLabel.Text = "Bir anakart seçin...";
            this.motherboardNameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // motherboardImageBox
            // 
            this.motherboardImageBox.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.motherboardImageBox.Dock = System.Windows.Forms.DockStyle.Left;
            this.motherboardImageBox.Image = ((System.Drawing.Image)(resources.GetObject("motherboardImageBox.Image")));
            this.motherboardImageBox.Location = new System.Drawing.Point(8, 23);
            this.motherboardImageBox.Name = "motherboardImageBox";
            this.motherboardImageBox.Size = new System.Drawing.Size(64, 64);
            this.motherboardImageBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.motherboardImageBox.TabIndex = 4;
            this.motherboardImageBox.TabStop = false;
            // 
            // compabilityBox
            // 
            this.compabilityBox.BackColor = System.Drawing.SystemColors.Control;
            this.compabilityBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.compabilityBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.compabilityBox.FormattingEnabled = true;
            this.compabilityBox.Location = new System.Drawing.Point(10, 10);
            this.compabilityBox.Name = "compabilityBox";
            this.compabilityBox.SelectionMode = System.Windows.Forms.SelectionMode.None;
            this.compabilityBox.Size = new System.Drawing.Size(964, 105);
            this.compabilityBox.TabIndex = 8;
            // 
            // BuildView
            // 
            this.AcceptButton = this.acceptButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.cancelButton;
            this.ClientSize = new System.Drawing.Size(984, 561);
            this.Controls.Add(this.container);
            this.Controls.Add(this.controlPanel);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(1000, 600);
            this.Name = "BuildView";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Bilgisayar";
            this.controlPanel.ResumeLayout(false);
            this.controlPanel.PerformLayout();
            this.container.Panel1.ResumeLayout(false);
            this.container.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.container)).EndInit();
            this.container.ResumeLayout(false);
            this.memoriesPanel.ResumeLayout(false);
            this.memoryBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.memoryImageBox)).EndInit();
            this.memoryNavigationPanel.ResumeLayout(false);
            this.graphicsCardBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.graphicsCardImageBox)).EndInit();
            this.processorBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.processorImageBox)).EndInit();
            this.motherboardBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.motherboardImageBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel controlPanel;
        private System.Windows.Forms.Button acceptButton;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.TextBox nameBox;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.Label totalLabel;
        private System.Windows.Forms.SplitContainer container;
        private System.Windows.Forms.Panel memoriesPanel;
        private System.Windows.Forms.GroupBox memoryBox;
        private System.Windows.Forms.Label memoryPriceLabel;
        private System.Windows.Forms.Button memoryRemoveButton;
        private System.Windows.Forms.Button memorySelectButton;
        private System.Windows.Forms.Label memoryNameLabel;
        private System.Windows.Forms.PictureBox memoryImageBox;
        private System.Windows.Forms.Panel memoryNavigationPanel;
        private System.Windows.Forms.Label memoryLabel;
        private System.Windows.Forms.Button nextMemoryButton;
        private System.Windows.Forms.Button previousMemoryButton;
        private System.Windows.Forms.GroupBox graphicsCardBox;
        private System.Windows.Forms.Label graphicsCardPriceLabel;
        private System.Windows.Forms.Button graphicsCardRemoveButton;
        private System.Windows.Forms.Button graphicsCardSelectButton;
        private System.Windows.Forms.Label graphicsCardNameLabel;
        private System.Windows.Forms.PictureBox graphicsCardImageBox;
        private System.Windows.Forms.GroupBox processorBox;
        private System.Windows.Forms.Label processorPriceLabel;
        private System.Windows.Forms.Button processorRemoveButton;
        private System.Windows.Forms.Button processorSelectButton;
        private System.Windows.Forms.Label processorNameLabel;
        private System.Windows.Forms.PictureBox processorImageBox;
        private System.Windows.Forms.GroupBox motherboardBox;
        private System.Windows.Forms.Label motherboardPriceLabel;
        private System.Windows.Forms.Button motherboardRemoveButton;
        private System.Windows.Forms.Button motherboardSelectButton;
        private System.Windows.Forms.Label motherboardNameLabel;
        private System.Windows.Forms.PictureBox motherboardImageBox;
        private System.Windows.Forms.ListBox compabilityBox;
    }
}