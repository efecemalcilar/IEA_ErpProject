using IEA_ErpProject.Entity;
using IEA_ErpProject.Fonksiyonlar;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IEA_ErpProject.BilgiGiris.Firmalar
{

    public partial class FirmaGiris : Form
    {



        Formlar f = new Formlar();
        private readonly IEA_ErpProject.Entity.ErpPro102SEntities _db = new Entity.ErpPro102SEntities();
        private int secimId = -1;
         private tblFirmalar kayitBul;

        public FirmaGiris()
        {
            InitializeComponent();
        }

        private void FirmaGiris_Load(object sender, EventArgs e)
        {
            ComboDoldur();
            Listele();
        }



        private void Listele()
        {
            Liste.Rows.Clear(); // Bütün satırlar Temizlendi

            int i = 0;

            frmList = (from s in _db.tblFirmalar select s).ToList(); // selec * from tblFirmalar demek.

            foreach (var item in frmList)
            {
                Liste.Rows.Add();
                Liste.Rows[i].Cells[0].Value = i + 1;
                Liste.Rows[i].Cells[1].Value = item.Id;
                Liste.Rows[i].Cells[2].Value = item.Adi;
                Liste.Rows[i].Cells[3].Value = item.FirmaTip;
                Liste.Rows[i].Cells[4].Value = item.Tel;



                if (item.Sehirler != null)
                {
                    Liste.Rows[i].Cells[5].Value = item.Sehirler.name;
                }

                i++;

            }
            Liste.AllowUserToAddRows = false; // iş bittikten sonra kullanıcı yeni bir satır ekleyemesin.
            Liste.AllowUserToDeleteRows = false; // kullanıcı bir kaydı silemesin.
            Liste.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            Liste.ReadOnly = true; // Burası sadece okunur olsun değiştirilemesin anlamına gelir.
        }

        private void ComboDoldur()
        {
            TxtFirmaTip.DataSource = Enum.GetValues(typeof(FirmaTip));

            TxtFirmaTip.SelectedIndex = -1;

            

            TxtSehir.DataSource = _db.Sehirler.ToList();
            TxtSehir.ValueMember = "Id";
            TxtSehir.DisplayMember = "name";
            TxtSehir.SelectedIndex = -1;

        }
        private List<tblFirmalar> frmList;    // tblFirmalar tablosunu bağlar fakat önce entity e tabloyu update etmen gerek.
        private void Temizle() // Temizle methodu çağırıldığında her yere boş ekran yazdırıyor ScFirma splitcontainer ismi.
        {
            foreach (Control k in ScFirma.Panel1.Controls)
            {
                if (k is TextBox || k is ComboBox || k is MaskedTextBox || k is RichTextBox)
                {
                    k.Text = "";



                }

                TxtFirmaAdi.Text = "";
                TxtFirmaTip.SelectedIndex = -1;   // burası uygulama acildiginda ekranların temiz olmasını sağlıyor.
                TxtSehir.SelectedIndex = -1;
                secimId = -1;
                kayitBul = null;
                BtnDetayEkle.Visible = false;
                BtnDetayGoster.Visible = false;


            }
        }

        private void BtnKaydet_Click(object sender, EventArgs e)
        {
            YeniKayit();
        }

        private void YeniKayit()
        {

            if (TxtFirmaAdi.Text == "")
            {
                MessageBox.Show("Ilgılı alanları doldurunuz!");
                return;
            }

            try
            {
                tblFirmalar frm = new tblFirmalar();    // kaydetdeceğim classın nesnesini üretip onu ref alıyoruz.

                frm.Adi = TxtFirmaAdi.Text;
                frm.FirmaTip = TxtFirmaTip.Text;
                frm.Adres = TxtAdres.Text;
                frm.VergiDairesi = TxtVergiDairesi.Text;
                frm.VergiNo = TxtVergiNo.Text;
                frm.Email = TxtEmail.Text;
                if (TxtSehir.SelectedValue != null) frm.SehirId = Convert.ToInt32(TxtSehir.SelectedValue);
                frm.Web = TxtWeb.Text;
                frm.Tel = TxtTelefon.Text;


                _db.tblFirmalar.Add(frm);
                _db.SaveChanges();
                MessageBox.Show("Kayit basarili");
                Temizle();
                Listele();


            }
            catch (Exception e)
            {

                MessageBox.Show(e.Message + "HataKodu : HGK102");
            }



        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e); 
        }


        private void BtnGüncelle_Click_1(object sender, EventArgs e)
        {
            Guncelle();
        }

        private void Guncelle()
        {
            if (secimId < 0)
            {
                MessageBox.Show("Degistirilecek kayit bulunamadi , once bir kayit secin");
                return;
            }

            try
            {

                if (kayitBul != null)
                {
                    kayitBul.Adi = TxtFirmaAdi.Text;
                    kayitBul.Adres = TxtAdres.Text;
                    kayitBul.SehirId = (int?)TxtSehir.SelectedValue;
                    kayitBul.FirmaTip = TxtFirmaTip.SelectedValue.ToString();
                    kayitBul.VergiDairesi = TxtVergiDairesi.Text;
                    kayitBul.VergiNo = TxtVergiNo.Text;
                    kayitBul.Email = TxtEmail.Text;
                    kayitBul.Web = TxtWeb.Text;

                }


                _db.SaveChanges();   // Yapılan değişikleri uygula demek.
                MessageBox.Show("Güncelleme Yapıldı.");
                Temizle();
                Listele();

            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message + " Bir şeyler ters gitti");
            }

        }

    

        public void Ac(int id)
        {
            secimId = id;
            if (secimId < 0)
            {
                MessageBox.Show("Kayit id bulunamamistir");
                return;
            }

            BtnDetayEkle.Visible = true;
            

            kayitBul = frmList.FirstOrDefault(x => x.Id == secimId);

            try
            {
                if (kayitBul != null)
                {
                    TxtWeb.Text = kayitBul.Web;
                    TxtTelefon.Text = kayitBul.Tel;
                    TxtVergiNo.Text = kayitBul.VergiNo;
                    if (kayitBul.Sehirler != null) TxtSehir.Text = kayitBul.Sehirler.name;
                    TxtFirmaAdi.Text = kayitBul.Adi;
                    TxtAdres.Text = kayitBul.Adres;
                    TxtEmail.Text = kayitBul.Email;
                    TxtVergiDairesi.Text = kayitBul.VergiDairesi;
                    TxtFirmaBul.Text = kayitBul.Id.ToString().PadLeft(5, '0');
                    // if li kodun anlamı eğer null gelirse kod a gitme ve görmezden gel hata gitmesin.



                }
            }
            catch (Exception e)
            {

                MessageBox.Show(e.Message + "Hata kodu : HGListe101");
            }




        }

        private void BtnSil_Click_1(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Kayit kalici olarak silenecektir !! ", "Silme işlemi ", MessageBoxButtons.YesNo, MessageBoxIcon.Question);



            if (dr == DialogResult.Yes)
            {
                Sil();
            }
        }

        private void Sil()
        {
            if (secimId < 0)
            {
                MessageBox.Show("Silinecek kaydi seciniz");
                return;
            }

            if (secimId > 0)
            {
                _db.tblFirmalar.Remove(kayitBul);
                _db.SaveChanges();
                MessageBox.Show("Kaydiniz Silinmistir, gecmis olsun.");
                
            }
            
            Listele();
            Temizle();
        }

        private void BtnDetayEkle_Click(object sender, EventArgs e)
        {
            FirmaDetay frmDetay = new FirmaDetay();
            frmDetay.LblFirmaAdi.Text = kayitBul.Adi;
            frmDetay.lblFirmaId.Text = kayitBul.Id.ToString();
            frmDetay.ShowDialog();
            Close();

            //string adi = "";       // Hadi daki text i al demek.
            //int id = -1;
            //if (secimId > 0)
            //{
            //    adi = TxtFirmaAdi.Text;
            //    id = int.Parse(TxtFirmaBul.Text);
            //    f.HastaneDetayAc(adi, id);                                            // Bir  fromdan başka bir form a veri taşıdık.
            //}

            //else
            //{
            //    MessageBox.Show("Once bir kayit secin !!!");
            //    return;

            //}
        }

        private void Liste_DoubleClick_1(object sender, EventArgs e)
        {
            if (Liste.CurrentRow != null)
            {
                secimId = (int)Liste.CurrentRow.Cells[1].Value;
            }

            Ac(secimId);
        }

        private void BtnDetayGoster_Click(object sender, EventArgs e)
        {
            FirmaDetay goster = new FirmaDetay();
            goster.Hadi= TxtFirmaAdi.Text;
            goster.ShowDialog();
        }
    }
}
