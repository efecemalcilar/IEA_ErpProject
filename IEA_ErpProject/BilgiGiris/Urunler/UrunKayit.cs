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
using IEA_ErpProject.Fonksiyonlar;
using IEA_ErpProject.Properties;

namespace IEA_ErpProject.BilgiGiris.Urunler
{


    public partial class UrunKayit : Form
    {

        private readonly ErpPro102SEntities _db = new ErpPro102SEntities();
        private Numaralar n = new Numaralar();
        private Resimler r = new Resimler();

        private bool _resim = false;
        private OpenFileDialog _dosya = new OpenFileDialog();
        private Formlar f = new Formlar();


        public UrunKayit()
        {
            InitializeComponent();
        }

        private void UrunKayit_Load(object sender, EventArgs e)
        {
            TxtUrunId.Text = n.Uidno();
        }

        private void BtnUrunResmiekle_Click(object sender, EventArgs e)
        {
            ResimSec();
        }

        private void ResimSec()
        {
            _dosya.Filter = "Jpg(*.jpg)|*.jpg|Jpeg(*.jpeg)|*.jpeg";   //Bu kod hem jpg hem de jpeg formatları kabul et diyor.
            if (_dosya.ShowDialog()==DialogResult.OK)
            {
                pbResim.ImageLocation = _dosya.FileName;
                _resim = true;
            }

        }


        protected override void OnLoad(EventArgs e)
        {
            var btn = new Button();             
            btn.Size = new Size(25, TxtUrunId.ClientSize.Height + 0);          
            btn.Location = new Point(TxtUrunId.ClientSize.Width - btn.Width - 1);
            btn.Cursor = Cursors.Default;
            btn.BackgroundImage = Resources.Ara32x32;
            btn.BackgroundImageLayout = ImageLayout.Stretch;
            btn.Anchor = (AnchorStyles.Top | AnchorStyles.Right);
            TxtUrunId.Controls.Add(btn);

            var btnFirma = new Button();
            btnFirma.Size = new Size(25, TxtFirmaKodu.ClientSize.Height + 0);           
            btnFirma.Location = new Point(TxtFirmaKodu.ClientSize.Width - btnFirma.Width - 1);
            btnFirma.Cursor = Cursors.Default;
            btnFirma.BackgroundImage = Resources.Ara32x32;
            btnFirma.BackgroundImageLayout = ImageLayout.Stretch;
            btnFirma.Anchor = (AnchorStyles.Top | AnchorStyles.Right);
            TxtFirmaKodu.Controls.Add(btnFirma);
            
            
            base.OnLoad(e);
            btn.Click += BtnUrun_Click;
            btnFirma.Click += BtnFirma_Click;
        }

        private void BtnUrun_Click(object sender, EventArgs e)
        {
            int id = f.UrunKayitListesiAc(true);
            if (id >0 )
            {
                UrunAc(id);

            }

            AnaSayfa.Aktarma = -1;
        }

