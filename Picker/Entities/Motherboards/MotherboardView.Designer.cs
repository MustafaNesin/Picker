namespace Picker
{
    partial class MotherboardView
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MotherboardView));
            this.controlPanel = new System.Windows.Forms.Panel();
            this.cancelButton = new System.Windows.Forms.Button();
            this.acceptButton = new System.Windows.Forms.Button();
            this.entityPanel = new System.Windows.Forms.Panel();
            this.formFactorBox = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.socketButton = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.chipsetButton = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.priceBox = new System.Windows.Forms.NumericUpDown();
            this.maxMemoryBox = new System.Windows.Forms.NumericUpDown();
            this.memorySlotsBox = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.maxMemoryFrequencyBox = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.memoryTypeBox = new System.Windows.Forms.ComboBox();
            this.brandButton = new System.Windows.Forms.Button();
            this.eccBox = new System.Windows.Forms.CheckBox();
            this.label3 = new System.Windows.Forms.Label();
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
            this.controlPanel.SuspendLayout();
            this.entityPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.priceBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.maxMemoryBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.memorySlotsBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.maxMemoryFrequencyBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageBox)).BeginInit();
            this.imagePanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // controlPanel
            // 
            this.controlPanel.Controls.Add(this.cancelButton);
            this.controlPanel.Controls.Add(this.acceptButton);
            this.controlPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.controlPanel.Location = new System.Drawing.Point(0, 206);
            this.controlPanel.Name = "controlPanel";
            this.controlPanel.Size = new System.Drawing.Size(476, 32);
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
            this.acceptButton.Location = new System.Drawing.Point(387, 0);
            this.acceptButton.Name = "acceptButton";
            this.acceptButton.Size = new System.Drawing.Size(89, 32);
            this.acceptButton.TabIndex = 0;
            this.acceptButton.Text = "Tamam";
            this.acceptButton.UseVisualStyleBackColor = false;
            this.acceptButton.Click += new System.EventHandler(this.acceptButton_Click);
            // 
            // entityPanel
            // 
            this.entityPanel.Controls.Add(this.formFactorBox);
            this.entityPanel.Controls.Add(this.label11);
            this.entityPanel.Controls.Add(this.label10);
            this.entityPanel.Controls.Add(this.socketButton);
            this.entityPanel.Controls.Add(this.label9);
            this.entityPanel.Controls.Add(this.chipsetButton);
            this.entityPanel.Controls.Add(this.label8);
            this.entityPanel.Controls.Add(this.priceBox);
            this.entityPanel.Controls.Add(this.maxMemoryBox);
            this.entityPanel.Controls.Add(this.memorySlotsBox);
            this.entityPanel.Controls.Add(this.label6);
            this.entityPanel.Controls.Add(this.maxMemoryFrequencyBox);
            this.entityPanel.Controls.Add(this.label4);
            this.entityPanel.Controls.Add(this.memoryTypeBox);
            this.entityPanel.Controls.Add(this.brandButton);
            this.entityPanel.Controls.Add(this.eccBox);
            this.entityPanel.Controls.Add(this.label3);
            this.entityPanel.Controls.Add(this.label2);
            this.entityPanel.Controls.Add(this.modelBox);
            this.entityPanel.Controls.Add(this.label1);
            this.entityPanel.Controls.Add(this.label7);
            this.entityPanel.Controls.Add(this.bandwidthLabel);
            this.entityPanel.Controls.Add(this.label5);
            this.entityPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.entityPanel.Location = new System.Drawing.Point(76, 0);
            this.entityPanel.Name = "entityPanel";
            this.entityPanel.Size = new System.Drawing.Size(400, 206);
            this.entityPanel.TabIndex = 0;
            // 
            // formFactorBox
            // 
            this.formFactorBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.formFactorBox.Location = new System.Drawing.Point(84, 106);
            this.formFactorBox.Name = "formFactorBox";
            this.formFactorBox.Size = new System.Drawing.Size(304, 22);
            this.formFactorBox.TabIndex = 11;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.label11.Location = new System.Drawing.Point(6, 111);
            this.label11.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(72, 13);
            this.label11.TabIndex = 10;
            this.label11.Text = "Form Faktör:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.label10.Location = new System.Drawing.Point(164, 175);
            this.label10.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(21, 13);
            this.label10.TabIndex = 19;
            this.label10.Text = "GB";
            // 
            // socketButton
            // 
            this.socketButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.socketButton.BackColor = System.Drawing.Color.Green;
            this.socketButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.socketButton.FlatAppearance.BorderSize = 0;
            this.socketButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.socketButton.ForeColor = System.Drawing.Color.White;
            this.socketButton.Location = new System.Drawing.Point(253, 73);
            this.socketButton.Name = "socketButton";
            this.socketButton.Size = new System.Drawing.Size(135, 23);
            this.socketButton.TabIndex = 9;
            this.socketButton.Text = "Soket Seç...";
            this.socketButton.UseVisualStyleBackColor = false;
            this.socketButton.Click += new System.EventHandler(this.socketButton_Click);
            // 
            // label9
            // 
            this.label9.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.label9.Location = new System.Drawing.Point(208, 79);
            this.label9.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(39, 13);
            this.label9.TabIndex = 8;
            this.label9.Text = "Soket:";
            // 
            // chipsetButton
            // 
            this.chipsetButton.BackColor = System.Drawing.Color.Green;
            this.chipsetButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.chipsetButton.FlatAppearance.BorderSize = 0;
            this.chipsetButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.chipsetButton.ForeColor = System.Drawing.Color.White;
            this.chipsetButton.Location = new System.Drawing.Point(75, 74);
            this.chipsetButton.Name = "chipsetButton";
            this.chipsetButton.Size = new System.Drawing.Size(124, 23);
            this.chipsetButton.TabIndex = 7;
            this.chipsetButton.Text = "Yonga Seti Seç...";
            this.chipsetButton.UseVisualStyleBackColor = false;
            this.chipsetButton.Click += new System.EventHandler(this.chipsetButton_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.label8.Location = new System.Drawing.Point(6, 79);
            this.label8.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(63, 13);
            this.label8.TabIndex = 6;
            this.label8.Text = "Yonga Seti:";
            // 
            // priceBox
            // 
            this.priceBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.priceBox.DecimalPlaces = 2;
            this.priceBox.Location = new System.Drawing.Point(312, 43);
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
            // maxMemoryBox
            // 
            this.maxMemoryBox.Location = new System.Drawing.Point(124, 173);
            this.maxMemoryBox.Maximum = new decimal(new int[] {
            999,
            0,
            0,
            0});
            this.maxMemoryBox.Name = "maxMemoryBox";
            this.maxMemoryBox.Size = new System.Drawing.Size(40, 22);
            this.maxMemoryBox.TabIndex = 18;
            // 
            // memorySlotsBox
            // 
            this.memorySlotsBox.Location = new System.Drawing.Point(236, 141);
            this.memorySlotsBox.Maximum = new decimal(new int[] {
            99,
            0,
            0,
            0});
            this.memorySlotsBox.Name = "memorySlotsBox";
            this.memorySlotsBox.Size = new System.Drawing.Size(34, 22);
            this.memorySlotsBox.TabIndex = 15;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.label6.Location = new System.Drawing.Point(160, 143);
            this.label6.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(70, 13);
            this.label6.TabIndex = 14;
            this.label6.Text = "Bellek Slotu:";
            // 
            // maxMemoryFrequencyBox
            // 
            this.maxMemoryFrequencyBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.maxMemoryFrequencyBox.Location = new System.Drawing.Point(312, 173);
            this.maxMemoryFrequencyBox.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.maxMemoryFrequencyBox.Name = "maxMemoryFrequencyBox";
            this.maxMemoryFrequencyBox.Size = new System.Drawing.Size(46, 22);
            this.maxMemoryFrequencyBox.TabIndex = 21;
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.label4.Location = new System.Drawing.Point(211, 175);
            this.label4.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(95, 13);
            this.label4.TabIndex = 20;
            this.label4.Text = "Maks. Bellek Hızı:";
            // 
            // memoryTypeBox
            // 
            this.memoryTypeBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.memoryTypeBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.memoryTypeBox.FormattingEnabled = true;
            this.memoryTypeBox.Items.AddRange(new object[] {
            "DDR",
            "DDR2",
            "DDR3",
            "DDR4"});
            this.memoryTypeBox.Location = new System.Drawing.Point(74, 140);
            this.memoryTypeBox.Name = "memoryTypeBox";
            this.memoryTypeBox.Size = new System.Drawing.Size(58, 21);
            this.memoryTypeBox.TabIndex = 13;
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
            this.brandButton.Size = new System.Drawing.Size(203, 23);
            this.brandButton.TabIndex = 3;
            this.brandButton.Text = "Marka Seç...";
            this.brandButton.UseVisualStyleBackColor = false;
            this.brandButton.Click += new System.EventHandler(this.brandButton_Click);
            // 
            // eccBox
            // 
            this.eccBox.AutoSize = true;
            this.eccBox.Location = new System.Drawing.Point(294, 142);
            this.eccBox.Name = "eccBox";
            this.eccBox.Size = new System.Drawing.Size(88, 17);
            this.eccBox.TabIndex = 16;
            this.eccBox.Text = "ECC Desteği";
            this.eccBox.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.label3.Location = new System.Drawing.Point(6, 143);
            this.label3.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 13);
            this.label3.TabIndex = 12;
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
            this.modelBox.Size = new System.Drawing.Size(334, 22);
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
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 175);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(112, 13);
            this.label7.TabIndex = 17;
            this.label7.Text = "Maks. Bellek Boyutu:";
            // 
            // bandwidthLabel
            // 
            this.bandwidthLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.bandwidthLabel.AutoSize = true;
            this.bandwidthLabel.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.bandwidthLabel.Location = new System.Drawing.Point(358, 175);
            this.bandwidthLabel.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.bandwidthLabel.Name = "bandwidthLabel";
            this.bandwidthLabel.Size = new System.Drawing.Size(30, 13);
            this.bandwidthLabel.TabIndex = 22;
            this.bandwidthLabel.Text = "MHz";
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.label5.Location = new System.Drawing.Point(263, 47);
            this.label5.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(43, 13);
            this.label5.TabIndex = 4;
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
            this.imagePanel.Size = new System.Drawing.Size(76, 206);
            this.imagePanel.TabIndex = 1;
            this.imagePanel.TabStop = false;
            this.imagePanel.Text = "Resim";
            // 
            // MotherboardView
            // 
            this.AcceptButton = this.acceptButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.cancelButton;
            this.ClientSize = new System.Drawing.Size(476, 238);
            this.Controls.Add(this.entityPanel);
            this.Controls.Add(this.imagePanel);
            this.Controls.Add(this.controlPanel);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "MotherboardView";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Anakart";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MotherboardView_FormClosed);
            this.Load += new System.EventHandler(this.MotherboardView_Load);
            this.controlPanel.ResumeLayout(false);
            this.entityPanel.ResumeLayout(false);
            this.entityPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.priceBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.maxMemoryBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.memorySlotsBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.maxMemoryFrequencyBox)).EndInit();
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
        private System.Windows.Forms.CheckBox eccBox;
        private System.Windows.Forms.Button brandButton;
        private System.Windows.Forms.PictureBox imageBox;
        private System.Windows.Forms.Button selectImageButton;
        private System.Windows.Forms.Button deleteImageButton;
        private System.Windows.Forms.GroupBox imagePanel;
        private System.Windows.Forms.ComboBox memoryTypeBox;
        private System.Windows.Forms.NumericUpDown maxMemoryFrequencyBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label bandwidthLabel;
        private System.Windows.Forms.NumericUpDown maxMemoryBox;
        private System.Windows.Forms.NumericUpDown memorySlotsBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.NumericUpDown priceBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button socketButton;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button chipsetButton;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox formFactorBox;
        private System.Windows.Forms.Label label11;
    }
}