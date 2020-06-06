namespace Picker
{
    partial class MemoryView
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MemoryView));
            this.controlPanel = new System.Windows.Forms.Panel();
            this.cancelButton = new System.Windows.Forms.Button();
            this.acceptButton = new System.Windows.Forms.Button();
            this.entityPanel = new System.Windows.Forms.Panel();
            this.priceBox = new System.Windows.Forms.NumericUpDown();
            this.capacityBox = new System.Windows.Forms.NumericUpDown();
            this.countBox = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.frequencyBox = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.typeBox = new System.Windows.Forms.ComboBox();
            this.brandButton = new System.Windows.Forms.Button();
            this.bufferedBox = new System.Windows.Forms.CheckBox();
            this.eccBox = new System.Windows.Forms.CheckBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.modelBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.capacityLabel = new System.Windows.Forms.Label();
            this.bandwidthLabel = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.imageBox = new System.Windows.Forms.PictureBox();
            this.selectImageButton = new System.Windows.Forms.Button();
            this.deleteImageButton = new System.Windows.Forms.Button();
            this.imagePanel = new System.Windows.Forms.GroupBox();
            this.controlPanel.SuspendLayout();
            this.entityPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.priceBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.capacityBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.countBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.frequencyBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageBox)).BeginInit();
            this.imagePanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // controlPanel
            // 
            this.controlPanel.Controls.Add(this.cancelButton);
            this.controlPanel.Controls.Add(this.acceptButton);
            this.controlPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.controlPanel.Location = new System.Drawing.Point(0, 145);
            this.controlPanel.Name = "controlPanel";
            this.controlPanel.Size = new System.Drawing.Size(454, 32);
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
            this.acceptButton.Location = new System.Drawing.Point(365, 0);
            this.acceptButton.Name = "acceptButton";
            this.acceptButton.Size = new System.Drawing.Size(89, 32);
            this.acceptButton.TabIndex = 0;
            this.acceptButton.Text = "Tamam";
            this.acceptButton.UseVisualStyleBackColor = false;
            this.acceptButton.Click += new System.EventHandler(this.acceptButton_Click);
            // 
            // entityPanel
            // 
            this.entityPanel.Controls.Add(this.priceBox);
            this.entityPanel.Controls.Add(this.capacityBox);
            this.entityPanel.Controls.Add(this.countBox);
            this.entityPanel.Controls.Add(this.label6);
            this.entityPanel.Controls.Add(this.frequencyBox);
            this.entityPanel.Controls.Add(this.label4);
            this.entityPanel.Controls.Add(this.typeBox);
            this.entityPanel.Controls.Add(this.brandButton);
            this.entityPanel.Controls.Add(this.bufferedBox);
            this.entityPanel.Controls.Add(this.eccBox);
            this.entityPanel.Controls.Add(this.label3);
            this.entityPanel.Controls.Add(this.label2);
            this.entityPanel.Controls.Add(this.modelBox);
            this.entityPanel.Controls.Add(this.label1);
            this.entityPanel.Controls.Add(this.label7);
            this.entityPanel.Controls.Add(this.capacityLabel);
            this.entityPanel.Controls.Add(this.bandwidthLabel);
            this.entityPanel.Controls.Add(this.label5);
            this.entityPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.entityPanel.Location = new System.Drawing.Point(76, 0);
            this.entityPanel.Name = "entityPanel";
            this.entityPanel.Size = new System.Drawing.Size(378, 145);
            this.entityPanel.TabIndex = 0;
            // 
            // priceBox
            // 
            this.priceBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.priceBox.DecimalPlaces = 2;
            this.priceBox.Increment = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.priceBox.Location = new System.Drawing.Point(290, 43);
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
            // capacityBox
            // 
            this.capacityBox.Location = new System.Drawing.Point(100, 110);
            this.capacityBox.Maximum = new decimal(new int[] {
            999,
            0,
            0,
            0});
            this.capacityBox.Name = "capacityBox";
            this.capacityBox.Size = new System.Drawing.Size(40, 22);
            this.capacityBox.TabIndex = 14;
            this.capacityBox.ValueChanged += new System.EventHandler(this.kit_ValueChanged);
            // 
            // countBox
            // 
            this.countBox.Location = new System.Drawing.Point(54, 110);
            this.countBox.Maximum = new decimal(new int[] {
            99,
            0,
            0,
            0});
            this.countBox.Name = "countBox";
            this.countBox.Size = new System.Drawing.Size(34, 22);
            this.countBox.TabIndex = 12;
            this.countBox.ValueChanged += new System.EventHandler(this.kit_ValueChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.label6.Location = new System.Drawing.Point(6, 111);
            this.label6.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(23, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "Kit:";
            // 
            // frequencyBox
            // 
            this.frequencyBox.Location = new System.Drawing.Point(152, 77);
            this.frequencyBox.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.frequencyBox.Name = "frequencyBox";
            this.frequencyBox.Size = new System.Drawing.Size(46, 22);
            this.frequencyBox.TabIndex = 9;
            this.frequencyBox.ValueChanged += new System.EventHandler(this.frequencyBox_ValueChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.label4.Location = new System.Drawing.Point(126, 79);
            this.label4.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(26, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Hız:";
            // 
            // typeBox
            // 
            this.typeBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.typeBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.typeBox.FormattingEnabled = true;
            this.typeBox.Items.AddRange(new object[] {
            "DDR",
            "DDR2",
            "DDR3",
            "DDR4"});
            this.typeBox.Location = new System.Drawing.Point(54, 75);
            this.typeBox.Name = "typeBox";
            this.typeBox.Size = new System.Drawing.Size(58, 21);
            this.typeBox.TabIndex = 7;
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
            this.brandButton.Size = new System.Drawing.Size(181, 23);
            this.brandButton.TabIndex = 3;
            this.brandButton.Text = "Marka Seç...";
            this.brandButton.UseVisualStyleBackColor = false;
            this.brandButton.Click += new System.EventHandler(this.brandButton_Click);
            // 
            // bufferedBox
            // 
            this.bufferedBox.AutoSize = true;
            this.bufferedBox.Location = new System.Drawing.Point(264, 111);
            this.bufferedBox.Name = "bufferedBox";
            this.bufferedBox.Size = new System.Drawing.Size(81, 17);
            this.bufferedBox.TabIndex = 17;
            this.bufferedBox.Text = "Registered";
            this.bufferedBox.UseVisualStyleBackColor = true;
            // 
            // eccBox
            // 
            this.eccBox.AutoSize = true;
            this.eccBox.Location = new System.Drawing.Point(212, 111);
            this.eccBox.Name = "eccBox";
            this.eccBox.Size = new System.Drawing.Size(46, 17);
            this.eccBox.TabIndex = 16;
            this.eccBox.Text = "ECC";
            this.eccBox.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.label3.Location = new System.Drawing.Point(6, 79);
            this.label3.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(26, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Tip:";
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
            this.modelBox.Size = new System.Drawing.Size(312, 22);
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
            this.label7.Location = new System.Drawing.Point(89, 111);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(12, 13);
            this.label7.TabIndex = 13;
            this.label7.Text = "x";
            // 
            // capacityLabel
            // 
            this.capacityLabel.AutoSize = true;
            this.capacityLabel.Location = new System.Drawing.Point(141, 111);
            this.capacityLabel.Name = "capacityLabel";
            this.capacityLabel.Size = new System.Drawing.Size(58, 13);
            this.capacityLabel.TabIndex = 15;
            this.capacityLabel.Text = "GB = 0 GB";
            // 
            // bandwidthLabel
            // 
            this.bandwidthLabel.AutoSize = true;
            this.bandwidthLabel.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.bandwidthLabel.Location = new System.Drawing.Point(198, 79);
            this.bandwidthLabel.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.bandwidthLabel.Name = "bandwidthLabel";
            this.bandwidthLabel.Size = new System.Drawing.Size(145, 13);
            this.bandwidthLabel.TabIndex = 10;
            this.bandwidthLabel.Text = "MHz, Bant Genişliği: 0 GB/s";
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.label5.Location = new System.Drawing.Point(241, 47);
            this.label5.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 13);
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
            this.imagePanel.Size = new System.Drawing.Size(76, 145);
            this.imagePanel.TabIndex = 1;
            this.imagePanel.TabStop = false;
            this.imagePanel.Text = "Resim";
            // 
            // MemoryView
            // 
            this.AcceptButton = this.acceptButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.cancelButton;
            this.ClientSize = new System.Drawing.Size(454, 177);
            this.Controls.Add(this.entityPanel);
            this.Controls.Add(this.imagePanel);
            this.Controls.Add(this.controlPanel);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "MemoryView";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Bellek";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MemoryView_FormClosed);
            this.Load += new System.EventHandler(this.MemoryView_Load);
            this.controlPanel.ResumeLayout(false);
            this.entityPanel.ResumeLayout(false);
            this.entityPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.priceBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.capacityBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.countBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.frequencyBox)).EndInit();
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
        private System.Windows.Forms.CheckBox bufferedBox;
        private System.Windows.Forms.CheckBox eccBox;
        private System.Windows.Forms.Button brandButton;
        private System.Windows.Forms.PictureBox imageBox;
        private System.Windows.Forms.Button selectImageButton;
        private System.Windows.Forms.Button deleteImageButton;
        private System.Windows.Forms.GroupBox imagePanel;
        private System.Windows.Forms.ComboBox typeBox;
        private System.Windows.Forms.NumericUpDown frequencyBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label bandwidthLabel;
        private System.Windows.Forms.NumericUpDown capacityBox;
        private System.Windows.Forms.NumericUpDown countBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label capacityLabel;
        private System.Windows.Forms.NumericUpDown priceBox;
        private System.Windows.Forms.Label label5;
    }
}