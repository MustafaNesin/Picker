namespace Picker
{
    partial class SocketItemView
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
            this.propertiesPanel = new System.Windows.Forms.TableLayoutPanel();
            this.ddr4Label = new System.Windows.Forms.Label();
            this.ddr3Label = new System.Windows.Forms.Label();
            this.brandLabel = new System.Windows.Forms.Label();
            this.ddr2Label = new System.Windows.Forms.Label();
            this.nameLabel = new System.Windows.Forms.Label();
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
            this.itemPanel.Controls.Add(this.propertiesPanel);
            this.itemPanel.Controls.Add(this.nameLabel);
            this.itemPanel.Controls.Add(this.controlPanel);
            this.itemPanel.Controls.Add(this.imagePanel);
            this.itemPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.itemPanel.Location = new System.Drawing.Point(3, 3);
            this.itemPanel.Name = "itemPanel";
            this.itemPanel.Padding = new System.Windows.Forms.Padding(3);
            this.itemPanel.Size = new System.Drawing.Size(716, 70);
            this.itemPanel.TabIndex = 0;
            // 
            // propertiesPanel
            // 
            this.propertiesPanel.BackColor = System.Drawing.Color.White;
            this.propertiesPanel.ColumnCount = 5;
            this.propertiesPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.propertiesPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.propertiesPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.propertiesPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.propertiesPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 357F));
            this.propertiesPanel.Controls.Add(this.ddr4Label, 3, 0);
            this.propertiesPanel.Controls.Add(this.ddr3Label, 2, 0);
            this.propertiesPanel.Controls.Add(this.brandLabel, 0, 0);
            this.propertiesPanel.Controls.Add(this.ddr2Label, 1, 0);
            this.propertiesPanel.Cursor = System.Windows.Forms.Cursors.Default;
            this.propertiesPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.propertiesPanel.Location = new System.Drawing.Point(77, 35);
            this.propertiesPanel.Name = "propertiesPanel";
            this.propertiesPanel.RowCount = 1;
            this.propertiesPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.propertiesPanel.Size = new System.Drawing.Size(540, 32);
            this.propertiesPanel.TabIndex = 2;
            this.propertiesPanel.Click += new System.EventHandler(this.entity_Click);
            // 
            // ddr4Label
            // 
            this.ddr4Label.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.ddr4Label.AutoSize = true;
            this.ddr4Label.ForeColor = System.Drawing.Color.Red;
            this.ddr4Label.Location = new System.Drawing.Point(141, 9);
            this.ddr4Label.Name = "ddr4Label";
            this.ddr4Label.Size = new System.Drawing.Size(36, 13);
            this.ddr4Label.TabIndex = 3;
            this.ddr4Label.Text = "DDR4";
            // 
            // ddr3Label
            // 
            this.ddr3Label.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.ddr3Label.AutoSize = true;
            this.ddr3Label.ForeColor = System.Drawing.Color.Red;
            this.ddr3Label.Location = new System.Drawing.Point(99, 9);
            this.ddr3Label.Name = "ddr3Label";
            this.ddr3Label.Size = new System.Drawing.Size(36, 13);
            this.ddr3Label.TabIndex = 2;
            this.ddr3Label.Text = "DDR3";
            // 
            // brandLabel
            // 
            this.brandLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.brandLabel.AutoSize = true;
            this.brandLabel.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.brandLabel.ForeColor = System.Drawing.SystemColors.ControlText;
            this.brandLabel.Location = new System.Drawing.Point(3, 6);
            this.brandLabel.Name = "brandLabel";
            this.brandLabel.Size = new System.Drawing.Size(48, 19);
            this.brandLabel.TabIndex = 0;
            this.brandLabel.Text = "Marka";
            // 
            // ddr2Label
            // 
            this.ddr2Label.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.ddr2Label.AutoSize = true;
            this.ddr2Label.ForeColor = System.Drawing.Color.Red;
            this.ddr2Label.Location = new System.Drawing.Point(57, 9);
            this.ddr2Label.Name = "ddr2Label";
            this.ddr2Label.Size = new System.Drawing.Size(36, 13);
            this.ddr2Label.TabIndex = 1;
            this.ddr2Label.Text = "DDR2";
            // 
            // nameLabel
            // 
            this.nameLabel.BackColor = System.Drawing.Color.White;
            this.nameLabel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.nameLabel.Dock = System.Windows.Forms.DockStyle.Top;
            this.nameLabel.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.nameLabel.ForeColor = System.Drawing.Color.Green;
            this.nameLabel.Location = new System.Drawing.Point(77, 3);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Padding = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.nameLabel.Size = new System.Drawing.Size(540, 32);
            this.nameLabel.TabIndex = 1;
            this.nameLabel.Text = "Name";
            this.nameLabel.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.nameLabel.Click += new System.EventHandler(this.entity_Click);
            // 
            // controlPanel
            // 
            this.controlPanel.BackColor = System.Drawing.Color.White;
            this.controlPanel.Controls.Add(this.mainButton);
            this.controlPanel.Controls.Add(this.deleteButton);
            this.controlPanel.Dock = System.Windows.Forms.DockStyle.Right;
            this.controlPanel.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.controlPanel.Location = new System.Drawing.Point(617, 3);
            this.controlPanel.Name = "controlPanel";
            this.controlPanel.Padding = new System.Windows.Forms.Padding(1);
            this.controlPanel.Size = new System.Drawing.Size(96, 64);
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
            this.mainButton.Size = new System.Drawing.Size(94, 30);
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
            this.deleteButton.Size = new System.Drawing.Size(94, 32);
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
            this.imagePanel.TabIndex = 3;
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
            // SocketItemView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.Controls.Add(this.itemPanel);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Name = "SocketItemView";
            this.Padding = new System.Windows.Forms.Padding(3);
            this.Size = new System.Drawing.Size(722, 76);
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
        private System.Windows.Forms.Label ddr4Label;
        private System.Windows.Forms.Label ddr3Label;
        private System.Windows.Forms.Label ddr2Label;
    }
}
