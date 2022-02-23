
using ProjeAtHome;
using ProjeAtHome.BilgiGiris.Hastaneler;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace ProjeAtHome.Fonksiyonlar
{
    public class Formlar
    {

        public int HastanelerListesiAc(bool secim = false)
        {
            HastanelerListesi frm = new HastanelerListesi();
            if (secim)
            {
                frm.Secim = true;
                frm.ShowDialog();
            }

            else
            {
                frm.MdiParent = Form.ActiveForm;
                frm.Show();
            }
            return AnaSayfa1.Aktarma;
        }

        public void HastaneGirisAc(int id)
        {
            HastaneGiris frm = new HastaneGiris();
            frm.MdiParent = Form.ActiveForm;
            frm.Show();
            frm.Ac(id);
        }

        public void HastaneDetayAc(string adi, int id)
        {
            HastaneDetay frm = new HastaneDetay();
            frm.LblHastaneAdi.Text = adi;
            frm.LblHastaneId.Text = id.ToString();
            frm.ShowDialog();
        }


    }
}
