using ProjeAtHome.BilgiGiris.Doktorlar;
using ProjeAtHome.BilgiGiris.Firmalar;
using ProjeAtHome.BilgiGiris.Hastaneler;
using ProjeAtHome.BilgiGiris.Personeller;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjeAtHome
{
    public partial class AnaSayfa1 : Form
    {
        internal static int Aktarma;

        public AnaSayfa1()
        {
            InitializeComponent();
        }

        private void AnaSayfa1_Load(object sender, EventArgs e)
        {

        }
    
    
        private void MenuOlustur(string info)
        {
            tvMenu.Nodes.Clear();

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

        private void btnBilgiGiris_Click(object sender, EventArgs e)
        {
            lblMenu.Text = btnBilgiGiris.Text;
            MenuOlustur("bilgi");                                       
        }
    
         private void tvMenu_Doubleclick(object sender,EventArgs e)
        {

            string isim = "";
            if (tvMenu.SelectedNode != null)                        
            {
                isim = tvMenu.SelectedNode.Text;
            }
            if (isim == "Hastaneler Listesi" && Application.OpenForms["HastanelerListesi"] == null)
            {
                HastanelerListesi frm1 = new HastanelerListesi();    
                frm1.MdiParent = Form.ActiveForm;                      
               
                frm1.Show();   
            }

            else if (isim == "Hastane Bilgi Giris" && Application.OpenForms["HastaneGiris"] == null)
            {
                HastaneGiris frm = new HastaneGiris();
                frm.MdiParent = Form.ActiveForm;
                frm.Show();
            }

            string isima = "";

            if (tvMenu.SelectedNode != null)
            {
                isima = tvMenu.SelectedNode.Text;
            }



            if (isima == "Doktorlar Listesi" && Application.OpenForms["DoktorlarListesi"] == null)
            {
                DoktorlarListesi frm1 = new DoktorlarListesi();
                frm1.MdiParent = Form.ActiveForm;
                frm1.Show();

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
                FirmalarListesi frm1 = new FirmalarListesi();
                frm1.MdiParent = Form.ActiveForm;
                frm1.Show();

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












        }

        
    }






}
