namespace ProjeAtHome.BilgiGiris.Personeller
{
    partial class PersonellerListesi
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
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Adi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PUnvan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tel = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Sehir = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.label3 = new System.Windows.Forms.Label();
            this.BtnHastaneAra = new System.Windows.Forms.Button();
            this.TxtHastaneAra = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.Liste)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Liste
            // 
            this.Liste.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Liste.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Sira,
            this.Id,
            this.Adi,
            this.PUnvan,
            this.Tel,
            this.Sehir});
            this.Liste.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Liste.Location = new System.Drawing.Point(0, 0);
            this.Liste.Name = "Liste";
            this.Liste.Size = new System.Drawing.Size(1247, 552);
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
            // Adi
            // 
            this.Adi.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Adi.HeaderText = "Personel Adi";
            this.Adi.Name = "Adi";
            // 
            // PUnvan
            // 
            this.PUnvan.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.PUnvan.HeaderText = "Personel Unvan";
            this.PUnvan.Name = "PUnvan";
            this.PUnvan.Width = 99;
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
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splitContainer1.Location = new System.Drawing.Point(0, 47);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.label3);
            this.splitContainer1.Panel1.Controls.Add(this.BtnHastaneAra);
            this.splitContainer1.Panel1.Controls.Add(this.TxtHastaneAra);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.Liste);
            this.splitContainer1.Size = new System.Drawing.Size(1457, 552);
            this.splitContainer1.SplitterDistance = 206;
            this.splitContainer1.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.SteelBlue;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(3, 48);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(193, 24);
            this.label3.TabIndex = 2;
            this.label3.Text = "Personel Adi";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // BtnHastaneAra
            // 
            this.BtnHastaneAra.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.BtnHastaneAra.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtnHastaneAra.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.BtnHastaneAra.Location = new System.Drawing.Point(0, 500);
            this.BtnHastaneAra.Name = "BtnHastaneAra";
            this.BtnHastaneAra.Size = new System.Drawing.Size(206, 52);
            this.BtnHastaneAra.TabIndex = 1;
            this.BtnHastaneAra.Text = "Perasonel Ara";
            this.BtnHastaneAra.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.BtnHastaneAra.UseVisualStyleBackColor = true;
            this.BtnHastaneAra.Click += new System.EventHandler(this.BtnHastaneAra_Click);
            // 
            // TxtHastaneAra
            // 
            this.TxtHastaneAra.Location = new System.Drawing.Point(3, 75);
            this.TxtHastaneAra.Name = "TxtHastaneAra";
            this.TxtHastaneAra.Size = new System.Drawing.Size(193, 20);
            this.TxtHastaneAra.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.SteelBlue;
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(1457, 47);
            this.label1.TabIndex = 3;
            this.label1.Text = "Personeller Listesi";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // PersonellerListesi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1457, 599);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.label1);
            this.Name = "PersonellerListesi";
            this.Text = "PersonellerListesi";
            this.Load += new System.EventHandler(this.PersonellerListesi_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Liste)).EndInit();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView Liste;
        private System.Windows.Forms.DataGridViewTextBoxColumn Sira;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Adi;
        private System.Windows.Forms.DataGridViewTextBoxColumn PUnvan;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tel;
        private System.Windows.Forms.DataGridViewTextBoxColumn Sehir;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button BtnHastaneAra;
        private System.Windows.Forms.TextBox TxtHastaneAra;
        private System.Windows.Forms.Label label1;
    }
}