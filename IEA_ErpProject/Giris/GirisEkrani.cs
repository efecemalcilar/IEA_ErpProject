using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using IEA_ErpProject.Entity.Code;

namespace IEA_ErpProject.Giris
{
    public partial class GirisEkrani : Form
    {
        private ErpProContext code = new ErpProContext();

        public GirisEkrani()
        {
            InitializeComponent();
        }

        private void GirisEkrani_Load(object sender, EventArgs e)
        {

        }

        private void BtnGiris_Click(object sender, EventArgs e)
        {
            if (TxtKullaniciAdi.Text !="" && TxtSifre.Text != "")
            {
                var srg = code.TblUsers
                    .FirstOrDefault(s => s.UserName == TxtKullaniciAdi.Text && s.Password == TxtSifre.Text).Id;
               
                //var srg1 = (from s in code.TblUsers where (s.UserName == TxtKullaniciAdi.Text && s.Password == TxtSifre.Text) select s.Id).FirstOrDefault();

                if (srg != null) // srg1>0
                {
                    AnaSayfa ana = new AnaSayfa();
                    ana.Show();
                    Hide();
                }

                else
                {
                    MessageBox.Show("Kullanici adi veya sifre hatali,lutfen kontrol edin");
                }
            }
        }
    }
}
