using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Odbc;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ProjeAtHome.Entity;

namespace ProjeAtHome.BilgiGiris.Hastaneler
{
    public partial class HastaneDetay : Form
    {

        private readonly ProjeAtHome.Entity.ErpPro102SEntities2 _db = new ErpPro102SEntities2();
        
        
        
        public HastaneDetay()
        {
            InitializeComponent();
        }

        private void HastaneDetay_Load(object sender, EventArgs e)
        {
            ComboDoldur();
        }

        private void ComboDoldur()
        {
            //TxtDepartman.DataSource = _db.tblDepartmanlar.Where(x => x.DepartmanKodu == 'H').ToList();
            TxtDepartman.ValueMember = "Id";
            TxtDepartman.DisplayMember = "Adi";
            TxtDepartman.SelectedIndex = -1;
        }
    
        

        private void BtnEkle_Click_1(object sender, EventArgs e)
        {
            Liste.AllowUserToAddRows = false;
            int i = -1;

            if (Liste.Rows.Count >= 0)
            {
                i = Liste.Rows.Count;
                Liste.Rows.Add();
                Liste.Rows[i].Cells[0].Value = i + 1;
                Liste.Rows[i].Cells[1].Value = LblHastaneId.Text;
                Liste.Rows[i].Cells[2].Value = 'H';
                Liste.Rows[i].Cells[3].Value = TxtYetkili.Text;
                Liste.Rows[i].Cells[4].Value = TxtDepartman.SelectedValue;
                Liste.Rows[i].Cells[5].Value = TxtTel.Text;
                Liste.Rows[i].Cells[6].Value = TxtGsm.Text;
                Liste.Rows[i].Cells[7].Value = TxtEmail.Text;

                Temizle();

            }

            else
            {
                MessageBox.Show("Ilgılı alanlari lutfen doldurunuz");
                ActiveControl = TxtYetkili;
            }

        }

        private void Temizle()
        {
            TxtYetkili.Clear();
            TxtDepartman.Text = "";
            TxtTel.Clear();

            ActiveControl = TxtYetkili;
        }

        private void BtnKayit_Click(object sender, EventArgs e)
        {
            YeniKayit();
        }

        private void YeniKayit()
        {
            if (Liste.Rows[0].Cells[0].Value==null)
            {
                MessageBox.Show("Once ekle butonuyla kayit ekleyin");
                ActiveControl = TxtYetkili;
                return;
            }

            List<tblHastaneDetaylar> lst = new List<tblHastaneDetaylar>();



            for (int i = 0; i < Liste.Rows.Count; i++)
            {
                lst.Add(
                    new tblHastaneDetaylar()
                    {
                        GirisId = Convert.ToInt32(Liste.Rows[i].Cells[1].Value),
                        YetkiliAdi = Liste.Rows[i].Cells[2].Value.ToString(),
                        DepartmanId = Convert.ToInt32(Liste.Rows[i].Cells[3].Value),
                        Tel = Liste.Rows[i].Cells[4].Value.ToString(),
                        Gsm = Liste.Rows[i].Cells[5].Value.ToString(),
                        Email = Liste.Rows[i].Cells[6].Value.ToString(),


                    });







                _db.tblHastaneDetaylar.AddRange(lst);
                _db.SaveChanges();
                MessageBox.Show("Kayit Gerceklesti");
                Close();



            }
            
                
          

                
            


        }




    }
}
