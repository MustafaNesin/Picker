namespace Picker
{
    partial class ProcessorView
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProcessorView));
            this.controlPanel = new System.Windows.Forms.Panel();
            this.cancelButton = new System.Windows.Forms.Button();
            this.acceptButton = new System.Windows.Forms.Button();
            this.entityPanel = new System.Windows.Forms.Panel();
            this.is64BitBox = new System.Windows.Forms.CheckBox();
            this.label16 = new System.Windows.Forms.Label();
            this.turboFrequencyBox = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.cacheSizeBox = new System.Windows.Forms.NumericUpDown();
            this.label13 = new System.Windows.Forms.Label();
            this.threadsBox = new System.Windows.Forms.NumericUpDown();
            this.label12 = new System.Windows.Forms.Label();
            this.coresBox = new System.Windows.Forms.NumericUpDown();
            this.familyBox = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.socketButton = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.priceBox = new System.Windows.Forms.NumericUpDown();
            this.maxMemoryBox = new System.Windows.Forms.NumericUpDown();
            this.maxMemorySpeedBox = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.frequencyBox = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.brandButton = new System.Windows.Forms.Button();
            this.eccBox = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.modelBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.bandwidthLabel = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.imageBox = new System.Windows.Forms.PictureBox();
            this.selectImageButton = new System.Windows.Forms.Button();
            this.deleteImageButton = new System.Windows.Forms.Button();
            this.imagePanel = new System.Windows.Forms.GroupBox();
            this.chipsetsPanel = new System.Windows.Forms.GroupBox();
            this.chipsetsBox = new System.Windows.Forms.ListBox();
            this.addChipsetButton = new System.Windows.Forms.Button();
            this.removeChipsetButton = new System.Windows.Forms.Button();
            this.controlPanel.SuspendLayout();
            this.entityPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.turboFrequencyBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cacheSizeBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.threadsBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.coresBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.priceBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.maxMemoryBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.maxMemorySpeedBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.frequencyBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageBox)).BeginInit();
            this.imagePanel.SuspendLayout();
            this.chipsetsPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // controlPanel
            // 
            this.controlPanel.Controls.Add(this.cancelButton);
            this.controlPanel.Controls.Add(this.acceptButton);
            this.controlPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.controlPanel.Location = new System.Drawing.Point(0, 200);
            this.controlPanel.Name = "controlPanel";
            this.controlPanel.Size = new System.Drawing.Size(642, 32);
            this.controlPanel.TabIndex = 3;
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
            this.acceptButton.Location = new System.Drawing.Point(553, 0);
            this.acceptButton.Name = "acceptButton";
            this.acceptButton.Size = new System.Drawing.Size(89, 32);
            this.acceptButton.TabIndex = 0;
            this.acceptButton.Text = "Tamam";
            this.acceptButton.UseVisualStyleBackColor = false;
            this.acceptButton.Click += new System.EventHandler(this.acceptButton_Click);
            // 
            // entityPanel
            // 
            this.entityPanel.Controls.Add(this.is64BitBox);
            this.entityPanel.Controls.Add(this.label16);
            this.entityPanel.Controls.Add(this.turboFrequencyBox);
            this.entityPanel.Controls.Add(this.label3);
            this.entityPanel.Controls.Add(this.label11);
            this.entityPanel.Controls.Add(this.label15);
            this.entityPanel.Controls.Add(this.label14);
            this.entityPanel.Controls.Add(this.cacheSizeBox);
            this.entityPanel.Controls.Add(this.label13);
            this.entityPanel.Controls.Add(this.threadsBox);
            this.entityPanel.Controls.Add(this.label12);
            this.entityPanel.Controls.Add(this.coresBox);
            this.entityPanel.Controls.Add(this.familyBox);
            this.entityPanel.Controls.Add(this.label8);
            this.entityPanel.Controls.Add(this.label10);
            this.entityPanel.Controls.Add(this.socketButton);
            this.entityPanel.Controls.Add(this.label9);
            this.entityPanel.Controls.Add(this.priceBox);
            this.entityPanel.Controls.Add(this.maxMemoryBox);
            this.entityPanel.Controls.Add(this.maxMemorySpeedBox);
            this.entityPanel.Controls.Add(this.label6);
            this.entityPanel.Controls.Add(this.frequencyBox);
            this.entityPanel.Controls.Add(this.label4);
            this.entityPanel.Controls.Add(this.brandButton);
            this.entityPanel.Controls.Add(this.eccBox);
            this.entityPanel.Controls.Add(this.label2);
            this.entityPanel.Controls.Add(this.modelBox);
            this.entityPanel.Controls.Add(this.label1);
            this.entityPanel.Controls.Add(this.label7);
            this.entityPanel.Controls.Add(this.bandwidthLabel);
            this.entityPanel.Controls.Add(this.label5);
            this.entityPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.entityPanel.Location = new System.Drawing.Point(76, 0);
            this.entityPanel.Name = "entityPanel";
            this.entityPanel.Size = new System.Drawing.Size(416, 200);
            this.entityPanel.TabIndex = 0;
            // 
            // is64BitBox
            // 
            this.is64BitBox.AutoSize = true;
            this.is64BitBox.Location = new System.Drawing.Point(262, 174);
            this.is64BitBox.Name = "is64BitBox";
            this.is64BitBox.Size = new System.Drawing.Size(54, 17);
            this.is64BitBox.TabIndex = 29;
            this.is64BitBox.Text = "64 Bit";
            this.is64BitBox.UseVisualStyleBackColor = true;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.label16.Location = new System.Drawing.Point(296, 143);
            this.label16.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(30, 13);
            this.label16.TabIndex = 26;
            this.label16.Text = "MHz";
            // 
            // turboFrequencyBox
            // 
            this.turboFrequencyBox.DecimalPlaces = 2;
            this.turboFrequencyBox.Location = new System.Drawing.Point(210, 109);
            this.turboFrequencyBox.Maximum = new decimal(new int[] {
            999,
            0,
            0,
            131072});
            this.turboFrequencyBox.Name = "turboFrequencyBox";
            this.turboFrequencyBox.Size = new System.Drawing.Size(46, 22);
            this.turboFrequencyBox.TabIndex = 19;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.label3.Location = new System.Drawing.Point(151, 111);
            this.label3.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 13);
            this.label3.TabIndex = 18;
            this.label3.Text = "Maks. Hız:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.label11.Location = new System.Drawing.Point(256, 111);
            this.label11.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(28, 13);
            this.label11.TabIndex = 20;
            this.label11.Text = "GHz";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.label15.Location = new System.Drawing.Point(387, 79);
            this.label15.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(23, 13);
            this.label15.TabIndex = 14;
            this.label15.Text = "MB";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.label14.Location = new System.Drawing.Point(290, 79);
            this.label14.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(57, 13);
            this.label14.TabIndex = 12;
            this.label14.Text = "Önbellek:";
            // 
            // cacheSizeBox
            // 
            this.cacheSizeBox.Location = new System.Drawing.Point(348, 77);
            this.cacheSizeBox.Maximum = new decimal(new int[] {
            999,
            0,
            0,
            0});
            this.cacheSizeBox.Name = "cacheSizeBox";
            this.cacheSizeBox.Size = new System.Drawing.Size(39, 22);
            this.cacheSizeBox.TabIndex = 13;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.label13.Location = new System.Drawing.Point(149, 79);
            this.label13.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(66, 13);
            this.label13.TabIndex = 10;
            this.label13.Text = "İş Parçacığı:";
            // 
            // threadsBox
            // 
            this.threadsBox.Location = new System.Drawing.Point(216, 77);
            this.threadsBox.Maximum = new decimal(new int[] {
            999,
            0,
            0,
            0});
            this.threadsBox.Name = "threadsBox";
            this.threadsBox.Size = new System.Drawing.Size(39, 22);
            this.threadsBox.TabIndex = 11;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.label12.Location = new System.Drawing.Point(6, 79);
            this.label12.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(55, 13);
            this.label12.TabIndex = 8;
            this.label12.Text = "Çekirdek:";
            // 
            // coresBox
            // 
            this.coresBox.Location = new System.Drawing.Point(62, 77);
            this.coresBox.Maximum = new decimal(new int[] {
            999,
            0,
            0,
            0});
            this.coresBox.Name = "coresBox";
            this.coresBox.Size = new System.Drawing.Size(39, 22);
            this.coresBox.TabIndex = 9;
            // 
            // familyBox
            // 
            this.familyBox.Location = new System.Drawing.Point(54, 44);
            this.familyBox.Name = "familyBox";
            this.familyBox.Size = new System.Drawing.Size(150, 22);
            this.familyBox.TabIndex = 5;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.label8.Location = new System.Drawing.Point(6, 47);
            this.label8.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(29, 13);
            this.label8.TabIndex = 4;
            this.label8.Text = "Seri:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.label10.Location = new System.Drawing.Point(122, 143);
            this.label10.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(21, 13);
            this.label10.TabIndex = 23;
            this.label10.Text = "GB";
            // 
            // socketButton
            // 
            this.socketButton.BackColor = System.Drawing.Color.Green;
            this.socketButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.socketButton.FlatAppearance.BorderSize = 0;
            this.socketButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.socketButton.ForeColor = System.Drawing.Color.White;
            this.socketButton.Location = new System.Drawing.Point(54, 170);
            this.socketButton.Name = "socketButton";
            this.socketButton.Size = new System.Drawing.Size(150, 23);
            this.socketButton.TabIndex = 28;
            this.socketButton.Text = "Soket Seç...";
            this.socketButton.UseVisualStyleBackColor = false;
            this.socketButton.Click += new System.EventHandler(this.socketButton_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.label9.Location = new System.Drawing.Point(6, 175);
            this.label9.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(39, 13);
            this.label9.TabIndex = 27;
            this.label9.Text = "Soket:";
            // 
            // priceBox
            // 
            this.priceBox.DecimalPlaces = 2;
            this.priceBox.Location = new System.Drawing.Point(334, 11);
            this.priceBox.Maximum = new decimal(new int[] {
            9999999,
            0,
            0,
            131072});
            this.priceBox.Name = "priceBox";
            this.priceBox.Size = new System.Drawing.Size(76, 22);
            this.priceBox.TabIndex = 3;
            this.priceBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.priceBox.UpDownAlign = System.Windows.Forms.LeftRightAlignment.Left;
            // 
            // maxMemoryBox
            // 
            this.maxMemoryBox.Location = new System.Drawing.Point(82, 141);
            this.maxMemoryBox.Maximum = new decimal(new int[] {
            999,
            0,
            0,
            0});
            this.maxMemoryBox.Name = "maxMemoryBox";
            this.maxMemoryBox.Size = new System.Drawing.Size(40, 22);
            this.maxMemoryBox.TabIndex = 22;
            // 
            // maxMemorySpeedBox
            // 
            this.maxMemorySpeedBox.Location = new System.Drawing.Point(247, 141);
            this.maxMemorySpeedBox.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.maxMemorySpeedBox.Name = "maxMemorySpeedBox";
            this.maxMemorySpeedBox.Size = new System.Drawing.Size(49, 22);
            this.maxMemorySpeedBox.TabIndex = 25;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.label6.Location = new System.Drawing.Point(151, 143);
            this.label6.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(95, 13);
            this.label6.TabIndex = 24;
            this.label6.Text = "Maks. Bellek Hızı:";
            // 
            // frequencyBox
            // 
            this.frequencyBox.DecimalPlaces = 2;
            this.frequencyBox.Location = new System.Drawing.Point(33, 109);
            this.frequencyBox.Maximum = new decimal(new int[] {
            999,
            0,
            0,
            131072});
            this.frequencyBox.Name = "frequencyBox";
            this.frequencyBox.Size = new System.Drawing.Size(46, 22);
            this.frequencyBox.TabIndex = 16;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.label4.Location = new System.Drawing.Point(6, 111);
            this.label4.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(26, 13);
            this.label4.TabIndex = 15;
            this.label4.Text = "Hız:";
            // 
            // brandButton
            // 
            this.brandButton.BackColor = System.Drawing.Color.Green;
            this.brandButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.brandButton.FlatAppearance.BorderSize = 0;
            this.brandButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.brandButton.ForeColor = System.Drawing.Color.White;
            this.brandButton.Location = new System.Drawing.Point(54, 12);
            this.brandButton.Name = "brandButton";
            this.brandButton.Size = new System.Drawing.Size(150, 23);
            this.brandButton.TabIndex = 1;
            this.brandButton.Text = "Marka Seç...";
            this.brandButton.UseVisualStyleBackColor = false;
            this.brandButton.Click += new System.EventHandler(this.brandButton_Click);
            // 
            // eccBox
            // 
            this.eccBox.AutoSize = true;
            this.eccBox.Location = new System.Drawing.Point(322, 174);
            this.eccBox.Name = "eccBox";
            this.eccBox.Size = new System.Drawing.Size(88, 17);
            this.eccBox.TabIndex = 3;
            this.eccBox.Text = "ECC Desteği";
            this.eccBox.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.label2.Location = new System.Drawing.Point(6, 15);
            this.label2.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Marka:";
            // 
            // modelBox
            // 
            this.modelBox.Location = new System.Drawing.Point(260, 44);
            this.modelBox.Name = "modelBox";
            this.modelBox.Size = new System.Drawing.Size(150, 22);
            this.modelBox.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.label1.Location = new System.Drawing.Point(211, 47);
            this.label1.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Model:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 143);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(73, 13);
            this.label7.TabIndex = 21;
            this.label7.Text = "Maks. Bellek:";
            // 
            // bandwidthLabel
            // 
            this.bandwidthLabel.AutoSize = true;
            this.bandwidthLabel.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.bandwidthLabel.Location = new System.Drawing.Point(79, 111);
            this.bandwidthLabel.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.bandwidthLabel.Name = "bandwidthLabel";
            this.bandwidthLabel.Size = new System.Drawing.Size(28, 13);
            this.bandwidthLabel.TabIndex = 17;
            this.bandwidthLabel.Text = "GHz";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.label5.Location = new System.Drawing.Point(285, 15);
            this.label5.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 13);
            this.label5.TabIndex = 2;
            this.label5.Text = "Fiyat ($):";
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
            this.imagePanel.Size = new System.Drawing.Size(76, 200);
            this.imagePanel.TabIndex = 2;
            this.imagePanel.TabStop = false;
            this.imagePanel.Text = "Resim";
            // 
            // chipsetsPanel
            // 
            this.chipsetsPanel.Controls.Add(this.chipsetsBox);
            this.chipsetsPanel.Controls.Add(this.addChipsetButton);
            this.chipsetsPanel.Controls.Add(this.removeChipsetButton);
            this.chipsetsPanel.Dock = System.Windows.Forms.DockStyle.Right;
            this.chipsetsPanel.Location = new System.Drawing.Point(492, 0);
            this.chipsetsPanel.Name = "chipsetsPanel";
            this.chipsetsPanel.Padding = new System.Windows.Forms.Padding(6, 6, 6, 10);
            this.chipsetsPanel.Size = new System.Drawing.Size(150, 200);
            this.chipsetsPanel.TabIndex = 1;
            this.chipsetsPanel.TabStop = false;
            this.chipsetsPanel.Text = "Uyumlu Yonga Setleri";
            // 
            // chipsetsBox
            // 
            this.chipsetsBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.chipsetsBox.FormattingEnabled = true;
            this.chipsetsBox.Location = new System.Drawing.Point(6, 21);
            this.chipsetsBox.Name = "chipsetsBox";
            this.chipsetsBox.Size = new System.Drawing.Size(138, 125);
            this.chipsetsBox.TabIndex = 0;
            this.chipsetsBox.SelectedIndexChanged += new System.EventHandler(this.chipsetsBox_SelectedIndexChanged);
            this.chipsetsBox.DoubleClick += new System.EventHandler(this.chipsetsBox_DoubleClick);
            // 
            // addChipsetButton
            // 
            this.addChipsetButton.BackColor = System.Drawing.Color.Green;
            this.addChipsetButton.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.addChipsetButton.FlatAppearance.BorderSize = 0;
            this.addChipsetButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addChipsetButton.ForeColor = System.Drawing.Color.White;
            this.addChipsetButton.Location = new System.Drawing.Point(6, 146);
            this.addChipsetButton.Name = "addChipsetButton";
            this.addChipsetButton.Size = new System.Drawing.Size(138, 22);
            this.addChipsetButton.TabIndex = 1;
            this.addChipsetButton.Text = "Ekle...";
            this.addChipsetButton.UseVisualStyleBackColor = false;
            this.addChipsetButton.Click += new System.EventHandler(this.addChipsetButton_Click);
            // 
            // removeChipsetButton
            // 
            this.removeChipsetButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.removeChipsetButton.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.removeChipsetButton.FlatAppearance.BorderSize = 0;
            this.removeChipsetButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.removeChipsetButton.ForeColor = System.Drawing.Color.White;
            this.removeChipsetButton.Location = new System.Drawing.Point(6, 168);
            this.removeChipsetButton.Name = "removeChipsetButton";
            this.removeChipsetButton.Size = new System.Drawing.Size(138, 22);
            this.removeChipsetButton.TabIndex = 2;
            this.removeChipsetButton.Text = "Kaldır";
            this.removeChipsetButton.UseVisualStyleBackColor = false;
            this.removeChipsetButton.Visible = false;
            this.removeChipsetButton.Click += new System.EventHandler(this.removeChipsetButton_Click);
            // 
            // ProcessorView
            // 
            this.AcceptButton = this.acceptButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.cancelButton;
            this.ClientSize = new System.Drawing.Size(642, 232);
            this.Controls.Add(this.entityPanel);
            this.Controls.Add(this.chipsetsPanel);
            this.Controls.Add(this.imagePanel);
            this.Controls.Add(this.controlPanel);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "ProcessorView";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "İşlemci";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.ProcessorView_FormClosed);
            this.Load += new System.EventHandler(this.ProcessorView_Load);
            this.controlPanel.ResumeLayout(false);
            this.entityPanel.ResumeLayout(false);
            this.entityPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.turboFrequencyBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cacheSizeBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.threadsBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.coresBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.priceBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.maxMemoryBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.maxMemorySpeedBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.frequencyBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageBox)).EndInit();
            this.imagePanel.ResumeLayout(false);
            this.chipsetsPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel controlPanel;
        private System.Windows.Forms.Button acceptButton;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.Panel entityPanel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox modelBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox eccBox;
        private System.Windows.Forms.Button brandButton;
        private System.Windows.Forms.PictureBox imageBox;
        private System.Windows.Forms.Button selectImageButton;
        private System.Windows.Forms.Button deleteImageButton;
        private System.Windows.Forms.GroupBox imagePanel;
        private System.Windows.Forms.NumericUpDown frequencyBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label bandwidthLabel;
        private System.Windows.Forms.NumericUpDown maxMemoryBox;
        private System.Windows.Forms.NumericUpDown maxMemorySpeedBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.NumericUpDown priceBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button socketButton;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox familyBox;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.NumericUpDown cacheSizeBox;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.NumericUpDown threadsBox;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.NumericUpDown coresBox;
        private System.Windows.Forms.NumericUpDown turboFrequencyBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.CheckBox is64BitBox;
        private System.Windows.Forms.GroupBox chipsetsPanel;
        private System.Windows.Forms.ListBox chipsetsBox;
        private System.Windows.Forms.Button addChipsetButton;
        private System.Windows.Forms.Button removeChipsetButton;
    }
}