using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Configuration;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ProjeAtHome.Entity;

namespace ProjeAtHome.BilgiGiris.Hastaneler
{
    public partial class HastaneDetayGoster : Form
    {

        private readonly ErpPro102SEntities2 _db = new ErpPro102SEntities2();

        public string Hadi = "";

        public HastaneDetayGoster()
        {
            InitializeComponent();
        }

        private void HastaneDetayGoster_Load(object sender, EventArgs e)
        {
            Listele();
        }

        private void Listele()
        {
            Liste.Rows.Clear();

            int i = 0;

            var hstDetayList = (from s in _db.tblHastaneDetaylar
                where s.GirisAdi == "H"
                where s.tblHastaneler.Adi == Hadi
                select s).ToList();

            foreach (var item in hstDetayList)
            {
                Liste.Rows.Add();
                Liste.Rows[i].Cells[0].Value = i + 1;
                Liste.Rows[i].Cells[3].Value = item.YetkiliAdi;
                Liste.Rows[i].Cells[4].Value = item.tblDepartmanlar.Adi;
                Liste.Rows[i].Cells[5].Value = item.Tel;
                Liste.Rows[i].Cells[6].Value = item.Gsm;
                Liste.Rows[i].Cells[7].Value = item.Email;

                i++;
            }
        }
    }
}
