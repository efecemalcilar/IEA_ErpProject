namespace IEA_ErpProject.BilgiGiris.Firmalar
{
    partial class FirmaDetay
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
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.BtnEklee = new System.Windows.Forms.Button();
            this.maskedTextBox1 = new System.Windows.Forms.MaskedTextBox();
            this.maskedTextBox2 = new System.Windows.Forms.MaskedTextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.lblFirmaId = new System.Windows.Forms.Label();
            this.LblFirmaAdi = new System.Windows.Forms.Label();
            this.BtnKayit = new System.Windows.Forms.Button();
            this.Liste = new System.Windows.Forms.DataGridView();
            this.Sira = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GirisId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GirisAdi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Yetkili = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Departman = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tel = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Gsm = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LblHastaneAdi = new System.Windows.Forms.Label();
            this.BtnEkle = new System.Windows.Forms.Button();
            this.LblHastaneId = new System.Windows.Forms.Label();
            this.TxtGsm = new System.Windows.Forms.MaskedTextBox();
            this.TxtYetkili = new System.Windows.Forms.TextBox();
            this.TxtTel = new System.Windows.Forms.MaskedTextBox();
            this.TxtEmail = new System.Windows.Forms.TextBox();
            this.TxtDepartman = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Liste)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.SteelBlue;
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(1281, 38);
            this.label1.TabIndex = 16;
            this.label1.Text = "Firma Detay";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Top;
            this.splitContainer1.Location = new System.Drawing.Point(0, 38);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.BtnEklee);
            this.splitContainer1.Panel1.Controls.Add(this.maskedTextBox1);
            this.splitContainer1.Panel1.Controls.Add(this.maskedTextBox2);
            this.splitContainer1.Panel1.Controls.Add(this.comboBox1);
            this.splitContainer1.Panel1.Controls.Add(this.textBox1);
            this.splitContainer1.Panel1.Controls.Add(this.textBox2);
            this.splitContainer1.Panel1.Controls.Add(this.lblFirmaId);
            this.splitContainer1.Panel1.Controls.Add(this.LblFirmaAdi);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.BtnKayit);
            this.splitContainer1.Panel2.Controls.Add(this.Liste);
            this.splitContainer1.Panel2.Controls.Add(this.LblHastaneAdi);
            this.splitContainer1.Panel2.Controls.Add(this.BtnEkle);
            this.splitContainer1.Panel2.Controls.Add(this.LblHastaneId);
            this.splitContainer1.Panel2.Controls.Add(this.TxtGsm);
            this.splitContainer1.Panel2.Controls.Add(this.TxtYetkili);
            this.splitContainer1.Panel2.Controls.Add(this.TxtTel);
            this.splitContainer1.Panel2.Controls.Add(this.TxtEmail);
            this.splitContainer1.Panel2.Controls.Add(this.TxtDepartman);
            this.splitContainer1.Size = new System.Drawing.Size(1281, 548);
            this.splitContainer1.SplitterDistance = 280;
            this.splitContainer1.TabIndex = 18;
            // 
            // BtnEklee
            // 
            this.BtnEklee.Location = new System.Drawing.Point(1024, 158);
            this.BtnEklee.Name = "BtnEklee";
            this.BtnEklee.Size = new System.Drawing.Size(77, 23);
            this.BtnEklee.TabIndex = 14;
            this.BtnEklee.Text = "Ekle";
            this.BtnEklee.UseVisualStyleBackColor = true;
            this.BtnEklee.Click += new System.EventHandler(this.BtnEklee_Click);
            // 
            // maskedTextBox1
            // 
            this.maskedTextBox1.Location = new System.Drawing.Point(695, 158);
            this.maskedTextBox1.Mask = "(999) 000-0000";
            this.maskedTextBox1.Name = "maskedTextBox1";
            this.maskedTextBox1.Size = new System.Drawing.Size(90, 20);
            this.maskedTextBox1.TabIndex = 12;
            // 
            // maskedTextBox2
            // 
            this.maskedTextBox2.Location = new System.Drawing.Point(589, 157);
            this.maskedTextBox2.Mask = "(999) 000-0000";
            this.maskedTextBox2.Name = "maskedTextBox2";
            this.maskedTextBox2.Size = new System.Drawing.Size(90, 20);
            this.maskedTextBox2.TabIndex = 13;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(406, 157);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(167, 21);
            this.comboBox1.TabIndex = 11;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(791, 158);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(211, 20);
            this.textBox1.TabIndex = 9;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(180, 155);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(211, 20);
            this.textBox2.TabIndex = 10;
            // 
            // lblFirmaId
            // 
            this.lblFirmaId.BackColor = System.Drawing.Color.SteelBlue;
            this.lblFirmaId.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblFirmaId.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblFirmaId.Location = new System.Drawing.Point(457, 100);
            this.lblFirmaId.Name = "lblFirmaId";
            this.lblFirmaId.Size = new System.Drawing.Size(60, 34);
            this.lblFirmaId.TabIndex = 7;
            this.lblFirmaId.Text = "****";
            this.lblFirmaId.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LblFirmaAdi
            // 
            this.LblFirmaAdi.BackColor = System.Drawing.Color.SteelBlue;
            this.LblFirmaAdi.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.LblFirmaAdi.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.LblFirmaAdi.Location = new System.Drawing.Point(523, 100);
            this.LblFirmaAdi.Name = "LblFirmaAdi";
            this.LblFirmaAdi.Size = new System.Drawing.Size(307, 34);
            this.LblFirmaAdi.TabIndex = 8;
            this.LblFirmaAdi.Text = "****";
            this.LblFirmaAdi.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // BtnKayit
            // 
            this.BtnKayit.BackColor = System.Drawing.Color.SteelBlue;
            this.BtnKayit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtnKayit.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BtnKayit.Location = new System.Drawing.Point(1029, 196);
            this.BtnKayit.Name = "BtnKayit";
            this.BtnKayit.Size = new System.Drawing.Size(120, 60);
            this.BtnKayit.TabIndex = 29;
            this.BtnKayit.Text = "Kaydet";
            this.BtnKayit.UseVisualStyleBackColor = false;
            this.BtnKayit.Click += new System.EventHandler(this.BtnKayit_Click);
            // 
            // Liste
            // 
            this.Liste.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Liste.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Sira,
            this.GirisId,
            this.GirisAdi,
            this.Yetkili,
            this.Departman,
            this.Tel,
            this.Gsm,
            this.Email});
            this.Liste.Location = new System.Drawing.Point(301, 28);
            this.Liste.Name = "Liste";
            this.Liste.Size = new System.Drawing.Size(676, 228);
            this.Liste.TabIndex = 28;
            // 
            // Sira
            // 
            this.Sira.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.Sira.HeaderText = "Sira";
            this.Sira.Name = "Sira";
            this.Sira.Width = 50;
            // 
            // GirisId
            // 
            this.GirisId.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.GirisId.HeaderText = "GirisId";
            this.GirisId.Name = "GirisId";
            this.GirisId.Width = 61;
            // 
            // GirisAdi
            // 
            this.GirisAdi.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.GirisAdi.HeaderText = "GirisAdi";
            this.GirisAdi.Name = "GirisAdi";
            this.GirisAdi.Width = 67;
            // 
            // Yetkili
            // 
            this.Yetkili.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Yetkili.HeaderText = "Yetkili";
            this.Yetkili.Name = "Yetkili";
            // 
            // Departman
            // 
            this.Departman.HeaderText = "Departman";
            this.Departman.Name = "Departman";
            // 
            // Tel
            // 
            this.Tel.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.Tel.HeaderText = "Tel";
            this.Tel.Name = "Tel";
            this.Tel.Width = 47;
            // 
            // Gsm
            // 
            this.Gsm.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.Gsm.HeaderText = "Gsm";
            this.Gsm.Name = "Gsm";
            this.Gsm.Width = 53;
            // 
            // Email
            // 
            this.Email.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Email.HeaderText = "Email";
            this.Email.Name = "Email";
            // 
            // LblHastaneAdi
            // 
            this.LblHastaneAdi.BackColor = System.Drawing.Color.SteelBlue;
            this.LblHastaneAdi.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.LblHastaneAdi.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.LblHastaneAdi.Location = new System.Drawing.Point(658, -132);
            this.LblHastaneAdi.Name = "LblHastaneAdi";
            this.LblHastaneAdi.Size = new System.Drawing.Size(307, 34);
            this.LblHastaneAdi.TabIndex = 21;
            this.LblHastaneAdi.Text = "****";
            this.LblHastaneAdi.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // BtnEkle
            // 
            this.BtnEkle.Location = new System.Drawing.Point(1230, -53);
            this.BtnEkle.Name = "BtnEkle";
            this.BtnEkle.Size = new System.Drawing.Size(77, 23);
            this.BtnEkle.TabIndex = 27;
            this.BtnEkle.Text = "Ekle";
            this.BtnEkle.UseVisualStyleBackColor = true;
            // 
            // LblHastaneId
            // 
            this.LblHastaneId.BackColor = System.Drawing.Color.SteelBlue;
            this.LblHastaneId.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.LblHastaneId.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.LblHastaneId.Location = new System.Drawing.Point(592, -132);
            this.LblHastaneId.Name = "LblHastaneId";
            this.LblHastaneId.Size = new System.Drawing.Size(60, 34);
            this.LblHastaneId.TabIndex = 20;
            this.LblHastaneId.Text = "****";
            this.LblHastaneId.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // TxtGsm
            // 
            this.TxtGsm.Location = new System.Drawing.Point(901, -53);
            this.TxtGsm.Mask = "(999) 000-0000";
            this.TxtGsm.Name = "TxtGsm";
            this.TxtGsm.Size = new System.Drawing.Size(90, 20);
            this.TxtGsm.TabIndex = 25;
            // 
            // TxtYetkili
            // 
            this.TxtYetkili.Location = new System.Drawing.Point(386, -56);
            this.TxtYetkili.Name = "TxtYetkili";
            this.TxtYetkili.Size = new System.Drawing.Size(211, 20);
            this.TxtYetkili.TabIndex = 23;
            // 
            // TxtTel
            // 
            this.TxtTel.Location = new System.Drawing.Point(795, -54);
            this.TxtTel.Mask = "(999) 000-0000";
            this.TxtTel.Name = "TxtTel";
            this.TxtTel.Size = new System.Drawing.Size(90, 20);
            this.TxtTel.TabIndex = 26;
            // 
            // TxtEmail
            // 
            this.TxtEmail.Location = new System.Drawing.Point(997, -53);
            this.TxtEmail.Name = "TxtEmail";
            this.TxtEmail.Size = new System.Drawing.Size(211, 20);
            this.TxtEmail.TabIndex = 22;
            // 
            // TxtDepartman
            // 
            this.TxtDepartman.FormattingEnabled = true;
            this.TxtDepartman.Location = new System.Drawing.Point(612, -54);
            this.TxtDepartman.Name = "TxtDepartman";
            this.TxtDepartman.Size = new System.Drawing.Size(167, 21);
            this.TxtDepartman.TabIndex = 24;
            // 
            // FirmaDetay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1281, 590);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.label1);
            this.Name = "FirmaDetay";
            this.Text = "FirmaDetayGoster";
            this.Load += new System.EventHandler(this.FirmaDetayGoster_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Liste)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Button BtnKayit;
        private System.Windows.Forms.DataGridView Liste;
        private System.Windows.Forms.DataGridViewTextBoxColumn Sira;
        private System.Windows.Forms.DataGridViewTextBoxColumn GirisId;
        private System.Windows.Forms.DataGridViewTextBoxColumn GirisAdi;
        private System.Windows.Forms.DataGridViewTextBoxColumn Yetkili;
        private System.Windows.Forms.DataGridViewTextBoxColumn Departman;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tel;
        private System.Windows.Forms.DataGridViewTextBoxColumn Gsm;
        private System.Windows.Forms.DataGridViewTextBoxColumn Email;
        public System.Windows.Forms.Label LblHastaneAdi;
        private System.Windows.Forms.Button BtnEkle;
        public System.Windows.Forms.Label LblHastaneId;
        private System.Windows.Forms.MaskedTextBox TxtGsm;
        private System.Windows.Forms.TextBox TxtYetkili;
        private System.Windows.Forms.MaskedTextBox TxtTel;
        private System.Windows.Forms.TextBox TxtEmail;
        private System.Windows.Forms.ComboBox TxtDepartman;
        private System.Windows.Forms.Button BtnEklee;
        private System.Windows.Forms.MaskedTextBox maskedTextBox1;
        private System.Windows.Forms.MaskedTextBox maskedTextBox2;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        public System.Windows.Forms.Label lblFirmaId;
        public System.Windows.Forms.Label LblFirmaAdi;
    }
}