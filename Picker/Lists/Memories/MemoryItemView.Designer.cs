namespace Picker
{
    partial class MemoryItemView
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
            this.bufferedLabel = new System.Windows.Forms.Label();
            this.eccLabel = new System.Windows.Forms.Label();
            this.bandwidthLabel = new System.Windows.Forms.Label();
            this.frequencyLabel = new System.Windows.Forms.Label();
            this.typeLabel = new System.Windows.Forms.Label();
            this.capacityLabel = new System.Windows.Forms.Label();
            this.brandLabel = new System.Windows.Forms.Label();
            this.countLabel = new System.Windows.Forms.Label();
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
            this.propertiesPanel.ColumnCount = 9;
            this.propertiesPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.propertiesPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.propertiesPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.propertiesPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.propertiesPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.propertiesPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.propertiesPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.propertiesPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.propertiesPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.propertiesPanel.Controls.Add(this.bufferedLabel, 7, 0);
            this.propertiesPanel.Controls.Add(this.eccLabel, 6, 0);
            this.propertiesPanel.Controls.Add(this.bandwidthLabel, 5, 0);
            this.propertiesPanel.Controls.Add(this.frequencyLabel, 4, 0);
            this.propertiesPanel.Controls.Add(this.typeLabel, 3, 0);
            this.propertiesPanel.Controls.Add(this.capacityLabel, 2, 0);
            this.propertiesPanel.Controls.Add(this.brandLabel, 0, 0);
            this.propertiesPanel.Controls.Add(this.countLabel, 1, 0);
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
            // bufferedLabel
            // 
            this.bufferedLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.bufferedLabel.AutoSize = true;
            this.bufferedLabel.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Strikeout, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.bufferedLabel.ForeColor = System.Drawing.Color.Red;
            this.bufferedLabel.Location = new System.Drawing.Point(359, 9);
            this.bufferedLabel.Name = "bufferedLabel";
            this.bufferedLabel.Size = new System.Drawing.Size(62, 13);
            this.bufferedLabel.TabIndex = 7;
            this.bufferedLabel.Text = "Registered";
            // 
            // eccLabel
            // 
            this.eccLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.eccLabel.AutoSize = true;
            this.eccLabel.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Strikeout, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.eccLabel.ForeColor = System.Drawing.Color.Red;
            this.eccLabel.Location = new System.Drawing.Point(326, 9);
            this.eccLabel.Name = "eccLabel";
            this.eccLabel.Size = new System.Drawing.Size(27, 13);
            this.eccLabel.TabIndex = 6;
            this.eccLabel.Text = "ECC";
            // 
            // bandwidthLabel
            // 
            this.bandwidthLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.bandwidthLabel.AutoSize = true;
            this.bandwidthLabel.Location = new System.Drawing.Point(257, 9);
            this.bandwidthLabel.Name = "bandwidthLabel";
            this.bandwidthLabel.Size = new System.Drawing.Size(63, 13);
            this.bandwidthLabel.TabIndex = 5;
            this.bandwidthLabel.Text = "Bandwidth";
            // 
            // frequencyLabel
            // 
            this.frequencyLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.frequencyLabel.AutoSize = true;
            this.frequencyLabel.Location = new System.Drawing.Point(191, 9);
            this.frequencyLabel.Name = "frequencyLabel";
            this.frequencyLabel.Size = new System.Drawing.Size(60, 13);
            this.frequencyLabel.TabIndex = 4;
            this.frequencyLabel.Text = "Frequency";
            // 
            // typeLabel
            // 
            this.typeLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.typeLabel.AutoSize = true;
            this.typeLabel.Location = new System.Drawing.Point(155, 9);
            this.typeLabel.Name = "typeLabel";
            this.typeLabel.Size = new System.Drawing.Size(30, 13);
            this.typeLabel.TabIndex = 3;
            this.typeLabel.Text = "Type";
            // 
            // capacityLabel
            // 
            this.capacityLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.capacityLabel.AutoSize = true;
            this.capacityLabel.Location = new System.Drawing.Point(99, 9);
            this.capacityLabel.Name = "capacityLabel";
            this.capacityLabel.Size = new System.Drawing.Size(50, 13);
            this.capacityLabel.TabIndex = 2;
            this.capacityLabel.Text = "Capacity";
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
            // countLabel
            // 
            this.countLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.countLabel.AutoSize = true;
            this.countLabel.Location = new System.Drawing.Point(54, 9);
            this.countLabel.Name = "countLabel";
            this.countLabel.Size = new System.Drawing.Size(39, 13);
            this.countLabel.TabIndex = 1;
            this.countLabel.Text = "Count";
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
            // MemoryItemView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.Controls.Add(this.itemPanel);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.MinimumSize = new System.Drawing.Size(914, 76);
            this.Name = "MemoryItemView";
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
        private System.Windows.Forms.Label countLabel;
        private System.Windows.Forms.Label priceLabel;
        private System.Windows.Forms.Label frequencyLabel;
        private System.Windows.Forms.Label typeLabel;
        private System.Windows.Forms.Label capacityLabel;
        private System.Windows.Forms.Label bandwidthLabel;
        private System.Windows.Forms.Label eccLabel;
        private System.Windows.Forms.Label bufferedLabel;
    }
}