        public void UrunAc(int uid)
        {
            
            Temizle();
            Liste.AllowUserToAddRows = false;

            tblUrunKayitUst lst = _db.tblUrunKayitUst.FirstOrDefault(s =>
                s.Uid == uid); // Lambda expression nesne çreneğini ref almamı bekliyor.
            
            TxtAciklamaEng.Text = lst.AciklamaEng;
            TxtAciklamaTr.Text = lst.AciklamaTr;
            TxtTarih.Text = lst.GirisTarih.ToString();
            if (lst.FirmaId != null)
            {
                TxtFirmaAdi.Text = lst.tblFirmalar.Adi;
                TxtFirmaKodu.Text = lst.FirmaId.ToString();
            }
                
            TxtUrunId.Text = lst.Uid.ToString().PadLeft(7,'0');
            TxtUrunKodu.Text = lst.UrunKodu;
            TxtSure.Text = lst.KullanimSuresi.ToString();
            if (lst.Resim != null)
                pbResim.Image = r.ResimGetirme(lst.Resim); // Resimde bir kayıt yok var ise işlem yap diyorum

            var Urunalt = _db.tblUrunKayitAlt.Where(x => x.Uid == uid).ToList();
            var UrunaltTek = _db.tblUrunKayitAlt.FirstOrDefault(s => s.Uid == uid);
            int i = 0;
            foreach (var alt in Urunalt)
            {
                Liste.Rows.Add();
                Liste.Rows[i].Cells[0].Value =alt.GMDMKodu;
                Liste.Rows[i].Cells[1].Value =alt.UMSPCKodu;
                Liste.Rows[i].Cells[2].Value = alt.SB;
                Liste.Rows[i].Cells[3].Value = alt.KullanimDisi;
                Liste.Rows[i].Cells[4].Value = alt.Ubb;
                Liste.Rows[i].Cells[5].Value = alt.Sut;
                Liste.Rows[i].Cells[6].Value = alt.SutFiyat;
                Liste.Rows[i].Cells[7].Value = alt.SutAciklama;
                Liste.Rows[i].Cells[8].Value = alt.UTS;
                Liste.Rows[i].Cells[9].Value = true;
                
                

                i++;


            }

            if (UrunaltTek != null)
            {
                TxtSinif.Text = UrunaltTek.Sinif;
                TxtParaBirimi.Text = UrunaltTek.ParaBirimi;
                TxtMinFiyat.Text = UrunaltTek.MinFiyat.ToString();
                TxtBirimFiyat.Text = UrunaltTek.Birimfiyat.ToString();
            }

           


            //Liste.AllowUserToAddRows = false;
            //Liste.AllowUserToDeleteRows = false;
            //Liste.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            //Liste.ReadOnly = true;



        }


        private void BtnFirma_Click(object sender, EventArgs e)
        {
            int id = f.FirmalarListesiAc(true);
            if (id > 0)
            {
                FirmaAc(id);

            }

            AnaSayfa.Aktarma = -1;  // ne işe yaradığını sor ?
        }

        private void FirmaAc(int id)
        {
            int cariId = id;

            tblFirmalar frm = _db.tblFirmalar.First(s => s.Id == cariId);
            TxtFirmaKodu.Text = frm.Id.ToString().PadLeft(7, '0');
            TxtFirmaAdi.Text = frm.Adi;

        }

        private void BtnKaydet_Click(object sender, EventArgs e)
        {
            YeniKaydet();
        }

