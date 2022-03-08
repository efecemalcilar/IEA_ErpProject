namespace IEA_ErpProject.Giris
{
    partial class GirisEkrani
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
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.TxtSifre = new System.Windows.Forms.TextBox();
            this.TxtKullaniciAdi = new System.Windows.Forms.TextBox();
            this.BtnGiris = new System.Windows.Forms.Button();
            this.btnCikis = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(30, 104);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "Sifre";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(30, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 37);
            this.label2.TabIndex = 5;
            this.label2.Text = "Kullanici Adi ";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // TxtSifre
            // 
            this.TxtSifre.Location = new System.Drawing.Point(127, 104);
            this.TxtSifre.Name = "TxtSifre";
            this.TxtSifre.PasswordChar = '*';
            this.TxtSifre.Size = new System.Drawing.Size(354, 20);
            this.TxtSifre.TabIndex = 1;
            // 
            // TxtKullaniciAdi
            // 
            this.TxtKullaniciAdi.BackColor = System.Drawing.SystemColors.Window;
            this.TxtKullaniciAdi.Location = new System.Drawing.Point(124, 54);
            this.TxtKullaniciAdi.Name = "TxtKullaniciAdi";
            this.TxtKullaniciAdi.Size = new System.Drawing.Size(357, 20);
            this.TxtKullaniciAdi.TabIndex = 0;
            // 
            // BtnGiris
            // 
            this.BtnGiris.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnGiris.BackgroundImage = global::IEA_ErpProject.Properties.Resources.images;
            this.BtnGiris.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnGiris.Location = new System.Drawing.Point(402, 170);
            this.BtnGiris.Name = "BtnGiris";
            this.BtnGiris.Size = new System.Drawing.Size(79, 69);
            this.BtnGiris.TabIndex = 2;
            this.BtnGiris.UseVisualStyleBackColor = true;
            this.BtnGiris.Click += new System.EventHandler(this.BtnGiris_Click);
            // 
            // btnCikis
            // 
            this.btnCikis.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCikis.BackgroundImage = global::IEA_ErpProject.Properties.Resources.exit_64;
            this.btnCikis.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnCikis.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCikis.Location = new System.Drawing.Point(12, 173);
            this.btnCikis.Name = "btnCikis";
            this.btnCikis.Size = new System.Drawing.Size(73, 66);
            this.btnCikis.TabIndex = 3;
            this.btnCikis.UseVisualStyleBackColor = true;
            this.btnCikis.Click += new System.EventHandler(this.btnCikis_Click);
            // 
            // GirisEkrani
            // 
            this.AcceptButton = this.BtnGiris;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.CancelButton = this.btnCikis;
            this.ClientSize = new System.Drawing.Size(507, 260);
            this.Controls.Add(this.btnCikis);
            this.Controls.Add(this.BtnGiris);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TxtSifre);
            this.Controls.Add(this.TxtKullaniciAdi);
            this.Name = "GirisEkrani";
            this.Text = "GirisEkrani";
            this.Load += new System.EventHandler(this.GirisEkrani_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TxtSifre;
        private System.Windows.Forms.TextBox TxtKullaniciAdi;
        private System.Windows.Forms.Button BtnGiris;
        private System.Windows.Forms.Button btnCikis;
    }
}