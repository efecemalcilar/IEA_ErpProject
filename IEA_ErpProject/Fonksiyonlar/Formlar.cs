using IEA_ErpProject.BilgiGiris.Doktorlar;
using IEA_ErpProject.BilgiGiris.Firmalar;
using IEA_ErpProject.BilgiGiris.Hastaneler;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using IEA_ErpProject.BilgiGiris.Personeller;
using IEA_ErpProject.BilgiGiris.Urunler;
using IEA_ErpProject.Entity;
using IEA_ErpProject.Entity.Code;
using IEA_ErpProject.UrunGirisIslemleri;
using IEA_ErpProject.Stok;
using IEA_ErpProject.KonsinyeIslemleri.Giris;

namespace IEA_ErpProject.Fonksiyonlar
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
            return AnaSayfa.Aktarma;
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
            return AnaSayfa.Aktarma;
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

        public void HastaneDetayAc(string adi,int id)
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
            return AnaSayfa.Aktarma;
        }


        public int PersonellerListesiAc(bool secim = false)
        {
            PersonellerListesi prs  = new PersonellerListesi();
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

            return AnaSayfa.Aktarma;
        }

        internal void PersonelGirisAc(int id)
        {
            HastaneGiris prs = new HastaneGiris();
            prs.MdiParent = Form.ActiveForm;
            prs.Show();
            prs.Ac(id);
        }

        public int UrunKayitListesiAc(bool secim =false)
        {
            
            UrunKayitListesi frm = new UrunKayitListesi();
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
            return AnaSayfa.Aktarma;
        }


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
            return AnaSayfa.Aktarma;
        }



        public int StokDurumAc(bool secim = false)
        {

            StokDurum frm = new StokDurum();
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
            return AnaSayfa.Aktarma;
        }

        public int KonsinyeGonderimAc(bool secim = false)
        {

            KonsinyeGonderim frm = new KonsinyeGonderim(new ErpProContext(),new ErpPro102SEntities());
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
            return AnaSayfa.Aktarma;
        }

    }
}
