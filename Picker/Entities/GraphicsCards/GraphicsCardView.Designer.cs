namespace Picker
{
    partial class GraphicsCardView
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GraphicsCardView));
            this.controlPanel = new System.Windows.Forms.Panel();
            this.cancelButton = new System.Windows.Forms.Button();
            this.acceptButton = new System.Windows.Forms.Button();
            this.entityPanel = new System.Windows.Forms.Panel();
            this.label17 = new System.Windows.Forms.Label();
            this.memoryBox = new System.Windows.Forms.NumericUpDown();
            this.label16 = new System.Windows.Forms.Label();
            this.bandwidthLabel = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.turboFrequencyBox = new System.Windows.Forms.NumericUpDown();
            this.label13 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.frequencyBox = new System.Windows.Forms.NumericUpDown();
            this.label11 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.memoryFrequencyBox = new System.Windows.Forms.NumericUpDown();
            this.label7 = new System.Windows.Forms.Label();
            this.busWidthBox = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.chipsetModelBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.chipsetBrandButton = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.priceBox = new System.Windows.Forms.NumericUpDown();
            this.memoryTypeBox = new System.Windows.Forms.ComboBox();
            this.brandButton = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.modelBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.imageBox = new System.Windows.Forms.PictureBox();
            this.selectImageButton = new System.Windows.Forms.Button();
            this.deleteImageButton = new System.Windows.Forms.Button();
            this.imagePanel = new System.Windows.Forms.GroupBox();
            this.controlPanel.SuspendLayout();
            this.entityPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.memoryBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.turboFrequencyBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.frequencyBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.memoryFrequencyBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.busWidthBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.priceBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageBox)).BeginInit();
            this.imagePanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // controlPanel
            // 
            this.controlPanel.Controls.Add(this.cancelButton);
            this.controlPanel.Controls.Add(this.acceptButton);
            this.controlPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.controlPanel.Location = new System.Drawing.Point(0, 203);
            this.controlPanel.Name = "controlPanel";
            this.controlPanel.Size = new System.Drawing.Size(575, 32);
            this.controlPanel.TabIndex = 2;
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
            this.acceptButton.Location = new System.Drawing.Point(486, 0);
            this.acceptButton.Name = "acceptButton";
            this.acceptButton.Size = new System.Drawing.Size(89, 32);
            this.acceptButton.TabIndex = 0;
            this.acceptButton.Text = "Tamam";
            this.acceptButton.UseVisualStyleBackColor = false;
            this.acceptButton.Click += new System.EventHandler(this.acceptButton_Click);
            // 
            // entityPanel
            // 
            this.entityPanel.Controls.Add(this.label17);
            this.entityPanel.Controls.Add(this.memoryBox);
            this.entityPanel.Controls.Add(this.label16);
            this.entityPanel.Controls.Add(this.bandwidthLabel);
            this.entityPanel.Controls.Add(this.label12);
            this.entityPanel.Controls.Add(this.turboFrequencyBox);
            this.entityPanel.Controls.Add(this.label13);
            this.entityPanel.Controls.Add(this.label10);
            this.entityPanel.Controls.Add(this.frequencyBox);
            this.entityPanel.Controls.Add(this.label11);
            this.entityPanel.Controls.Add(this.label9);
            this.entityPanel.Controls.Add(this.label8);
            this.entityPanel.Controls.Add(this.memoryFrequencyBox);
            this.entityPanel.Controls.Add(this.label7);
            this.entityPanel.Controls.Add(this.busWidthBox);
            this.entityPanel.Controls.Add(this.label6);
            this.entityPanel.Controls.Add(this.chipsetModelBox);
            this.entityPanel.Controls.Add(this.label5);
            this.entityPanel.Controls.Add(this.chipsetBrandButton);
            this.entityPanel.Controls.Add(this.label4);
            this.entityPanel.Controls.Add(this.priceBox);
            this.entityPanel.Controls.Add(this.memoryTypeBox);
            this.entityPanel.Controls.Add(this.brandButton);
            this.entityPanel.Controls.Add(this.label3);
            this.entityPanel.Controls.Add(this.label2);
            this.entityPanel.Controls.Add(this.modelBox);
            this.entityPanel.Controls.Add(this.label1);
            this.entityPanel.Controls.Add(this.label15);
            this.entityPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.entityPanel.Location = new System.Drawing.Point(76, 0);
            this.entityPanel.Name = "entityPanel";
            this.entityPanel.Size = new System.Drawing.Size(499, 203);
            this.entityPanel.TabIndex = 0;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.label17.Location = new System.Drawing.Point(281, 111);
            this.label17.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(21, 13);
            this.label17.TabIndex = 14;
            this.label17.Text = "GB";
            // 
            // memoryBox
            // 
            this.memoryBox.Location = new System.Drawing.Point(241, 109);
            this.memoryBox.Maximum = new decimal(new int[] {
            999,
            0,
            0,
            0});
            this.memoryBox.Name = "memoryBox";
            this.memoryBox.Size = new System.Drawing.Size(40, 22);
            this.memoryBox.TabIndex = 13;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.label16.Location = new System.Drawing.Point(195, 111);
            this.label16.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(40, 13);
            this.label16.TabIndex = 12;
            this.label16.Text = "Bellek:";
            // 
            // bandwidthLabel
            // 
            this.bandwidthLabel.AutoSize = true;
            this.bandwidthLabel.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.bandwidthLabel.Location = new System.Drawing.Point(195, 173);
            this.bandwidthLabel.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.bandwidthLabel.Name = "bandwidthLabel";
            this.bandwidthLabel.Size = new System.Drawing.Size(116, 13);
            this.bandwidthLabel.TabIndex = 27;
            this.bandwidthLabel.Text = "Bant Genişliği: 0 GB/s";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.label12.Location = new System.Drawing.Point(386, 143);
            this.label12.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(30, 13);
            this.label12.TabIndex = 23;
            this.label12.Text = "MHz";
            // 
            // turboFrequencyBox
            // 
            this.turboFrequencyBox.Location = new System.Drawing.Point(336, 141);
            this.turboFrequencyBox.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.turboFrequencyBox.Name = "turboFrequencyBox";
            this.turboFrequencyBox.Size = new System.Drawing.Size(50, 22);
            this.turboFrequencyBox.TabIndex = 22;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.label13.Location = new System.Drawing.Point(195, 143);
            this.label13.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(135, 13);
            this.label13.TabIndex = 21;
            this.label13.Text = "Maksimum Çekirdek Hızı:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.label10.Location = new System.Drawing.Point(139, 143);
            this.label10.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(30, 13);
            this.label10.TabIndex = 20;
            this.label10.Text = "MHz";
            // 
            // frequencyBox
            // 
            this.frequencyBox.Location = new System.Drawing.Point(89, 141);
            this.frequencyBox.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.frequencyBox.Name = "frequencyBox";
            this.frequencyBox.Size = new System.Drawing.Size(50, 22);
            this.frequencyBox.TabIndex = 19;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.label11.Location = new System.Drawing.Point(6, 143);
            this.label11.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(77, 13);
            this.label11.TabIndex = 18;
            this.label11.Text = "Çekirdek Hızı:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.label9.Location = new System.Drawing.Point(162, 173);
            this.label9.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(20, 13);
            this.label9.TabIndex = 26;
            this.label9.Text = "Bit";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.label8.Location = new System.Drawing.Point(456, 111);
            this.label8.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(30, 13);
            this.label8.TabIndex = 17;
            this.label8.Text = "MHz";
            // 
            // memoryFrequencyBox
            // 
            this.memoryFrequencyBox.Location = new System.Drawing.Point(406, 109);
            this.memoryFrequencyBox.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.memoryFrequencyBox.Name = "memoryFrequencyBox";
            this.memoryFrequencyBox.Size = new System.Drawing.Size(50, 22);
            this.memoryFrequencyBox.TabIndex = 16;
            this.memoryFrequencyBox.ValueChanged += new System.EventHandler(this.bandwidth_Changed);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.label7.Location = new System.Drawing.Point(341, 111);
            this.label7.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(62, 13);
            this.label7.TabIndex = 15;
            this.label7.Text = "Bellek Hızı:";
            // 
            // busWidthBox
            // 
            this.busWidthBox.Location = new System.Drawing.Point(110, 171);
            this.busWidthBox.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.busWidthBox.Name = "busWidthBox";
            this.busWidthBox.Size = new System.Drawing.Size(50, 22);
            this.busWidthBox.TabIndex = 25;
            this.busWidthBox.ValueChanged += new System.EventHandler(this.bandwidth_Changed);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.label6.Location = new System.Drawing.Point(6, 173);
            this.label6.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(101, 13);
            this.label6.TabIndex = 24;
            this.label6.Text = "Veri Yolu Genişliği:";
            // 
            // chipsetModelBox
            // 
            this.chipsetModelBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.chipsetModelBox.Location = new System.Drawing.Point(323, 76);
            this.chipsetModelBox.Name = "chipsetModelBox";
            this.chipsetModelBox.Size = new System.Drawing.Size(164, 22);
            this.chipsetModelBox.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.label5.Location = new System.Drawing.Point(215, 79);
            this.label5.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(102, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Yonga Seti Modeli:";
            // 
            // chipsetBrandButton
            // 
            this.chipsetBrandButton.BackColor = System.Drawing.Color.Green;
            this.chipsetBrandButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.chipsetBrandButton.FlatAppearance.BorderSize = 0;
            this.chipsetBrandButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.chipsetBrandButton.ForeColor = System.Drawing.Color.White;
            this.chipsetBrandButton.Location = new System.Drawing.Point(118, 74);
            this.chipsetBrandButton.Name = "chipsetBrandButton";
            this.chipsetBrandButton.Size = new System.Drawing.Size(91, 23);
            this.chipsetBrandButton.TabIndex = 7;
            this.chipsetBrandButton.Text = "Marka Seç...";
            this.chipsetBrandButton.UseVisualStyleBackColor = false;
            this.chipsetBrandButton.Click += new System.EventHandler(this.chipsetBrandButton_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.label4.Location = new System.Drawing.Point(6, 79);
            this.label4.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(106, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Yonga Seti Markası:";
            // 
            // priceBox
            // 
            this.priceBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.priceBox.DecimalPlaces = 2;
            this.priceBox.Location = new System.Drawing.Point(411, 43);
            this.priceBox.Maximum = new decimal(new int[] {
            9999999,
            0,
            0,
            131072});
            this.priceBox.Name = "priceBox";
            this.priceBox.Size = new System.Drawing.Size(76, 22);
            this.priceBox.TabIndex = 5;
            this.priceBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.priceBox.UpDownAlign = System.Windows.Forms.LeftRightAlignment.Left;
            // 
            // memoryTypeBox
            // 
            this.memoryTypeBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.memoryTypeBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.memoryTypeBox.FormattingEnabled = true;
            this.memoryTypeBox.Items.AddRange(new object[] {
            "HBM",
            "HBM2",
            "DDR",
            "DDR2",
            "DDR3",
            "DDR4",
            "GDDR",
            "GDDR2",
            "GDDR3",
            "GDDR4",
            "GDDR5",
            "GDDR5X",
            "GDDR6"});
            this.memoryTypeBox.Location = new System.Drawing.Point(74, 108);
            this.memoryTypeBox.Name = "memoryTypeBox";
            this.memoryTypeBox.Size = new System.Drawing.Size(66, 21);
            this.memoryTypeBox.TabIndex = 11;
            this.memoryTypeBox.TextChanged += new System.EventHandler(this.bandwidth_Changed);
            // 
            // brandButton
            // 
            this.brandButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.brandButton.BackColor = System.Drawing.Color.Green;
            this.brandButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.brandButton.FlatAppearance.BorderSize = 0;
            this.brandButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.brandButton.ForeColor = System.Drawing.Color.White;
            this.brandButton.Location = new System.Drawing.Point(54, 42);
            this.brandButton.Name = "brandButton";
            this.brandButton.Size = new System.Drawing.Size(302, 23);
            this.brandButton.TabIndex = 3;
            this.brandButton.Text = "Marka Seç...";
            this.brandButton.UseVisualStyleBackColor = false;
            this.brandButton.Click += new System.EventHandler(this.brandButton_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.label3.Location = new System.Drawing.Point(6, 111);
            this.label3.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Bellek Tipi:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.label2.Location = new System.Drawing.Point(6, 47);
            this.label2.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Marka:";
            // 
            // modelBox
            // 
            this.modelBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.modelBox.Location = new System.Drawing.Point(54, 12);
            this.modelBox.Name = "modelBox";
            this.modelBox.Size = new System.Drawing.Size(433, 22);
            this.modelBox.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.label1.Location = new System.Drawing.Point(6, 15);
            this.label1.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Model:";
            // 
            // label15
            // 
            this.label15.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.label15.Location = new System.Drawing.Point(362, 47);
            this.label15.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(43, 13);
            this.label15.TabIndex = 4;
            this.label15.Text = "Fiyat: $";
            // 
            // imageBox
            // 
            this.imageBox.Dock = System.Windows.Forms.DockStyle.Top;
            this.imageBox.InitialImage = null;
            this.imageBox.Location = new System.Drawing.Point(6, 18);
            this.imageBox.Name = "imageBox";
            this.imageBox.Size = new System.Drawing.Size(64, 64);
            this.imageBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.imageBox.TabIndex = 5;
            this.imageBox.TabStop = false;
            // 
            // selectImageButton
            // 
            this.selectImageButton.BackColor = System.Drawing.Color.Green;
            this.selectImageButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.selectImageButton.FlatAppearance.BorderSize = 0;
            this.selectImageButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.selectImageButton.ForeColor = System.Drawing.Color.White;
            this.selectImageButton.Location = new System.Drawing.Point(6, 82);
            this.selectImageButton.Name = "selectImageButton";
            this.selectImageButton.Size = new System.Drawing.Size(64, 22);
            this.selectImageButton.TabIndex = 0;
            this.selectImageButton.Text = "Seç...";
            this.selectImageButton.UseVisualStyleBackColor = false;
            this.selectImageButton.Click += new System.EventHandler(this.selectImageButton_Click);
            // 
            // deleteImageButton
            // 
            this.deleteImageButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.deleteImageButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.deleteImageButton.FlatAppearance.BorderSize = 0;
            this.deleteImageButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.deleteImageButton.ForeColor = System.Drawing.Color.White;
            this.deleteImageButton.Location = new System.Drawing.Point(6, 104);
            this.deleteImageButton.Name = "deleteImageButton";
            this.deleteImageButton.Size = new System.Drawing.Size(64, 22);
            this.deleteImageButton.TabIndex = 1;
            this.deleteImageButton.Text = "Sil";
            this.deleteImageButton.UseVisualStyleBackColor = false;
            this.deleteImageButton.Click += new System.EventHandler(this.deleteImageButton_Click);
            // 
            // imagePanel
            // 
            this.imagePanel.Controls.Add(this.deleteImageButton);
            this.imagePanel.Controls.Add(this.selectImageButton);
            this.imagePanel.Controls.Add(this.imageBox);
            this.imagePanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.imagePanel.Location = new System.Drawing.Point(0, 0);
            this.imagePanel.Name = "imagePanel";
            this.imagePanel.Padding = new System.Windows.Forms.Padding(6, 3, 6, 3);
            this.imagePanel.Size = new System.Drawing.Size(76, 203);
            this.imagePanel.TabIndex = 1;
            this.imagePanel.TabStop = false;
            this.imagePanel.Text = "Resim";
            // 
            // GraphicsCardView
            // 
            this.AcceptButton = this.acceptButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.cancelButton;
            this.ClientSize = new System.Drawing.Size(575, 235);
            this.Controls.Add(this.entityPanel);
            this.Controls.Add(this.imagePanel);
            this.Controls.Add(this.controlPanel);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "GraphicsCardView";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ekran Kartı";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.GraphicsCardView_FormClosed);
            this.Load += new System.EventHandler(this.GraphicsCardView_Load);
            this.controlPanel.ResumeLayout(false);
            this.entityPanel.ResumeLayout(false);
            this.entityPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.memoryBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.turboFrequencyBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.frequencyBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.memoryFrequencyBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.busWidthBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.priceBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageBox)).EndInit();
            this.imagePanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel controlPanel;
        private System.Windows.Forms.Button acceptButton;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.Panel entityPanel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox modelBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button brandButton;
        private System.Windows.Forms.PictureBox imageBox;
        private System.Windows.Forms.Button selectImageButton;
        private System.Windows.Forms.Button deleteImageButton;
        private System.Windows.Forms.GroupBox imagePanel;
        private System.Windows.Forms.ComboBox memoryTypeBox;
        private System.Windows.Forms.NumericUpDown priceBox;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox chipsetModelBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button chipsetBrandButton;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown busWidthBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.NumericUpDown memoryFrequencyBox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.NumericUpDown frequencyBox;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label bandwidthLabel;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.NumericUpDown turboFrequencyBox;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.NumericUpDown memoryBox;
    }
}