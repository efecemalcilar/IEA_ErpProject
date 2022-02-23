namespace IEA_ErpProject.BilgiGiris.Hastaneler
{
    partial class HastaneGiris
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
            this.label1 = new System.Windows.Forms.Label();
            this.ScHastane = new System.Windows.Forms.SplitContainer();
            this.BtnDetayGoster = new System.Windows.Forms.Button();
            this.BtnDetayEkle = new System.Windows.Forms.Button();
            this.TxtHastaneBul = new System.Windows.Forms.TextBox();
            this.TxtVergiNo = new System.Windows.Forms.MaskedTextBox();
            this.TxtVergiDairesi = new System.Windows.Forms.TextBox();
            this.TxtTelefon = new System.Windows.Forms.MaskedTextBox();
            this.TxtAdres = new System.Windows.Forms.RichTextBox();
            this.TxtSehir = new System.Windows.Forms.ComboBox();
            this.TxtTipAdi = new System.Windows.Forms.ComboBox();
            this.TxtCariHadi = new System.Windows.Forms.TextBox();
            this.TxtHadi = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Liste = new System.Windows.Forms.DataGridView();
            this.Sira = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Adi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TipAdi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tel = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Sehir = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BtnKapat = new System.Windows.Forms.Button();
            this.BtnTemizle = new System.Windows.Forms.Button();
            this.BtnSil = new System.Windows.Forms.Button();
            this.BtnGüncelle = new System.Windows.Forms.Button();
            this.BtnKaydet = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.ScHastane)).BeginInit();
            this.ScHastane.Panel1.SuspendLayout();
            this.ScHastane.Panel2.SuspendLayout();
            this.ScHastane.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Liste)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.SteelBlue;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(1298, 72);
            this.label1.TabIndex = 1;
            this.label1.Text = "Hastane Giris";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // ScHastane
            // 
            this.ScHastane.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.ScHastane.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ScHastane.Location = new System.Drawing.Point(0, 72);
            this.ScHastane.Name = "ScHastane";
            this.ScHastane.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // ScHastane.Panel1
            // 
            this.ScHastane.Panel1.Controls.Add(this.BtnDetayGoster);
            this.ScHastane.Panel1.Controls.Add(this.BtnDetayEkle);
            this.ScHastane.Panel1.Controls.Add(this.TxtHastaneBul);
            this.ScHastane.Panel1.Controls.Add(this.TxtVergiNo);
            this.ScHastane.Panel1.Controls.Add(this.TxtVergiDairesi);
            this.ScHastane.Panel1.Controls.Add(this.TxtTelefon);
            this.ScHastane.Panel1.Controls.Add(this.TxtAdres);
            this.ScHastane.Panel1.Controls.Add(this.TxtSehir);
            this.ScHastane.Panel1.Controls.Add(this.TxtTipAdi);
            this.ScHastane.Panel1.Controls.Add(this.TxtCariHadi);
            this.ScHastane.Panel1.Controls.Add(this.TxtHadi);
            this.ScHastane.Panel1.Controls.Add(this.label9);
            this.ScHastane.Panel1.Controls.Add(this.label5);
            this.ScHastane.Panel1.Controls.Add(this.label8);
            this.ScHastane.Panel1.Controls.Add(this.label3);
            this.ScHastane.Panel1.Controls.Add(this.label7);
            this.ScHastane.Panel1.Controls.Add(this.label6);
            this.ScHastane.Panel1.Controls.Add(this.label4);
            this.ScHastane.Panel1.Controls.Add(this.label2);
            // 
            // ScHastane.Panel2
            // 
            this.ScHastane.Panel2.Controls.Add(this.Liste);
            this.ScHastane.Size = new System.Drawing.Size(1298, 504);
            this.ScHastane.SplitterDistance = 244;
            this.ScHastane.TabIndex = 3;
            // 
            // BtnDetayGoster
            // 
            this.BtnDetayGoster.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnDetayGoster.BackColor = System.Drawing.Color.SteelBlue;
            this.BtnDetayGoster.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtnDetayGoster.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BtnDetayGoster.Location = new System.Drawing.Point(1151, 145);
            this.BtnDetayGoster.Name = "BtnDetayGoster";
            this.BtnDetayGoster.Size = new System.Drawing.Size(118, 37);
            this.BtnDetayGoster.TabIndex = 10;
            this.BtnDetayGoster.Text = "Detay Goster";
            this.BtnDetayGoster.UseVisualStyleBackColor = false;
            this.BtnDetayGoster.Visible = false;
            this.BtnDetayGoster.Click += new System.EventHandler(this.BtnDetayGoster_Click);
            // 
            // BtnDetayEkle
            // 
            this.BtnDetayEkle.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnDetayEkle.BackColor = System.Drawing.Color.SteelBlue;
            this.BtnDetayEkle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtnDetayEkle.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BtnDetayEkle.Location = new System.Drawing.Point(1151, 185);
            this.BtnDetayEkle.Name = "BtnDetayEkle";
            this.BtnDetayEkle.Size = new System.Drawing.Size(118, 37);
            this.BtnDetayEkle.TabIndex = 10;
            this.BtnDetayEkle.Text = "Detay Ekle";
            this.BtnDetayEkle.UseVisualStyleBackColor = false;
            this.BtnDetayEkle.Visible = false;
            this.BtnDetayEkle.Click += new System.EventHandler(this.BtnDetayEkle_Click);
            // 
            // TxtHastaneBul
            // 
            this.TxtHastaneBul.Location = new System.Drawing.Point(758, 126);
            this.TxtHastaneBul.Name = "TxtHastaneBul";
            this.TxtHastaneBul.Size = new System.Drawing.Size(347, 20);
            this.TxtHastaneBul.TabIndex = 9;
            
            // 
            // TxtVergiNo
            // 
            this.TxtVergiNo.Location = new System.Drawing.Point(840, 81);
            this.TxtVergiNo.Mask = "00000000000";
            this.TxtVergiNo.Name = "TxtVergiNo";
            this.TxtVergiNo.Size = new System.Drawing.Size(265, 20);
            this.TxtVergiNo.TabIndex = 8;
            // 
            // TxtVergiDairesi
            // 
            this.TxtVergiDairesi.Location = new System.Drawing.Point(840, 19);
            this.TxtVergiDairesi.Name = "TxtVergiDairesi";
            this.TxtVergiDairesi.Size = new System.Drawing.Size(265, 20);
            this.TxtVergiDairesi.TabIndex = 7;
            // 
            // TxtTelefon
            // 
            this.TxtTelefon.Location = new System.Drawing.Point(469, 185);
            this.TxtTelefon.Mask = "(999) 000-0000";
            this.TxtTelefon.Name = "TxtTelefon";
            this.TxtTelefon.Size = new System.Drawing.Size(159, 20);
            this.TxtTelefon.TabIndex = 6;
            // 
            // TxtAdres
            // 
            this.TxtAdres.Location = new System.Drawing.Point(116, 154);
            this.TxtAdres.Name = "TxtAdres";
            this.TxtAdres.Size = new System.Drawing.Size(240, 55);
            this.TxtAdres.TabIndex = 4;
            this.TxtAdres.Text = "";
            // 
            // TxtSehir
            // 
            this.TxtSehir.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.TxtSehir.FormattingEnabled = true;
            this.TxtSehir.Location = new System.Drawing.Point(469, 105);
            this.TxtSehir.Name = "TxtSehir";
            this.TxtSehir.Size = new System.Drawing.Size(159, 21);
            this.TxtSehir.TabIndex = 5;
            // 
            // TxtTipAdi
            // 
            this.TxtTipAdi.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.TxtTipAdi.FormattingEnabled = true;
            this.TxtTipAdi.Location = new System.Drawing.Point(116, 105);
            this.TxtTipAdi.Name = "TxtTipAdi";
            this.TxtTipAdi.Size = new System.Drawing.Size(227, 21);
            this.TxtTipAdi.TabIndex = 3;
            // 
            // TxtCariHadi
            // 
            this.TxtCariHadi.Location = new System.Drawing.Point(116, 56);
            this.TxtCariHadi.Name = "TxtCariHadi";
            this.TxtCariHadi.Size = new System.Drawing.Size(512, 20);
            this.TxtCariHadi.TabIndex = 2;
            // 
            // TxtHadi
            // 
            this.TxtHadi.Location = new System.Drawing.Point(116, 14);
            this.TxtHadi.Name = "TxtHadi";
            this.TxtHadi.Size = new System.Drawing.Size(512, 20);
            this.TxtHadi.TabIndex = 1;
            // 
            // label9
            // 
            this.label9.BackColor = System.Drawing.SystemColors.ControlLight;
            this.label9.Location = new System.Drawing.Point(757, 77);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(77, 26);
            this.label9.TabIndex = 0;
            this.label9.Text = "Vergi No : ";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.SystemColors.ControlLight;
            this.label5.Location = new System.Drawing.Point(397, 182);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(66, 25);
            this.label5.TabIndex = 0;
            this.label5.Text = "Telefon : ";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label8
            // 
            this.label8.BackColor = System.Drawing.SystemColors.ControlLight;
            this.label8.Location = new System.Drawing.Point(10, 162);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(87, 32);
            this.label8.TabIndex = 0;
            this.label8.Text = "Adres :";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.SystemColors.ControlLight;
            this.label3.Location = new System.Drawing.Point(7, 98);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 33);
            this.label3.TabIndex = 0;
            this.label3.Text = "Hastane Tipi : ";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label7
            // 
            this.label7.BackColor = System.Drawing.SystemColors.ControlLight;
            this.label7.Location = new System.Drawing.Point(754, 11);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(80, 34);
            this.label7.TabIndex = 0;
            this.label7.Text = "Vergi Dairesi : ";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label6
            // 
            this.label6.BackColor = System.Drawing.SystemColors.ControlLight;
            this.label6.Location = new System.Drawing.Point(397, 105);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(66, 21);
            this.label6.TabIndex = 0;
            this.label6.Text = "Sehir : ";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.SystemColors.ControlLight;
            this.label4.Location = new System.Drawing.Point(7, 49);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(87, 33);
            this.label4.TabIndex = 0;
            this.label4.Text = "Cari Adi :";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.SystemColors.ControlLight;
            this.label2.Location = new System.Drawing.Point(10, 6);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 34);
            this.label2.TabIndex = 0;
            this.label2.Text = "Hastane Adi :";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // Liste
            // 
            this.Liste.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Liste.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Sira,
            this.Id,
            this.Adi,
            this.TipAdi,
            this.Tel,
            this.Sehir});
            this.Liste.Dock = System.Windows.Forms.DockStyle.Top;
            this.Liste.Location = new System.Drawing.Point(0, 0);
            this.Liste.Name = "Liste";
            this.Liste.Size = new System.Drawing.Size(1294, 245);
            this.Liste.TabIndex = 0;
            this.Liste.DoubleClick += new System.EventHandler(this.Liste_DoubleClick);
            // 
            // Sira
            // 
            this.Sira.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.Sira.HeaderText = "Sira";
            this.Sira.Name = "Sira";
            this.Sira.Width = 50;
            // 
            // Id
            // 
            this.Id.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.Id.HeaderText = "Id";
            this.Id.Name = "Id";
            this.Id.Width = 41;
            // 
            // Adi
            // 
            this.Adi.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Adi.HeaderText = "Hastane Adi";
            this.Adi.Name = "Adi";
            // 
            // TipAdi
            // 
            this.TipAdi.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.TipAdi.HeaderText = "HastaneTipi";
            this.TipAdi.Name = "TipAdi";
            this.TipAdi.Width = 89;
            // 
            // Tel
            // 
            this.Tel.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.Tel.HeaderText = "Telefon";
            this.Tel.Name = "Tel";
            this.Tel.Width = 68;
            // 
            // Sehir
            // 
            this.Sehir.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.Sehir.HeaderText = "Sehir";
            this.Sehir.Name = "Sehir";
            this.Sehir.Width = 56;
            // 
            // BtnKapat
            // 
            this.BtnKapat.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnKapat.BackgroundImage = global::IEA_ErpProject.Properties.Resources.exit_64;
            this.BtnKapat.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnKapat.Location = new System.Drawing.Point(1217, 12);
            this.BtnKapat.Name = "BtnKapat";
            this.BtnKapat.Size = new System.Drawing.Size(49, 43);
            this.BtnKapat.TabIndex = 4;
            this.BtnKapat.UseVisualStyleBackColor = true;
            this.BtnKapat.Click += new System.EventHandler(this.BtnKapat_Click);
            // 
            // BtnTemizle
            // 
            this.BtnTemizle.BackgroundImage = global::IEA_ErpProject.Properties.Resources.clean;
            this.BtnTemizle.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnTemizle.Location = new System.Drawing.Point(214, 12);
            this.BtnTemizle.Name = "BtnTemizle";
            this.BtnTemizle.Size = new System.Drawing.Size(49, 43);
            this.BtnTemizle.TabIndex = 3;
            this.BtnTemizle.UseVisualStyleBackColor = true;
            this.BtnTemizle.Click += new System.EventHandler(this.BtnTemizle_Click);
            // 
            // BtnSil
            // 
            this.BtnSil.BackgroundImage = global::IEA_ErpProject.Properties.Resources.cop24x24;
            this.BtnSil.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnSil.Location = new System.Drawing.Point(148, 12);
            this.BtnSil.Name = "BtnSil";
            this.BtnSil.Size = new System.Drawing.Size(49, 43);
            this.BtnSil.TabIndex = 2;
            this.BtnSil.UseVisualStyleBackColor = true;
            this.BtnSil.Click += new System.EventHandler(this.BtnSil_Click);
            // 
            // BtnGüncelle
            // 
            this.BtnGüncelle.BackgroundImage = global::IEA_ErpProject.Properties.Resources.Update32x32;
            this.BtnGüncelle.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnGüncelle.Location = new System.Drawing.Point(81, 12);
            this.BtnGüncelle.Name = "BtnGüncelle";
            this.BtnGüncelle.Size = new System.Drawing.Size(49, 43);
            this.BtnGüncelle.TabIndex = 1;
            this.BtnGüncelle.UseVisualStyleBackColor = true;
            this.BtnGüncelle.Click += new System.EventHandler(this.BtnGüncelle_Click);
            // 
            // BtnKaydet
            // 
            this.BtnKaydet.BackgroundImage = global::IEA_ErpProject.Properties.Resources.Save_icon64x64;
            this.BtnKaydet.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnKaydet.Location = new System.Drawing.Point(12, 12);
            this.BtnKaydet.Name = "BtnKaydet";
            this.BtnKaydet.Size = new System.Drawing.Size(49, 43);
            this.BtnKaydet.TabIndex = 0;
            this.BtnKaydet.UseVisualStyleBackColor = true;
            this.BtnKaydet.Click += new System.EventHandler(this.BtnKaydet_Click);
            // 
            // HastaneGiris
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1298, 576);
            this.Controls.Add(this.ScHastane);
            this.Controls.Add(this.BtnKapat);
            this.Controls.Add(this.BtnTemizle);
            this.Controls.Add(this.BtnSil);
            this.Controls.Add(this.BtnGüncelle);
            this.Controls.Add(this.BtnKaydet);
            this.Controls.Add(this.label1);
            this.Name = "HastaneGiris";
            this.Text = "HastaneGirid";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.HastaneGiris_Load);
            this.ScHastane.Panel1.ResumeLayout(false);
            this.ScHastane.Panel1.PerformLayout();
            this.ScHastane.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ScHastane)).EndInit();
            this.ScHastane.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Liste)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BtnKaydet;
        private System.Windows.Forms.Button BtnGüncelle;
        private System.Windows.Forms.Button BtnSil;
        private System.Windows.Forms.Button BtnTemizle;
        private System.Windows.Forms.Button BtnKapat;
        private System.Windows.Forms.SplitContainer ScHastane;
        private System.Windows.Forms.DataGridView Liste;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.MaskedTextBox TxtVergiNo;
        private System.Windows.Forms.TextBox TxtVergiDairesi;
        private System.Windows.Forms.MaskedTextBox TxtTelefon;
        private System.Windows.Forms.RichTextBox TxtAdres;
        private System.Windows.Forms.ComboBox TxtSehir;
        private System.Windows.Forms.ComboBox TxtTipAdi;
        private System.Windows.Forms.TextBox TxtCariHadi;
        private System.Windows.Forms.TextBox TxtHadi;
        private System.Windows.Forms.DataGridViewTextBoxColumn Sira;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Adi;
        private System.Windows.Forms.DataGridViewTextBoxColumn TipAdi;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tel;
        private System.Windows.Forms.DataGridViewTextBoxColumn Sehir;
        private System.Windows.Forms.TextBox TxtHastaneBul;
        private System.Windows.Forms.Button BtnDetayEkle;
        private System.Windows.Forms.Button BtnDetayGoster;
    }
}