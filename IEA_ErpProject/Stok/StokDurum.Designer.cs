namespace IEA_ErpProject.Stok
{
    partial class StokDurum
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
            this.SpcStok = new System.Windows.Forms.SplitContainer();
            this.ListeStok = new System.Windows.Forms.DataGridView();
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.PnlSol = new System.Windows.Forms.Panel();
            this.ListeSube = new System.Windows.Forms.DataGridView();
            this.splitter3 = new System.Windows.Forms.Splitter();
            this.splitter2 = new System.Windows.Forms.Splitter();
            this.ListeKonsinye = new System.Windows.Forms.DataGridView();
            this.ListeUrunHareket = new System.Windows.Forms.DataGridView();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.TcStokDurum = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.ListeStok1 = new System.Windows.Forms.DataGridView();
            this.Barkod = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UrunKodu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LotSeri = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StokAdet = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RafAdet = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sBarkod = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sUrunKodu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sLot = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sStokAdet = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sRafAdet = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.KonsinyeAdet = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sSubeAdet = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sUrunHareketadet = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sUts = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.UTarih = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SkTarih = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.SpcStok)).BeginInit();
            this.SpcStok.Panel1.SuspendLayout();
            this.SpcStok.Panel2.SuspendLayout();
            this.SpcStok.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ListeStok)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ListeSube)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ListeKonsinye)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ListeUrunHareket)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.TcStokDurum.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ListeStok1)).BeginInit();
            this.SuspendLayout();
            // 
            // SpcStok
            // 
            this.SpcStok.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.SpcStok.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SpcStok.FixedPanel = System.Windows.Forms.FixedPanel.Panel2;
            this.SpcStok.Location = new System.Drawing.Point(0, 0);
            this.SpcStok.Name = "SpcStok";
            this.SpcStok.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // SpcStok.Panel1
            // 
            this.SpcStok.Panel1.BackColor = System.Drawing.SystemColors.Control;
            this.SpcStok.Panel1.Controls.Add(this.tabControl1);
            this.SpcStok.Panel1.Controls.Add(this.splitter1);
            this.SpcStok.Panel1.Controls.Add(this.PnlSol);
            // 
            // SpcStok.Panel2
            // 
            this.SpcStok.Panel2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.SpcStok.Panel2.Controls.Add(this.ListeSube);
            this.SpcStok.Panel2.Controls.Add(this.splitter3);
            this.SpcStok.Panel2.Controls.Add(this.splitter2);
            this.SpcStok.Panel2.Controls.Add(this.ListeKonsinye);
            this.SpcStok.Panel2.Controls.Add(this.ListeUrunHareket);
            this.SpcStok.Size = new System.Drawing.Size(1464, 634);
            this.SpcStok.SplitterDistance = 450;
            this.SpcStok.TabIndex = 0;
            // 
            // ListeStok
            // 
            this.ListeStok.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ListeStok.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.sBarkod,
            this.sUrunKodu,
            this.sLot,
            this.sStokAdet,
            this.sRafAdet,
            this.KonsinyeAdet,
            this.sSubeAdet,
            this.sUrunHareketadet,
            this.sUts,
            this.UTarih,
            this.SkTarih});
            this.ListeStok.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ListeStok.Location = new System.Drawing.Point(3, 3);
            this.ListeStok.Name = "ListeStok";
            this.ListeStok.Size = new System.Drawing.Size(1223, 414);
            this.ListeStok.TabIndex = 2;
            // 
            // splitter1
            // 
            this.splitter1.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.splitter1.Location = new System.Drawing.Point(201, 0);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(22, 446);
            this.splitter1.TabIndex = 1;
            this.splitter1.TabStop = false;
            // 
            // PnlSol
            // 
            this.PnlSol.BackColor = System.Drawing.Color.LightSalmon;
            this.PnlSol.Dock = System.Windows.Forms.DockStyle.Left;
            this.PnlSol.Location = new System.Drawing.Point(0, 0);
            this.PnlSol.Name = "PnlSol";
            this.PnlSol.Size = new System.Drawing.Size(201, 446);
            this.PnlSol.TabIndex = 0;
            // 
            // ListeSube
            // 
            this.ListeSube.BackgroundColor = System.Drawing.SystemColors.Info;
            this.ListeSube.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ListeSube.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ListeSube.Location = new System.Drawing.Point(315, 0);
            this.ListeSube.Name = "ListeSube";
            this.ListeSube.Size = new System.Drawing.Size(828, 176);
            this.ListeSube.TabIndex = 4;
            // 
            // splitter3
            // 
            this.splitter3.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.splitter3.Dock = System.Windows.Forms.DockStyle.Right;
            this.splitter3.Location = new System.Drawing.Point(1143, 0);
            this.splitter3.Name = "splitter3";
            this.splitter3.Size = new System.Drawing.Size(12, 176);
            this.splitter3.TabIndex = 3;
            this.splitter3.TabStop = false;
            // 
            // splitter2
            // 
            this.splitter2.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.splitter2.Location = new System.Drawing.Point(305, 0);
            this.splitter2.Name = "splitter2";
            this.splitter2.Size = new System.Drawing.Size(10, 176);
            this.splitter2.TabIndex = 2;
            this.splitter2.TabStop = false;
            // 
            // ListeKonsinye
            // 
            this.ListeKonsinye.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ListeKonsinye.Dock = System.Windows.Forms.DockStyle.Right;
            this.ListeKonsinye.Location = new System.Drawing.Point(1155, 0);
            this.ListeKonsinye.Name = "ListeKonsinye";
            this.ListeKonsinye.Size = new System.Drawing.Size(305, 176);
            this.ListeKonsinye.TabIndex = 1;
            // 
            // ListeUrunHareket
            // 
            this.ListeUrunHareket.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ListeUrunHareket.Dock = System.Windows.Forms.DockStyle.Left;
            this.ListeUrunHareket.Location = new System.Drawing.Point(0, 0);
            this.ListeUrunHareket.Name = "ListeUrunHareket";
            this.ListeUrunHareket.Size = new System.Drawing.Size(305, 176);
            this.ListeUrunHareket.TabIndex = 0;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.TcStokDurum);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(223, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1237, 446);
            this.tabControl1.TabIndex = 3;
            // 
            // TcStokDurum
            // 
            this.TcStokDurum.Controls.Add(this.ListeStok);
            this.TcStokDurum.Location = new System.Drawing.Point(4, 22);
            this.TcStokDurum.Name = "TcStokDurum";
            this.TcStokDurum.Padding = new System.Windows.Forms.Padding(3);
            this.TcStokDurum.Size = new System.Drawing.Size(1229, 420);
            this.TcStokDurum.TabIndex = 0;
            this.TcStokDurum.Text = "Stok Durum 1";
            this.TcStokDurum.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.ListeStok1);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1229, 420);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Stok Durum2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // ListeStok1
            // 
            this.ListeStok1.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.ListeStok1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ListeStok1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Barkod,
            this.UrunKodu,
            this.LotSeri,
            this.StokAdet,
            this.RafAdet});
            this.ListeStok1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ListeStok1.Location = new System.Drawing.Point(3, 3);
            this.ListeStok1.Name = "ListeStok1";
            this.ListeStok1.Size = new System.Drawing.Size(1223, 414);
            this.ListeStok1.TabIndex = 3;
            // 
            // Barkod
            // 
            this.Barkod.HeaderText = "Barkod";
            this.Barkod.Name = "Barkod";
            // 
            // UrunKodu
            // 
            this.UrunKodu.HeaderText = "Urun Kodu";
            this.UrunKodu.Name = "UrunKodu";
            // 
            // LotSeri
            // 
            this.LotSeri.HeaderText = "Lot Seri No";
            this.LotSeri.Name = "LotSeri";
            // 
            // StokAdet
            // 
            this.StokAdet.HeaderText = "Stok Adet";
            this.StokAdet.Name = "StokAdet";
            // 
            // RafAdet
            // 
            this.RafAdet.HeaderText = "Raf Adet";
            this.RafAdet.Name = "RafAdet";
            this.RafAdet.Width = 74;
            // 
            // Id
            // 
            this.Id.HeaderText = "Id";
            this.Id.Name = "Id";
            this.Id.Visible = false;
            // 
            // sBarkod
            // 
            this.sBarkod.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.sBarkod.HeaderText = "Barkod";
            this.sBarkod.Name = "sBarkod";
            this.sBarkod.Visible = false;
            this.sBarkod.Width = 66;
            // 
            // sUrunKodu
            // 
            this.sUrunKodu.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.sUrunKodu.HeaderText = "Urun Kodu";
            this.sUrunKodu.Name = "sUrunKodu";
            // 
            // sLot
            // 
            this.sLot.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.sLot.HeaderText = "Lot Seri No";
            this.sLot.Name = "sLot";
            this.sLot.Width = 85;
            // 
            // sStokAdet
            // 
            this.sStokAdet.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.sStokAdet.HeaderText = "Stok Adet";
            this.sStokAdet.Name = "sStokAdet";
            this.sStokAdet.Width = 79;
            // 
            // sRafAdet
            // 
            this.sRafAdet.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.sRafAdet.HeaderText = "Raf Adet";
            this.sRafAdet.Name = "sRafAdet";
            this.sRafAdet.Width = 74;
            // 
            // KonsinyeAdet
            // 
            this.KonsinyeAdet.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.KonsinyeAdet.HeaderText = "Konsinye Adet";
            this.KonsinyeAdet.Name = "KonsinyeAdet";
            // 
            // sSubeAdet
            // 
            this.sSubeAdet.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.sSubeAdet.HeaderText = "Sube Adet";
            this.sSubeAdet.Name = "sSubeAdet";
            this.sSubeAdet.Width = 82;
            // 
            // sUrunHareketadet
            // 
            this.sUrunHareketadet.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.sUrunHareketadet.HeaderText = "Urun Hareket Adet";
            this.sUrunHareketadet.Name = "sUrunHareketadet";
            this.sUrunHareketadet.Width = 111;
            // 
            // sUts
            // 
            this.sUts.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.sUts.HeaderText = "Uts";
            this.sUts.Name = "sUts";
            this.sUts.Width = 29;
            // 
            // UTarih
            // 
            this.UTarih.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.UTarih.HeaderText = "Uretim T";
            this.UTarih.Name = "UTarih";
            this.UTarih.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.UTarih.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.UTarih.Visible = false;
            this.UTarih.Width = 48;
            // 
            // SkTarih
            // 
            this.SkTarih.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.SkTarih.HeaderText = "Son Kullanma T";
            this.SkTarih.Name = "SkTarih";
            this.SkTarih.Visible = false;
            this.SkTarih.Width = 89;
            // 
            // StokDurum
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1464, 634);
            this.Controls.Add(this.SpcStok);
            this.Name = "StokDurum";
            this.Text = "StokDurum";
            this.Load += new System.EventHandler(this.StokDurum_Load);
            this.SpcStok.Panel1.ResumeLayout(false);
            this.SpcStok.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.SpcStok)).EndInit();
            this.SpcStok.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ListeStok)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ListeSube)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ListeKonsinye)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ListeUrunHareket)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.TcStokDurum.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ListeStok1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer SpcStok;
        private System.Windows.Forms.DataGridView ListeStok;
        private System.Windows.Forms.Splitter splitter1;
        private System.Windows.Forms.Panel PnlSol;
        private System.Windows.Forms.DataGridView ListeSube;
        private System.Windows.Forms.Splitter splitter3;
        private System.Windows.Forms.Splitter splitter2;
        private System.Windows.Forms.DataGridView ListeKonsinye;
        private System.Windows.Forms.DataGridView ListeUrunHareket;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage TcStokDurum;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn sBarkod;
        private System.Windows.Forms.DataGridViewTextBoxColumn sUrunKodu;
        private System.Windows.Forms.DataGridViewTextBoxColumn sLot;
        private System.Windows.Forms.DataGridViewTextBoxColumn sStokAdet;
        private System.Windows.Forms.DataGridViewTextBoxColumn sRafAdet;
        private System.Windows.Forms.DataGridViewTextBoxColumn KonsinyeAdet;
        private System.Windows.Forms.DataGridViewTextBoxColumn sSubeAdet;
        private System.Windows.Forms.DataGridViewTextBoxColumn sUrunHareketadet;
        private System.Windows.Forms.DataGridViewCheckBoxColumn sUts;
        private System.Windows.Forms.DataGridViewTextBoxColumn UTarih;
        private System.Windows.Forms.DataGridViewTextBoxColumn SkTarih;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.DataGridView ListeStok1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Barkod;
        private System.Windows.Forms.DataGridViewTextBoxColumn UrunKodu;
        private System.Windows.Forms.DataGridViewTextBoxColumn LotSeri;
        private System.Windows.Forms.DataGridViewTextBoxColumn StokAdet;
        private System.Windows.Forms.DataGridViewTextBoxColumn RafAdet;
    }
}