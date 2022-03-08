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

namespace IEA_ErpProject.Stok
{
    public partial class StokDurum : Form
    {

        private readonly ErpPro102SEntities _db = new ErpPro102SEntities();
        public bool Secim = false;
        public StokDurum()
        {
            InitializeComponent();
        }

        private void StokDurum_Load(object sender, EventArgs e)
        {
            listele1();
            Listele2();
        }

        private void listele1()
        {
            ListeStok.Rows.Clear();
            int i = 0;

            var srg = from s in _db.tblStokDurum select s;

            foreach (var s in srg.ToList())
            {
                ListeStok.Rows.Add();
                ListeStok.Rows[i].Cells[0].Value = s.Id;
                ListeStok.Rows[i].Cells[1].Value = s.Barkod;
                ListeStok.Rows[i].Cells[2].Value = s.UrunKodu;
                ListeStok.Rows[i].Cells[3].Value = s.LotSeriNo;
                ListeStok.Rows[i].Cells[4].Value = s.StokAdet;
                ListeStok.Rows[i].Cells[5].Value = s.RafAdet;
                ListeStok.Rows[i].Cells[6].Value = s.KonsinyeAdet;
                ListeStok.Rows[i].Cells[7].Value = s.SubeAdet;
                ListeStok.Rows[i].Cells[8].Value = s.UrunHareketAdet;
                ListeStok.Rows[i].Cells[9].Value = s.Uts;
                ListeStok.Rows[i].Cells[10].Value = s.UTarih;
                ListeStok.Rows[i].Cells[11].Value = s.SKTarih;
                i++;


            }
           
            ListeStok.AllowUserToAddRows = false;
            ListeStok.AllowUserToDeleteRows = false;
            ListeStok.ReadOnly = true;
            ListeStok.SelectionMode = DataGridViewSelectionMode.FullRowSelect;


        }

        private void Listele2()
        {
            ListeStok1.Rows.Clear();
            int i = 0;

            var srg1 = from s in _db.tblStokDurum select s;

            var srg = (from s in _db.tblUrunGirisAlt   //LINQ SORGU database tabloları al s nesnesine taşı ve bu slerden bir group oluştur içinde barkod,urunkodu,lotserino olsun ve 4 ünden bir G tipinde nesne oluşturdum G nin anahtarı barkod urun kodu lot seri no olsun ama G nin bir de içerinde sum olsun(Group by) bunları toplayabilmek için bunları grup içinde tutmam gerekiyor. 3ünde ortak nokta varsa adet aralıklarını topluyor.
                 
                group s by new {s.Barkod, s.UrunKodu, s.LotSeriNo,}
                into g
                select new
                {
                    barkod = g.Key.Barkod,
                    urunKodu = g.Key.UrunKodu,
                    lot = g.Key.LotSeriNo,
                    adet = g.Sum(x => x.GirisAdet)

                }).ToList();

            //SELECT        Barkod, UrunKodu, LotSeriNo, SUM(GirisAdet) AS GirisAdet // SQL SORGU
            //FROM dbo.tblUrunGirisAlt
             //   GROUP BY Barkod, UrunKodu, LotSeriNo



            foreach (var s in srg.ToList())
            {
                ListeStok1.Rows.Add();
                
                ListeStok1.Rows[i].Cells[0].Value = s.barkod;
                ListeStok1.Rows[i].Cells[1].Value = s.urunKodu;
                ListeStok1.Rows[i].Cells[2].Value = s.lot;
                ListeStok1.Rows[i].Cells[3].Value = s.adet;
                ListeStok1.Rows[i].Cells[4].Value = s.adet;
                
                i++;


            }

            ListeStok1.AllowUserToAddRows = false;
            ListeStok1.AllowUserToDeleteRows = false;
            ListeStok1.ReadOnly = true;
            ListeStok1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }
    }
}
