namespace Picker
{
    partial class BuildListView
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BuildListView));
            this.controlPanel = new System.Windows.Forms.Panel();
            this.countLabel = new System.Windows.Forms.Label();
            this.newButton = new System.Windows.Forms.Button();
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
            this.controlPanel.SuspendLayout();
            this.navigationPanel.SuspendLayout();
            this.navigationSubPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pageNumberBox)).BeginInit();
            this.listPanelBorder.SuspendLayout();
            this.SuspendLayout();
            // 
            // controlPanel
            // 
            this.controlPanel.Controls.Add(this.countLabel);
            this.controlPanel.Controls.Add(this.newButton);
            this.controlPanel.Controls.Add(this.mainButton);
            this.controlPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.controlPanel.Location = new System.Drawing.Point(0, 517);
            this.controlPanel.Name = "controlPanel";
            this.controlPanel.Size = new System.Drawing.Size(584, 44);
            this.controlPanel.TabIndex = 3;
            // 
            // countLabel
            // 
            this.countLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.countLabel.Location = new System.Drawing.Point(75, 0);
            this.countLabel.Name = "countLabel";
            this.countLabel.Size = new System.Drawing.Size(321, 44);
            this.countLabel.TabIndex = 0;
            this.countLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // newButton
            // 
            this.newButton.BackColor = System.Drawing.Color.Green;
            this.newButton.Dock = System.Windows.Forms.DockStyle.Right;
            this.newButton.FlatAppearance.BorderSize = 0;
            this.newButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.newButton.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.newButton.ForeColor = System.Drawing.Color.White;
            this.newButton.Location = new System.Drawing.Point(396, 0);
            this.newButton.Name = "newButton";
            this.newButton.Size = new System.Drawing.Size(188, 44);
            this.newButton.TabIndex = 5;
            this.newButton.Text = "Yeni Bilgisayar Topla";
            this.newButton.UseVisualStyleBackColor = false;
            this.newButton.Click += new System.EventHandler(this.newButton_Click);
            // 
            // mainButton
            // 
            this.mainButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.mainButton.Dock = System.Windows.Forms.DockStyle.Left;
            this.mainButton.Location = new System.Drawing.Point(0, 0);
            this.mainButton.Name = "mainButton";
            this.mainButton.Size = new System.Drawing.Size(75, 44);
            this.mainButton.TabIndex = 1;
            this.mainButton.Text = "Çık";
            this.mainButton.UseVisualStyleBackColor = true;
            this.mainButton.Click += new System.EventHandler(this.mainButton_Click);
            // 
            // navigationPanel
            // 
            this.navigationPanel.Controls.Add(this.navigationSubPanel);
            this.navigationPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.navigationPanel.Location = new System.Drawing.Point(0, 489);
            this.navigationPanel.Name = "navigationPanel";
            this.navigationPanel.Padding = new System.Windows.Forms.Padding(3);
            this.navigationPanel.Size = new System.Drawing.Size(584, 28);
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
            this.navigationSubPanel.Location = new System.Drawing.Point(192, 3);
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
            this.listPanelBorder.Location = new System.Drawing.Point(0, 0);
            this.listPanelBorder.Name = "listPanelBorder";
            this.listPanelBorder.Padding = new System.Windows.Forms.Padding(3);
            this.listPanelBorder.Size = new System.Drawing.Size(584, 489);
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
            this.listPanel.Size = new System.Drawing.Size(578, 483);
            this.listPanel.TabIndex = 0;
            // 
            // BuildListView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.mainButton;
            this.ClientSize = new System.Drawing.Size(584, 561);
            this.Controls.Add(this.listPanelBorder);
            this.Controls.Add(this.navigationPanel);
            this.Controls.Add(this.controlPanel);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(600, 600);
            this.Name = "BuildListView";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Picker | Bilgisayarlar";
            this.Load += new System.EventHandler(this.BuildListView_Load);
            this.controlPanel.ResumeLayout(false);
            this.navigationPanel.ResumeLayout(false);
            this.navigationSubPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pageNumberBox)).EndInit();
            this.listPanelBorder.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel controlPanel;
        private System.Windows.Forms.Button mainButton;
        private System.Windows.Forms.Panel navigationPanel;
        private System.Windows.Forms.Label countLabel;
        private System.Windows.Forms.Panel navigationSubPanel;
        private System.Windows.Forms.Label pageCountLabel;
        private System.Windows.Forms.Panel listPanelBorder;
        internal System.Windows.Forms.Panel listPanel;
        private System.Windows.Forms.NumericUpDown pageNumberBox;
        private System.Windows.Forms.Button nextPageButton;
        private System.Windows.Forms.Button lastPageButton;
        private System.Windows.Forms.Button previousPageButton;
        private System.Windows.Forms.Button firstPageButton;
        private System.Windows.Forms.Button newButton;
    }
}