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
using IEA_ErpProject.Fonksiyonlar;
using IEA_ErpProject.Properties;

namespace IEA_ErpProject.BilgiGiris.Personeller
{


    public partial class PersonelGiris : Form
    {




        private readonly Entity.ErpPro102SEntities _db = new Entity.ErpPro102SEntities();
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

        public Formlar f = new Formlar();

        private List<tblPersoneller> prsList;
        private int secimId = -1;
        private tblPersoneller kayitBul;
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

            Liste.AllowUserToAddRows = false; // iş bittikten sonra kullanıcı yeni bir satır ekleyemesin.
            Liste.AllowUserToDeleteRows = false; // kullanıcı bir kaydı silemesin.
            Liste.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            Liste.ReadOnly = true; // Burası sadece okunur olsun değiştirilemesin anlamına gelir.

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
            if (secimId < 0)
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
                    //kayitBul.IsBaslangis = TxtIsBaslangic. ??
                    //kayitBul.IsBitis = TxtIsBitis

                    _db.SaveChanges();   // Yapılan değişikleri uygula demek.
                    MessageBox.Show("Güncelleme Yapıldı.");
                    Temizle();
                    Listele();
                    ;
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
            if (secimId < 0)
            {
                MessageBox.Show("Silinecek kaydi seciniz");
                return;
            }

            if (secimId > 0)
            {
                _db.tblPersoneller.Remove(kayitBul);
                _db.SaveChanges();
                MessageBox.Show("Kaydiniz Silinmistir, gecmis olsun.");
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
                secimId = (int)Liste.CurrentRow.Cells[1].Value;
            }

            Ac(secimId);
        }

        protected override void OnLoad(EventArgs e)
        {
            var btn = new Button();             // Burada button u sanal olarak oluşturacaz.
            btn.Size = new Size(25, TxtPersonelBul.ClientSize.Height + 0);            // Size(Genişlik,Yükseklik) normal bir height kadar al
            btn.Location = new Point(TxtPersonelBul.ClientSize.Width - btn.Width - 1);
            btn.Cursor = Cursors.Default;
            btn.BackgroundImage = Resources.Ara32x32;
            btn.BackgroundImageLayout = ImageLayout.Stretch;
            btn.Anchor = (AnchorStyles.Top | AnchorStyles.Right);
            TxtPersonelBul.Controls.Add(btn);
            base.OnLoad(e);

            // Kodsal olarak Click eventini oluşturmak
            btn.Click += Btn_Click;
        }
        private void Btn_Click(object sender, EventArgs e)
        {
            int id = f.PersonellerListesiAc(true);

            if (id > 0)
            {
                Ac(id);
            }
            AnaSayfa.Aktarma = -1;
        }
        public void Ac(int secimId)
        {
            Temizle();
            if (secimId < 0)
            {
                MessageBox.Show("Kayit id bulunamamistir.");
                return;

            }

            // tblHastaneler kayitBul = _db.tblHastaneler.Find(secimId);  // Burdan bana bir kayıt getirmesini istiyorum. Bu bana datebase de ki ilgili id yi bulup o satırı kayıtBul a atar.

            kayitBul = prsList.FirstOrDefault(x => x.Id == secimId); // Bu db ye bağlanmaz x dktList den bir nesne olarak türetilir . amacımız dktList deki columb bilgilerine ulaşabilmek.  (x => x.Id == secimId)  x i oluşturdum x den id yi türettim... Lambda expression

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
