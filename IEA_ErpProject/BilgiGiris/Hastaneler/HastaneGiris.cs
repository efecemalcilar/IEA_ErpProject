using IEA_ErpProject.Entity;
using IEA_ErpProject.Fonksiyonlar;
using IEA_ErpProject.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IEA_ErpProject.BilgiGiris.Hastaneler
{
    public partial class HastaneGiris : Form
    {

        // global area
        private readonly IEA_ErpProject.Entity.ErpPro102SEntities _db = new Entity.ErpPro102SEntities(); // bu _db yazdıktan sonra tablolarıma ulaşabilmemi sağlayacak.
        private int secimId = -1; // 
        private tblHastaneler kayitBul;

        Formlar f = new Formlar();

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
            TxtTipAdi.DataSource = _db.tblHastaneTipleri.ToList();              // Verilerin nereden geleceğini bu alana declare edecez.Bu yazdığımız Lambda expression başlangıcı. Bu işlem SQL ye şu komutu girecek (select * from tblHastaneTipleri)

            TxtTipAdi.ValueMember = "Id";                              // Değerin nereden geleceğini yazıyoruz.
            TxtTipAdi.DisplayMember = "TipAdi";                // Arka planda Idlerle calısıcaksın ama ben sana text olarak ne göstereyim
            TxtTipAdi.SelectedIndex = -1;                       // Sayfayı actığımızda devlet geliyo ve bunu istemiyoruz, o yüzden selectedİndex kullanıp - 1 yaptık çünkü -1 indexinde hiç bir şey yok ve o yüzden boş gelecek.
                                                                // Burada Valuemember,displaymember,selectedindex hepsi Datasource elemanıdır.

            TxtSehir.DataSource = _db.Sehirler.ToList();
            TxtSehir.ValueMember = "Id";
            TxtSehir.DisplayMember = "name";
            TxtSehir.SelectedIndex = -1;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void BtnKaydet_Click(object sender, EventArgs e)
        {
            YeniKayit();
        }

        private void YeniKayit()
        {
            if (TxtHadi.Text == "")
            {
                MessageBox.Show("Ilgili alanlar doldurulmadan kayit yapilamaz.");
                return;
            }

            try
            {
                tblHastaneler hst = new tblHastaneler();
                hst.Adi = TxtHadi.Text;
                hst.Adres = TxtAdres.Text;
                hst.CariAdi = TxtCariHadi.Text;
                if (TxtSehir != null) hst.SehirId = (int)TxtSehir.SelectedValue;               // objelerin convert işlemlerine verilen isim CAST dir.
                if (TxtTipAdi != null) hst.TipId = (int)TxtTipAdi.SelectedValue;         // hst adındaki nesneyi tanımladım, bu verileri database e göndermem gerek
                hst.Tel = TxtTelefon.Text;
                hst.VergiDairesi = TxtVergiDairesi.Text;
                hst.VergiNo = TxtVergiNo.Text;

                _db.tblHastaneler.Add(hst);
                _db.SaveChanges();
                MessageBox.Show("Kayit islemi gerceklestirildi");

                Listele();
                Temizle();
            }
            catch (Exception e)  // exception ana sınıf, Argument exception yazarsak Try da verilen değerlerin içinde hata arar.
            {

                MessageBox.Show(e.Message + "HataKodu : HGK100");
            }

        }

        private void Temizle()
        {
            //TxtVergiNo.Text = "";
            //TxtVergiNo.Clear();
            foreach (Control k in ScHastane.Panel1.Controls)
            {
                if (k is TextBox || k is ComboBox || k is MaskedTextBox || k is RichTextBox)
                {
                    k.Text = "";

                }
            }
            TxtTipAdi.SelectedIndex = -1;
            TxtSehir.SelectedIndex = -1;
            secimId = -1;
            kayitBul = null;
            BtnDetayEkle.Visible = false;
            BtnDetayGoster.Visible = false;
        }

        private void BtnTemizle_Click(object sender, EventArgs e)
        {
            Temizle();
        }

        private List<tblHastaneler> hstList;    // Listenin içindeki veriler tblHastaneler tablosuyla uyuşmalı.
        private void Listele()
        {
            Liste.Rows.Clear();   // Bütün satırları temizliyor.

            int i = 0, sira = 1;

            hstList = (from s in _db.tblHastaneler select s).ToList();           // linq sorguları fromla başlıyor.(linq sql de ki temel select* from işlemini yapıyor.) _db database e bağlanacağım tablonun ismi. Bu işlem db ye gidip bir liste alacak.

            foreach (var item in hstList)
            {
                Liste.Rows.Add();
                Liste.Rows[i].Cells[0].Value = sira;   // row 0 ın 0. cell inde Value si itemden gelen
                Liste.Rows[i].Cells[1].Value = item.Id;
                Liste.Rows[i].Cells[2].Value = item.Adi;
                Liste.Rows[i].Cells[3].Value = item.tblHastaneTipleri.TipAdi;
                Liste.Rows[i].Cells[4].Value = item.Tel;
                Liste.Rows[i].Cells[5].Value = item.Sehirler.name;              // Kodu yazarken dataGrid de ki columb lara verdiğimiz isime bakıp yapacağız.  

                i++;
                sira++;



            }

            Liste.AllowUserToAddRows = false; // iş bittikten sonra kullanıcı yeni bir satır ekleyemesin.
            Liste.AllowUserToDeleteRows = false; // kullanıcı bir kaydı silemesin.
            Liste.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            Liste.ReadOnly = true; // Burası sadece okunur olsun değiştirilemesin anlamına gelir.






        }

        private void Liste_DoubleClick(object sender, EventArgs e)
        {
                                                                            // (int) casting işlemidir.
            if (Liste.CurrentRow != null)
            {
                secimId = (int)Liste.CurrentRow.Cells[1].Value;
            }

            Ac(secimId);

        }

        public void Ac(int secimId)
        {
            if (secimId < 0)
            {
                MessageBox.Show("Kayit id bulunamamistir.");
                return;
                
            }
            BtnDetayEkle.Visible = true;
            BtnDetayGoster.Visible = true;
            // tblHastaneler kayitBul = _db.tblHastaneler.Find(secimId);  // Burdan bana bir kayıt getirmesini istiyorum. Bu bana datebase de ki ilgili id yi bulup o satırı kayıtBul a atar.
            
            kayitBul= hstList.FirstOrDefault(x => x.Id == secimId); // Bu db ye bağlanmaz x hstlist den bir nesne olarak türetilir . amacımız hstlist deki columb bilgilerine ulaşabilmek.  (x => x.Id == secimId)  x i oluşturdum x den id yi türettim... Lambda expression

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
                    TxtHastaneBul.Text = kayitBul.Id.ToString().PadLeft(5,'0');  // Total alanım 5 ,padding char da 0 char olduğu için tek tırnak.   1 Geliyorsa başına 4 0 koyacak total hep 5 e tamamlanacak.

                }
            }
            catch (Exception e)
            {

                MessageBox.Show(e.Message+"Hata Kodu : HGListe101");
            }





        }

        private void BtnGüncelle_Click(object sender, EventArgs e)
        {
            Guncelle();
        }

        private void Guncelle()
        {
            if (secimId<0)
            {
                MessageBox.Show("Degistirilecek kayit bulunamadi , once bir kayit secin");
                return;
            }

            try
            {

                if (kayitBul != null)
                {
                    kayitBul.Adi = TxtHadi.Text;
                    kayitBul.Adres = TxtAdres.Text;
                    kayitBul.CariAdi = TxtCariHadi.Text;
                    kayitBul.Tel = TxtTelefon.Text;
                    kayitBul.VergiDairesi = TxtVergiDairesi.Text;       // Bu bir db güncelleme işlemidir.
                    kayitBul.SehirId = (int?)TxtSehir.SelectedValue;    // int e soru işareti koymama demek null verilere izin verdin demek.
                    kayitBul.TipId = (int?)TxtTipAdi.SelectedValue;
                    kayitBul.VergiNo = TxtVergiNo.Text;
                }


                _db.SaveChanges();   // Yapılan değişikleri uygula demek.
                MessageBox.Show("Güncelleme Yapıldı.");
                Temizle();
                Listele();

            }
            catch (Exception e)
            {

                MessageBox.Show(e.Message + "Bir şeyler ters gitti");
            }
            

        }

        private void BtnSil_Click(object sender, EventArgs e)
        {
            DialogResult dr=MessageBox.Show("Kayit kalici olarak silenecektir !! ","Silme işlemi ",MessageBoxButtons.YesNo,MessageBoxIcon.Question);
            // Nurdan dönecek sonucun adına dialog result diyoruz.
            

            if (dr ==DialogResult.Yes)
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
                _db.SaveChanges();
                MessageBox.Show("Kaydiniz Silinmistir, gecmis olsun.");
                Temizle();
                Listele();
            }
            
                       
        }



        protected override void OnLoad(EventArgs e)  // OnLoad yeniden inşaa etmek demektir.
        {

            var btn = new Button();             // Burada button u sanal olarak oluşturacaz.
            btn.Size = new Size(25,TxtHastaneBul.ClientSize.Height+0);            // Size(Genişlik,Yükseklik) normal bir height kadar al
            btn.Location = new Point(TxtHastaneBul.ClientSize.Width - btn.Width-1);
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
            AnaSayfa.Aktarma = -1;
        
        }

        private void BtnDetayEkle_Click(object sender, EventArgs e)
        {

            string adi = "";       // Hadi daki text i al demek.
            int id = -1;
            if (secimId>0)
            {
                adi = TxtHadi.Text;
                id = int.Parse(TxtHastaneBul.Text);
                f.HastaneDetayAc(adi,id);                                            // Bir  fromdan başka bir form a veri taşıdık.
            }

            else
            {
                MessageBox.Show("Once bir kayit secin !!!");
                return;

            }
        
        
        }

        private void BtnDetayGoster_Click(object sender, EventArgs e)
        {
            HastaneDetayGoster goster = new HastaneDetayGoster();
            goster.Hadi = TxtHadi.Text;
            goster.ShowDialog();
        }

        private void BtnKapat_Click(object sender, EventArgs e)
        {
            Close();
        }

       
    }
}
