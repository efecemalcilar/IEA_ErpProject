using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ProjeAtHome.Entity;
using ProjeAtHome.Fonksiyonlar;
using ProjeAtHome.Properties;

namespace ProjeAtHome.BilgiGiris.Doktorlar
{
    public partial class DoktorGiris : Form
    {

        private readonly Entity.ErpPro102SEntities2 _db = new ErpPro102SEntities2();
        private Formlar f = new Formlar();
        public DoktorGiris()
        {
            InitializeComponent();
        }

        private void DoktorGiris_Load(object sender, EventArgs e)
        {
            ComboDoldur();
        }

        private void ComboDoldur()
        {
            TxtUnvan.DataSource = Enum.GetValues(typeof(Unvan)).Cast<Enum>().Select(value => new
                {
                    (Attribute.GetCustomAttribute(value.GetType().GetField(value.ToString()),
                        typeof(DescriptionAttribute)) as DescriptionAttribute).Description,
                    value
                })
                .OrderBy(item => item.value)
                .ToList();



            TxtUnvan.DisplayMember = "Description";
            TxtUnvan.ValueMember = "Value";
            TxtUnvan.SelectedIndex = -1;


            var srg = _db.tblHastaneler.ToList();

            TxtHastane1.DataSource = srg.ToList();              // database e ulaşmamız gerekiyor.tblHastaneler e git ve listesini al
            TxtHastane1.ValueMember = "Id";
            TxtHastane1.DisplayMember = "Adi";
            TxtHastane1.SelectedIndex = -1;


            TxtHastane2.DataSource = srg.ToList();
            TxtHastane2.ValueMember = "Id";
            TxtHastane2.DisplayMember = "Adi";
            TxtHastane2.SelectedIndex = -1;


            TxtHastane3.DataSource = srg.ToList();
            TxtHastane3.ValueMember = "Id";
            TxtHastane3.DisplayMember = "Adi";
            TxtHastane3.SelectedIndex = -1;


            TxtSehir.DataSource = _db.Sehirler.ToList();
            TxtSehir.ValueMember = "Id";
            TxtSehir.DisplayMember = "name";
            TxtSehir.SelectedIndex = -1;

        }

        private void BtnKaydet_Click(object sender, EventArgs e)
        {
            YeniKayit();
        }

        private void YeniKayit()
        {
            tblDoktorlar dkt = new tblDoktorlar()
            {

                Adi = TxtDadi.Text,
                DTarih = TxtDTarih.Value,          // Value dediğimiz için direk değerini alacak.
                Email = TxtEmail.Text,
                Gsm = TxtGsm.Text,
                Hastane1Id = Convert.ToInt32(TxtHastane1.SelectedValue),
                Hastane2Id = Convert.ToInt32(TxtHastane2.SelectedValue),
                Hastane3Id = Convert.ToInt32(TxtHastane3.SelectedValue),
                Muayenehane = TxtMAdres.Text,
                SehirId = Convert.ToInt32(TxtSehir.SelectedValue),
                Tel1 = TxtTelefon1.Text,
                Tel2 = TxtTelefon2.Text,
                Unvan = TxtUnvan.Text,
                VergiDairesi = TxtVergiDairesi.Text,
                VergiNo = TxtVergiNo.Text


            };

            if (TxtHastane1.SelectedValue != null) dkt.Hastane1Id = Convert.ToInt32(TxtHastane1.SelectedValue); // null kontrolü
            if (TxtHastane2.SelectedValue != null) dkt.Hastane2Id = Convert.ToInt32(TxtHastane2.SelectedValue);
            if (TxtHastane3.SelectedValue != null) dkt.Hastane3Id = Convert.ToInt32(TxtHastane3.SelectedValue);
            if (TxtSehir.SelectedValue != null) dkt.SehirId = Convert.ToInt32(TxtSehir.SelectedValue);

            _db.tblDoktorlar.Add(dkt);
            _db.SaveChanges();
            MessageBox.Show("Kayit basariyla yapildi.");
            Temizle();
            Listele();
        }

        
        private void Temizle()
        {
            foreach (Control k in ScDoktor.Panel1.Controls)
            {
                if (k is TextBox || k is ComboBox || k is MaskedTextBox || k is RichTextBox)
                {
                    k.Text = "";
                }

                TxtHastane1.SelectedIndex = -1;
                TxtHastane2.SelectedIndex = -1;
                TxtHastane3.SelectedIndex = -1;
                TxtSehir.SelectedIndex = -1;
                TxtUnvan.SelectedIndex = -1;
                TxtDTarih.Value = DateTime.Now;



            }
        }

        private List<tblDoktorlar> dktList;
        private int secimId = -1;
        private tblDoktorlar kayitBul;


        private void Listele()
        {
            Liste.Rows.Clear();

            int i = 0;


            dktList = (from s in _db.tblDoktorlar select s).ToList();

            foreach (var item in dktList)
            {
                Liste.Rows.Add();
                Liste.Rows[i].Cells[0].Value = i + 1;
                Liste.Rows[i].Cells[1].Value = item.Id;
                Liste.Rows[i].Cells[2].Value = item.Adi;
                Liste.Rows[i].Cells[3].Value = item.Tel1;
                Liste.Rows[i].Cells[4].Value = item.Tel2;
                Liste.Rows[i].Cells[5].Value = item.Gsm;
                Liste.Rows[i].Cells[6].Value = item.Email;
                if (item.Sehirler != null)
                {
                    Liste.Rows[i].Cells[7].Value = item.Sehirler.name;
                }



                i++;
            }
        }
        
