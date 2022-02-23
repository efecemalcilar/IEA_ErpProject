
using ProjeAtHome.Fonksiyonlar;
using ProjeAtHome.Entity;
using ProjeAtHome.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjeAtHome.BilgiGiris.Hastaneler
{
    public partial class HastaneGiris : Form
    {

        private readonly ProjeAtHome.Entity.ErpPro102Entities _db = new ProjeAtHome.Entity.ErpPro102Entities();

        private int secimId = -1;
        public bool Secim = false;
        private tblHastaneler kayitBul;

        

        Formlar f = new Formlar();

        public static int Aktarma = -1;
        
        public HastaneGiris()
        {
            InitializeComponent();
        }

        private void HastaneGiris_Load(object sender, EventArgs e)
        {
            ComboDoldur();
            Listele();
        }


        private void ComboDoldur()
        {
            TxtTipAdi.DataSource = _db.tblHastaneTipleri.ToList();
            TxtTipAdi.ValueMember = "Id";
            TxtTipAdi.DisplayMember = "TipAdi";
            TxtTipAdi.SelectedIndex = -1;

            TxtSehir.DataSource = _db.Sehirler.ToList();
            TxtSehir.ValueMember = "Id";
            TxtSehir.DisplayMember = "name";
            TxtSehir.SelectedIndex = -1;

        }
        
        
        private void YeniKayit()
        {
            if (TxtHadi.Text == "")
            {
                MessageBox.Show("Ilgili alanlar doldurulmadan kayit yapilamaz");
                return;
            }

            try
            {
                tblHastaneler hst = new tblHastaneler();
                hst.Adi = TxtHadi.Text;
                hst.Adres = TxtAdres.Text;
                hst.CariAdi = TxtCariHadi.Text;
                if (TxtSehir != null) hst.SehirId = (int)TxtSehir.SelectedValue;               
                if (TxtTipAdi != null) hst.TipId = (int)TxtTipAdi.SelectedValue;         
                hst.Tel = TxtTelefon.Text;
                hst.VergiDairesi = TxtVergiDairesi.Text;
                hst.VergiNo = TxtVergiNo.Text;

                _db.tblHastaneler.Add(hst);
                _db.SaveChanges();
                MessageBox.Show("Kayit islemi gerceklestirildi");

                Listele();
                Temizle();
            }
            catch (Exception e)
            {

                MessageBox.Show(e.Message + " HataKodu : HGK100");
            }
        
        
        
        
        
        }

        private void BtnTemizle_Click(object sender, EventArgs e)
        {
            Temizle();
        }

        private void Temizle()
        {
            foreach (Control k  in ScHastane.Panel1.Controls)
            {
                if (k is TextBox || k is ComboBox || k is MaskedTextBox ||k is RichTextBox)
                {
                    k.Text = "";
                }
            }
            TxtTipAdi.SelectedIndex = -1;
            TxtSehir.SelectedIndex = -1;
        }
        
        private List<tblHastaneler> hstList;

        private void Listele()
        {
            Liste.Rows.Clear();

            int i = 0, sira = 1;

            hstList = (from s in _db.tblHastaneler select s).Tolist();

            foreach (var item in hstList)
            {
                Liste.Rows.Add();
                Liste.Rows[i].Cells[0].Value = sira;
                Liste.Rows[i].Cells[1].Value = item.Id;
                Liste.Rows[i].Cells[2].Value = item.Adi;
                Liste.Rows[i].Cells[3].Value = item.tblHastaneTipleri.TipAdi;
                Liste.Rows[i].Cells[4].Value = item.Tel;
                Liste.Rows[i].Cells[5].Value = item.Sehirler.name;               

                i++;
                sira++;
            }

            Liste.AllowUserToAddRows = false;
            Liste.AllowUserToDeleteRows = false;
            Liste.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            Liste.ReadOnly = true;

        
        
        }
    

        private void Liste_DoubleClick(object sender, EventArgs e)
        {
            if (Liste.CurrentRow != null)
            {
                secimId = (int)Liste.CurrentRow.Cells[1].Value;
            }
            Ac(secimId);
        }


        public void Ac(int secimId)
        {
            if (secimId<0)
            {
                MessageBox.Show("Kayit id bulunamamistir");
                return;
            }

            kayitBul = hstList.FirstOrDefault(x => x.Id == secimId);

            try
            {

                if (kayitBul != null)
                {
                    TxtVergiNo.Text = kayitBul.VergiNo;
                    TxtTipAdi.Text = kayitBul.tblHastaneTipleri.TipAdi;
                    TxtSehir.Text = kayitBul.Sehirler.name;
                    TxtAdres.Text = kayitBul.Adres;
                    TxtCariHadi.Text = kayitBul.CariAdi;
                    TxtHadi.Text = kayitBul.Adi;
                    TxtTelefon.Text = kayitBul.Tel;
                    TxtVergiDairesi.Text = kayitBul.VergiDairesi;
                    TxtHastaneBul.Text = kayitBul.Id.ToString().PadLeft(5, '0');
                }



            }
            catch (Exception e)
            {

                MessageBox.Show(e.Message + "Hata Kodu : HGListe101");
            }
        
        
        
        } 
        
        
        
        
        private void BtnGüncelle_Click(object sender,EventArgs e)
        {
            Guncelle();
        }
     
         private void Guncelle()
        {
            if (secimId<0)
            {
                MessageBox.Show("Degistirilecek kayit bulunamadi, once bir kayit secin");

            }

            try
            {
                if (kayitBul != null)
                {
                    kayitBul.Adi = TxtHadi.Text;
                    kayitBul.Adres = TxtAdres.Text;
                    kayitBul.CariAdi = TxtCariHadi.Text;
                    kayitBul.Tel = TxtTelefon.Text;
                    kayitBul.VergiDairesi = TxtVergiDairesi.Text;       
                    kayitBul.SehirId = (int?)TxtSehir.SelectedValue;    
                    kayitBul.TipId = (int?)TxtTipAdi.SelectedValue;
                    kayitBul.VergiNo = TxtVergiNo.Text;
                }

                _db.SaveChanges();
                MessageBox.Show("Güncelleme Yapildi");
                Temizle();
                Listele();

            }
            catch (Exception e)
            {

                MessageBox.Show(e.Message + " Bir seyler ters gitti");
            }
        
        
        }
    
    
         private void BtnSil_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Kayit kalici olarak silinecektir !! ","Silme işlemi ",MessageBoxButtons.YesNo,MessageBoxIcon.Question);

            if (dr == DialogResult.Yes)
            {
                Sil();
            }
        
        
        }

         private void Sil()
        {
            if (secimId<0)
            {
                MessageBox.Show("Silinecek kaydi seciniz");
                return;
            }

            if (secimId>0)
            {
                _db.tblHastaneler.Remove(kayitBul);
                _db.Savechanges();
                MessageBox.Show("Kaydiniz silinmistir, gecmis olsun");
                Temizle();
                Listele();
            }
        
        
        
        }

        protected override void OnLoad(EventArgs e)
        {
            var btn = new Button();
            btn.Size = new Size(25, TxtHastaneBul.ClientSize.Height + 0);            
            btn.Location = new Point(TxtHastaneBul.ClientSize.Width - btn.Width - 1);
            btn.Cursor = Cursors.Default;
            btn.BackgroundImage = Resources.Ara32x32;
            btn.BackgroundImageLayout = ImageLayout.Stretch;
            btn.Anchor = (AnchorStyles.Top | AnchorStyles.Right);
            TxtHastaneBul.Controls.Add(btn);
            base.OnLoad(e);

            // Kodsal olarak Click eventini oluşturmak
            btn.Click += Btn_Click;
        }


        private void Btn_Click(object sender, EventArgs e)
        {
            int id = f.HastanelerListesiAc(true);
            if (id>0)
            {
                Ac(id);
            }

            AnaSayfa1.Aktarma = -1;
        }



        private void BtnDetayEkle_Click(object sender, EventArgs e)
        {

        }


    }
}
