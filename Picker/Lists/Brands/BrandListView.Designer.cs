namespace Picker
{
    partial class BrandListView
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BrandListView));
            this.filterPanel = new System.Windows.Forms.Panel();
            this.itemCountBox = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.orderBox = new System.Windows.Forms.ComboBox();
            this.nameBox = new System.Windows.Forms.TextBox();
            this.countryBox = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.applyFilterButton = new System.Windows.Forms.Button();
            this.newButton = new System.Windows.Forms.Button();
            this.listPanel = new System.Windows.Forms.Panel();
            this.controlPanel = new System.Windows.Forms.Panel();
            this.countLabel = new System.Windows.Forms.Label();
            this.acceptButton = new System.Windows.Forms.Button();
            this.navigationPanel = new System.Windows.Forms.Panel();
            this.pageIndexBox = new System.Windows.Forms.NumericUpDown();
            this.pageCountLabel = new System.Windows.Forms.Label();
            this.filterPanel.SuspendLayout();
            this.controlPanel.SuspendLayout();
            this.navigationPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pageIndexBox)).BeginInit();
            this.SuspendLayout();
            // 
            // filterPanel
            // 
            this.filterPanel.Controls.Add(this.itemCountBox);
            this.filterPanel.Controls.Add(this.label5);
            this.filterPanel.Controls.Add(this.label4);
            this.filterPanel.Controls.Add(this.label3);
            this.filterPanel.Controls.Add(this.orderBox);
            this.filterPanel.Controls.Add(this.nameBox);
            this.filterPanel.Controls.Add(this.countryBox);
            this.filterPanel.Controls.Add(this.label2);
            this.filterPanel.Controls.Add(this.label1);
            this.filterPanel.Controls.Add(this.applyFilterButton);
            this.filterPanel.Controls.Add(this.newButton);
            this.filterPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.filterPanel.Location = new System.Drawing.Point(0, 0);
            this.filterPanel.Name = "filterPanel";
            this.filterPanel.Size = new System.Drawing.Size(623, 99);
            this.filterPanel.TabIndex = 0;
            // 
            // itemCountBox
            // 
            this.itemCountBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.itemCountBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.itemCountBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.itemCountBox.FormattingEnabled = true;
            this.itemCountBox.Items.AddRange(new object[] {
            "5",
            "10",
            "20",
            "50"});
            this.itemCountBox.Location = new System.Drawing.Point(399, 39);
            this.itemCountBox.Name = "itemCountBox";
            this.itemCountBox.Size = new System.Drawing.Size(47, 21);
            this.itemCountBox.TabIndex = 4;
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(452, 42);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(70, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "kayıt göster.";
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(322, 42);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Sayfa başına";
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(322, 15);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Sıralama:";
            // 
            // orderBox
            // 
            this.orderBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.orderBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.orderBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.orderBox.FormattingEnabled = true;
            this.orderBox.Items.AddRange(new object[] {
            "Eskiden yeniye",
            "Yeniden eskiye",
            "İsme göre (A-Z)",
            "İsme göre (Z-A)",
            "Ülke ismine göre (A-Z)",
            "Ülke ismine göre (Z-A)"});
            this.orderBox.Location = new System.Drawing.Point(381, 12);
            this.orderBox.Name = "orderBox";
            this.orderBox.Size = new System.Drawing.Size(230, 21);
            this.orderBox.TabIndex = 3;
            // 
            // nameBox
            // 
            this.nameBox.Location = new System.Drawing.Point(69, 39);
            this.nameBox.Name = "nameBox";
            this.nameBox.Size = new System.Drawing.Size(207, 22);
            this.nameBox.TabIndex = 1;
            // 
            // countryBox
            // 
            this.countryBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.countryBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.countryBox.FormattingEnabled = true;
            this.countryBox.Items.AddRange(new object[] {
            "ABD Virgin Adaları",
            "Afganistan",
            "Aland Adaları",
            "Almanya",
            "Amerika Birleşik Devletleri",
            "Amerika Birleşik Devletleri Küçük Dış Adaları",
            "Amerikan Samoası",
            "Andora",
            "Angola",
            "Anguilla",
            "Antarktika",
            "Antigua ve Barbuda",
            "Arjantin",
            "Arnavutluk",
            "Aruba",
            "Avrupa Birliği",
            "Avustralya",
            "Avusturya",
            "Azerbaycan",
            "Bahamalar",
            "Bahreyn",
            "Bangladeş",
            "Barbados",
            "Batı Sahara",
            "Belize",
            "Belçika",
            "Benin",
            "Bermuda",
            "Beyaz Rusya",
            "Bhutan",
            "Birleşik Arap Emirlikleri",
            "Birleşik Krallık",
            "Bolivya",
            "Bosna Hersek",
            "Botsvana",
            "Bouvet Adası",
            "Brezilya",
            "Brunei",
            "Bulgaristan",
            "Burkina Faso",
            "Burundi",
            "Cape Verde",
            "Cebelitarık",
            "Cezayir",
            "Christmas Adası",
            "Cibuti",
            "Cocos Adaları",
            "Cook Adaları",
            "Çad",
            "Çek Cumhuriyeti",
            "Çin",
            "Danimarka",
            "Dominik",
            "Dominik Cumhuriyeti",
            "Doğu Timor",
            "Ekvator",
            "Ekvator Ginesi",
            "El Salvador",
            "Endonezya",
            "Eritre",
            "Ermenistan",
            "Estonya",
            "Etiyopya",
            "Falkland Adaları (Malvinalar)",
            "Faroe Adaları",
            "Fas",
            "Fiji",
            "Fildişi Sahilleri",
            "Filipinler",
            "Filistin Bölgesi",
            "Finlandiya",
            "Fransa",
            "Fransız Guyanası",
            "Fransız Güney Bölgeleri",
            "Fransız Polinezyası",
            "Gabon",
            "Gambia",
            "Gana",
            "Gine",
            "Gine-Bissau",
            "Granada",
            "Grönland",
            "Guadeloupe",
            "Guam",
            "Guatemala",
            "Guernsey",
            "Guyana",
            "Güney Afrika",
            "Güney Georgia ve Güney Sandwich Adaları",
            "Güney Kore",
            "Güney Kıbrıs Rum Kesimi",
            "Gürcistan",
            "Haiti",
            "Heard Adası ve McDonald Adaları",
            "Hindistan",
            "Hint Okyanusu İngiliz Bölgesi",
            "Hollanda",
            "Hollanda Antilleri",
            "Honduras",
            "Hong Kong SAR - Çin",
            "Hırvatistan",
            "Irak",
            "İngiliz Virgin Adaları",
            "İran",
            "İrlanda",
            "İspanya",
            "İsrail",
            "İsveç",
            "İsviçre",
            "İtalya",
            "İzlanda",
            "Jamaika",
            "Japonya",
            "Jersey",
            "Kamboçya",
            "Kamerun",
            "Kanada",
            "Karadağ",
            "Katar",
            "Kayman Adaları",
            "Kazakistan",
            "Kenya",
            "Kiribati",
            "Kolombiya",
            "Komorlar",
            "Kongo",
            "Kongo Demokratik Cumhuriyeti",
            "Kosta Rika",
            "Kuveyt",
            "Kuzey Kore",
            "Kuzey Mariana Adaları",
            "Küba",
            "Kırgızistan",
            "Laos",
            "Lesotho",
            "Letonya",
            "Liberya",
            "Libya",
            "Liechtenstein",
            "Litvanya",
            "Lübnan",
            "Lüksemburg",
            "Macaristan",
            "Madagaskar",
            "Makao S.A.R. Çin",
            "Makedonya",
            "Malavi",
            "Maldivler",
            "Malezya",
            "Mali",
            "Malta",
            "Man Adası",
            "Marshall Adaları",
            "Martinik",
            "Mauritius",
            "Mayotte",
            "Meksika",
            "Mikronezya Federal Eyaletleri",
            "Moldovya Cumhuriyeti",
            "Monako",
            "Montserrat",
            "Moritanya",
            "Mozambik",
            "Moğolistan",
            "Myanmar",
            "Mısır",
            "Namibya",
            "Nauru",
            "Nepal",
            "Nijer",
            "Nijerya",
            "Nikaragua",
            "Niue",
            "Norfolk Adası",
            "Norveç",
            "Orta Afrika Cumhuriyeti",
            "Özbekistan",
            "Pakistan",
            "Palau",
            "Panama",
            "Papua Yeni Gine",
            "Paraguay",
            "Peru",
            "Pitcairn",
            "Polonya",
            "Portekiz",
            "Porto Riko",
            "Reunion",
            "Romanya",
            "Ruanda",
            "Rusya Federasyonu",
            "Saint Helena",
            "Saint Kitts ve Nevis",
            "Saint Lucia",
            "Saint Pierre ve Miquelon",
            "Saint Vincent ve Grenadinler",
            "Samoa",
            "San Marino",
            "Sao Tome ve Principe",
            "Senegal",
            "Seyşeller",
            "Sierra Leone",
            "Singapur",
            "Slovakya",
            "Slovenya",
            "Solomon Adaları",
            "Somali",
            "Sri Lanka",
            "Sudan",
            "Surinam",
            "Suriye",
            "Suudi Arabistan",
            "Svalbard ve Jan Mayen",
            "Svaziland",
            "Sırbistan",
            "Sırbistan-Karadağ",
            "Şili",
            "Tacikistan",
            "Tanzanya",
            "Tayland",
            "Tayvan",
            "Togo",
            "Tokelau",
            "Tonga",
            "Trinidad ve Tobago",
            "Tunus",
            "Turks ve Caicos Adaları",
            "Tuvalu",
            "Türkiye",
            "Türkmenistan",
            "Uganda",
            "Ukrayna",
            "Umman",
            "Uruguay",
            "Uzak Okyanusya",
            "Ürdün",
            "Vanuatu",
            "Vatikan",
            "Venezuela",
            "Vietnam",
            "Wallis ve Futuna",
            "Yemen",
            "Yeni Kaledonya",
            "Yeni Zelanda",
            "Yunanistan",
            "Zambiya",
            "Zimbabve"});
            this.countryBox.Location = new System.Drawing.Point(69, 12);
            this.countryBox.Name = "countryBox";
            this.countryBox.Size = new System.Drawing.Size(207, 21);
            this.countryBox.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(27, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Ara:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Ülke:";
            // 
            // applyFilterButton
            // 
            this.applyFilterButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.applyFilterButton.Location = new System.Drawing.Point(12, 70);
            this.applyFilterButton.Name = "applyFilterButton";
            this.applyFilterButton.Size = new System.Drawing.Size(112, 23);
            this.applyFilterButton.TabIndex = 2;
            this.applyFilterButton.Text = "Filtreyi Uygula";
            this.applyFilterButton.UseVisualStyleBackColor = true;
            this.applyFilterButton.Click += new System.EventHandler(this.GenerateListEvent);
            // 
            // newButton
            // 
            this.newButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.newButton.Location = new System.Drawing.Point(536, 70);
            this.newButton.Name = "newButton";
            this.newButton.Size = new System.Drawing.Size(75, 23);
            this.newButton.TabIndex = 5;
            this.newButton.Text = "Yeni...";
            this.newButton.UseVisualStyleBackColor = true;
            this.newButton.Click += new System.EventHandler(this.newButton_Click);
            // 
            // listPanel
            // 
            this.listPanel.AutoScroll = true;
            this.listPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listPanel.Location = new System.Drawing.Point(0, 99);
            this.listPanel.Name = "listPanel";
            this.listPanel.Size = new System.Drawing.Size(623, 418);
            this.listPanel.TabIndex = 1;
            // 
            // controlPanel
            // 
            this.controlPanel.Controls.Add(this.countLabel);
            this.controlPanel.Controls.Add(this.acceptButton);
            this.controlPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.controlPanel.Location = new System.Drawing.Point(0, 539);
            this.controlPanel.Name = "controlPanel";
            this.controlPanel.Size = new System.Drawing.Size(623, 22);
            this.controlPanel.TabIndex = 2;
            // 
            // countLabel
            // 
            this.countLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.countLabel.Location = new System.Drawing.Point(0, 0);
            this.countLabel.Name = "countLabel";
            this.countLabel.Size = new System.Drawing.Size(548, 22);
            this.countLabel.TabIndex = 1;
            this.countLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // acceptButton
            // 
            this.acceptButton.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.acceptButton.Dock = System.Windows.Forms.DockStyle.Right;
            this.acceptButton.Location = new System.Drawing.Point(548, 0);
            this.acceptButton.Name = "acceptButton";
            this.acceptButton.Size = new System.Drawing.Size(75, 22);
            this.acceptButton.TabIndex = 7;
            this.acceptButton.Text = "Tamam";
            this.acceptButton.UseVisualStyleBackColor = true;
            // 
            // navigationPanel
            // 
            this.navigationPanel.Controls.Add(this.pageIndexBox);
            this.navigationPanel.Controls.Add(this.pageCountLabel);
            this.navigationPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.navigationPanel.Location = new System.Drawing.Point(0, 517);
            this.navigationPanel.Name = "navigationPanel";
            this.navigationPanel.Size = new System.Drawing.Size(623, 22);
            this.navigationPanel.TabIndex = 3;
            // 
            // pageIndexBox
            // 
            this.pageIndexBox.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.pageIndexBox.Location = new System.Drawing.Point(286, 0);
            this.pageIndexBox.Maximum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.pageIndexBox.Name = "pageIndexBox";
            this.pageIndexBox.Size = new System.Drawing.Size(35, 22);
            this.pageIndexBox.TabIndex = 6;
            this.pageIndexBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.pageIndexBox.UpDownAlign = System.Windows.Forms.LeftRightAlignment.Left;
            // 
            // pageCountLabel
            // 
            this.pageCountLabel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.pageCountLabel.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.pageCountLabel.Location = new System.Drawing.Point(320, 2);
            this.pageCountLabel.Name = "pageCountLabel";
            this.pageCountLabel.Size = new System.Drawing.Size(35, 19);
            this.pageCountLabel.TabIndex = 1;
            this.pageCountLabel.Text = "/ 0";
            // 
            // BrandListView
            // 
            this.AcceptButton = this.acceptButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(623, 561);
            this.Controls.Add(this.listPanel);
            this.Controls.Add(this.navigationPanel);
            this.Controls.Add(this.controlPanel);
            this.Controls.Add(this.filterPanel);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(600, 600);
            this.Name = "BrandListView";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Markalar";
            this.Load += new System.EventHandler(this.BrandListView_Load);
            this.filterPanel.ResumeLayout(false);
            this.filterPanel.PerformLayout();
            this.controlPanel.ResumeLayout(false);
            this.navigationPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pageIndexBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel filterPanel;
        private System.Windows.Forms.Panel controlPanel;
        internal System.Windows.Forms.Panel listPanel;
        private System.Windows.Forms.Button acceptButton;
        private System.Windows.Forms.Button newButton;
        private System.Windows.Forms.Button applyFilterButton;
        private System.Windows.Forms.Panel navigationPanel;
        private System.Windows.Forms.TextBox nameBox;
        private System.Windows.Forms.ComboBox countryBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox orderBox;
        private System.Windows.Forms.ComboBox itemCountBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown pageIndexBox;
        private System.Windows.Forms.Label pageCountLabel;
        private System.Windows.Forms.Label countLabel;
    }
}