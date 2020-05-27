namespace Picker.Views
{
    partial class ListForm<TEntity>
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
            this.filterPanel = new System.Windows.Forms.Panel();
            this.controlPanel = new System.Windows.Forms.Panel();
            this.deleteAllButton = new System.Windows.Forms.Button();
            this.newItemButton = new System.Windows.Forms.Button();
            this.backButton = new System.Windows.Forms.Button();
            this.navigationPanel = new System.Windows.Forms.Panel();
            this.listPanel = new System.Windows.Forms.Panel();
            this.controlPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // filterPanel
            // 
            this.filterPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.filterPanel.Location = new System.Drawing.Point(0, 0);
            this.filterPanel.Name = "filterPanel";
            this.filterPanel.Size = new System.Drawing.Size(820, 103);
            this.filterPanel.TabIndex = 0;
            // 
            // controlPanel
            // 
            this.controlPanel.Controls.Add(this.deleteAllButton);
            this.controlPanel.Controls.Add(this.newItemButton);
            this.controlPanel.Controls.Add(this.backButton);
            this.controlPanel.Controls.Add(this.navigationPanel);
            this.controlPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.controlPanel.Location = new System.Drawing.Point(0, 452);
            this.controlPanel.Name = "controlPanel";
            this.controlPanel.Size = new System.Drawing.Size(820, 65);
            this.controlPanel.TabIndex = 1;
            // 
            // deleteAllButton
            // 
            this.deleteAllButton.Dock = System.Windows.Forms.DockStyle.Right;
            this.deleteAllButton.Location = new System.Drawing.Point(664, 20);
            this.deleteAllButton.Name = "deleteAllButton";
            this.deleteAllButton.Size = new System.Drawing.Size(75, 45);
            this.deleteAllButton.TabIndex = 0;
            this.deleteAllButton.TabStop = false;
            this.deleteAllButton.Text = "Tümünü Sil";
            this.deleteAllButton.UseVisualStyleBackColor = true;
            // 
            // newItemButton
            // 
            this.newItemButton.Dock = System.Windows.Forms.DockStyle.Right;
            this.newItemButton.Location = new System.Drawing.Point(739, 20);
            this.newItemButton.Name = "newItemButton";
            this.newItemButton.Size = new System.Drawing.Size(81, 45);
            this.newItemButton.TabIndex = 1;
            this.newItemButton.Text = "Yeni Öğe...";
            this.newItemButton.UseVisualStyleBackColor = true;
            // 
            // backButton
            // 
            this.backButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.backButton.Dock = System.Windows.Forms.DockStyle.Left;
            this.backButton.Location = new System.Drawing.Point(0, 20);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(65, 45);
            this.backButton.TabIndex = 0;
            this.backButton.Text = "Geri";
            this.backButton.UseVisualStyleBackColor = true;
            // 
            // navigationPanel
            // 
            this.navigationPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.navigationPanel.Location = new System.Drawing.Point(0, 0);
            this.navigationPanel.Name = "navigationPanel";
            this.navigationPanel.Size = new System.Drawing.Size(820, 20);
            this.navigationPanel.TabIndex = 0;
            // 
            // listPanel
            // 
            this.listPanel.AutoScroll = true;
            this.listPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listPanel.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.listPanel.Location = new System.Drawing.Point(0, 103);
            this.listPanel.Name = "listPanel";
            this.listPanel.Size = new System.Drawing.Size(820, 349);
            this.listPanel.TabIndex = 2;
            // 
            // ListForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.backButton;
            this.ClientSize = new System.Drawing.Size(820, 517);
            this.Controls.Add(this.listPanel);
            this.Controls.Add(this.controlPanel);
            this.Controls.Add(this.filterPanel);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.Name = "ListForm";
            this.Text = "ListForm";
            this.Load += new System.EventHandler(this.FormLoad);
            this.controlPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel filterPanel;
        private System.Windows.Forms.Panel controlPanel;
        private System.Windows.Forms.Panel navigationPanel;
        private System.Windows.Forms.Button deleteAllButton;
        private System.Windows.Forms.Button newItemButton;
        private System.Windows.Forms.Button backButton;
        public System.Windows.Forms.Panel listPanel;
    }
}