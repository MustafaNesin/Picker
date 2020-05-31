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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.contextPanel = new System.Windows.Forms.Panel();
            this.productsGroupBox = new System.Windows.Forms.GroupBox();
            this.memoriesButton = new System.Windows.Forms.Button();
            this.processorsButton = new System.Windows.Forms.Button();
            this.graphicsCardButton = new System.Windows.Forms.Button();
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
            this.exitButton = new System.Windows.Forms.Button();
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
            this.productsGroupBox.Controls.Add(this.graphicsCardButton);
            this.productsGroupBox.Controls.Add(this.motherboardsButton);
            this.productsGroupBox.Location = new System.Drawing.Point(3, 79);
            this.productsGroupBox.Name = "productsGroupBox";
            this.productsGroupBox.Size = new System.Drawing.Size(218, 112);
            this.productsGroupBox.TabIndex = 1;
            this.productsGroupBox.TabStop = false;
            this.productsGroupBox.Text = "Ürünler";
            // 
            // memoriesButton
            // 
            this.memoriesButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.memoriesButton.Cursor = System.Windows.Forms.Cursors.Default;
            this.memoriesButton.FlatAppearance.BorderColor = System.Drawing.Color.Teal;
            this.memoriesButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(160)))), ((int)(((byte)(160)))));
            this.memoriesButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.memoriesButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.memoriesButton.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.memoriesButton.ForeColor = System.Drawing.Color.White;
            this.memoriesButton.Location = new System.Drawing.Point(112, 66);
            this.memoriesButton.Name = "memoriesButton";
            this.memoriesButton.Size = new System.Drawing.Size(100, 40);
            this.memoriesButton.TabIndex = 4;
            this.memoriesButton.Text = "Bellekler";
            this.memoriesButton.UseVisualStyleBackColor = false;
            this.memoriesButton.Click += new System.EventHandler(this.memoriesButton_Click);
            // 
            // processorsButton
            // 
            this.processorsButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.processorsButton.Cursor = System.Windows.Forms.Cursors.Default;
            this.processorsButton.FlatAppearance.BorderColor = System.Drawing.Color.Teal;
            this.processorsButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(160)))), ((int)(((byte)(160)))));
            this.processorsButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.processorsButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.processorsButton.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.processorsButton.ForeColor = System.Drawing.Color.White;
            this.processorsButton.Location = new System.Drawing.Point(112, 19);
            this.processorsButton.Name = "processorsButton";
            this.processorsButton.Size = new System.Drawing.Size(100, 40);
            this.processorsButton.TabIndex = 2;
            this.processorsButton.Text = "İşlemciler";
            this.processorsButton.UseVisualStyleBackColor = false;
            this.processorsButton.Click += new System.EventHandler(this.processorsButton_Click);
            // 
            // graphicsCardButton
            // 
            this.graphicsCardButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.graphicsCardButton.Cursor = System.Windows.Forms.Cursors.Default;
            this.graphicsCardButton.FlatAppearance.BorderColor = System.Drawing.Color.Teal;
            this.graphicsCardButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(160)))), ((int)(((byte)(160)))));
            this.graphicsCardButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.graphicsCardButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.graphicsCardButton.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.graphicsCardButton.ForeColor = System.Drawing.Color.White;
            this.graphicsCardButton.Location = new System.Drawing.Point(6, 66);
            this.graphicsCardButton.Name = "graphicsCardButton";
            this.graphicsCardButton.Size = new System.Drawing.Size(100, 40);
            this.graphicsCardButton.TabIndex = 3;
            this.graphicsCardButton.Text = "Ekran Kartları";
            this.graphicsCardButton.UseVisualStyleBackColor = false;
            this.graphicsCardButton.Click += new System.EventHandler(this.graphicsCardButton_Click);
            // 
            // motherboardsButton
            // 
            this.motherboardsButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.motherboardsButton.Cursor = System.Windows.Forms.Cursors.Default;
            this.motherboardsButton.FlatAppearance.BorderColor = System.Drawing.Color.Teal;
            this.motherboardsButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(160)))), ((int)(((byte)(160)))));
            this.motherboardsButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.motherboardsButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.motherboardsButton.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.motherboardsButton.ForeColor = System.Drawing.Color.White;
            this.motherboardsButton.Location = new System.Drawing.Point(6, 19);
            this.motherboardsButton.Name = "motherboardsButton";
            this.motherboardsButton.Size = new System.Drawing.Size(100, 40);
            this.motherboardsButton.TabIndex = 1;
            this.motherboardsButton.Text = "Anakartlar";
            this.motherboardsButton.UseVisualStyleBackColor = false;
            this.motherboardsButton.Click += new System.EventHandler(this.motherboardsButton_Click);
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
            this.brandsButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.brandsButton.Cursor = System.Windows.Forms.Cursors.Default;
            this.brandsButton.FlatAppearance.BorderColor = System.Drawing.Color.Teal;
            this.brandsButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(160)))), ((int)(((byte)(160)))));
            this.brandsButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.brandsButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.brandsButton.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.brandsButton.ForeColor = System.Drawing.Color.White;
            this.brandsButton.Location = new System.Drawing.Point(6, 19);
            this.brandsButton.Name = "brandsButton";
            this.brandsButton.Size = new System.Drawing.Size(100, 25);
            this.brandsButton.TabIndex = 5;
            this.brandsButton.Text = "Markalar";
            this.brandsButton.UseVisualStyleBackColor = false;
            this.brandsButton.Click += new System.EventHandler(this.brandsButton_Click);
            // 
            // socketsButton
            // 
            this.socketsButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.socketsButton.Cursor = System.Windows.Forms.Cursors.Default;
            this.socketsButton.FlatAppearance.BorderColor = System.Drawing.Color.Teal;
            this.socketsButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(160)))), ((int)(((byte)(160)))));
            this.socketsButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.socketsButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.socketsButton.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.socketsButton.ForeColor = System.Drawing.Color.White;
            this.socketsButton.Location = new System.Drawing.Point(6, 81);
            this.socketsButton.Name = "socketsButton";
            this.socketsButton.Size = new System.Drawing.Size(100, 25);
            this.socketsButton.TabIndex = 7;
            this.socketsButton.Text = "Soketler";
            this.socketsButton.UseVisualStyleBackColor = false;
            this.socketsButton.Click += new System.EventHandler(this.socketsButton_Click);
            // 
            // chipsetsButton
            // 
            this.chipsetsButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.chipsetsButton.Cursor = System.Windows.Forms.Cursors.Default;
            this.chipsetsButton.FlatAppearance.BorderColor = System.Drawing.Color.Teal;
            this.chipsetsButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(160)))), ((int)(((byte)(160)))));
            this.chipsetsButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.chipsetsButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.chipsetsButton.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.chipsetsButton.ForeColor = System.Drawing.Color.White;
            this.chipsetsButton.Location = new System.Drawing.Point(6, 50);
            this.chipsetsButton.Name = "chipsetsButton";
            this.chipsetsButton.Size = new System.Drawing.Size(100, 25);
            this.chipsetsButton.TabIndex = 6;
            this.chipsetsButton.Text = "Yonga Setleri";
            this.chipsetsButton.UseVisualStyleBackColor = false;
            this.chipsetsButton.Click += new System.EventHandler(this.chipsetsButton_Click);
            // 
            // buildsButton
            // 
            this.buildsButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.buildsButton.Cursor = System.Windows.Forms.Cursors.Default;
            this.buildsButton.FlatAppearance.BorderColor = System.Drawing.Color.Teal;
            this.buildsButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(160)))), ((int)(((byte)(160)))));
            this.buildsButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.buildsButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buildsButton.Font = new System.Drawing.Font("Segoe UI", 16F);
            this.buildsButton.ForeColor = System.Drawing.Color.White;
            this.buildsButton.Location = new System.Drawing.Point(3, 3);
            this.buildsButton.Name = "buildsButton";
            this.buildsButton.Size = new System.Drawing.Size(336, 70);
            this.buildsButton.TabIndex = 0;
            this.buildsButton.Text = "Bilgisayarlar";
            this.buildsButton.UseVisualStyleBackColor = false;
            this.buildsButton.Click += new System.EventHandler(this.buildsButton_Click);
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
            this.copyrightLabel.Click += new System.EventHandler(this.copyrightLabel_Click);
            // 
            // springLabel
            // 
            this.springLabel.Name = "springLabel";
            this.springLabel.Size = new System.Drawing.Size(679, 17);
            this.springLabel.Spring = true;
            // 
            // versionLabel
            // 
            this.versionLabel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.versionLabel.Name = "versionLabel";
            this.versionLabel.Size = new System.Drawing.Size(48, 17);
            this.versionLabel.Text = "version";
            // 
            // exitButton
            // 
            this.exitButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.exitButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.exitButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.exitButton.FlatAppearance.BorderColor = System.Drawing.Color.Maroon;
            this.exitButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.exitButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.exitButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.exitButton.ForeColor = System.Drawing.Color.White;
            this.exitButton.Location = new System.Drawing.Point(360, 328);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(81, 27);
            this.exitButton.TabIndex = 5;
            this.exitButton.Text = "Çıkış";
            this.exitButton.UseVisualStyleBackColor = false;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.exitButton;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.statusStrip);
            this.Controls.Add(this.contextPanel);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
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
        private System.Windows.Forms.Button graphicsCardButton;
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
        private System.Windows.Forms.Button exitButton;
    }
}