        protected override void Onload(EventArgs e)
        {
            var btn = new Button();             // Burada button u sanal olarak oluşturacaz.
            btn.Size = new Size(25, TxtDoktorBul.ClientSize.Height + 0);            // Size(Genişlik,Yükseklik) normal bir height kadar al
            btn.Location = new Point(TxtDoktorBul.ClientSize.Width - btn.Width - 1);
            btn.Cursor = Cursors.Default;
            btn.BackgroundImage = Resources.Ara32x32;
            btn.BackgroundImageLayout = ImageLayout.Stretch;
            btn.Anchor = (AnchorStyles.Top | AnchorStyles.Right);
            TxtDoktorBul.Controls.Add(btn);
            base.OnLoad(e);

            // Kodsal olarak Click eventini oluşturmak
            btn.Click += Btn_Click;

        }

        private void Btn_Click(object sender, EventArgs e)
        {
            int id = f.DoktorlarListesiAc(true);

            if (id >0)
            {
                Ac(id);
            }

            AnaSayfa1.Aktarma = -1;
        }

        public void Ac(int secimId)
        {
            Temizle();

            if (secimId < 0 )
            {
                MessageBox.Show("Kayit Id Bulunamadi");
                return;
            }


            kayitBul = dktList.FirstOrDefault(x => x.Id == secimId);


            try
            {
                if (kayitBul != null)
                {
                    TxtVergiNo.Text = kayitBul.VergiNo;
                    TxtTelefon1.Text = kayitBul.Tel1;
                    if (kayitBul.Sehirler != null) TxtSehir.Text = kayitBul.Sehirler.name;
                    TxtMAdres.Text = kayitBul.Muayenehane;
                    TxtUnvan.Text = kayitBul.Unvan;
                    TxtDadi.Text = kayitBul.Adi;
                    TxtTelefon2.Text = kayitBul.Tel2;
                    TxtVergiDairesi.Text = kayitBul.VergiDairesi;
                    TxtDoktorBul.Text = kayitBul.Id.ToString().PadLeft(5, '0');
                    if (kayitBul.tblHastaneler != null) TxtHastane1.Text = kayitBul.tblHastaneler.Adi;
                    if (kayitBul.tblHastaneler1 != null) TxtHastane2.Text = kayitBul.tblHastaneler1.Adi;  // if li kodun anlamı eğer null gelirse kod a gitme ve görmezden gel hata gitmesin.
                    if (kayitBul.tblHastaneler2 != null) TxtHastane3.Text = kayitBul.tblHastaneler2.Adi;
                    TxtEmail.Text = kayitBul.Email;
                    TxtDTarih.Text = kayitBul.DTarih.ToString();
                    TxtGsm.Text = kayitBul.Gsm;



                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message + "Hata Kodu : HGListe101");
                
            }


        }

        private void Liste_DoubleClick(object sender, EventArgs e)
        {
            if (Liste.CurrentRow != null)
            {
                secimId = (int) Liste.CurrentRow.Cells[1].Value;
            }

            Ac(secimId);

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

                    kayitBul.VergiNo = TxtVergiNo.Text;
                    kayitBul.Tel1 = TxtTelefon1.Text;
                    if (TxtHastane1.SelectedValue != null) kayitBul.SehirId = Convert.ToInt32(TxtSehir.SelectedValue);
                    kayitBul.Muayenehane = TxtMAdres.Text;
                    kayitBul.Unvan = TxtUnvan.Text;
                    kayitBul.Adi = TxtDadi.Text;
                    kayitBul.Tel2 = TxtTelefon2.Text;
                    kayitBul.VergiDairesi = TxtVergiDairesi.Text;
                    if (TxtHastane1.SelectedValue != null)
                    {
                        kayitBul.Hastane1Id = Convert.ToInt32(TxtHastane1.SelectedValue);
                    }
                    if (TxtHastane2.SelectedValue != null) kayitBul.Hastane2Id = Convert.ToInt32(TxtHastane2.SelectedValue);

                    if (TxtHastane3.SelectedValue != null) kayitBul.Hastane3Id = Convert.ToInt32(TxtHastane3.SelectedValue);

                    kayitBul.Email = TxtEmail.Text;
                    kayitBul.DTarih = TxtDTarih.Value;
                    kayitBul.Gsm = TxtGsm.Text;



                    ;
                }


                _db.SaveChanges();   // Yapılan değişikleri uygula demek.
                MessageBox.Show("Güncelleme Yapıldı.");
                Temizle();
                Listele();

            }
            catch (Exception e)
            {

                MessageBox.Show(e.Message + "Bir şeyler ters gitti");
            }
        }

        private void BtnSil_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Kayit Kalici olarak silinecektir ! ", "Silme islemi",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);

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
                _db.tblDoktorlar.Remove(kayitBul);
                _db.SaveChanges();
                MessageBox.Show("Kaydiniz silinmistir, gecmis olsun!");
                Temizle();
                Listele();
            }

        }
    }
}
