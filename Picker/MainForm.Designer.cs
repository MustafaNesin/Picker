namespace Picker
{
    partial class MainForm
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
            this.components = new System.ComponentModel.Container();
            this.contextPanel = new System.Windows.Forms.Panel();
            this.productsGroupBox = new System.Windows.Forms.GroupBox();
            this.memoriesButton = new System.Windows.Forms.Button();
            this.processorsButton = new System.Windows.Forms.Button();
            this.graphicsButton = new System.Windows.Forms.Button();
            this.motherboardsButton = new System.Windows.Forms.Button();
            this.miscGroupBox = new System.Windows.Forms.GroupBox();
            this.brandsButton = new System.Windows.Forms.Button();
            this.socketsButton = new System.Windows.Forms.Button();
            this.chipsetsButton = new System.Windows.Forms.Button();
            this.buildsButton = new System.Windows.Forms.Button();
            this.countToolTip = new System.Windows.Forms.ToolTip(this.components);
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.copyrightLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.springLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.versionLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.contextPanel.SuspendLayout();
            this.productsGroupBox.SuspendLayout();
            this.miscGroupBox.SuspendLayout();
            this.statusStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // contextPanel
            // 
            this.contextPanel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.contextPanel.Controls.Add(this.productsGroupBox);
            this.contextPanel.Controls.Add(this.miscGroupBox);
            this.contextPanel.Controls.Add(this.buildsButton);
            this.contextPanel.Location = new System.Drawing.Point(229, 128);
            this.contextPanel.Name = "contextPanel";
            this.contextPanel.Size = new System.Drawing.Size(342, 194);
            this.contextPanel.TabIndex = 0;
            // 
            // productsGroupBox
            // 
            this.productsGroupBox.Controls.Add(this.memoriesButton);
            this.productsGroupBox.Controls.Add(this.processorsButton);
            this.productsGroupBox.Controls.Add(this.graphicsButton);
            this.productsGroupBox.Controls.Add(this.motherboardsButton);
            this.productsGroupBox.Location = new System.Drawing.Point(3, 79);
            this.productsGroupBox.Name = "productsGroupBox";
            this.productsGroupBox.Size = new System.Drawing.Size(218, 112);
            this.productsGroupBox.TabIndex = 1;
            this.productsGroupBox.TabStop = false;
            this.productsGroupBox.Tag = typeof(Picker.Models.Product);
            this.productsGroupBox.Text = "Ürünler";
            // 
            // memoriesButton
            // 
            this.memoriesButton.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.memoriesButton.Location = new System.Drawing.Point(112, 66);
            this.memoriesButton.Name = "memoriesButton";
            this.memoriesButton.Size = new System.Drawing.Size(100, 40);
            this.memoriesButton.TabIndex = 4;
            this.memoriesButton.Tag = typeof(Picker.Models.Memory);
            this.memoriesButton.Text = "Bellekler";
            this.memoriesButton.UseVisualStyleBackColor = true;
            this.memoriesButton.Click += new System.EventHandler(this.contextButtons_Click);
            // 
            // processorsButton
            // 
            this.processorsButton.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.processorsButton.Location = new System.Drawing.Point(112, 19);
            this.processorsButton.Name = "processorsButton";
            this.processorsButton.Size = new System.Drawing.Size(100, 40);
            this.processorsButton.TabIndex = 2;
            this.processorsButton.Tag = typeof(Picker.Models.Processor);
            this.processorsButton.Text = "İşlemciler";
            this.processorsButton.UseVisualStyleBackColor = true;
            this.processorsButton.Click += new System.EventHandler(this.contextButtons_Click);
            // 
            // graphicsButton
            // 
            this.graphicsButton.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.graphicsButton.Location = new System.Drawing.Point(6, 66);
            this.graphicsButton.Name = "graphicsButton";
            this.graphicsButton.Size = new System.Drawing.Size(100, 40);
            this.graphicsButton.TabIndex = 3;
            this.graphicsButton.Tag = typeof(Picker.Models.Graphics);
            this.graphicsButton.Text = "Ekran Kartları";
            this.graphicsButton.UseVisualStyleBackColor = true;
            this.graphicsButton.Click += new System.EventHandler(this.contextButtons_Click);
            // 
            // motherboardsButton
            // 
            this.motherboardsButton.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.motherboardsButton.Location = new System.Drawing.Point(6, 19);
            this.motherboardsButton.Name = "motherboardsButton";
            this.motherboardsButton.Size = new System.Drawing.Size(100, 40);
            this.motherboardsButton.TabIndex = 1;
            this.motherboardsButton.Tag = typeof(Picker.Models.Motherboard);
            this.motherboardsButton.Text = "Anakartlar";
            this.motherboardsButton.UseVisualStyleBackColor = true;
            this.motherboardsButton.Click += new System.EventHandler(this.contextButtons_Click);
            // 
            // miscGroupBox
            // 
            this.miscGroupBox.Controls.Add(this.brandsButton);
            this.miscGroupBox.Controls.Add(this.socketsButton);
            this.miscGroupBox.Controls.Add(this.chipsetsButton);
            this.miscGroupBox.Location = new System.Drawing.Point(227, 79);
            this.miscGroupBox.Name = "miscGroupBox";
            this.miscGroupBox.Size = new System.Drawing.Size(112, 112);
            this.miscGroupBox.TabIndex = 5;
            this.miscGroupBox.TabStop = false;
            this.miscGroupBox.Text = "Çeşitli";
            // 
            // brandsButton
            // 
            this.brandsButton.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.brandsButton.Location = new System.Drawing.Point(6, 19);
            this.brandsButton.Name = "brandsButton";
            this.brandsButton.Size = new System.Drawing.Size(100, 25);
            this.brandsButton.TabIndex = 5;
            this.brandsButton.Tag = typeof(Picker.Models.Brand);
            this.brandsButton.Text = "Markalar";
            this.brandsButton.UseVisualStyleBackColor = true;
            this.brandsButton.Click += new System.EventHandler(this.contextButtons_Click);
            // 
            // socketsButton
            // 
            this.socketsButton.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.socketsButton.Location = new System.Drawing.Point(6, 81);
            this.socketsButton.Name = "socketsButton";
            this.socketsButton.Size = new System.Drawing.Size(100, 25);
            this.socketsButton.TabIndex = 7;
            this.socketsButton.Tag = typeof(Picker.Models.Socket);
            this.socketsButton.Text = "Soketler";
            this.socketsButton.UseVisualStyleBackColor = true;
            this.socketsButton.Click += new System.EventHandler(this.contextButtons_Click);
            // 
            // chipsetsButton
            // 
            this.chipsetsButton.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.chipsetsButton.Location = new System.Drawing.Point(6, 50);
            this.chipsetsButton.Name = "chipsetsButton";
            this.chipsetsButton.Size = new System.Drawing.Size(100, 25);
            this.chipsetsButton.TabIndex = 6;
            this.chipsetsButton.Tag = typeof(Picker.Models.Chipset);
            this.chipsetsButton.Text = "Yonga Setleri";
            this.chipsetsButton.UseVisualStyleBackColor = true;
            this.chipsetsButton.Click += new System.EventHandler(this.contextButtons_Click);
            // 
            // buildsButton
            // 
            this.buildsButton.Font = new System.Drawing.Font("Segoe UI", 16F);
            this.buildsButton.Location = new System.Drawing.Point(3, 3);
            this.buildsButton.Name = "buildsButton";
            this.buildsButton.Size = new System.Drawing.Size(336, 70);
            this.buildsButton.TabIndex = 0;
            this.buildsButton.Tag = typeof(Picker.Models.Build);
            this.buildsButton.Text = "Bilgisayarlar";
            this.buildsButton.UseVisualStyleBackColor = true;
            this.buildsButton.Click += new System.EventHandler(this.contextButtons_Click);
            // 
            // countToolTip
            // 
            this.countToolTip.AutomaticDelay = 100;
            // 
            // statusStrip
            // 
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.copyrightLabel,
            this.springLabel,
            this.versionLabel});
            this.statusStrip.Location = new System.Drawing.Point(0, 428);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Size = new System.Drawing.Size(800, 22);
            this.statusStrip.SizingGrip = false;
            this.statusStrip.TabIndex = 4;
            this.statusStrip.Text = "statusStrip1";
            // 
            // copyrightLabel
            // 
            this.copyrightLabel.IsLink = true;
            this.copyrightLabel.Name = "copyrightLabel";
            this.copyrightLabel.Size = new System.Drawing.Size(58, 17);
            this.copyrightLabel.Text = "copyright";
            // 
            // springLabel
            // 
            this.springLabel.Name = "springLabel";
            this.springLabel.Size = new System.Drawing.Size(648, 17);
            this.springLabel.Spring = true;
            // 
            // versionLabel
            // 
            this.versionLabel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.versionLabel.Name = "versionLabel";
            this.versionLabel.Size = new System.Drawing.Size(48, 17);
            this.versionLabel.Text = "version";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.statusStrip);
            this.Controls.Add(this.contextPanel);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Picker";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.contextPanel.ResumeLayout(false);
            this.productsGroupBox.ResumeLayout(false);
            this.miscGroupBox.ResumeLayout(false);
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel contextPanel;
        private System.Windows.Forms.GroupBox productsGroupBox;
        private System.Windows.Forms.Button memoriesButton;
        private System.Windows.Forms.Button processorsButton;
        private System.Windows.Forms.Button graphicsButton;
        private System.Windows.Forms.Button motherboardsButton;
        private System.Windows.Forms.GroupBox miscGroupBox;
        private System.Windows.Forms.Button brandsButton;
        private System.Windows.Forms.Button socketsButton;
        private System.Windows.Forms.Button chipsetsButton;
        private System.Windows.Forms.Button buildsButton;
        private System.Windows.Forms.ToolTip countToolTip;
        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.ToolStripStatusLabel springLabel;
        private System.Windows.Forms.ToolStripStatusLabel copyrightLabel;
        private System.Windows.Forms.ToolStripStatusLabel versionLabel;
    }
}