        private void YeniKaydet()
        {
            Liste.AllowUserToAddRows = false;   // Neden false???
            if (TxtUrunId.Text=="" || TxtUrunKodu.Text=="" || TxtFirmaKodu.Text == "") // urunıd ve urunkodu boşsa hata ver
            {
                MessageBox.Show("Ilgılı alani doldurunuz");
                Liste.AllowUserToAddRows = true;
                return;
            }

            tblUrunKayitUst ust = new tblUrunKayitUst();
            ust.AciklamaEng = TxtAciklamaEng.Text;
            ust.AciklamaTr = TxtAciklamaTr.Text;
            ust.GirisTarih = TxtTarih.Value;
            ust.FirmaId = int.Parse(TxtFirmaKodu.Text);
            if (pbResim.Image != null) ust.Resim = new System.Data.Linq.Binary(r.ResimYukle(pbResim.Image)).ToArray(); // Binary tipinde veri almak istiyorum resim yükleye git ordan pbresimi çalıştır ve bun yaparkende image i gönder.
            ust.Uid = int.Parse(TxtUrunId.Text);
            ust.UrunKodu = TxtUrunKodu.Text;
            ust.KullanimSuresi = int.Parse(TxtSure.Text);

            _db.tblUrunKayitUst.Add(ust);

            tblUrunKayitAlt[] alt = new tblUrunKayitAlt[Liste.RowCount];                        // Bu array tipinde oluşturdum ve buna alt ismini verdim. Array benden bir sınır bekliyor, bu eleman sayisini listenin içerisinde count(Row.Count=satırların sayısı kadar anlamina geliyor.) yaparak vereceğim.

            for (int i = 0; i < Liste.RowCount; i++)  // Burada yapmam gereken array in elemanlarını doldurmak
            {
                alt[i] = new tblUrunKayitAlt();  // newledik ve array alt 1 için yeni bir alan açacak
                alt[i].Aciklama = TxtAciklamaTr.Text;
                alt[i].Birimfiyat = Convert.ToDecimal(TxtBirimFiyat.Text);
                alt[i].BransAdi = "";
                alt[i].GMDMKodu = Liste.Rows[i].Cells[0].Value.ToString();
                alt[i].UMSPCKodu = Liste.Rows[i].Cells[1].Value.ToString();
                alt[i].KullanimDisi = Convert.ToBoolean(Liste.Rows[i].Cells[3].Value);
                alt[i].SB = Convert.ToBoolean(Liste.Rows[i].Cells[2].Value);
                alt[i].MinFiyat = Convert.ToDecimal(TxtMinFiyat.Text);
                alt[i].ParaBirimi = TxtParaBirimi.Text;
                alt[i].Sinif = TxtSinif.Text;
                alt[i].Sut = Liste.Rows[i].Cells[5].Value.ToString();
                alt[i].SutFiyat = Convert.ToDecimal(Liste.Rows[i].Cells[6].Value);
                alt[i].SutAciklama = Liste.Rows[i].Cells[7].Value.ToString();
                alt[i].Ubb = Liste.Rows[i].Cells[4].Value.ToString();
                alt[i].UTS = Convert.ToBoolean(Liste.Rows[i].Cells[8].Value);
                alt[i].Uid = int.Parse(TxtUrunId.Text);
                alt[i].UIKodu = TxtUrunKodu.Text;
                

                _db.tblUrunKayitAlt.Add(alt[i]);

                // Row Count un anlamı tam ne???

            }
            
            
            
            
            
            _db.SaveChanges();


            MessageBox.Show("Kayit islemi gerceklesti");
            Temizle();

        }

        private void Temizle()
        {
            foreach (Control item in SpcUrunKayit.Panel1.Controls)  // control sınıfının uyelerinden turettik.
            {
                if (item is TextBox || item is ComboBox )
                {
                    if (item.Name!=TxtUrunId.Name)
                    {
                        item.Text = "";
                    }
                   
                }

                pbResim.Image = null;

            }

            Liste.Rows.Clear();
            //Liste.Rows.Add();
            TxtUrunId.Text = n.Uidno();  // Tekrardan database kontrol eder terse dödnduru ve bana sonuc verir.(refresh)
        }

        private void BtnTemizle_Click(object sender, EventArgs e)
        {
            Temizle();
        }

        private void BtnGüncelle_Click(object sender, EventArgs e)
        {
            Guncelle();
        }

