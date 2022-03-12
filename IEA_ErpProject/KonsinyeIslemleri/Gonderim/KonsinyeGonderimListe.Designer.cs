namespace IEA_ErpProject.KonsinyeIslemleri.Giris
{
    partial class KonsinyeGonderimListe
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
            this.PnlUst = new System.Windows.Forms.Panel();
            this.TxtGirisAra = new System.Windows.Forms.TextBox();
            this.BtnGirisBul = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.Sira = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CariTur = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CariAdi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GonderimTarih = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Aciklama = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GonId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.Liste)).BeginInit();
            this.PnlUst.SuspendLayout();
            this.SuspendLayout();
            // 
            // Liste
            // 
            this.Liste.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Liste.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Sira,
            this.Id,
            this.CariTur,
            this.CariAdi,
            this.GonderimTarih,
            this.Aciklama,
            this.GonId});
            this.Liste.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Liste.Location = new System.Drawing.Point(0, 67);
            this.Liste.Name = "Liste";
            this.Liste.Size = new System.Drawing.Size(1382, 552);
            this.Liste.TabIndex = 5;
            this.Liste.DoubleClick += new System.EventHandler(this.Liste_DoubleClick);
            // 
            // PnlUst
            // 
            this.PnlUst.BackColor = System.Drawing.Color.SteelBlue;
            this.PnlUst.Controls.Add(this.TxtGirisAra);
            this.PnlUst.Controls.Add(this.BtnGirisBul);
            this.PnlUst.Controls.Add(this.label1);
            this.PnlUst.Dock = System.Windows.Forms.DockStyle.Top;
            this.PnlUst.Location = new System.Drawing.Point(0, 0);
            this.PnlUst.Name = "PnlUst";
            this.PnlUst.Size = new System.Drawing.Size(1382, 67);
            this.PnlUst.TabIndex = 4;
            this.PnlUst.DoubleClick += new System.EventHandler(this.Liste_DoubleClick);
            // 
            // TxtGirisAra
            // 
            this.TxtGirisAra.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.TxtGirisAra.Location = new System.Drawing.Point(1099, 13);
            this.TxtGirisAra.Multiline = true;
            this.TxtGirisAra.Name = "TxtGirisAra";
            this.TxtGirisAra.Size = new System.Drawing.Size(239, 32);
            this.TxtGirisAra.TabIndex = 1;
            this.TxtGirisAra.TextChanged += new System.EventHandler(this.TxtGirisAra_TextChanged);
            // 
            // BtnGirisBul
            // 
            this.BtnGirisBul.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnGirisBul.Location = new System.Drawing.Point(1002, 13);
            this.BtnGirisBul.Name = "BtnGirisBul";
            this.BtnGirisBul.Size = new System.Drawing.Size(91, 32);
            this.BtnGirisBul.TabIndex = 1;
            this.BtnGirisBul.Text = "Giris Bul";
            this.BtnGirisBul.UseVisualStyleBackColor = true;
            this.BtnGirisBul.Click += new System.EventHandler(this.BtnGirisBul_Click);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(240, 43);
            this.label1.TabIndex = 1;
            this.label1.Text = "Konsinye Gonderim Listesi";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
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
            // CariTur
            // 
            this.CariTur.HeaderText = "Cari Tur";
            this.CariTur.Name = "CariTur";
            // 
            // CariAdi
            // 
            this.CariAdi.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.CariAdi.HeaderText = "Cari Adi";
            this.CariAdi.Name = "CariAdi";
            // 
            // GonderimTarih
            // 
            this.GonderimTarih.HeaderText = "Gonderim Tarih";
            this.GonderimTarih.Name = "GonderimTarih";
            // 
            // Aciklama
            // 
            this.Aciklama.HeaderText = "Aciklama";
            this.Aciklama.Name = "Aciklama";
            // 
            // GonId
            // 
            this.GonId.HeaderText = "GonderimId";
            this.GonId.Name = "GonId";
            // 
            // KonsinyeGonderimListe
            // 
            this.ClientSize = new System.Drawing.Size(1382, 619);
            this.Controls.Add(this.Liste);
            this.Controls.Add(this.PnlUst);
            this.Name = "KonsinyeGonderimListe";
            this.Load += new System.EventHandler(this.KonsinyeGonderimListe_Load);
            this.DoubleClick += new System.EventHandler(this.Liste_DoubleClick);
            ((System.ComponentModel.ISupportInitialize)(this.Liste)).EndInit();
            this.PnlUst.ResumeLayout(false);
            this.PnlUst.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView Liste;
        private System.Windows.Forms.Panel PnlUst;
        private System.Windows.Forms.TextBox TxtGirisAra;
        private System.Windows.Forms.Button BtnGirisBul;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Sira;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn CariTur;
        private System.Windows.Forms.DataGridViewTextBoxColumn CariAdi;
        private System.Windows.Forms.DataGridViewTextBoxColumn GonderimTarih;
        private System.Windows.Forms.DataGridViewTextBoxColumn Aciklama;
        private System.Windows.Forms.DataGridViewTextBoxColumn GonId;
    }
}