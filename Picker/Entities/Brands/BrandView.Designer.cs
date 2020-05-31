namespace Picker
{
    partial class BrandView
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BrandView));
            this.controlPanel = new System.Windows.Forms.Panel();
            this.cancelButton = new System.Windows.Forms.Button();
            this.acceptButton = new System.Windows.Forms.Button();
            this.entityPanel = new System.Windows.Forms.Panel();
            this.pickColorButton = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.countryBox = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.nameBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.uploadImageButton = new System.Windows.Forms.Button();
            this.imageBox = new System.Windows.Forms.PictureBox();
            this.controlPanel.SuspendLayout();
            this.entityPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imageBox)).BeginInit();
            this.SuspendLayout();
            // 
            // controlPanel
            // 
            this.controlPanel.Controls.Add(this.cancelButton);
            this.controlPanel.Controls.Add(this.acceptButton);
            this.controlPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.controlPanel.Location = new System.Drawing.Point(0, 115);
            this.controlPanel.Name = "controlPanel";
            this.controlPanel.Size = new System.Drawing.Size(297, 32);
            this.controlPanel.TabIndex = 0;
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
            this.acceptButton.Location = new System.Drawing.Point(208, 0);
            this.acceptButton.Name = "acceptButton";
            this.acceptButton.Size = new System.Drawing.Size(89, 32);
            this.acceptButton.TabIndex = 0;
            this.acceptButton.Text = "Tamam";
            this.acceptButton.UseVisualStyleBackColor = false;
            this.acceptButton.Click += new System.EventHandler(this.acceptButton_Click);
            // 
            // entityPanel
            // 
            this.entityPanel.Controls.Add(this.pickColorButton);
            this.entityPanel.Controls.Add(this.label3);
            this.entityPanel.Controls.Add(this.countryBox);
            this.entityPanel.Controls.Add(this.label2);
            this.entityPanel.Controls.Add(this.nameBox);
            this.entityPanel.Controls.Add(this.label1);
            this.entityPanel.Controls.Add(this.uploadImageButton);
            this.entityPanel.Controls.Add(this.imageBox);
            this.entityPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.entityPanel.Location = new System.Drawing.Point(0, 0);
            this.entityPanel.Name = "entityPanel";
            this.entityPanel.Size = new System.Drawing.Size(297, 115);
            this.entityPanel.TabIndex = 1;
            // 
            // pickColorButton
            // 
            this.pickColorButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pickColorButton.BackColor = System.Drawing.Color.Green;
            this.pickColorButton.FlatAppearance.BorderSize = 0;
            this.pickColorButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.pickColorButton.ForeColor = System.Drawing.Color.White;
            this.pickColorButton.Location = new System.Drawing.Point(124, 67);
            this.pickColorButton.Name = "pickColorButton";
            this.pickColorButton.Size = new System.Drawing.Size(161, 23);
            this.pickColorButton.TabIndex = 7;
            this.pickColorButton.Text = "Renk Seç...";
            this.pickColorButton.UseVisualStyleBackColor = false;
            this.pickColorButton.Click += new System.EventHandler(this.pickColorButton_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.label3.Location = new System.Drawing.Point(82, 72);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Renk:";
            // 
            // countryBox
            // 
            this.countryBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
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
            this.countryBox.Location = new System.Drawing.Point(124, 40);
            this.countryBox.Name = "countryBox";
            this.countryBox.Size = new System.Drawing.Size(161, 21);
            this.countryBox.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.label2.Location = new System.Drawing.Point(82, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Ülke:";
            // 
            // nameBox
            // 
            this.nameBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.nameBox.Location = new System.Drawing.Point(124, 12);
            this.nameBox.Name = "nameBox";
            this.nameBox.Size = new System.Drawing.Size(161, 22);
            this.nameBox.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.label1.Location = new System.Drawing.Point(82, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(24, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Ad:";
            // 
            // uploadImageButton
            // 
            this.uploadImageButton.BackColor = System.Drawing.Color.Green;
            this.uploadImageButton.FlatAppearance.BorderSize = 0;
            this.uploadImageButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.uploadImageButton.ForeColor = System.Drawing.Color.White;
            this.uploadImageButton.Location = new System.Drawing.Point(12, 82);
            this.uploadImageButton.Name = "uploadImageButton";
            this.uploadImageButton.Size = new System.Drawing.Size(64, 23);
            this.uploadImageButton.TabIndex = 1;
            this.uploadImageButton.Text = "Yükle...";
            this.uploadImageButton.UseVisualStyleBackColor = false;
            this.uploadImageButton.Click += new System.EventHandler(this.uploadImageButton_Click);
            // 
            // imageBox
            // 
            this.imageBox.Image = global::Picker.Properties.Resources.favicon_64;
            this.imageBox.Location = new System.Drawing.Point(12, 12);
            this.imageBox.Name = "imageBox";
            this.imageBox.Size = new System.Drawing.Size(64, 64);
            this.imageBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.imageBox.TabIndex = 0;
            this.imageBox.TabStop = false;
            // 
            // BrandView
            // 
            this.AcceptButton = this.acceptButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.cancelButton;
            this.ClientSize = new System.Drawing.Size(297, 147);
            this.Controls.Add(this.entityPanel);
            this.Controls.Add(this.controlPanel);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "BrandView";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BrandView";
            this.controlPanel.ResumeLayout(false);
            this.entityPanel.ResumeLayout(false);
            this.entityPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imageBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel controlPanel;
        private System.Windows.Forms.Panel entityPanel;
        private System.Windows.Forms.Button acceptButton;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button uploadImageButton;
        private System.Windows.Forms.ComboBox countryBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox nameBox;
        private System.Windows.Forms.Button pickColorButton;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox imageBox;
    }
}