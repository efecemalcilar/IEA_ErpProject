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
            this.PnlSol = new System.Windows.Forms.Panel();
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.ListeStok = new System.Windows.Forms.DataGridView();
            this.ListeUrunHareket = new System.Windows.Forms.DataGridView();
            this.ListeKonsinye = new System.Windows.Forms.DataGridView();
            this.splitter2 = new System.Windows.Forms.Splitter();
            this.splitter3 = new System.Windows.Forms.Splitter();
            this.ListeSube = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.SpcStok)).BeginInit();
            this.SpcStok.Panel1.SuspendLayout();
            this.SpcStok.Panel2.SuspendLayout();
            this.SpcStok.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ListeStok)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ListeUrunHareket)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ListeKonsinye)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ListeSube)).BeginInit();
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
            this.SpcStok.Panel1.Controls.Add(this.ListeStok);
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
            // PnlSol
            // 
            this.PnlSol.BackColor = System.Drawing.Color.LightSalmon;
            this.PnlSol.Dock = System.Windows.Forms.DockStyle.Left;
            this.PnlSol.Location = new System.Drawing.Point(0, 0);
            this.PnlSol.Name = "PnlSol";
            this.PnlSol.Size = new System.Drawing.Size(201, 446);
            this.PnlSol.TabIndex = 0;
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
            // ListeStok
            // 
            this.ListeStok.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ListeStok.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ListeStok.Location = new System.Drawing.Point(223, 0);
            this.ListeStok.Name = "ListeStok";
            this.ListeStok.Size = new System.Drawing.Size(1237, 446);
            this.ListeStok.TabIndex = 2;
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
            // ListeKonsinye
            // 
            this.ListeKonsinye.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ListeKonsinye.Dock = System.Windows.Forms.DockStyle.Right;
            this.ListeKonsinye.Location = new System.Drawing.Point(1155, 0);
            this.ListeKonsinye.Name = "ListeKonsinye";
            this.ListeKonsinye.Size = new System.Drawing.Size(305, 176);
            this.ListeKonsinye.TabIndex = 1;
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
            // StokDurum
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1464, 634);
            this.Controls.Add(this.SpcStok);
            this.Name = "StokDurum";
            this.Text = "StokDurum";
            this.SpcStok.Panel1.ResumeLayout(false);
            this.SpcStok.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.SpcStok)).EndInit();
            this.SpcStok.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ListeStok)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ListeUrunHareket)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ListeKonsinye)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ListeSube)).EndInit();
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
    }
}