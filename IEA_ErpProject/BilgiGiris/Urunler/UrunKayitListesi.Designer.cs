namespace IEA_ErpProject.BilgiGiris.Urunler
{
    partial class UrunKayitListesi
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
            this.PnlUst = new System.Windows.Forms.Panel();
            this.TxtUrunAra = new System.Windows.Forms.TextBox();
            this.BtnUrunAra = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.Liste = new System.Windows.Forms.DataGridView();
            this.Sira = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Firma = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UrunKodu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AcikTr = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Uid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PnlUst.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Liste)).BeginInit();
            this.SuspendLayout();
            // 
            // PnlUst
            // 
            this.PnlUst.BackColor = System.Drawing.Color.SteelBlue;
            this.PnlUst.Controls.Add(this.TxtUrunAra);
            this.PnlUst.Controls.Add(this.BtnUrunAra);
            this.PnlUst.Controls.Add(this.label1);
            this.PnlUst.Dock = System.Windows.Forms.DockStyle.Top;
            this.PnlUst.Location = new System.Drawing.Point(0, 0);
            this.PnlUst.Name = "PnlUst";
            this.PnlUst.Size = new System.Drawing.Size(1379, 67);
            this.PnlUst.TabIndex = 0;
            // 
            // TxtUrunAra
            // 
            this.TxtUrunAra.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.TxtUrunAra.Location = new System.Drawing.Point(1096, 13);
            this.TxtUrunAra.Multiline = true;
            this.TxtUrunAra.Name = "TxtUrunAra";
            this.TxtUrunAra.Size = new System.Drawing.Size(239, 32);
            this.TxtUrunAra.TabIndex = 1;
            this.TxtUrunAra.TextChanged += new System.EventHandler(this.TxtUrunAra_TextChanged);
            // 
            // BtnUrunAra
            // 
            this.BtnUrunAra.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnUrunAra.Location = new System.Drawing.Point(999, 13);
            this.BtnUrunAra.Name = "BtnUrunAra";
            this.BtnUrunAra.Size = new System.Drawing.Size(91, 32);
            this.BtnUrunAra.TabIndex = 1;
            this.BtnUrunAra.Text = "Urun Ara";
            this.BtnUrunAra.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(179, 43);
            this.label1.TabIndex = 1;
            this.label1.Text = "Urun Kayit Listesi";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Liste
            // 
            this.Liste.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Liste.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Sira,
            this.Id,
            this.Firma,
            this.UrunKodu,
            this.AcikTr,
            this.Uid});
            this.Liste.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Liste.Location = new System.Drawing.Point(0, 67);
            this.Liste.Name = "Liste";
            this.Liste.Size = new System.Drawing.Size(1379, 529);
            this.Liste.TabIndex = 1;
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
            // Firma
            // 
            this.Firma.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Firma.HeaderText = "Firma";
            this.Firma.Name = "Firma";
            // 
            // UrunKodu
            // 
            this.UrunKodu.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.UrunKodu.HeaderText = "Urun Kodu";
            this.UrunKodu.Name = "UrunKodu";
            // 
            // AcikTr
            // 
            this.AcikTr.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.AcikTr.HeaderText = "Acıklama TR";
            this.AcikTr.Name = "AcikTr";
            // 
            // Uid
            // 
            this.Uid.HeaderText = "Uid";
            this.Uid.Name = "Uid";
            this.Uid.Visible = false;
            // 
            // UrunKayitListesi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1379, 596);
            this.Controls.Add(this.Liste);
            this.Controls.Add(this.PnlUst);
            this.Name = "UrunKayitListesi";
            this.Text = "UrunKayitListesi";
            this.Load += new System.EventHandler(this.UrunKayitListesi_Load);
            this.PnlUst.ResumeLayout(false);
            this.PnlUst.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Liste)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel PnlUst;
        private System.Windows.Forms.TextBox TxtUrunAra;
        private System.Windows.Forms.Button BtnUrunAra;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView Liste;
        private System.Windows.Forms.DataGridViewTextBoxColumn Sira;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Firma;
        private System.Windows.Forms.DataGridViewTextBoxColumn UrunKodu;
        private System.Windows.Forms.DataGridViewTextBoxColumn AcikTr;
        private System.Windows.Forms.DataGridViewTextBoxColumn Uid;
    }
}