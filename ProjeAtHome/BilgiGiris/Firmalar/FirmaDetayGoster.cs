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

namespace ProjeAtHome.BilgiGiris.Firmalar
{


    public partial class FirmaDetayGoster : Form
    {

        private readonly ErpPro102SEntities2 _db = new ErpPro102SEntities2();
        private string Fadi = "";

        public FirmaDetayGoster()
        {
            InitializeComponent();
        }

        private void FirmaDetayGoster_Load(object sender, EventArgs e)
        {
            Listele();
        }

        private void Listele()
        {
            Liste.Rows.Clear();

            int i = 0;

            var frmDetayList =
                (from s in _db.tblFirmaDetaylar where s.tblFirmalar.Adi == Fadi select s).ToList();

            foreach (var item in frmDetayList)
            {
                Liste.Rows.Add();
                Liste.Rows[i].Cells[0].Value = i + 1;
                Liste.Rows[i].Cells[1].Value = item.YetkiliAdi;
                Liste.Rows[i].Cells[2].Value = item.tblDepartmanlar.Adi;
                Liste.Rows[i].Cells[3].Value = item.Tel;
                Liste.Rows[i].Cells[4].Value = item.Gsm;
                Liste.Rows[i].Cells[5].Value = item.Email;

                i++;
            }
        }
    }
}
