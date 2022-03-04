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
    public partial class FirmaDetay : Form
    {
        public string Hadi = "";
        private List<tblFirmaDetaylar> lst = new List<tblFirmaDetaylar>();
        private readonly ErpPro102SEntities2 _db = new ErpPro102SEntities2();


        public FirmaDetay()
        {
            InitializeComponent();
        }

        private void FirmaDetay_Load(object sender, EventArgs e)
        {
            Combodoldur();
            Listele();
        }

        private void Listele()
        {

        }

        private void Combodoldur()
        {
            TxtDepartman.DataSource = _db.tblDepartmanlar.Where(x => x.DepartmanKodu == "F").ToList();          
            TxtDepartman.ValueMember = "Id";
            TxtDepartman.DisplayMember = "Adi";  
            TxtDepartman.SelectedIndex = -1;        }

        private void BtnKayit_Click(object sender, EventArgs e)
        {
            YeniKayit();
        }

        private void YeniKayit()
        {
            if (Liste.Rows[0].Cells[0].Value == null)
            {
                MessageBox.Show("Once ekle butonuyla kayit ekleyin !");
                ActiveControl = TxtYetkili;
                return;
                
            }

            List<tblFirmaDetaylar> lst = new List<tblFirmaDetaylar>();


            for (int i = 0; i < Liste.Rows.Count; i++)
            {
                lst.Add(
                    new tblFirmaDetaylar()
                    {


                        GirisId = Convert.ToInt32(Liste.Rows[i].Cells[1].Value),  
                        YetkiliAdi = Liste.Rows[i].Cells[2].Value.ToString(),
                        DepartmanId = Convert.ToInt32(Liste.Rows[i].Cells[3].Value),
                        Tel = Liste.Rows[i].Cells[4].Value.ToString(),
                        Gsm = Liste.Rows[i].Cells[5].Value.ToString(),
                        Email = Liste.Rows[i].Cells[6].Value.ToString(),
                        

                    });

                _db.tblFirmaDetaylar.AddRange(lst);
                _db.SaveChanges();
                MessageBox.Show("Kayit gerceklesti");
                Close();



            }
        }

        private void BtnEklee_Click(object sender, EventArgs e)
        {
            Listele();
            Temizle();
            ActiveControl = TxtYetkili;
        }

        private void Temizle()
        {
            TxtYetkili.Clear();
            TxtDepartman.Text = "";
            TxtTel.Clear();
            TxtGsm.Clear();

            ActiveControl = TxtYetkili;
        }
    }
}
