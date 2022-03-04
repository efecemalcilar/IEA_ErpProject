using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using IEA_ErpProject.Entity;
using IEA_ErpProject.Fonksiyonlar;

namespace IEA_ErpProject.BilgiGiris.Firmalar
{



    public partial class FirmalarListesi : Form
    {
        private List<tblFirmalar> frmList;
        private readonly ErpPro102SEntities _db = new ErpPro102SEntities();
        private Formlar f = new Formlar();

        public int secimId = -1;
        public bool Secim = false;

        public FirmalarListesi()
        {
            InitializeComponent();
        }


        private void FirmalarListesi_Load(object sender, EventArgs e)
        {
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

        private void Liste_DoubleClick(object sender, EventArgs e)
        {
            if (Liste.CurrentRow != null)
                secimId = (int?)
                    Liste.CurrentRow.Cells[1].Value ?? -1;

            if (secimId > 0 && Secim && Application.OpenForms["FirmaGiris"] == null)
            {
                AnaSayfa.Aktarma = secimId;
                Close();


            } // tıkladığımda hangi satır seçiliyse currentRow kullanırız.
            // Eğer normal bir değer gelirse burdaki değeri al int e cevir , eger null gelirse -1 yaz.

            else if (Secim && Application.OpenForms["FirmaGiris"] != null)
            {
                FirmaGiris frm = Application.OpenForms["Firmagiris"] as FirmaGiris;
                frm.Ac(secimId);
                Close();

            }


            else if (!Secim)
            {
                f.FirmaGirisAc(secimId);
                Close();
            }
        }
    }
}

