using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ProjeAtHome.Entity;
using ProjeAtHome.Fonksiyonlar;

namespace ProjeAtHome.BilgiGiris.Firmalar
{
    public partial class FirmalarListesi : Form
    {
        private readonly ErpPro102SEntities2 _db = new ErpPro102SEntities2();

        private List<tblFirmalar> frmList;
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

            frmList = (from s in _db.tblFirmalar select s).ToList();

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

            Liste.AllowUserToAddRows = false;
            Liste.AllowUserToDeleteRows = false;
            Liste.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            Liste.ReadOnly = true;
        }

        private void Liste_DoubleClick(object sender, EventArgs e)
        {
            if (Liste.CurrentRow != null)
                secimId = (int?)
                    Liste.CurrentRow.Cells[1].Value ?? -1;

            if (secimId > 0 && Secim && Application.OpenForms["FirmaGiris"] == null)
            {
                AnaSayfa1.Aktarma = secimId;
                Close();


            }


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
