
using ProjeAtHome;
using ProjeAtHome.BilgiGiris.Doktorlar;
using ProjeAtHome.BilgiGiris.Firmalar;
using ProjeAtHome.BilgiGiris.Hastaneler;
using ProjeAtHome.BilgiGiris.Personeller;
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
        
        public int DoktorlarListesiAc(bool secim = false)
        {


            DoktorlarListesi frm = new DoktorlarListesi();
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

        public void FirmaGirisAc(int id)
        {
            FirmaGiris frm = new FirmaGiris();
            frm.MdiParent = Form.ActiveForm;
            frm.Show();
            frm.Ac(id);
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

        internal void DoktorlarGirisAc(int id)
        {
            DoktorGiris frm = new DoktorGiris();
            frm.MdiParent = Form.ActiveForm;
            frm.Show();
            frm.Ac(id);
        }

        internal int FirmalarListesiAc(bool secim = false)
        {
            FirmalarListesi frm = new FirmalarListesi();
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


        public int PersonellerListesiAc(bool secim = false)
        {
            PersonellerListesi prs = new PersonellerListesi();
            if (secim)
            {
                prs.Secim = true;
                prs.ShowDialog();
            }

            else
            {
                prs.MdiParent = Form.ActiveForm;
                prs.Show();
            }

            return AnaSayfa1.Aktarma;
        }

        internal int UrunKayitListesiAc(bool v)
        {
            throw new NotImplementedException();
        }

        internal void PersonelGirisAc(int id)
        {
            HastaneGiris prs = new HastaneGiris();
            prs.MdiParent = Form.ActiveForm;
            prs.Show();
            prs.Ac(id);
        }

        //public int UrunKayitListesiAc(bool secim = false)
        //{

        //    UrunKayitListesi frm = new UrunKayitListesi();
        //    if (secim)
        //    {
        //        frm.Secim = true;
        //        frm.ShowDialog();
        //    }

        //    else
        //    {
        //        frm.MdiParent = Form.ActiveForm;
        //        frm.Show();
        //    }
        //    return AnaSayfa1.Aktarma;
        //}


        public int UrunGirisListesiAc(bool secim = false)
        {

            UrunlerGirisListesi frm = new UrunlerGirisListesi();
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



        //public int StokDurumAc(bool secim = false)
        //{

        //    StokDurum frm = new StokDurum();
        //    if (secim)
        //    {
        //        frm.Secim = true;
        //        frm.ShowDialog();
        //    }

        //    else
        //    {
        //        frm.MdiParent = Form.ActiveForm;
        //        frm.Show();
        //    }
        //    return AnaSayfa1.Aktarma;
        //}


    }
}
