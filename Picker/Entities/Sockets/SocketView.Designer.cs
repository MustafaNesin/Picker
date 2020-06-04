namespace Picker
{
    partial class SocketView
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SocketView));
            this.controlPanel = new System.Windows.Forms.Panel();
            this.cancelButton = new System.Windows.Forms.Button();
            this.acceptButton = new System.Windows.Forms.Button();
            this.entityPanel = new System.Windows.Forms.Panel();
            this.brandButton = new System.Windows.Forms.Button();
            this.ddr4Box = new System.Windows.Forms.CheckBox();
            this.ddr3Box = new System.Windows.Forms.CheckBox();
            this.ddr2Box = new System.Windows.Forms.CheckBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.nameBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.imageBox = new System.Windows.Forms.PictureBox();
            this.selectImageButton = new System.Windows.Forms.Button();
            this.deleteImageButton = new System.Windows.Forms.Button();
            this.imagePanel = new System.Windows.Forms.GroupBox();
            this.controlPanel.SuspendLayout();
            this.entityPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imageBox)).BeginInit();
            this.imagePanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // controlPanel
            // 
            this.controlPanel.Controls.Add(this.cancelButton);
            this.controlPanel.Controls.Add(this.acceptButton);
            this.controlPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.controlPanel.Location = new System.Drawing.Point(0, 135);
            this.controlPanel.Name = "controlPanel";
            this.controlPanel.Size = new System.Drawing.Size(386, 32);
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
            this.acceptButton.Location = new System.Drawing.Point(297, 0);
            this.acceptButton.Name = "acceptButton";
            this.acceptButton.Size = new System.Drawing.Size(89, 32);
            this.acceptButton.TabIndex = 0;
            this.acceptButton.Text = "Tamam";
            this.acceptButton.UseVisualStyleBackColor = false;
            this.acceptButton.Click += new System.EventHandler(this.acceptButton_Click);
            // 
            // entityPanel
            // 
            this.entityPanel.Controls.Add(this.brandButton);
            this.entityPanel.Controls.Add(this.ddr4Box);
            this.entityPanel.Controls.Add(this.ddr3Box);
            this.entityPanel.Controls.Add(this.ddr2Box);
            this.entityPanel.Controls.Add(this.label3);
            this.entityPanel.Controls.Add(this.label2);
            this.entityPanel.Controls.Add(this.nameBox);
            this.entityPanel.Controls.Add(this.label1);
            this.entityPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.entityPanel.Location = new System.Drawing.Point(76, 0);
            this.entityPanel.Name = "entityPanel";
            this.entityPanel.Size = new System.Drawing.Size(310, 135);
            this.entityPanel.TabIndex = 0;
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
            this.brandButton.Location = new System.Drawing.Point(94, 42);
            this.brandButton.Name = "brandButton";
            this.brandButton.Size = new System.Drawing.Size(204, 23);
            this.brandButton.TabIndex = 3;
            this.brandButton.Text = "Marka Seç...";
            this.brandButton.UseVisualStyleBackColor = false;
            this.brandButton.Click += new System.EventHandler(this.brandButton_Click);
            // 
            // ddr4Box
            // 
            this.ddr4Box.AutoSize = true;
            this.ddr4Box.Location = new System.Drawing.Point(216, 78);
            this.ddr4Box.Name = "ddr4Box";
            this.ddr4Box.Size = new System.Drawing.Size(55, 17);
            this.ddr4Box.TabIndex = 7;
            this.ddr4Box.Text = "DDR4";
            this.ddr4Box.UseVisualStyleBackColor = true;
            // 
            // ddr3Box
            // 
            this.ddr3Box.AutoSize = true;
            this.ddr3Box.Location = new System.Drawing.Point(155, 78);
            this.ddr3Box.Name = "ddr3Box";
            this.ddr3Box.Size = new System.Drawing.Size(55, 17);
            this.ddr3Box.TabIndex = 6;
            this.ddr3Box.Text = "DDR3";
            this.ddr3Box.UseVisualStyleBackColor = true;
            // 
            // ddr2Box
            // 
            this.ddr2Box.AutoSize = true;
            this.ddr2Box.Location = new System.Drawing.Point(94, 78);
            this.ddr2Box.Name = "ddr2Box";
            this.ddr2Box.Size = new System.Drawing.Size(55, 17);
            this.ddr2Box.TabIndex = 5;
            this.ddr2Box.Text = "DDR2";
            this.ddr2Box.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.label3.Location = new System.Drawing.Point(6, 79);
            this.label3.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Bellek Desteği:";
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
            // nameBox
            // 
            this.nameBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.nameBox.Location = new System.Drawing.Point(94, 12);
            this.nameBox.Name = "nameBox";
            this.nameBox.Size = new System.Drawing.Size(204, 22);
            this.nameBox.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.label1.Location = new System.Drawing.Point(6, 15);
            this.label1.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(24, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ad:";
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
            this.imagePanel.Size = new System.Drawing.Size(76, 135);
            this.imagePanel.TabIndex = 1;
            this.imagePanel.TabStop = false;
            this.imagePanel.Text = "Resim";
            // 
            // SocketView
            // 
            this.AcceptButton = this.acceptButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.cancelButton;
            this.ClientSize = new System.Drawing.Size(386, 167);
            this.Controls.Add(this.entityPanel);
            this.Controls.Add(this.imagePanel);
            this.Controls.Add(this.controlPanel);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "SocketView";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Soket";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.SocketView_FormClosed);
            this.Load += new System.EventHandler(this.SocketView_Load);
            this.controlPanel.ResumeLayout(false);
            this.entityPanel.ResumeLayout(false);
            this.entityPanel.PerformLayout();
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
        private System.Windows.Forms.TextBox nameBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox ddr4Box;
        private System.Windows.Forms.CheckBox ddr3Box;
        private System.Windows.Forms.CheckBox ddr2Box;
        private System.Windows.Forms.Button brandButton;
        private System.Windows.Forms.PictureBox imageBox;
        private System.Windows.Forms.Button selectImageButton;
        private System.Windows.Forms.Button deleteImageButton;
        private System.Windows.Forms.GroupBox imagePanel;
    }
}