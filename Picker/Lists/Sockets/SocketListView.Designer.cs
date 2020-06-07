namespace Picker
{
    partial class SocketListView
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SocketListView));
            this.filterPanel = new System.Windows.Forms.Panel();
            this.filterGroup = new System.Windows.Forms.GroupBox();
            this.ddr4Box = new System.Windows.Forms.CheckBox();
            this.ddr3Box = new System.Windows.Forms.CheckBox();
            this.label3 = new System.Windows.Forms.Label();
            this.ddr2Box = new System.Windows.Forms.CheckBox();
            this.brandBox = new System.Windows.Forms.TextBox();
            this.nameBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.applyFilterButton = new System.Windows.Forms.Button();
            this.orderGroup = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.itemPerPageBox = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.orderBox = new System.Windows.Forms.ComboBox();
            this.controlGroup = new System.Windows.Forms.GroupBox();
            this.newButton = new System.Windows.Forms.Button();
            this.controlPanel = new System.Windows.Forms.Panel();
            this.countLabel = new System.Windows.Forms.Label();
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
            this.filterPanel.SuspendLayout();
            this.filterGroup.SuspendLayout();
            this.orderGroup.SuspendLayout();
            this.controlGroup.SuspendLayout();
            this.controlPanel.SuspendLayout();
            this.navigationPanel.SuspendLayout();
            this.navigationSubPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pageNumberBox)).BeginInit();
            this.listPanelBorder.SuspendLayout();
            this.SuspendLayout();
            // 
            // filterPanel
            // 
            this.filterPanel.BackColor = System.Drawing.SystemColors.Control;
            this.filterPanel.Controls.Add(this.filterGroup);
            this.filterPanel.Controls.Add(this.orderGroup);
            this.filterPanel.Controls.Add(this.controlGroup);
            this.filterPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.filterPanel.Location = new System.Drawing.Point(0, 0);
            this.filterPanel.Name = "filterPanel";
            this.filterPanel.Size = new System.Drawing.Size(630, 100);
            this.filterPanel.TabIndex = 0;
            // 
            // filterGroup
            // 
            this.filterGroup.Controls.Add(this.ddr4Box);
            this.filterGroup.Controls.Add(this.ddr3Box);
            this.filterGroup.Controls.Add(this.label3);
            this.filterGroup.Controls.Add(this.ddr2Box);
            this.filterGroup.Controls.Add(this.brandBox);
            this.filterGroup.Controls.Add(this.nameBox);
            this.filterGroup.Controls.Add(this.label1);
            this.filterGroup.Controls.Add(this.applyFilterButton);
            this.filterGroup.Dock = System.Windows.Forms.DockStyle.Fill;
            this.filterGroup.Location = new System.Drawing.Point(0, 0);
            this.filterGroup.Name = "filterGroup";
            this.filterGroup.Size = new System.Drawing.Size(331, 100);
            this.filterGroup.TabIndex = 0;
            this.filterGroup.TabStop = false;
            this.filterGroup.Text = "Filtrele";
            // 
            // ddr4Box
            // 
            this.ddr4Box.AutoSize = true;
            this.ddr4Box.Checked = true;
            this.ddr4Box.CheckState = System.Windows.Forms.CheckState.Indeterminate;
            this.ddr4Box.Location = new System.Drawing.Point(218, 49);
            this.ddr4Box.Name = "ddr4Box";
            this.ddr4Box.Size = new System.Drawing.Size(55, 17);
            this.ddr4Box.TabIndex = 5;
            this.ddr4Box.Text = "DDR4";
            this.ddr4Box.ThreeState = true;
            this.ddr4Box.UseVisualStyleBackColor = true;
            this.ddr4Box.CheckStateChanged += new System.EventHandler(this.GenerateListAsyncEvent);
            // 
            // ddr3Box
            // 
            this.ddr3Box.AutoSize = true;
            this.ddr3Box.Checked = true;
            this.ddr3Box.CheckState = System.Windows.Forms.CheckState.Indeterminate;
            this.ddr3Box.Location = new System.Drawing.Point(157, 49);
            this.ddr3Box.Name = "ddr3Box";
            this.ddr3Box.Size = new System.Drawing.Size(55, 17);
            this.ddr3Box.TabIndex = 4;
            this.ddr3Box.Text = "DDR3";
            this.ddr3Box.ThreeState = true;
            this.ddr3Box.UseVisualStyleBackColor = true;
            this.ddr3Box.CheckStateChanged += new System.EventHandler(this.GenerateListAsyncEvent);
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(6, 46);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 21);
            this.label3.TabIndex = 2;
            this.label3.Text = "Bellek Desteği:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // ddr2Box
            // 
            this.ddr2Box.AutoSize = true;
            this.ddr2Box.Checked = true;
            this.ddr2Box.CheckState = System.Windows.Forms.CheckState.Indeterminate;
            this.ddr2Box.Location = new System.Drawing.Point(96, 49);
            this.ddr2Box.Name = "ddr2Box";
            this.ddr2Box.Size = new System.Drawing.Size(55, 17);
            this.ddr2Box.TabIndex = 3;
            this.ddr2Box.Text = "DDR2";
            this.ddr2Box.ThreeState = true;
            this.ddr2Box.UseVisualStyleBackColor = true;
            this.ddr2Box.CheckStateChanged += new System.EventHandler(this.GenerateListAsyncEvent);
            // 
            // brandBox
            // 
            this.brandBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.brandBox.Location = new System.Drawing.Point(96, 21);
            this.brandBox.Name = "brandBox";
            this.brandBox.Size = new System.Drawing.Size(224, 22);
            this.brandBox.TabIndex = 2;
            // 
            // nameBox
            // 
            this.nameBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.nameBox.Location = new System.Drawing.Point(6, 72);
            this.nameBox.Name = "nameBox";
            this.nameBox.Size = new System.Drawing.Size(266, 22);
            this.nameBox.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(6, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "Marka:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // applyFilterButton
            // 
            this.applyFilterButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.applyFilterButton.Location = new System.Drawing.Point(278, 72);
            this.applyFilterButton.Name = "applyFilterButton";
            this.applyFilterButton.Size = new System.Drawing.Size(47, 22);
            this.applyFilterButton.TabIndex = 1;
            this.applyFilterButton.Text = "Ara";
            this.applyFilterButton.UseVisualStyleBackColor = true;
            this.applyFilterButton.Click += new System.EventHandler(this.GenerateListAsyncEvent);
            // 
            // orderGroup
            // 
            this.orderGroup.Controls.Add(this.label2);
            this.orderGroup.Controls.Add(this.itemPerPageBox);
            this.orderGroup.Controls.Add(this.label5);
            this.orderGroup.Controls.Add(this.label4);
            this.orderGroup.Controls.Add(this.orderBox);
            this.orderGroup.Dock = System.Windows.Forms.DockStyle.Right;
            this.orderGroup.Location = new System.Drawing.Point(331, 0);
            this.orderGroup.Name = "orderGroup";
            this.orderGroup.Size = new System.Drawing.Size(230, 100);
            this.orderGroup.TabIndex = 1;
            this.orderGroup.TabStop = false;
            this.orderGroup.Text = "Sırala";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.Location = new System.Drawing.Point(183, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 21);
            this.label2.TabIndex = 1;
            this.label2.Text = "sırala.";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // itemPerPageBox
            // 
            this.itemPerPageBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.itemPerPageBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.itemPerPageBox.FormattingEnabled = true;
            this.itemPerPageBox.Items.AddRange(new object[] {
            "5",
            "10",
            "20"});
            this.itemPerPageBox.Location = new System.Drawing.Point(97, 48);
            this.itemPerPageBox.Name = "itemPerPageBox";
            this.itemPerPageBox.Size = new System.Drawing.Size(47, 21);
            this.itemPerPageBox.TabIndex = 3;
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(150, 48);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(70, 21);
            this.label5.TabIndex = 4;
            this.label5.Text = "kayıt göster.";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(6, 48);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(85, 21);
            this.label4.TabIndex = 2;
            this.label4.Text = "ve sayfa başına";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // orderBox
            // 
            this.orderBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.orderBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.orderBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.orderBox.FormattingEnabled = true;
            this.orderBox.Items.AddRange(new object[] {
            "Eskiden yeniye",
            "Yeniden eskiye",
            "İsme göre (A-Z)",
            "İsme göre (Z-A)",
            "Marka ismine göre (A-Z)",
            "Marka ismine göre (Z-A)"});
            this.orderBox.Location = new System.Drawing.Point(6, 21);
            this.orderBox.Name = "orderBox";
            this.orderBox.Size = new System.Drawing.Size(171, 21);
            this.orderBox.TabIndex = 0;
            // 
            // controlGroup
            // 
            this.controlGroup.Controls.Add(this.newButton);
            this.controlGroup.Dock = System.Windows.Forms.DockStyle.Right;
            this.controlGroup.Location = new System.Drawing.Point(561, 0);
            this.controlGroup.Name = "controlGroup";
            this.controlGroup.Size = new System.Drawing.Size(69, 100);
            this.controlGroup.TabIndex = 2;
            this.controlGroup.TabStop = false;
            // 
            // newButton
            // 
            this.newButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.newButton.Location = new System.Drawing.Point(3, 18);
            this.newButton.Name = "newButton";
            this.newButton.Size = new System.Drawing.Size(63, 79);
            this.newButton.TabIndex = 0;
            this.newButton.Text = "Yeni\r\nSoket\r\nEkle";
            this.newButton.UseVisualStyleBackColor = true;
            this.newButton.Click += new System.EventHandler(this.newButton_Click);
            // 
            // controlPanel
            // 
            this.controlPanel.Controls.Add(this.countLabel);
            this.controlPanel.Controls.Add(this.mainButton);
            this.controlPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.controlPanel.Location = new System.Drawing.Point(0, 609);
            this.controlPanel.Name = "controlPanel";
            this.controlPanel.Size = new System.Drawing.Size(630, 22);
            this.controlPanel.TabIndex = 3;
            // 
            // countLabel
            // 
            this.countLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.countLabel.Location = new System.Drawing.Point(0, 0);
            this.countLabel.Name = "countLabel";
            this.countLabel.Size = new System.Drawing.Size(555, 22);
            this.countLabel.TabIndex = 0;
            this.countLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // mainButton
            // 
            this.mainButton.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.mainButton.Dock = System.Windows.Forms.DockStyle.Right;
            this.mainButton.Location = new System.Drawing.Point(555, 0);
            this.mainButton.Name = "mainButton";
            this.mainButton.Size = new System.Drawing.Size(75, 22);
            this.mainButton.TabIndex = 1;
            this.mainButton.Text = "Tamam";
            this.mainButton.UseVisualStyleBackColor = true;
            this.mainButton.Click += new System.EventHandler(this.mainButton_Click);
            // 
            // navigationPanel
            // 
            this.navigationPanel.Controls.Add(this.navigationSubPanel);
            this.navigationPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.navigationPanel.Location = new System.Drawing.Point(0, 581);
            this.navigationPanel.Name = "navigationPanel";
            this.navigationPanel.Padding = new System.Windows.Forms.Padding(3);
            this.navigationPanel.Size = new System.Drawing.Size(630, 28);
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
            this.navigationSubPanel.Location = new System.Drawing.Point(215, 3);
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
            this.listPanelBorder.Location = new System.Drawing.Point(0, 100);
            this.listPanelBorder.Name = "listPanelBorder";
            this.listPanelBorder.Padding = new System.Windows.Forms.Padding(3);
            this.listPanelBorder.Size = new System.Drawing.Size(630, 481);
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
            this.listPanel.Size = new System.Drawing.Size(624, 475);
            this.listPanel.TabIndex = 0;
            // 
            // SocketListView
            // 
            this.AcceptButton = this.applyFilterButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.mainButton;
            this.ClientSize = new System.Drawing.Size(630, 631);
            this.Controls.Add(this.listPanelBorder);
            this.Controls.Add(this.navigationPanel);
            this.Controls.Add(this.controlPanel);
            this.Controls.Add(this.filterPanel);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(646, 670);
            this.Name = "SocketListView";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Picker | Soketler";
            this.Load += new System.EventHandler(this.SocketListView_Load);
            this.filterPanel.ResumeLayout(false);
            this.filterGroup.ResumeLayout(false);
            this.filterGroup.PerformLayout();
            this.orderGroup.ResumeLayout(false);
            this.controlGroup.ResumeLayout(false);
            this.controlPanel.ResumeLayout(false);
            this.navigationPanel.ResumeLayout(false);
            this.navigationSubPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pageNumberBox)).EndInit();
            this.listPanelBorder.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel filterPanel;
        private System.Windows.Forms.Panel controlPanel;
        private System.Windows.Forms.Button mainButton;
        private System.Windows.Forms.Panel navigationPanel;
        private System.Windows.Forms.Label countLabel;
        private System.Windows.Forms.Panel navigationSubPanel;
        private System.Windows.Forms.Label pageCountLabel;
        private System.Windows.Forms.GroupBox controlGroup;
        private System.Windows.Forms.GroupBox orderGroup;
        private System.Windows.Forms.ComboBox itemPerPageBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox orderBox;
        private System.Windows.Forms.Button newButton;
        private System.Windows.Forms.GroupBox filterGroup;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button applyFilterButton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel listPanelBorder;
        internal System.Windows.Forms.Panel listPanel;
        private System.Windows.Forms.NumericUpDown pageNumberBox;
        private System.Windows.Forms.Button nextPageButton;
        private System.Windows.Forms.Button lastPageButton;
        private System.Windows.Forms.Button previousPageButton;
        private System.Windows.Forms.Button firstPageButton;
        private System.Windows.Forms.TextBox nameBox;
        private System.Windows.Forms.TextBox brandBox;
        private System.Windows.Forms.CheckBox ddr4Box;
        private System.Windows.Forms.CheckBox ddr3Box;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox ddr2Box;
    }
}