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

namespace ProjeAtHome.BilgiGiris.Personeller
{
    public partial class PersonelGiris : Form
    {

        private readonly ErpPro102SEntities2 _db = new ErpPro102SEntities2();
        public Formlar F = new Formlar();
        private List<tblPersoneller> prsList;
        private int secimId = -1;
        private tblPersoneller kayitBul;


        public PersonelGiris()
        {
            InitializeComponent();
        }

        private void PersonelGiris_Load(object sender, EventArgs e)
        {
            ComboDoldur();
            Listele();
        }


        private void ComboDoldur()
        {
            TxtSehir.DataSource = _db.Sehirler.ToList();
            TxtSehir.ValueMember = "Id";
            TxtSehir.DisplayMember = "name";
            TxtSehir.SelectedIndex = -1;

            TxtDepartman.DataSource = _db.tblDepartmanlar.ToList();
            TxtDepartman.ValueMember = "Id";
            TxtDepartman.DisplayMember = "Adi";
            TxtDepartman.SelectedValue = -1;
        }

        private void Listele()
        {

            Liste.Rows.Clear();

            int i = 0;


            prsList = (from s in _db.tblPersoneller select s).ToList();

            foreach (var item in prsList)
            {
                Liste.Rows.Add();
                Liste.Rows[i].Cells[0].Value = i + 1;
                Liste.Rows[i].Cells[1].Value = item.Id;
                Liste.Rows[i].Cells[2].Value = item.Adi;
                Liste.Rows[i].Cells[3].Value = item.Unvan;
                Liste.Rows[i].Cells[4].Value = item.Tel;

                i++;


                if (item.Sehirler != null)
                {
                    Liste.Rows[i].Cells[5].Value = item.Sehirler.name;
                }




            }

            Liste.AllowUserToAddRows = false;
            Liste.AllowUserToDeleteRows = false;
            Liste.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            Liste.ReadOnly = true;

        }

        private void BtnKaydet_Click(object sender, EventArgs e)
        {
            YeniKayit();
        }

        private void YeniKayit()
        {
            if (TxtPAdi.Text == "")
            {
                MessageBox.Show("Ilgılı alanları doldurunuz!");
                return;
            }

            try
            {
                tblPersoneller prs = new tblPersoneller();    // kaydetdeceğim classın nesnesini üretip onu ref alıyoruz.

                prs.Adi = TxtPAdi.Text;
                prs.Unvan = TxtUnvanAdi.SelectedText;
                prs.Adres = TxtAdres.Text;
                if (TxtDepartman.SelectedValue != null) prs.DepartmanId = Convert.ToInt32(TxtDepartman.SelectedValue);
                prs.Email = TxtEmail.Text;
                if (TxtSehir.SelectedValue != null) prs.SehirId = Convert.ToInt32(TxtSehir.SelectedValue);
                prs.Tel = TxtTelefon.Text;
                prs.IsBaslangis = TxtDBaslangic.Value;
                prs.IsBitis = TxtDBitis.Value;
                prs.Gsm = TxtGsm.Text;
                ;


                _db.tblPersoneller.Add(prs);
                _db.SaveChanges();
                MessageBox.Show("Kayit basarili");
                Temizle();
                Listele();


            }
            catch (Exception e)
            {

                MessageBox.Show(e.Message + "HataKodu : HGK102");

            }

        }

        private void Temizle()
        {
            foreach (Control k in ScPersonel.Controls)
            {
                if (k is TextBox || k is ComboBox || k is MaskedTextBox || k is RichTextBox)
                {
                    k.Text = "";

                }
            }
            TxtDepartman.SelectedIndex = -1;
            TxtSehir.SelectedIndex = -1;
            secimId = -1;
            kayitBul = null;
            BtnDetayEkle.Visible = false;
            BtnDetayGoster.Visible = false;
        }

        private void BtnGüncelle_Click(object sender, EventArgs e)
        {
            Guncelle();
        }

        private void Guncelle()
        {
            if (secimId<0)
            {
                MessageBox.Show("Degistirilecek kayit bulunamadi , once bir kayit secin");
                return;
            }

            try
            {
                if (kayitBul != null)
                {
                    kayitBul.Adi = TxtPAdi.Text;
                    kayitBul.Adres = TxtAdres.Text;
                    kayitBul.DepartmanId = (int?)TxtDepartman.SelectedValue;
                    kayitBul.Email = TxtEmail.Text;
                    kayitBul.Gsm = TxtGsm.Text;
                    kayitBul.SehirId = (int?)TxtSehir.SelectedValue;
                    kayitBul.Unvan = TxtUnvan.Text;
                    kayitBul.Tel = TxtTelefon.Text;
                    

                    _db.SaveChanges();   
                    MessageBox.Show("Güncelleme Yapıldı.");
                    Temizle();
                    Listele();

                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message + "Bir şeyler ters gitti");
            }



        }

        private void BtnSil_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Kayit kalici olarak silenecektir !! ", "Silme işlemi ", MessageBoxButtons.YesNo, MessageBoxIcon.Question);



            if (dr == DialogResult.Yes)
            {
                Sil();
            }
        }

        private void Sil()
        {
            if (secimId < 0 )
            {
                MessageBox.Show("Silinecek kaydi seciniz");
                return;
            }

            if (secimId >0)
            {
                _db.tblPersoneller.Remove(kayitBul);
                _db.SaveChanges();
                MessageBox.Show("Kaydiniz silinmistir, gecmis olsun");
                Temizle();
                Listele();
            }


        }

        private void BtnTemizle_Click(object sender, EventArgs e)
        {
            Temizle();
        }

        private void Liste_DoubleClick(object sender, EventArgs e)
        {
            if (Liste.CurrentRow != null)
            {
                secimId = (int) Liste.CurrentRow.Cells[1].Value;
            }

            Ac(secimId);
        }

        public void Ac(int secimId)
        {
            Temizle();
            if (secimId < 0)
            {
                MessageBox.Show("Kayit id bulunamamistir.");
                return;

            }

            

            kayitBul = prsList.FirstOrDefault(x => x.Id == secimId); 

            try
            {
                if (kayitBul != null)
                {
                    TxtPAdi.Text = kayitBul.Adi;
                    TxtAdres.Text = kayitBul.Adres;
                    if (kayitBul.DepartmanId != null) TxtDepartman.Text = kayitBul.tblDepartmanlar.Adi;
                    TxtEmail.Text = kayitBul.Email;
                    TxtGsm.Text = kayitBul.Gsm;
                    if (kayitBul.SehirId != null) TxtSehir.Text = kayitBul.Sehirler.name;
                    TxtUnvan.Text = kayitBul.Unvan;
                    TxtTelefon.Text = kayitBul.Tel;


                }
            }
            catch (Exception e)
            {

                MessageBox.Show(e.Message + "Hata Kodu : HGListe101");
            }
        }

        private void BtnKapat_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
