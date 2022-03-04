using IEA_ErpProject.Entity;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IEA_ErpProject.BilgiGiris.Hastaneler
{
    public partial class HastaneDetay : Form
    {

        private readonly IEA_ErpProject.Entity.ErpPro102SEntities _db = new Entity.ErpPro102SEntities();

        public HastaneDetay()
        {
            InitializeComponent();
        }

        private void HastaneDetay_Load(object sender, EventArgs e)
        {
            ComboDoldur();
            TxtYetkili.Focus();  // yetkilinin üzerinde imleç yanıp yanıp sönecek.
        }

        private void ComboDoldur()
        {
            TxtDepartman.DataSource = _db.tblDepartmanlar.Where(x=>x.DepartmanKodu=="H").ToList();          // _db ile başlayan yer linq olarak geçiyor.
            TxtDepartman.ValueMember = "Id";
            TxtDepartman.DisplayMember = "Adi";  // Ekranda göreceğim kısım,İdlerle çalışıcam ama görürken isimleri görücem
            TxtDepartman.SelectedIndex = -1; // ekranda bir şey göstermemesi için.
        
        
        }


        //*************** 17.02.2022******************


        private void BtnEkle_Click(object sender, EventArgs e)
        {

            if (TxtYetkili.Text != "" && TxtDepartman.SelectedIndex != -1)  
            {
                Liste.AllowUserToAddRows = false;
                int i = -1;



                if (Liste.Rows.Count >= 0)
                {
                    i = Liste.Rows.Count; // Count içeride ki row u sayıyor. Eğer row doluysa
                    Liste.Rows.Add(); // Eldeki verileri datagridview e yazmak istiyoruz.
                    Liste.Rows[i].Cells[0].Value = i + 1; //ilk rows umun cell 0 ında Sira var. Sira 1
                    Liste.Rows[i].Cells[1].Value = LblHastaneId.Text;
                    Liste.Rows[i].Cells[2].Value = TxtYetkili.Text;
                    Liste.Rows[i].Cells[3].Value =
                        TxtDepartman
                            .SelectedValue; // Departmanın text halinde value si değilde select edilmiş idsni seiicem.
                    Liste.Rows[i].Cells[4].Value = TxtTel.Text;
                    Liste.Rows[i].Cells[5].Value = TxtGsm.Text;
                    Liste.Rows[i].Cells[6].Value = TxtEmail.Text;



                    Temizle();
                }

            }

            else
            {
                MessageBox.Show("Ilgili alanlari lütfen doldurun");
                ActiveControl = TxtYetkili;
            }
        }

                

        private void Temizle()
        {
            TxtYetkili.Clear();
            TxtDepartman.Text = "";
            TxtTel.Clear();
            TxtGsm.Clear();
        
            ActiveControl = TxtYetkili;
        
        }





        private void BtnKayit_Click(object sender, EventArgs e)
        {
            YeniKayit();
        }
           // eğer newlersek dty nin içine 1 satırlık bir bilgi atmış oluruz.
        
        private void YeniKayit()
        {
            if (Liste.Rows[0].Cells[0].Value==null)
            {
                MessageBox.Show("Once ekle butonuyla kayit ekleyin!");
                ActiveControl = TxtYetkili;
                return;
            }


            List<tblHastaneDetaylar> lst = new List<tblHastaneDetaylar>();





            for (int i = 0; i < Liste.Rows.Count; i++)
            {

                lst.Add(
                    new tblHastaneDetaylar
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

            _db.tblHastaneDetaylar.AddRange(lst);          // Add tek tek kayit yapar AddRange toplu kayit yapar.
            _db.SaveChanges();
            MessageBox.Show("Kayit gerceklesti");
            Close();
        
        
        
        
        }
    }
}
