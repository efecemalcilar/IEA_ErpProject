using IEA_ErpProject.BilgiGiris.Doktorlar;
using IEA_ErpProject.BilgiGiris.Firmalar;
using IEA_ErpProject.BilgiGiris.Hastaneler;
using IEA_ErpProject.BilgiGiris.Personeller;
using IEA_ErpProject.BilgiGiris.Urunler;
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

namespace IEA_ErpProject
{
    public partial class AnaSayfa : Form
    {

        Formlar f = new Formlar();
        
        public static int Aktarma = -1;

        
        public AnaSayfa()
        {
            InitializeComponent();
        }

        private void AnaSayfa_Load(object sender, EventArgs e)
        {

        }

     
        private void btnBilgiGiris_Click(object sender, EventArgs e)
        {
            lblMenu.Text = btnBilgiGiris.Text;            // Bilgi giriş'e tıkladigimizda Yukarıda Bilgi giriş yazısı gelir.
            MenuOlustur("bilgi");                                 // MenuOlustur() yapıp ampule tıklayınca kendi otomatik method oluşturdu                         
        }

        private void MenuOlustur(string info)
        {                                                           // ctrl+K+S yapınca komple if bloğu içine alabiliyoruz.
            tvMenu.Nodes.Clear();                                   // Her seferinde 0 dan açsın diye kullanıyoruz.

            if (info=="bilgi")
            {
                tvMenu.Nodes.Add("Hastaneler");                        //root eleman 
                tvMenu.Nodes[0].Nodes.Add("Hastaneler Listesi");       // Child
                tvMenu.Nodes[0].Nodes.Add("Hastane Bilgi Giris");

                tvMenu.Nodes.Add("Doktorlar");                          
                tvMenu.Nodes[1].Nodes.Add("Doktorlar Listesi");
                tvMenu.Nodes[1].Nodes.Add("Doktor Bilgi Giris");

                tvMenu.Nodes.Add("Firmalar");
                tvMenu.Nodes[2].Nodes.Add("Firmalar Listesi");
                tvMenu.Nodes[2].Nodes.Add("Firma Bilgi Giris");

                tvMenu.Nodes.Add("Personeller");
                tvMenu.Nodes[3].Nodes.Add("Personeller Listesi");
                tvMenu.Nodes[3].Nodes.Add("Personel Bilgi Giris");


                tvMenu.Nodes.Add("Urunler");
                tvMenu.Nodes[4].Nodes.Add("Urun Kayit Listesi");
                tvMenu.Nodes[4].Nodes.Add("Urun Kayit");



            }
            else if (info=="urun")
            {
                tvMenu.Nodes.Add("Urunler");          
                tvMenu.Nodes[0].Nodes.Add("Urunler Listesi");
                tvMenu.Nodes[0].Nodes.Add("Urun Giris");

            }



        }

        private void btnUrunGiris_Click(object sender, EventArgs e)
        {
            lblMenu.Text = btnUrunGiris.Text;
            MenuOlustur("urun");
        }

        private void tvMenu_DoubleClick(object sender, EventArgs e)
        {
            string isim = "";
            if (tvMenu.SelectedNode!=null)                         // burdan gelen deger eger bir null değilse
            {
                isim = tvMenu.SelectedNode.Text;
            }
            if (isim=="Hastaneler Listesi" && Application.OpenForms["HastanelerListesi"]==null)// bu form daha önceden acıldıysa acma diyor.
            {
                //HastanelerListesi frm = new HastanelerListesi();       // referans alıp frm nin içine yüklemiş oldum.
                //frm.MdiParent = Form.ActiveForm;                      // bu formun parent i = Form sınıfına git ordaki aktif formu kullan
                //frm.MdiParent = Application.OpenForms["Ana sayfa"] as AnaSayfa;
                //frm.Show();    // yeni pencereyi göstermesi için. On ayarlar yapılır ve en son gösterilir.
                f.HastanelerListesiAc();
            }

            else if (isim == "Hastane Bilgi Giris" && Application.OpenForms["HastaneGiris"] == null)
            {
                HastaneGiris frm = new HastaneGiris();
                frm.MdiParent = Form.ActiveForm;
                frm.Show();
            }

            string isima = "";

            if (tvMenu.SelectedNode!=null)
            {
                isima = tvMenu.SelectedNode.Text;
            }

            

            if (isima=="Doktorlar Listesi" && Application.OpenForms["DoktorlarListesi"]==null)
            {
                //DoktorlarListesi frm1 = new DoktorlarListesi();
                //frm1.MdiParent = Form.ActiveForm;
                //frm1.Show();
                f.DoktorlarListesiAc();
            }

            else if (isima == "Doktor Bilgi Giris" && Application.OpenForms["DoktorGiris"] == null)
            {
                DoktorGiris frm1 = new DoktorGiris();
                frm1.MdiParent = Form.ActiveForm;
                frm1.Show();
            }

            string isimb = "";

            if (tvMenu.SelectedNode != null)
            {
                isimb = tvMenu.SelectedNode.Text;
            }



            if (isimb == "Firmalar Listesi" && Application.OpenForms["FirmalarListesi"] == null)
            {
                //FirmalarListesi frm1 = new FirmalarListesi();
                //frm1.MdiParent = Form.ActiveForm;
                //frm1.Show();
                f.FirmalarListesiAc();
            }

            else if (isimb == "Firma Bilgi Giris" && Application.OpenForms["FirmaGiris"] == null)
            {
                FirmaGiris frm1 = new FirmaGiris();
                frm1.MdiParent = Form.ActiveForm;
                frm1.Show();
            }

            string isimc = "";

            if (tvMenu.SelectedNode != null)
            {
                isimc = tvMenu.SelectedNode.Text;
            }



            if (isimc == "Personeller Listesi" && Application.OpenForms["PersonellerListesi"] == null)
            {
                PersonellerListesi frm2 = new PersonellerListesi();
                frm2.MdiParent = Form.ActiveForm;
                frm2.Show();

            }

            else if (isimc == "Personel Bilgi Giris" && Application.OpenForms["PersonelGiris"] == null)
            {
                PersonelGiris frm2 = new PersonelGiris();
                frm2.MdiParent = Form.ActiveForm;
                frm2.Show();
            }


            if (isimb == "Urun Kayit Listesi" && Application.OpenForms["UrunKayitListesi"] == null)
            {
                
                f.UrunKayitListesiAc();
            }

            else if (isimb == "Urun Kayit" && Application.OpenForms["UrunKayit"] == null)
            {
                UrunKayit frm1 = new UrunKayit();
                frm1.MdiParent = Form.ActiveForm;
                frm1.Show();
            }

           



        }


    }
}
