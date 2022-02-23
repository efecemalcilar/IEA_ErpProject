namespace ProjeAtHome.BilgiGiris.Hastaneler
{
    partial class HastaneDetay
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
            this.Liste = new System.Windows.Forms.DataGridView();
            this.Sira = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GirisId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GirisAdi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Yetkili = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Departman = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tel = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Gsm = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BtnEkle = new System.Windows.Forms.Button();
            this.TxtGsm = new System.Windows.Forms.MaskedTextBox();
            this.TxtTel = new System.Windows.Forms.MaskedTextBox();
            this.TxtDepartman = new System.Windows.Forms.ComboBox();
            this.TxtEmail = new System.Windows.Forms.TextBox();
            this.TxtYetkili = new System.Windows.Forms.TextBox();
            this.LblHastaneId = new System.Windows.Forms.Label();
            this.LblHastaneAdi = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.Liste)).BeginInit();
            this.SuspendLayout();
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
            this.Liste.Location = new System.Drawing.Point(162, 289);
            this.Liste.Name = "Liste";
            this.Liste.Size = new System.Drawing.Size(676, 228);
            this.Liste.TabIndex = 8;
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
            // BtnEkle
            // 
            this.BtnEkle.Location = new System.Drawing.Point(864, 147);
            this.BtnEkle.Name = "BtnEkle";
            this.BtnEkle.Size = new System.Drawing.Size(77, 23);
            this.BtnEkle.TabIndex = 16;
            this.BtnEkle.Text = "Ekle";
            this.BtnEkle.UseVisualStyleBackColor = true;
            // 
            // TxtGsm
            // 
            this.TxtGsm.Location = new System.Drawing.Point(535, 147);
            this.TxtGsm.Mask = "(999) 000-0000";
            this.TxtGsm.Name = "TxtGsm";
            this.TxtGsm.Size = new System.Drawing.Size(90, 20);
            this.TxtGsm.TabIndex = 14;
            // 
            // TxtTel
            // 
            this.TxtTel.Location = new System.Drawing.Point(429, 146);
            this.TxtTel.Mask = "(999) 000-0000";
            this.TxtTel.Name = "TxtTel";
            this.TxtTel.Size = new System.Drawing.Size(90, 20);
            this.TxtTel.TabIndex = 15;
            // 
            // TxtDepartman
            // 
            this.TxtDepartman.FormattingEnabled = true;
            this.TxtDepartman.Location = new System.Drawing.Point(246, 146);
            this.TxtDepartman.Name = "TxtDepartman";
            this.TxtDepartman.Size = new System.Drawing.Size(167, 21);
            this.TxtDepartman.TabIndex = 13;
            // 
            // TxtEmail
            // 
            this.TxtEmail.Location = new System.Drawing.Point(631, 147);
            this.TxtEmail.Name = "TxtEmail";
            this.TxtEmail.Size = new System.Drawing.Size(211, 20);
            this.TxtEmail.TabIndex = 11;
            // 
            // TxtYetkili
            // 
            this.TxtYetkili.Location = new System.Drawing.Point(20, 144);
            this.TxtYetkili.Name = "TxtYetkili";
            this.TxtYetkili.Size = new System.Drawing.Size(211, 20);
            this.TxtYetkili.TabIndex = 12;
            // 
            // LblHastaneId
            // 
            this.LblHastaneId.BackColor = System.Drawing.Color.Khaki;
            this.LblHastaneId.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.LblHastaneId.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.LblHastaneId.Location = new System.Drawing.Point(297, 89);
            this.LblHastaneId.Name = "LblHastaneId";
            this.LblHastaneId.Size = new System.Drawing.Size(60, 34);
            this.LblHastaneId.TabIndex = 9;
            this.LblHastaneId.Text = "****";
            this.LblHastaneId.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LblHastaneAdi
            // 
            this.LblHastaneAdi.BackColor = System.Drawing.Color.Khaki;
            this.LblHastaneAdi.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.LblHastaneAdi.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.LblHastaneAdi.Location = new System.Drawing.Point(363, 89);
            this.LblHastaneAdi.Name = "LblHastaneAdi";
            this.LblHastaneAdi.Size = new System.Drawing.Size(307, 34);
            this.LblHastaneAdi.TabIndex = 10;
            this.LblHastaneAdi.Text = "****";
            this.LblHastaneAdi.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Khaki;
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(1018, 38);
            this.label1.TabIndex = 17;
            this.label1.Text = "Hastane Detay";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // HastaneDetay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1018, 551);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BtnEkle);
            this.Controls.Add(this.TxtGsm);
            this.Controls.Add(this.TxtTel);
            this.Controls.Add(this.TxtDepartman);
            this.Controls.Add(this.TxtEmail);
            this.Controls.Add(this.TxtYetkili);
            this.Controls.Add(this.LblHastaneId);
            this.Controls.Add(this.LblHastaneAdi);
            this.Controls.Add(this.Liste);
            this.Name = "HastaneDetay";
            this.Text = "HastaneDetay";
            this.Load += new System.EventHandler(this.HastaneDetay_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Liste)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView Liste;
        private System.Windows.Forms.DataGridViewTextBoxColumn Sira;
        private System.Windows.Forms.DataGridViewTextBoxColumn GirisId;
        private System.Windows.Forms.DataGridViewTextBoxColumn GirisAdi;
        private System.Windows.Forms.DataGridViewTextBoxColumn Yetkili;
        private System.Windows.Forms.DataGridViewTextBoxColumn Departman;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tel;
        private System.Windows.Forms.DataGridViewTextBoxColumn Gsm;
        private System.Windows.Forms.DataGridViewTextBoxColumn Email;
        private System.Windows.Forms.Button BtnEkle;
        private System.Windows.Forms.MaskedTextBox TxtGsm;
        private System.Windows.Forms.MaskedTextBox TxtTel;
        private System.Windows.Forms.ComboBox TxtDepartman;
        private System.Windows.Forms.TextBox TxtEmail;
        private System.Windows.Forms.TextBox TxtYetkili;
        public System.Windows.Forms.Label LblHastaneId;
        public System.Windows.Forms.Label LblHastaneAdi;
        private System.Windows.Forms.Label label1;
    }
}