        private void Guncelle()
        {
            Liste.AllowUserToAddRows = false;
            int a = Convert.ToInt32(TxtUrunId.Text);
            tblUrunKayitUst ust = _db.tblUrunKayitUst.FirstOrDefault(x => x.Uid == a);

            ust.AciklamaEng = TxtAciklamaEng.Text;
            ust.AciklamaTr = TxtAciklamaTr.Text;
            ust.GirisTarih = TxtTarih.Value;
            ust.FirmaId = int.Parse(TxtFirmaKodu.Text);
            //if (pbResim.Image != null) ust.Resim = new System.Data.Linq.Binary(r.ResimYukle(pbResim.Image)).ToArray(); // Binary tipinde veri almak istiyorum resim yükleye git ordan pbresimi çalıştır ve bun yaparkende image i gönder.
            ust.Uid = int.Parse(TxtUrunId.Text);
            ust.UrunKodu = TxtUrunKodu.Text;
            ust.KullanimSuresi = int.Parse(TxtSure.Text);
            _db.SaveChanges();

            tblUrunKayitAlt[] alt = _db.tblUrunKayitAlt.Where(s => s.Uid == a).ToArray();

            for (int i = 0; i < alt.Count(); i++)  // burda foreach yapacaktık sonra for yaptık neden ?????
            {
                if ((bool)Liste.Rows[i].Cells[9].Value ==true) // string e cevir string karsılıgı 1 ise ...
                {
                    int indexId = alt[i].Id;
                    alt[i] = _db.tblUrunKayitAlt.FirstOrDefault(s => s.Id == indexId);

                    //alt[i] = new tblUrunKayitAlt();  // newledik ve array alt 1 için yeni bir alan açacak
                    alt[i].Aciklama = TxtAciklamaTr.Text;
                    alt[i].Birimfiyat = Convert.ToDecimal(TxtBirimFiyat.Text);
                    alt[i].BransAdi = "";
                    alt[i].GMDMKodu = Liste.Rows[i].Cells[0].Value.ToString();
                    alt[i].UMSPCKodu = Liste.Rows[i].Cells[1].Value.ToString();
                    alt[i].KullanimDisi = Convert.ToBoolean(Liste.Rows[i].Cells[3].Value);
                    alt[i].SB = Convert.ToBoolean(Liste.Rows[i].Cells[2].Value);
                    alt[i].MinFiyat = Convert.ToDecimal(TxtMinFiyat.Text);
                    alt[i].ParaBirimi = TxtParaBirimi.Text;
                    alt[i].Sinif = TxtSinif.Text;
                    alt[i].Sut = Liste.Rows[i].Cells[5].Value.ToString();
                    alt[i].SutFiyat = Convert.ToDecimal(Liste.Rows[i].Cells[6].Value);
                    alt[i].SutAciklama = Liste.Rows[i].Cells[7].Value.ToString();
                    alt[i].Ubb = Liste.Rows[i].Cells[4].Value.ToString();
                    alt[i].UTS = Convert.ToBoolean(Liste.Rows[i].Cells[8].Value);
                    alt[i].Uid = int.Parse(TxtUrunId.Text);
                    alt[i].UIKodu = TxtUrunKodu.Text;
                }

                else
                {

                    
                    alt[i] = new tblUrunKayitAlt();
                    //alt[i] = new tblUrunKayitAlt();  // newledik ve array alt 1 için yeni bir alan açacak
                    alt[i].Aciklama = TxtAciklamaTr.Text;
                    alt[i].Birimfiyat = Convert.ToDecimal(TxtBirimFiyat.Text);
                    alt[i].BransAdi = "";
                    alt[i].GMDMKodu = Liste.Rows[i].Cells[0].Value.ToString();
                    alt[i].UMSPCKodu = Liste.Rows[i].Cells[1].Value.ToString();
                    alt[i].KullanimDisi = Convert.ToBoolean(Liste.Rows[i].Cells[3].Value);
                    alt[i].SB = Convert.ToBoolean(Liste.Rows[i].Cells[2].Value);
                    alt[i].MinFiyat = Convert.ToDecimal(TxtMinFiyat.Text);
                    alt[i].ParaBirimi = TxtParaBirimi.Text;
                    alt[i].Sinif = TxtSinif.Text;
                    alt[i].Sut = Liste.Rows[i].Cells[5].Value.ToString();
                    alt[i].SutFiyat = Convert.ToDecimal(Liste.Rows[i].Cells[6].Value);
                    alt[i].SutAciklama = Liste.Rows[i].Cells[7].Value.ToString();
                    alt[i].Ubb = Liste.Rows[i].Cells[4].Value.ToString();
                    alt[i].UTS = Convert.ToBoolean(Liste.Rows[i].Cells[8].Value);
                    alt[i].Uid = int.Parse(TxtUrunId.Text);
                    alt[i].UIKodu = TxtUrunKodu.Text;
                    _db.tblUrunKayitAlt.Add(alt[i]);
                }

                _db.SaveChanges();

            }

        }

        private void BtnAddListeRow_Click(object sender, EventArgs e)
        {
            Liste.AllowUserToAddRows = Liste.AllowUserToAddRows != true;
            Liste.CurrentRow.Cells[9].Value = 0;

        }
    }
}
