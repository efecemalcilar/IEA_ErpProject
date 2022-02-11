using IEA_ErpProject.BilgiGiris.Hastaneler;
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
                HastanelerListesi frm = new HastanelerListesi();       // referans alıp frm nin içine yüklemiş oldum.
                frm.MdiParent = Form.ActiveForm;                      // bu formun parent i = Form sınıfına git ordaki aktif formu kullan
                //frm.MdiParent = Application.OpenForms["Ana sayfa"] as AnaSayfa;
                frm.Show();    // yeni pencereyi göstermesi için. On ayarlar yapılır ve en son gösterilir.
            }

            else if (isim == "Hastane Bilgi Giris" && Application.OpenForms["HastaneGiris"] == null)
            {
                HastaneGiris frm = new HastaneGiris();
                frm.MdiParent = Form.ActiveForm;
                frm.Show();
            }
        }
    }
}
