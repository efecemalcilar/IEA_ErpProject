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
using IEA_ErpProject.Entity;

namespace IEA_ErpProject.BilgiGiris.Firmalar
{
    public partial class FirmaDetay : Form
    {

        public string Hadi = "";
        List<tblFirmaDetaylar> lst = new List<tblFirmaDetaylar>();
        private readonly Entity.ErpPro102SEntities _db = new Entity.ErpPro102SEntities();
        public FirmaDetay()
        {
            InitializeComponent();
        }

        private void FirmaDetayGoster_Load(object sender, EventArgs e)
        {
            ComboDoldur();
            Listele();
            
        }

        private void ComboDoldur()
        {
            TxtDepartman.DataSource = _db.tblDepartmanlar.Where(x => x.DepartmanKodu == "F").ToList();          // _db ile başlayan yer linq olarak geçiyor.
            TxtDepartman.ValueMember = "Id";
            TxtDepartman.DisplayMember = "Adi";  // Ekranda göreceğim kısım,İdlerle çalışıcam ama görürken isimleri görücem
            TxtDepartman.SelectedIndex = -1; // ekranda bir şey göstermemesi için.


        }

        private void Listele()
        {
            
        }

    

        private void BtnKayit_Click(object sender, EventArgs e)
        {
            YeniKayit();
        }

        private void YeniKayit()
        {
            if (Liste.Rows[0].Cells[0].Value == null)
            {
                MessageBox.Show("Once ekle butonuyla kayit ekleyin!");
                ActiveControl = TxtYetkili;
                return;
            }


            List<tblFirmaDetaylar> lst = new List<tblFirmaDetaylar>();





            for (int i = 0; i < Liste.Rows.Count; i++)
            {

                lst.Add(
                    new tblFirmaDetaylar()
                    {


                        GirisId = Convert.ToInt32(Liste.Rows[i].Cells[1].Value),  // intParse bir veri tipinden veri tipine dönüşüm sağlar
                        // convert objeleride dönüştürebiliyor.
                        YetkiliAdi = Liste.Rows[i].Cells[2].Value.ToString(),
                        DepartmanId = Convert.ToInt32(Liste.Rows[i].Cells[3].Value),
                        Tel = Liste.Rows[i].Cells[4].Value.ToString(),
                        Gsm = Liste.Rows[i].Cells[5].Value.ToString(),
                        Email = Liste.Rows[i].Cells[6].Value.ToString(),
                        // lst.Add() referenans noktası olarak aldık ve lst.GirisId gibi yazmamıza gerek kalmadı bu kod sayesinde tek satira indi.

                    });



            }

            _db.tblFirmaDetaylar.AddRange(lst);          // Add tek tek kayit yapar AddRange toplu kayit yapar.
            _db.SaveChanges();
            MessageBox.Show("Kayit gerceklesti");
            Close();



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
