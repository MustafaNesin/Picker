namespace Picker
{
    partial class MotherboardItemView
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.itemPanel = new System.Windows.Forms.Panel();
            this.nameLabel = new System.Windows.Forms.Label();
            this.priceLabel = new System.Windows.Forms.Label();
            this.propertiesPanel = new System.Windows.Forms.TableLayoutPanel();
            this.eccLabel = new System.Windows.Forms.Label();
            this.maxMemoryFrequencyLabel = new System.Windows.Forms.Label();
            this.maxMemoryLabel = new System.Windows.Forms.Label();
            this.memorySlotsLabel = new System.Windows.Forms.Label();
            this.memoryTypeLabel = new System.Windows.Forms.Label();
            this.socketLabel = new System.Windows.Forms.Label();
            this.formFactorLabel = new System.Windows.Forms.Label();
            this.brandLabel = new System.Windows.Forms.Label();
            this.chipsetLabel = new System.Windows.Forms.Label();
            this.controlPanel = new System.Windows.Forms.Panel();
            this.mainButton = new System.Windows.Forms.Button();
            this.deleteButton = new System.Windows.Forms.Button();
            this.imagePanel = new System.Windows.Forms.Panel();
            this.imageBox = new System.Windows.Forms.PictureBox();
            this.itemPanel.SuspendLayout();
            this.propertiesPanel.SuspendLayout();
            this.controlPanel.SuspendLayout();
            this.imagePanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imageBox)).BeginInit();
            this.SuspendLayout();
            // 
            // itemPanel
            // 
            this.itemPanel.BackColor = System.Drawing.Color.Green;
            this.itemPanel.Controls.Add(this.nameLabel);
            this.itemPanel.Controls.Add(this.priceLabel);
            this.itemPanel.Controls.Add(this.propertiesPanel);
            this.itemPanel.Controls.Add(this.controlPanel);
            this.itemPanel.Controls.Add(this.imagePanel);
            this.itemPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.itemPanel.Location = new System.Drawing.Point(3, 3);
            this.itemPanel.Name = "itemPanel";
            this.itemPanel.Padding = new System.Windows.Forms.Padding(3);
            this.itemPanel.Size = new System.Drawing.Size(908, 70);
            this.itemPanel.TabIndex = 0;
            // 
            // nameLabel
            // 
            this.nameLabel.BackColor = System.Drawing.Color.White;
            this.nameLabel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.nameLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.nameLabel.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.nameLabel.ForeColor = System.Drawing.Color.Green;
            this.nameLabel.Location = new System.Drawing.Point(77, 3);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Padding = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.nameLabel.Size = new System.Drawing.Size(661, 32);
            this.nameLabel.TabIndex = 1;
            this.nameLabel.Text = "Name";
            this.nameLabel.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.nameLabel.Click += new System.EventHandler(this.entity_Click);
            // 
            // priceLabel
            // 
            this.priceLabel.BackColor = System.Drawing.Color.White;
            this.priceLabel.Dock = System.Windows.Forms.DockStyle.Right;
            this.priceLabel.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.priceLabel.ForeColor = System.Drawing.Color.Green;
            this.priceLabel.Location = new System.Drawing.Point(738, 3);
            this.priceLabel.Name = "priceLabel";
            this.priceLabel.Size = new System.Drawing.Size(97, 32);
            this.priceLabel.TabIndex = 2;
            this.priceLabel.Text = "$0.00";
            this.priceLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // propertiesPanel
            // 
            this.propertiesPanel.BackColor = System.Drawing.Color.White;
            this.propertiesPanel.ColumnCount = 10;
            this.propertiesPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.propertiesPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.propertiesPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.propertiesPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.propertiesPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.propertiesPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.propertiesPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.propertiesPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.propertiesPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.propertiesPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.propertiesPanel.Controls.Add(this.eccLabel, 8, 0);
            this.propertiesPanel.Controls.Add(this.maxMemoryFrequencyLabel, 7, 0);
            this.propertiesPanel.Controls.Add(this.maxMemoryLabel, 6, 0);
            this.propertiesPanel.Controls.Add(this.memorySlotsLabel, 5, 0);
            this.propertiesPanel.Controls.Add(this.memoryTypeLabel, 4, 0);
            this.propertiesPanel.Controls.Add(this.socketLabel, 2, 0);
            this.propertiesPanel.Controls.Add(this.formFactorLabel, 3, 0);
            this.propertiesPanel.Controls.Add(this.brandLabel, 0, 0);
            this.propertiesPanel.Controls.Add(this.chipsetLabel, 1, 0);
            this.propertiesPanel.Cursor = System.Windows.Forms.Cursors.Default;
            this.propertiesPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.propertiesPanel.Location = new System.Drawing.Point(77, 35);
            this.propertiesPanel.Name = "propertiesPanel";
            this.propertiesPanel.RowCount = 1;
            this.propertiesPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.propertiesPanel.Size = new System.Drawing.Size(758, 32);
            this.propertiesPanel.TabIndex = 3;
            this.propertiesPanel.Click += new System.EventHandler(this.entity_Click);
            // 
            // eccLabel
            // 
            this.eccLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.eccLabel.AutoSize = true;
            this.eccLabel.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Strikeout, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.eccLabel.ForeColor = System.Drawing.Color.Red;
            this.eccLabel.Location = new System.Drawing.Point(601, 9);
            this.eccLabel.Name = "eccLabel";
            this.eccLabel.Size = new System.Drawing.Size(27, 13);
            this.eccLabel.TabIndex = 8;
            this.eccLabel.Text = "ECC";
            // 
            // maxMemoryFrequencyLabel
            // 
            this.maxMemoryFrequencyLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.maxMemoryFrequencyLabel.AutoSize = true;
            this.maxMemoryFrequencyLabel.Location = new System.Drawing.Point(467, 9);
            this.maxMemoryFrequencyLabel.Name = "maxMemoryFrequencyLabel";
            this.maxMemoryFrequencyLabel.Size = new System.Drawing.Size(128, 13);
            this.maxMemoryFrequencyLabel.TabIndex = 7;
            this.maxMemoryFrequencyLabel.Text = "Max Memory Frequency";
            // 
            // maxMemoryLabel
            // 
            this.maxMemoryLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.maxMemoryLabel.AutoSize = true;
            this.maxMemoryLabel.Location = new System.Drawing.Point(389, 9);
            this.maxMemoryLabel.Name = "maxMemoryLabel";
            this.maxMemoryLabel.Size = new System.Drawing.Size(72, 13);
            this.maxMemoryLabel.TabIndex = 6;
            this.maxMemoryLabel.Text = "Max Memory";
            // 
            // memorySlotsLabel
            // 
            this.memorySlotsLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.memorySlotsLabel.AutoSize = true;
            this.memorySlotsLabel.Location = new System.Drawing.Point(307, 9);
            this.memorySlotsLabel.Name = "memorySlotsLabel";
            this.memorySlotsLabel.Size = new System.Drawing.Size(76, 13);
            this.memorySlotsLabel.TabIndex = 5;
            this.memorySlotsLabel.Text = "Memory Slots";
            // 
            // memoryTypeLabel
            // 
            this.memoryTypeLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.memoryTypeLabel.AutoSize = true;
            this.memoryTypeLabel.Location = new System.Drawing.Point(227, 9);
            this.memoryTypeLabel.Name = "memoryTypeLabel";
            this.memoryTypeLabel.Size = new System.Drawing.Size(74, 13);
            this.memoryTypeLabel.TabIndex = 4;
            this.memoryTypeLabel.Text = "Memory Type";
            // 
            // socketLabel
            // 
            this.socketLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.socketLabel.AutoSize = true;
            this.socketLabel.Location = new System.Drawing.Point(106, 9);
            this.socketLabel.Name = "socketLabel";
            this.socketLabel.Size = new System.Drawing.Size(41, 13);
            this.socketLabel.TabIndex = 3;
            this.socketLabel.Text = "Socket";
            // 
            // formFactorLabel
            // 
            this.formFactorLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.formFactorLabel.AutoSize = true;
            this.formFactorLabel.Location = new System.Drawing.Point(153, 9);
            this.formFactorLabel.Name = "formFactorLabel";
            this.formFactorLabel.Size = new System.Drawing.Size(68, 13);
            this.formFactorLabel.TabIndex = 2;
            this.formFactorLabel.Text = "Form Factor";
            // 
            // brandLabel
            // 
            this.brandLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.brandLabel.AutoSize = true;
            this.brandLabel.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.brandLabel.ForeColor = System.Drawing.SystemColors.ControlText;
            this.brandLabel.Location = new System.Drawing.Point(3, 6);
            this.brandLabel.Name = "brandLabel";
            this.brandLabel.Size = new System.Drawing.Size(45, 19);
            this.brandLabel.TabIndex = 0;
            this.brandLabel.Text = "Brand";
            // 
            // chipsetLabel
            // 
            this.chipsetLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.chipsetLabel.AutoSize = true;
            this.chipsetLabel.Location = new System.Drawing.Point(54, 9);
            this.chipsetLabel.Name = "chipsetLabel";
            this.chipsetLabel.Size = new System.Drawing.Size(46, 13);
            this.chipsetLabel.TabIndex = 1;
            this.chipsetLabel.Text = "Chipset";
            // 
            // controlPanel
            // 
            this.controlPanel.BackColor = System.Drawing.Color.White;
            this.controlPanel.Controls.Add(this.mainButton);
            this.controlPanel.Controls.Add(this.deleteButton);
            this.controlPanel.Dock = System.Windows.Forms.DockStyle.Right;
            this.controlPanel.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.controlPanel.Location = new System.Drawing.Point(835, 3);
            this.controlPanel.Name = "controlPanel";
            this.controlPanel.Padding = new System.Windows.Forms.Padding(1);
            this.controlPanel.Size = new System.Drawing.Size(70, 64);
            this.controlPanel.TabIndex = 0;
            // 
            // mainButton
            // 
            this.mainButton.BackColor = System.Drawing.Color.Green;
            this.mainButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.mainButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainButton.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.mainButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.mainButton.ForeColor = System.Drawing.Color.White;
            this.mainButton.Location = new System.Drawing.Point(1, 1);
            this.mainButton.Name = "mainButton";
            this.mainButton.Size = new System.Drawing.Size(68, 30);
            this.mainButton.TabIndex = 0;
            this.mainButton.Text = "Düzenle";
            this.mainButton.UseVisualStyleBackColor = false;
            this.mainButton.Click += new System.EventHandler(this.mainButton_Click);
            // 
            // deleteButton
            // 
            this.deleteButton.BackColor = System.Drawing.Color.Green;
            this.deleteButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.deleteButton.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.deleteButton.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.deleteButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.deleteButton.ForeColor = System.Drawing.Color.White;
            this.deleteButton.Location = new System.Drawing.Point(1, 31);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(68, 32);
            this.deleteButton.TabIndex = 1;
            this.deleteButton.Text = "Sil";
            this.deleteButton.UseVisualStyleBackColor = false;
            this.deleteButton.Click += new System.EventHandler(this.deleteButton_Click);
            // 
            // imagePanel
            // 
            this.imagePanel.BackColor = System.Drawing.Color.White;
            this.imagePanel.Controls.Add(this.imageBox);
            this.imagePanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.imagePanel.Location = new System.Drawing.Point(3, 3);
            this.imagePanel.Name = "imagePanel";
            this.imagePanel.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.imagePanel.Size = new System.Drawing.Size(74, 64);
            this.imagePanel.TabIndex = 4;
            // 
            // imageBox
            // 
            this.imageBox.BackColor = System.Drawing.Color.White;
            this.imageBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.imageBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.imageBox.Location = new System.Drawing.Point(10, 0);
            this.imageBox.Name = "imageBox";
            this.imageBox.Size = new System.Drawing.Size(64, 64);
            this.imageBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.imageBox.TabIndex = 1;
            this.imageBox.TabStop = false;
            this.imageBox.Click += new System.EventHandler(this.entity_Click);
            // 
            // MotherboardItemView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.Controls.Add(this.itemPanel);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.MinimumSize = new System.Drawing.Size(914, 76);
            this.Name = "MotherboardItemView";
            this.Padding = new System.Windows.Forms.Padding(3);
            this.Size = new System.Drawing.Size(914, 76);
            this.itemPanel.ResumeLayout(false);
            this.propertiesPanel.ResumeLayout(false);
            this.propertiesPanel.PerformLayout();
            this.controlPanel.ResumeLayout(false);
            this.imagePanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.imageBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel itemPanel;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.Panel controlPanel;
        private System.Windows.Forms.Button mainButton;
        private System.Windows.Forms.TableLayoutPanel propertiesPanel;
        private System.Windows.Forms.Label brandLabel;
        private System.Windows.Forms.Panel imagePanel;
        private System.Windows.Forms.PictureBox imageBox;
        private System.Windows.Forms.Button deleteButton;
        private System.Windows.Forms.Label chipsetLabel;
        private System.Windows.Forms.Label priceLabel;
        private System.Windows.Forms.Label memoryTypeLabel;
        private System.Windows.Forms.Label socketLabel;
        private System.Windows.Forms.Label formFactorLabel;
        private System.Windows.Forms.Label memorySlotsLabel;
        private System.Windows.Forms.Label eccLabel;
        private System.Windows.Forms.Label maxMemoryFrequencyLabel;
        private System.Windows.Forms.Label maxMemoryLabel;
    }
}
