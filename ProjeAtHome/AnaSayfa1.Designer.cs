namespace ProjeAtHome
{
    partial class AnaSayfa1
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
            this.splitter2 = new System.Windows.Forms.Splitter();
            this.pnlSol = new System.Windows.Forms.Panel();
            this.scMenu = new System.Windows.Forms.SplitContainer();
            this.tvMenu = new System.Windows.Forms.TreeView();
            this.btnUrunGiris = new System.Windows.Forms.Button();
            this.btnBilgiGiris = new System.Windows.Forms.Button();
            this.pnlsolUst = new System.Windows.Forms.Panel();
            this.btnSolUstCollapse = new System.Windows.Forms.Button();
            this.lblMenu = new System.Windows.Forms.Label();
            this.btnSolUstAra = new System.Windows.Forms.Button();
            this.txtSolUstAra = new System.Windows.Forms.TextBox();
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.tabPGenel = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.pnlSol.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.scMenu)).BeginInit();
            this.scMenu.Panel1.SuspendLayout();
            this.scMenu.Panel2.SuspendLayout();
            this.scMenu.SuspendLayout();
            this.pnlsolUst.SuspendLayout();
            this.tabPGenel.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitter2
            // 
            this.splitter2.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.splitter2.Location = new System.Drawing.Point(474, 105);
            this.splitter2.Name = "splitter2";
            this.splitter2.Size = new System.Drawing.Size(10, 470);
            this.splitter2.TabIndex = 7;
            this.splitter2.TabStop = false;
            // 
            // pnlSol
            // 
            this.pnlSol.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.pnlSol.Controls.Add(this.scMenu);
            this.pnlSol.Controls.Add(this.pnlsolUst);
            this.pnlSol.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlSol.Location = new System.Drawing.Point(0, 105);
            this.pnlSol.Name = "pnlSol";
            this.pnlSol.Size = new System.Drawing.Size(474, 470);
            this.pnlSol.TabIndex = 6;
            // 
            // scMenu
            // 
            this.scMenu.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.scMenu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.scMenu.Location = new System.Drawing.Point(0, 62);
            this.scMenu.Name = "scMenu";
            this.scMenu.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // scMenu.Panel1
            // 
            this.scMenu.Panel1.BackColor = System.Drawing.SystemColors.MenuBar;
            this.scMenu.Panel1.Controls.Add(this.tvMenu);
            // 
            // scMenu.Panel2
            // 
            this.scMenu.Panel2.BackColor = System.Drawing.Color.Gainsboro;
            this.scMenu.Panel2.Controls.Add(this.btnUrunGiris);
            this.scMenu.Panel2.Controls.Add(this.btnBilgiGiris);
            this.scMenu.Size = new System.Drawing.Size(474, 408);
            this.scMenu.SplitterDistance = 227;
            this.scMenu.TabIndex = 4;
            // 
            // tvMenu
            // 
            this.tvMenu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tvMenu.Location = new System.Drawing.Point(0, 0);
            this.tvMenu.Name = "tvMenu";
            this.tvMenu.Size = new System.Drawing.Size(470, 223);
            this.tvMenu.TabIndex = 0;
            this.tvMenu.DoubleClick += new System.EventHandler(this.tvMenu_DoubleClick_1);
            // 
            // btnUrunGiris
            // 
            this.btnUrunGiris.Location = new System.Drawing.Point(99, 3);
            this.btnUrunGiris.Name = "btnUrunGiris";
            this.btnUrunGiris.Size = new System.Drawing.Size(79, 52);
            this.btnUrunGiris.TabIndex = 1;
            this.btnUrunGiris.Text = "Urun Islemleri";
            this.btnUrunGiris.UseVisualStyleBackColor = true;
            this.btnUrunGiris.Click += new System.EventHandler(this.btnUrunGiris_Click_1);
            // 
            // btnBilgiGiris
            // 
            this.btnBilgiGiris.Location = new System.Drawing.Point(4, 3);
            this.btnBilgiGiris.Name = "btnBilgiGiris";
            this.btnBilgiGiris.Size = new System.Drawing.Size(79, 52);
            this.btnBilgiGiris.TabIndex = 0;
            this.btnBilgiGiris.Text = "Bilgi Giris Islemleri";
            this.btnBilgiGiris.UseVisualStyleBackColor = true;
            this.btnBilgiGiris.Click += new System.EventHandler(this.btnBilgiGiris_Click);
            // 
            // pnlsolUst
            // 
            this.pnlsolUst.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.pnlsolUst.Controls.Add(this.btnSolUstCollapse);
            this.pnlsolUst.Controls.Add(this.lblMenu);
            this.pnlsolUst.Controls.Add(this.btnSolUstAra);
            this.pnlsolUst.Controls.Add(this.txtSolUstAra);
            this.pnlsolUst.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlsolUst.Location = new System.Drawing.Point(0, 0);
            this.pnlsolUst.Name = "pnlsolUst";
            this.pnlsolUst.Size = new System.Drawing.Size(474, 62);
            this.pnlsolUst.TabIndex = 4;
            // 
            // btnSolUstCollapse
            // 
            this.btnSolUstCollapse.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSolUstCollapse.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSolUstCollapse.Location = new System.Drawing.Point(441, 26);
            this.btnSolUstCollapse.Name = "btnSolUstCollapse";
            this.btnSolUstCollapse.Size = new System.Drawing.Size(30, 32);
            this.btnSolUstCollapse.TabIndex = 3;
            this.btnSolUstCollapse.UseVisualStyleBackColor = true;
            // 
            // lblMenu
            // 
            this.lblMenu.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblMenu.BackColor = System.Drawing.SystemColors.ControlLight;
            this.lblMenu.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblMenu.Location = new System.Drawing.Point(3, 26);
            this.lblMenu.Name = "lblMenu";
            this.lblMenu.Size = new System.Drawing.Size(438, 33);
            this.lblMenu.TabIndex = 2;
            this.lblMenu.Text = "****";
            this.lblMenu.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnSolUstAra
            // 
            this.btnSolUstAra.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSolUstAra.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSolUstAra.Location = new System.Drawing.Point(441, 0);
            this.btnSolUstAra.Name = "btnSolUstAra";
            this.btnSolUstAra.Size = new System.Drawing.Size(30, 23);
            this.btnSolUstAra.TabIndex = 1;
            this.btnSolUstAra.UseVisualStyleBackColor = true;
            // 
            // txtSolUstAra
            // 
            this.txtSolUstAra.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSolUstAra.Location = new System.Drawing.Point(0, 2);
            this.txtSolUstAra.Name = "txtSolUstAra";
            this.txtSolUstAra.Size = new System.Drawing.Size(441, 20);
            this.txtSolUstAra.TabIndex = 0;
            // 
            // splitter1
            // 
            this.splitter1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.splitter1.Dock = System.Windows.Forms.DockStyle.Top;
            this.splitter1.Location = new System.Drawing.Point(0, 100);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(1156, 5);
            this.splitter1.TabIndex = 5;
            this.splitter1.TabStop = false;
            // 
            // tabPGenel
            // 
            this.tabPGenel.Controls.Add(this.tabPage1);
            this.tabPGenel.Controls.Add(this.tabPage2);
            this.tabPGenel.Dock = System.Windows.Forms.DockStyle.Top;
            this.tabPGenel.Location = new System.Drawing.Point(0, 0);
            this.tabPGenel.Name = "tabPGenel";
            this.tabPGenel.SelectedIndex = 0;
            this.tabPGenel.Size = new System.Drawing.Size(1156, 100);
            this.tabPGenel.TabIndex = 4;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.Khaki;
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1148, 74);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Genel";
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1148, 74);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Yonetim";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // AnaSayfa1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1156, 575);
            this.Controls.Add(this.splitter2);
            this.Controls.Add(this.pnlSol);
            this.Controls.Add(this.splitter1);
            this.Controls.Add(this.tabPGenel);
            this.Name = "AnaSayfa1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.AnaSayfa1_Load);
            this.pnlSol.ResumeLayout(false);
            this.scMenu.Panel1.ResumeLayout(false);
            this.scMenu.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.scMenu)).EndInit();
            this.scMenu.ResumeLayout(false);
            this.pnlsolUst.ResumeLayout(false);
            this.pnlsolUst.PerformLayout();
            this.tabPGenel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Splitter splitter2;
        private System.Windows.Forms.Panel pnlSol;
        private System.Windows.Forms.SplitContainer scMenu;
        private System.Windows.Forms.TreeView tvMenu;
        private System.Windows.Forms.Button btnUrunGiris;
        private System.Windows.Forms.Button btnBilgiGiris;
        private System.Windows.Forms.Panel pnlsolUst;
        private System.Windows.Forms.Button btnSolUstCollapse;
        private System.Windows.Forms.Label lblMenu;
        private System.Windows.Forms.Button btnSolUstAra;
        private System.Windows.Forms.TextBox txtSolUstAra;
        private System.Windows.Forms.Splitter splitter1;
        private System.Windows.Forms.TabControl tabPGenel;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
    }
}

