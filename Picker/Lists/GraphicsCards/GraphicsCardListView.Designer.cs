namespace Picker
{
    partial class GraphicsCardListView
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GraphicsCardListView));
            this.filterPanel = new System.Windows.Forms.Panel();
            this.filterGroup = new System.Windows.Forms.GroupBox();
            this.maxTurboFrequencyBox = new System.Windows.Forms.NumericUpDown();
            this.enableMaxTurboFrequencyBox = new System.Windows.Forms.CheckBox();
            this.minTurboFrequencyBox = new System.Windows.Forms.NumericUpDown();
            this.enableMinTurboFrequencyBox = new System.Windows.Forms.CheckBox();
            this.label13 = new System.Windows.Forms.Label();
            this.maxFrequencyBox = new System.Windows.Forms.NumericUpDown();
            this.enableMaxFrequencyBox = new System.Windows.Forms.CheckBox();
            this.minFrequencyBox = new System.Windows.Forms.NumericUpDown();
            this.enableMinFrequencyBox = new System.Windows.Forms.CheckBox();
            this.label12 = new System.Windows.Forms.Label();
            this.maxBusWidthBox = new System.Windows.Forms.NumericUpDown();
            this.enableMaxBusWidthBox = new System.Windows.Forms.CheckBox();
            this.minBusWidthBox = new System.Windows.Forms.NumericUpDown();
            this.enableMinBusWidthBox = new System.Windows.Forms.CheckBox();
            this.label11 = new System.Windows.Forms.Label();
            this.chipsetModelBox = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.chipsetBrandBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.memoryTypeBox = new System.Windows.Forms.ComboBox();
            this.compatiblesBox = new System.Windows.Forms.CheckBox();
            this.clearFilterButton = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.maxMemoryBox = new System.Windows.Forms.NumericUpDown();
            this.enableMaxMemoryBox = new System.Windows.Forms.CheckBox();
            this.enableMinMemoryBox = new System.Windows.Forms.CheckBox();
            this.minMemoryBox = new System.Windows.Forms.NumericUpDown();
            this.maxMemoryFrequencyBox = new System.Windows.Forms.NumericUpDown();
            this.enableMaxMemoryFrequencyBox = new System.Windows.Forms.CheckBox();
            this.minMemoryFrequencyBox = new System.Windows.Forms.NumericUpDown();
            this.enableMinMemoryFrequencyBox = new System.Windows.Forms.CheckBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.maxPriceBox = new System.Windows.Forms.NumericUpDown();
            this.minPriceBox = new System.Windows.Forms.NumericUpDown();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.brandBox = new System.Windows.Forms.TextBox();
            this.nameBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.applyFilterButton = new System.Windows.Forms.Button();
            this.enableMaxPriceBox = new System.Windows.Forms.CheckBox();
            this.enableMinPriceBox = new System.Windows.Forms.CheckBox();
            this.orderGroup = new System.Windows.Forms.GroupBox();
            this.newButton = new System.Windows.Forms.Button();
            this.itemPerPageBox = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.orderBox = new System.Windows.Forms.ComboBox();
            this.controlPanel = new System.Windows.Forms.Panel();
            this.countLabel = new System.Windows.Forms.Label();
            this.mainButton = new System.Windows.Forms.Button();
            this.navigationPanel = new System.Windows.Forms.Panel();
            this.navigationSubPanel = new System.Windows.Forms.Panel();
            this.pageNumberBox = new System.Windows.Forms.NumericUpDown();
            this.nextPageButton = new System.Windows.Forms.Button();
            this.lastPageButton = new System.Windows.Forms.Button();
            this.previousPageButton = new System.Windows.Forms.Button();
            this.firstPageButton = new System.Windows.Forms.Button();
            this.pageCountLabel = new System.Windows.Forms.Label();
            this.listPanelBorder = new System.Windows.Forms.Panel();
            this.listPanel = new System.Windows.Forms.Panel();
            this.filterPanel.SuspendLayout();
            this.filterGroup.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.maxTurboFrequencyBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.minTurboFrequencyBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.maxFrequencyBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.minFrequencyBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.maxBusWidthBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.minBusWidthBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.maxMemoryBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.minMemoryBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.maxMemoryFrequencyBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.minMemoryFrequencyBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.maxPriceBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.minPriceBox)).BeginInit();
            this.orderGroup.SuspendLayout();
            this.controlPanel.SuspendLayout();
            this.navigationPanel.SuspendLayout();
            this.navigationSubPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pageNumberBox)).BeginInit();
            this.listPanelBorder.SuspendLayout();
            this.SuspendLayout();
            // 
            // filterPanel
            // 
            this.filterPanel.BackColor = System.Drawing.SystemColors.Control;
            this.filterPanel.Controls.Add(this.filterGroup);
            this.filterPanel.Controls.Add(this.orderGroup);
            this.filterPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.filterPanel.Location = new System.Drawing.Point(0, 0);
            this.filterPanel.Name = "filterPanel";
            this.filterPanel.Size = new System.Drawing.Size(1264, 145);
            this.filterPanel.TabIndex = 0;
            // 
            // filterGroup
            // 
            this.filterGroup.Controls.Add(this.maxTurboFrequencyBox);
            this.filterGroup.Controls.Add(this.enableMaxTurboFrequencyBox);
            this.filterGroup.Controls.Add(this.minTurboFrequencyBox);
            this.filterGroup.Controls.Add(this.enableMinTurboFrequencyBox);
            this.filterGroup.Controls.Add(this.label13);
            this.filterGroup.Controls.Add(this.maxFrequencyBox);
            this.filterGroup.Controls.Add(this.enableMaxFrequencyBox);
            this.filterGroup.Controls.Add(this.minFrequencyBox);
            this.filterGroup.Controls.Add(this.enableMinFrequencyBox);
            this.filterGroup.Controls.Add(this.label12);
            this.filterGroup.Controls.Add(this.maxBusWidthBox);
            this.filterGroup.Controls.Add(this.enableMaxBusWidthBox);
            this.filterGroup.Controls.Add(this.minBusWidthBox);
            this.filterGroup.Controls.Add(this.enableMinBusWidthBox);
            this.filterGroup.Controls.Add(this.label11);
            this.filterGroup.Controls.Add(this.chipsetModelBox);
            this.filterGroup.Controls.Add(this.label10);
            this.filterGroup.Controls.Add(this.chipsetBrandBox);
            this.filterGroup.Controls.Add(this.label2);
            this.filterGroup.Controls.Add(this.memoryTypeBox);
            this.filterGroup.Controls.Add(this.compatiblesBox);
            this.filterGroup.Controls.Add(this.clearFilterButton);
            this.filterGroup.Controls.Add(this.label9);
            this.filterGroup.Controls.Add(this.maxMemoryBox);
            this.filterGroup.Controls.Add(this.enableMaxMemoryBox);
            this.filterGroup.Controls.Add(this.enableMinMemoryBox);
            this.filterGroup.Controls.Add(this.minMemoryBox);
            this.filterGroup.Controls.Add(this.maxMemoryFrequencyBox);
            this.filterGroup.Controls.Add(this.enableMaxMemoryFrequencyBox);
            this.filterGroup.Controls.Add(this.minMemoryFrequencyBox);
            this.filterGroup.Controls.Add(this.enableMinMemoryFrequencyBox);
            this.filterGroup.Controls.Add(this.label8);
            this.filterGroup.Controls.Add(this.label3);
            this.filterGroup.Controls.Add(this.maxPriceBox);
            this.filterGroup.Controls.Add(this.minPriceBox);
            this.filterGroup.Controls.Add(this.label7);
            this.filterGroup.Controls.Add(this.label6);
            this.filterGroup.Controls.Add(this.brandBox);
            this.filterGroup.Controls.Add(this.nameBox);
            this.filterGroup.Controls.Add(this.label1);
            this.filterGroup.Controls.Add(this.applyFilterButton);
            this.filterGroup.Controls.Add(this.enableMaxPriceBox);
            this.filterGroup.Controls.Add(this.enableMinPriceBox);
            this.filterGroup.Dock = System.Windows.Forms.DockStyle.Fill;
            this.filterGroup.Location = new System.Drawing.Point(0, 0);
            this.filterGroup.Name = "filterGroup";
            this.filterGroup.Size = new System.Drawing.Size(1038, 145);
            this.filterGroup.TabIndex = 0;
            this.filterGroup.TabStop = false;
            this.filterGroup.Text = "Filtrele";
            // 
            // maxTurboFrequencyBox
            // 
            this.maxTurboFrequencyBox.Enabled = false;
            this.maxTurboFrequencyBox.Location = new System.Drawing.Point(570, 86);
            this.maxTurboFrequencyBox.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.maxTurboFrequencyBox.Name = "maxTurboFrequencyBox";
            this.maxTurboFrequencyBox.Size = new System.Drawing.Size(46, 22);
            this.maxTurboFrequencyBox.TabIndex = 37;
            // 
            // enableMaxTurboFrequencyBox
            // 
            this.enableMaxTurboFrequencyBox.AutoSize = true;
            this.enableMaxTurboFrequencyBox.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.enableMaxTurboFrequencyBox.Location = new System.Drawing.Point(540, 89);
            this.enableMaxTurboFrequencyBox.Name = "enableMaxTurboFrequencyBox";
            this.enableMaxTurboFrequencyBox.Size = new System.Drawing.Size(30, 17);
            this.enableMaxTurboFrequencyBox.TabIndex = 36;
            this.enableMaxTurboFrequencyBox.Text = "-";
            this.enableMaxTurboFrequencyBox.UseVisualStyleBackColor = true;
            this.enableMaxTurboFrequencyBox.CheckedChanged += new System.EventHandler(this.enableMaxTurboFrequencyBox_CheckedChanged);
            // 
            // minTurboFrequencyBox
            // 
            this.minTurboFrequencyBox.Enabled = false;
            this.minTurboFrequencyBox.Location = new System.Drawing.Point(494, 86);
            this.minTurboFrequencyBox.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.minTurboFrequencyBox.Name = "minTurboFrequencyBox";
            this.minTurboFrequencyBox.Size = new System.Drawing.Size(46, 22);
            this.minTurboFrequencyBox.TabIndex = 35;
            // 
            // enableMinTurboFrequencyBox
            // 
            this.enableMinTurboFrequencyBox.AutoSize = true;
            this.enableMinTurboFrequencyBox.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.enableMinTurboFrequencyBox.Location = new System.Drawing.Point(479, 90);
            this.enableMinTurboFrequencyBox.Name = "enableMinTurboFrequencyBox";
            this.enableMinTurboFrequencyBox.Size = new System.Drawing.Size(15, 14);
            this.enableMinTurboFrequencyBox.TabIndex = 34;
            this.enableMinTurboFrequencyBox.UseVisualStyleBackColor = true;
            this.enableMinTurboFrequencyBox.CheckedChanged += new System.EventHandler(this.enableMinTurboFrequencyBox_CheckedChanged);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(306, 89);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(167, 13);
            this.label13.TabIndex = 33;
            this.label13.Text = "Maksimum Çekirdek Hızı (MHz):";
            this.label13.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // maxFrequencyBox
            // 
            this.maxFrequencyBox.Enabled = false;
            this.maxFrequencyBox.Location = new System.Drawing.Point(218, 86);
            this.maxFrequencyBox.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.maxFrequencyBox.Name = "maxFrequencyBox";
            this.maxFrequencyBox.Size = new System.Drawing.Size(46, 22);
            this.maxFrequencyBox.TabIndex = 32;
            // 
            // enableMaxFrequencyBox
            // 
            this.enableMaxFrequencyBox.AutoSize = true;
            this.enableMaxFrequencyBox.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.enableMaxFrequencyBox.Location = new System.Drawing.Point(188, 89);
            this.enableMaxFrequencyBox.Name = "enableMaxFrequencyBox";
            this.enableMaxFrequencyBox.Size = new System.Drawing.Size(30, 17);
            this.enableMaxFrequencyBox.TabIndex = 31;
            this.enableMaxFrequencyBox.Text = "-";
            this.enableMaxFrequencyBox.UseVisualStyleBackColor = true;
            this.enableMaxFrequencyBox.CheckedChanged += new System.EventHandler(this.enableMaxFrequencyBox_CheckedChanged);
            // 
            // minFrequencyBox
            // 
            this.minFrequencyBox.Enabled = false;
            this.minFrequencyBox.Location = new System.Drawing.Point(142, 86);
            this.minFrequencyBox.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.minFrequencyBox.Name = "minFrequencyBox";
            this.minFrequencyBox.Size = new System.Drawing.Size(46, 22);
            this.minFrequencyBox.TabIndex = 30;
            // 
            // enableMinFrequencyBox
            // 
            this.enableMinFrequencyBox.AutoSize = true;
            this.enableMinFrequencyBox.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.enableMinFrequencyBox.Location = new System.Drawing.Point(127, 90);
            this.enableMinFrequencyBox.Name = "enableMinFrequencyBox";
            this.enableMinFrequencyBox.Size = new System.Drawing.Size(15, 14);
            this.enableMinFrequencyBox.TabIndex = 29;
            this.enableMinFrequencyBox.UseVisualStyleBackColor = true;
            this.enableMinFrequencyBox.CheckedChanged += new System.EventHandler(this.enableMinFrequencyBox_CheckedChanged);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(12, 89);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(109, 13);
            this.label12.TabIndex = 28;
            this.label12.Text = "Çekirdek Hızı (MHz):";
            this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // maxBusWidthBox
            // 
            this.maxBusWidthBox.Enabled = false;
            this.maxBusWidthBox.Location = new System.Drawing.Point(859, 52);
            this.maxBusWidthBox.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.maxBusWidthBox.Name = "maxBusWidthBox";
            this.maxBusWidthBox.Size = new System.Drawing.Size(46, 22);
            this.maxBusWidthBox.TabIndex = 27;
            // 
            // enableMaxBusWidthBox
            // 
            this.enableMaxBusWidthBox.AutoSize = true;
            this.enableMaxBusWidthBox.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.enableMaxBusWidthBox.Location = new System.Drawing.Point(829, 55);
            this.enableMaxBusWidthBox.Name = "enableMaxBusWidthBox";
            this.enableMaxBusWidthBox.Size = new System.Drawing.Size(30, 17);
            this.enableMaxBusWidthBox.TabIndex = 26;
            this.enableMaxBusWidthBox.Text = "-";
            this.enableMaxBusWidthBox.UseVisualStyleBackColor = true;
            this.enableMaxBusWidthBox.CheckedChanged += new System.EventHandler(this.enableMaxBusWidthBox_CheckedChanged);
            // 
            // minBusWidthBox
            // 
            this.minBusWidthBox.Enabled = false;
            this.minBusWidthBox.Location = new System.Drawing.Point(783, 52);
            this.minBusWidthBox.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.minBusWidthBox.Name = "minBusWidthBox";
            this.minBusWidthBox.Size = new System.Drawing.Size(46, 22);
            this.minBusWidthBox.TabIndex = 25;
            // 
            // enableMinBusWidthBox
            // 
            this.enableMinBusWidthBox.AutoSize = true;
            this.enableMinBusWidthBox.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.enableMinBusWidthBox.Location = new System.Drawing.Point(768, 56);
            this.enableMinBusWidthBox.Name = "enableMinBusWidthBox";
            this.enableMinBusWidthBox.Size = new System.Drawing.Size(15, 14);
            this.enableMinBusWidthBox.TabIndex = 24;
            this.enableMinBusWidthBox.UseVisualStyleBackColor = true;
            this.enableMinBusWidthBox.CheckedChanged += new System.EventHandler(this.enableMinBusWidthBox_CheckedChanged);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(639, 56);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(123, 13);
            this.label11.TabIndex = 23;
            this.label11.Text = "Veri Yolu Genişliği (Bit):";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // chipsetModelBox
            // 
            this.chipsetModelBox.Location = new System.Drawing.Point(607, 19);
            this.chipsetModelBox.Name = "chipsetModelBox";
            this.chipsetModelBox.Size = new System.Drawing.Size(164, 22);
            this.chipsetModelBox.TabIndex = 5;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(499, 23);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(102, 13);
            this.label10.TabIndex = 4;
            this.label10.Text = "Yonga Seti Modeli:";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // chipsetBrandBox
            // 
            this.chipsetBrandBox.Location = new System.Drawing.Point(317, 19);
            this.chipsetBrandBox.Name = "chipsetBrandBox";
            this.chipsetBrandBox.Size = new System.Drawing.Size(164, 22);
            this.chipsetBrandBox.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(248, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Yonga Seti:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
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
            this.memoryTypeBox.Location = new System.Drawing.Point(80, 52);
            this.memoryTypeBox.Name = "memoryTypeBox";
            this.memoryTypeBox.Size = new System.Drawing.Size(66, 21);
            this.memoryTypeBox.TabIndex = 12;
            // 
            // compatiblesBox
            // 
            this.compatiblesBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.compatiblesBox.AutoSize = true;
            this.compatiblesBox.Location = new System.Drawing.Point(883, 119);
            this.compatiblesBox.Name = "compatiblesBox";
            this.compatiblesBox.Size = new System.Drawing.Size(149, 17);
            this.compatiblesBox.TabIndex = 47;
            this.compatiblesBox.Text = "Uyumsuz parçaları gizle.";
            this.compatiblesBox.UseVisualStyleBackColor = true;
            this.compatiblesBox.CheckedChanged += new System.EventHandler(this.GenerateListAsyncEvent);
            // 
            // clearFilterButton
            // 
            this.clearFilterButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.clearFilterButton.Location = new System.Drawing.Point(421, 117);
            this.clearFilterButton.Name = "clearFilterButton";
            this.clearFilterButton.Size = new System.Drawing.Size(91, 22);
            this.clearFilterButton.TabIndex = 46;
            this.clearFilterButton.Text = "Filtreyi Temizle";
            this.clearFilterButton.UseVisualStyleBackColor = true;
            this.clearFilterButton.Click += new System.EventHandler(this.clearFilterButton_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(165, 56);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(63, 13);
            this.label9.TabIndex = 13;
            this.label9.Text = "Bellek (GB):";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // maxMemoryBox
            // 
            this.maxMemoryBox.Enabled = false;
            this.maxMemoryBox.Location = new System.Drawing.Point(318, 52);
            this.maxMemoryBox.Maximum = new decimal(new int[] {
            999,
            0,
            0,
            0});
            this.maxMemoryBox.Name = "maxMemoryBox";
            this.maxMemoryBox.Size = new System.Drawing.Size(40, 22);
            this.maxMemoryBox.TabIndex = 17;
            // 
            // enableMaxMemoryBox
            // 
            this.enableMaxMemoryBox.AutoSize = true;
            this.enableMaxMemoryBox.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.enableMaxMemoryBox.Location = new System.Drawing.Point(288, 55);
            this.enableMaxMemoryBox.Name = "enableMaxMemoryBox";
            this.enableMaxMemoryBox.Size = new System.Drawing.Size(30, 17);
            this.enableMaxMemoryBox.TabIndex = 16;
            this.enableMaxMemoryBox.Text = "-";
            this.enableMaxMemoryBox.UseVisualStyleBackColor = true;
            this.enableMaxMemoryBox.CheckedChanged += new System.EventHandler(this.enableMaxMemoryBox_CheckedChanged);
            // 
            // enableMinMemoryBox
            // 
            this.enableMinMemoryBox.AutoSize = true;
            this.enableMinMemoryBox.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.enableMinMemoryBox.Location = new System.Drawing.Point(233, 56);
            this.enableMinMemoryBox.Name = "enableMinMemoryBox";
            this.enableMinMemoryBox.Size = new System.Drawing.Size(15, 14);
            this.enableMinMemoryBox.TabIndex = 14;
            this.enableMinMemoryBox.UseVisualStyleBackColor = true;
            this.enableMinMemoryBox.CheckedChanged += new System.EventHandler(this.enableMinMemoryBox_CheckedChanged);
            // 
            // minMemoryBox
            // 
            this.minMemoryBox.Enabled = false;
            this.minMemoryBox.Location = new System.Drawing.Point(248, 52);
            this.minMemoryBox.Maximum = new decimal(new int[] {
            999,
            0,
            0,
            0});
            this.minMemoryBox.Name = "minMemoryBox";
            this.minMemoryBox.Size = new System.Drawing.Size(40, 22);
            this.minMemoryBox.TabIndex = 15;
            // 
            // maxMemoryFrequencyBox
            // 
            this.maxMemoryFrequencyBox.Enabled = false;
            this.maxMemoryFrequencyBox.Location = new System.Drawing.Point(570, 52);
            this.maxMemoryFrequencyBox.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.maxMemoryFrequencyBox.Name = "maxMemoryFrequencyBox";
            this.maxMemoryFrequencyBox.Size = new System.Drawing.Size(46, 22);
            this.maxMemoryFrequencyBox.TabIndex = 22;
            // 
            // enableMaxMemoryFrequencyBox
            // 
            this.enableMaxMemoryFrequencyBox.AutoSize = true;
            this.enableMaxMemoryFrequencyBox.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.enableMaxMemoryFrequencyBox.Location = new System.Drawing.Point(540, 55);
            this.enableMaxMemoryFrequencyBox.Name = "enableMaxMemoryFrequencyBox";
            this.enableMaxMemoryFrequencyBox.Size = new System.Drawing.Size(30, 17);
            this.enableMaxMemoryFrequencyBox.TabIndex = 21;
            this.enableMaxMemoryFrequencyBox.Text = "-";
            this.enableMaxMemoryFrequencyBox.UseVisualStyleBackColor = true;
            this.enableMaxMemoryFrequencyBox.CheckedChanged += new System.EventHandler(this.enableMaxMemoryFrequencyBox_CheckedChanged);
            // 
            // minMemoryFrequencyBox
            // 
            this.minMemoryFrequencyBox.Enabled = false;
            this.minMemoryFrequencyBox.Location = new System.Drawing.Point(494, 52);
            this.minMemoryFrequencyBox.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.minMemoryFrequencyBox.Name = "minMemoryFrequencyBox";
            this.minMemoryFrequencyBox.Size = new System.Drawing.Size(46, 22);
            this.minMemoryFrequencyBox.TabIndex = 20;
            // 
            // enableMinMemoryFrequencyBox
            // 
            this.enableMinMemoryFrequencyBox.AutoSize = true;
            this.enableMinMemoryFrequencyBox.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.enableMinMemoryFrequencyBox.Location = new System.Drawing.Point(479, 56);
            this.enableMinMemoryFrequencyBox.Name = "enableMinMemoryFrequencyBox";
            this.enableMinMemoryFrequencyBox.Size = new System.Drawing.Size(15, 14);
            this.enableMinMemoryFrequencyBox.TabIndex = 19;
            this.enableMinMemoryFrequencyBox.UseVisualStyleBackColor = true;
            this.enableMinMemoryFrequencyBox.CheckedChanged += new System.EventHandler(this.enableMinMemoryFrequencyBox_CheckedChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(379, 56);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(94, 13);
            this.label8.TabIndex = 18;
            this.label8.Text = "Bellek Hızı (MHz):";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 56);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "Bellek Tipi:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // maxPriceBox
            // 
            this.maxPriceBox.DecimalPlaces = 2;
            this.maxPriceBox.Enabled = false;
            this.maxPriceBox.Location = new System.Drawing.Point(958, 20);
            this.maxPriceBox.Maximum = new decimal(new int[] {
            9999999,
            0,
            0,
            131072});
            this.maxPriceBox.Name = "maxPriceBox";
            this.maxPriceBox.Size = new System.Drawing.Size(70, 22);
            this.maxPriceBox.TabIndex = 10;
            this.maxPriceBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // minPriceBox
            // 
            this.minPriceBox.DecimalPlaces = 2;
            this.minPriceBox.Enabled = false;
            this.minPriceBox.Location = new System.Drawing.Point(858, 20);
            this.minPriceBox.Maximum = new decimal(new int[] {
            9999999,
            0,
            0,
            131072});
            this.minPriceBox.Name = "minPriceBox";
            this.minPriceBox.Size = new System.Drawing.Size(70, 22);
            this.minPriceBox.TabIndex = 8;
            this.minPriceBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(788, 23);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(49, 13);
            this.label7.TabIndex = 6;
            this.label7.Text = "Fiyat ($):";
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 120);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(27, 13);
            this.label6.TabIndex = 43;
            this.label6.Text = "Ara:";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // brandBox
            // 
            this.brandBox.Location = new System.Drawing.Point(60, 19);
            this.brandBox.Name = "brandBox";
            this.brandBox.Size = new System.Drawing.Size(164, 22);
            this.brandBox.TabIndex = 1;
            // 
            // nameBox
            // 
            this.nameBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.nameBox.Location = new System.Drawing.Point(45, 117);
            this.nameBox.Name = "nameBox";
            this.nameBox.Size = new System.Drawing.Size(273, 22);
            this.nameBox.TabIndex = 44;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Marka:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // applyFilterButton
            // 
            this.applyFilterButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.applyFilterButton.Location = new System.Drawing.Point(324, 117);
            this.applyFilterButton.Name = "applyFilterButton";
            this.applyFilterButton.Size = new System.Drawing.Size(91, 22);
            this.applyFilterButton.TabIndex = 45;
            this.applyFilterButton.Text = "Ara ve Filtrele";
            this.applyFilterButton.UseVisualStyleBackColor = true;
            this.applyFilterButton.Click += new System.EventHandler(this.GenerateListAsyncEvent);
            // 
            // enableMaxPriceBox
            // 
            this.enableMaxPriceBox.AutoSize = true;
            this.enableMaxPriceBox.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.enableMaxPriceBox.Location = new System.Drawing.Point(928, 23);
            this.enableMaxPriceBox.Name = "enableMaxPriceBox";
            this.enableMaxPriceBox.Size = new System.Drawing.Size(30, 17);
            this.enableMaxPriceBox.TabIndex = 9;
            this.enableMaxPriceBox.Text = "-";
            this.enableMaxPriceBox.UseVisualStyleBackColor = true;
            this.enableMaxPriceBox.CheckedChanged += new System.EventHandler(this.enableMaxPriceBox_CheckedChanged);
            // 
            // enableMinPriceBox
            // 
            this.enableMinPriceBox.AutoSize = true;
            this.enableMinPriceBox.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.enableMinPriceBox.Location = new System.Drawing.Point(843, 24);
            this.enableMinPriceBox.Name = "enableMinPriceBox";
            this.enableMinPriceBox.Size = new System.Drawing.Size(15, 14);
            this.enableMinPriceBox.TabIndex = 7;
            this.enableMinPriceBox.UseVisualStyleBackColor = true;
            this.enableMinPriceBox.CheckedChanged += new System.EventHandler(this.enableMinPriceBox_CheckedChanged);
            // 
            // orderGroup
            // 
            this.orderGroup.Controls.Add(this.newButton);
            this.orderGroup.Controls.Add(this.itemPerPageBox);
            this.orderGroup.Controls.Add(this.label5);
            this.orderGroup.Controls.Add(this.label4);
            this.orderGroup.Controls.Add(this.orderBox);
            this.orderGroup.Dock = System.Windows.Forms.DockStyle.Right;
            this.orderGroup.Location = new System.Drawing.Point(1038, 0);
            this.orderGroup.Name = "orderGroup";
            this.orderGroup.Size = new System.Drawing.Size(226, 145);
            this.orderGroup.TabIndex = 1;
            this.orderGroup.TabStop = false;
            this.orderGroup.Text = "Sırala";
            // 
            // newButton
            // 
            this.newButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.newButton.Location = new System.Drawing.Point(6, 117);
            this.newButton.Name = "newButton";
            this.newButton.Size = new System.Drawing.Size(214, 22);
            this.newButton.TabIndex = 4;
            this.newButton.Text = "Yeni Ekran Kartı Ekle";
            this.newButton.UseVisualStyleBackColor = true;
            this.newButton.Click += new System.EventHandler(this.newButton_Click);
            // 
            // itemPerPageBox
            // 
            this.itemPerPageBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.itemPerPageBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.itemPerPageBox.FormattingEnabled = true;
            this.itemPerPageBox.Items.AddRange(new object[] {
            "5",
            "10",
            "20"});
            this.itemPerPageBox.Location = new System.Drawing.Point(79, 48);
            this.itemPerPageBox.Name = "itemPerPageBox";
            this.itemPerPageBox.Size = new System.Drawing.Size(47, 21);
            this.itemPerPageBox.TabIndex = 2;
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(129, 48);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(70, 21);
            this.label5.TabIndex = 3;
            this.label5.Text = "kayıt göster.";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(6, 48);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 21);
            this.label4.TabIndex = 1;
            this.label4.Text = "Sayfa başına";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // orderBox
            // 
            this.orderBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.orderBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.orderBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.orderBox.FormattingEnabled = true;
            this.orderBox.Items.AddRange(new object[] {
            "Eskiden yeniye",
            "Yeniden eskiye",
            "İsme göre (A-Z)",
            "İsme göre (Z-A)",
            "Marka ismine göre (A-Z)",
            "Marka ismine göre (Z-A)",
            "Fiyata göre (En ucuz)",
            "Fiyata göre (En pahalı)",
            "Yonga setine göre (A-Z)",
            "Yonga setine göre (Z-A)",
            "Yonga seti markasına göre (A-Z)",
            "Yonga seti markasına göre (Z-A)",
            "Bellek tipine göre (A-Z)",
            "Bellek tipine göre (Z-A)",
            "Bellek kapasitesine göre (En az)",
            "Bellek kapasitesine göre (En çok)",
            "Bellek hızına göre (En yavaş)",
            "Bellek hızına göre (En hızlı)",
            "Çekirdek hızına göre (En yavaş)",
            "Çekirdek hızına göre (En hızlı)",
            "Maks. çekirdek hızına göre (En yavaş)",
            "Maks. çekirdek hızına göre (En hızlı)",
            "Veri yolu genişliğine göre (En az)",
            "Veri yolu genişliğine göre (En çok)"});
            this.orderBox.Location = new System.Drawing.Point(6, 22);
            this.orderBox.Name = "orderBox";
            this.orderBox.Size = new System.Drawing.Size(214, 21);
            this.orderBox.TabIndex = 0;
            // 
            // controlPanel
            // 
            this.controlPanel.Controls.Add(this.countLabel);
            this.controlPanel.Controls.Add(this.mainButton);
            this.controlPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.controlPanel.Location = new System.Drawing.Point(0, 664);
            this.controlPanel.Name = "controlPanel";
            this.controlPanel.Size = new System.Drawing.Size(1264, 22);
            this.controlPanel.TabIndex = 3;
            // 
            // countLabel
            // 
            this.countLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.countLabel.Location = new System.Drawing.Point(0, 0);
            this.countLabel.Name = "countLabel";
            this.countLabel.Size = new System.Drawing.Size(1189, 22);
            this.countLabel.TabIndex = 0;
            this.countLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // mainButton
            // 
            this.mainButton.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.mainButton.Dock = System.Windows.Forms.DockStyle.Right;
            this.mainButton.Location = new System.Drawing.Point(1189, 0);
            this.mainButton.Name = "mainButton";
            this.mainButton.Size = new System.Drawing.Size(75, 22);
            this.mainButton.TabIndex = 1;
            this.mainButton.Text = "Tamam";
            this.mainButton.UseVisualStyleBackColor = true;
            this.mainButton.Click += new System.EventHandler(this.mainButton_Click);
            // 
            // navigationPanel
            // 
            this.navigationPanel.Controls.Add(this.navigationSubPanel);
            this.navigationPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.navigationPanel.Location = new System.Drawing.Point(0, 636);
            this.navigationPanel.Name = "navigationPanel";
            this.navigationPanel.Padding = new System.Windows.Forms.Padding(3);
            this.navigationPanel.Size = new System.Drawing.Size(1264, 28);
            this.navigationPanel.TabIndex = 2;
            // 
            // navigationSubPanel
            // 
            this.navigationSubPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.navigationSubPanel.Controls.Add(this.pageNumberBox);
            this.navigationSubPanel.Controls.Add(this.nextPageButton);
            this.navigationSubPanel.Controls.Add(this.lastPageButton);
            this.navigationSubPanel.Controls.Add(this.previousPageButton);
            this.navigationSubPanel.Controls.Add(this.firstPageButton);
            this.navigationSubPanel.Controls.Add(this.pageCountLabel);
            this.navigationSubPanel.Location = new System.Drawing.Point(532, 3);
            this.navigationSubPanel.Name = "navigationSubPanel";
            this.navigationSubPanel.Size = new System.Drawing.Size(201, 22);
            this.navigationSubPanel.TabIndex = 0;
            // 
            // pageNumberBox
            // 
            this.pageNumberBox.Dock = System.Windows.Forms.DockStyle.Left;
            this.pageNumberBox.Location = new System.Drawing.Point(70, 0);
            this.pageNumberBox.Maximum = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.pageNumberBox.Name = "pageNumberBox";
            this.pageNumberBox.Size = new System.Drawing.Size(35, 22);
            this.pageNumberBox.TabIndex = 0;
            this.pageNumberBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.pageNumberBox.UpDownAlign = System.Windows.Forms.LeftRightAlignment.Left;
            // 
            // nextPageButton
            // 
            this.nextPageButton.Dock = System.Windows.Forms.DockStyle.Right;
            this.nextPageButton.Enabled = false;
            this.nextPageButton.Location = new System.Drawing.Point(131, 0);
            this.nextPageButton.Name = "nextPageButton";
            this.nextPageButton.Size = new System.Drawing.Size(35, 22);
            this.nextPageButton.TabIndex = 4;
            this.nextPageButton.Text = ">";
            this.nextPageButton.UseVisualStyleBackColor = true;
            this.nextPageButton.Click += new System.EventHandler(this.nextPageButton_Click);
            // 
            // lastPageButton
            // 
            this.lastPageButton.Dock = System.Windows.Forms.DockStyle.Right;
            this.lastPageButton.Enabled = false;
            this.lastPageButton.Location = new System.Drawing.Point(166, 0);
            this.lastPageButton.Name = "lastPageButton";
            this.lastPageButton.Size = new System.Drawing.Size(35, 22);
            this.lastPageButton.TabIndex = 5;
            this.lastPageButton.Text = ">>";
            this.lastPageButton.UseVisualStyleBackColor = true;
            this.lastPageButton.Click += new System.EventHandler(this.lastPageButton_Click);
            // 
            // previousPageButton
            // 
            this.previousPageButton.Dock = System.Windows.Forms.DockStyle.Left;
            this.previousPageButton.Enabled = false;
            this.previousPageButton.Location = new System.Drawing.Point(35, 0);
            this.previousPageButton.Name = "previousPageButton";
            this.previousPageButton.Size = new System.Drawing.Size(35, 22);
            this.previousPageButton.TabIndex = 3;
            this.previousPageButton.Text = "<";
            this.previousPageButton.UseVisualStyleBackColor = true;
            this.previousPageButton.Click += new System.EventHandler(this.previousPageButton_Click);
            // 
            // firstPageButton
            // 
            this.firstPageButton.Dock = System.Windows.Forms.DockStyle.Left;
            this.firstPageButton.Enabled = false;
            this.firstPageButton.Location = new System.Drawing.Point(0, 0);
            this.firstPageButton.Name = "firstPageButton";
            this.firstPageButton.Size = new System.Drawing.Size(35, 22);
            this.firstPageButton.TabIndex = 2;
            this.firstPageButton.Text = "<<";
            this.firstPageButton.UseVisualStyleBackColor = true;
            this.firstPageButton.Click += new System.EventHandler(this.firstPageButton_Click);
            // 
            // pageCountLabel
            // 
            this.pageCountLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pageCountLabel.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.pageCountLabel.Location = new System.Drawing.Point(103, 2);
            this.pageCountLabel.Name = "pageCountLabel";
            this.pageCountLabel.Size = new System.Drawing.Size(26, 15);
            this.pageCountLabel.TabIndex = 1;
            this.pageCountLabel.Text = "/ 0";
            this.pageCountLabel.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // listPanelBorder
            // 
            this.listPanelBorder.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.listPanelBorder.Controls.Add(this.listPanel);
            this.listPanelBorder.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listPanelBorder.Location = new System.Drawing.Point(0, 145);
            this.listPanelBorder.Name = "listPanelBorder";
            this.listPanelBorder.Padding = new System.Windows.Forms.Padding(3);
            this.listPanelBorder.Size = new System.Drawing.Size(1264, 491);
            this.listPanelBorder.TabIndex = 1;
            // 
            // listPanel
            // 
            this.listPanel.AutoScroll = true;
            this.listPanel.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.listPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listPanel.Location = new System.Drawing.Point(3, 3);
            this.listPanel.Name = "listPanel";
            this.listPanel.Padding = new System.Windows.Forms.Padding(5);
            this.listPanel.Size = new System.Drawing.Size(1258, 485);
            this.listPanel.TabIndex = 0;
            // 
            // GraphicsCardListView
            // 
            this.AcceptButton = this.applyFilterButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.mainButton;
            this.ClientSize = new System.Drawing.Size(1264, 686);
            this.Controls.Add(this.listPanelBorder);
            this.Controls.Add(this.navigationPanel);
            this.Controls.Add(this.controlPanel);
            this.Controls.Add(this.filterPanel);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(1280, 725);
            this.Name = "GraphicsCardListView";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Picker | Ekran Kartları";
            this.Load += new System.EventHandler(this.GraphicsCardListView_Load);
            this.filterPanel.ResumeLayout(false);
            this.filterGroup.ResumeLayout(false);
            this.filterGroup.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.maxTurboFrequencyBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.minTurboFrequencyBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.maxFrequencyBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.minFrequencyBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.maxBusWidthBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.minBusWidthBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.maxMemoryBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.minMemoryBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.maxMemoryFrequencyBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.minMemoryFrequencyBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.maxPriceBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.minPriceBox)).EndInit();
            this.orderGroup.ResumeLayout(false);
            this.controlPanel.ResumeLayout(false);
            this.navigationPanel.ResumeLayout(false);
            this.navigationSubPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pageNumberBox)).EndInit();
            this.listPanelBorder.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel filterPanel;
        private System.Windows.Forms.Panel controlPanel;
        private System.Windows.Forms.Button mainButton;
        private System.Windows.Forms.Panel navigationPanel;
        private System.Windows.Forms.Label countLabel;
        private System.Windows.Forms.Panel navigationSubPanel;
        private System.Windows.Forms.Label pageCountLabel;
        private System.Windows.Forms.GroupBox orderGroup;
        private System.Windows.Forms.ComboBox itemPerPageBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox orderBox;
        private System.Windows.Forms.GroupBox filterGroup;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button applyFilterButton;
        private System.Windows.Forms.Panel listPanelBorder;
        internal System.Windows.Forms.Panel listPanel;
        private System.Windows.Forms.NumericUpDown pageNumberBox;
        private System.Windows.Forms.Button nextPageButton;
        private System.Windows.Forms.Button lastPageButton;
        private System.Windows.Forms.Button previousPageButton;
        private System.Windows.Forms.Button firstPageButton;
        private System.Windows.Forms.TextBox nameBox;
        private System.Windows.Forms.TextBox brandBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.NumericUpDown maxPriceBox;
        private System.Windows.Forms.NumericUpDown minPriceBox;
        private System.Windows.Forms.CheckBox enableMaxPriceBox;
        private System.Windows.Forms.CheckBox enableMinPriceBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown minMemoryFrequencyBox;
        private System.Windows.Forms.CheckBox enableMinMemoryFrequencyBox;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.NumericUpDown maxMemoryFrequencyBox;
        private System.Windows.Forms.CheckBox enableMaxMemoryFrequencyBox;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.NumericUpDown maxMemoryBox;
        private System.Windows.Forms.CheckBox enableMaxMemoryBox;
        private System.Windows.Forms.CheckBox enableMinMemoryBox;
        private System.Windows.Forms.NumericUpDown minMemoryBox;
        private System.Windows.Forms.CheckBox compatiblesBox;
        private System.Windows.Forms.Button clearFilterButton;
        private System.Windows.Forms.Button newButton;
        private System.Windows.Forms.ComboBox memoryTypeBox;
        private System.Windows.Forms.TextBox chipsetModelBox;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox chipsetBrandBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown maxBusWidthBox;
        private System.Windows.Forms.CheckBox enableMaxBusWidthBox;
        private System.Windows.Forms.NumericUpDown minBusWidthBox;
        private System.Windows.Forms.CheckBox enableMinBusWidthBox;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.NumericUpDown maxFrequencyBox;
        private System.Windows.Forms.CheckBox enableMaxFrequencyBox;
        private System.Windows.Forms.NumericUpDown minFrequencyBox;
        private System.Windows.Forms.CheckBox enableMinFrequencyBox;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.NumericUpDown maxTurboFrequencyBox;
        private System.Windows.Forms.CheckBox enableMaxTurboFrequencyBox;
        private System.Windows.Forms.NumericUpDown minTurboFrequencyBox;
        private System.Windows.Forms.CheckBox enableMinTurboFrequencyBox;
        private System.Windows.Forms.Label label13;
    }
}