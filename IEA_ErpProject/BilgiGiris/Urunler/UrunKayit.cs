using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.Design;
using System.Data;
using System.Data.SqlClient;
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
        private int secimId = -1;

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
            _dosya.Filter =
                "Jpg(*.jpg)|*.jpg|Jpeg(*.jpeg)|*.jpeg"; //Bu kod hem jpg hem de jpeg formatları kabul et diyor.
            if (_dosya.ShowDialog() == DialogResult.OK)
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
            if (id > 0)
            {
                UrunAc(id);

            }

            AnaSayfa.Aktarma = -1;
        }

        public void UrunAc(int uid)
        {
            
            Temizle();
            secimId = uid;
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

            TxtUrunId.Text = lst.Uid.ToString().PadLeft(7, '0');
            TxtUrunKodu.Text = lst.UrunKodu;
            EtiketId.Text = lst.Id.ToString().PadLeft(7, '0');
            TxtSure.Text = lst.KullanimSuresi.ToString();
            if (lst.Resim != null)
                pbResim.Image = r.ResimGetirme(lst.Resim); // Resimde bir kayıt yok var ise işlem yap diyorum

            var Urunalt = _db.tblUrunKayitAlt.Where(x => x.Uid == uid).ToList();
            var UrunaltTek = _db.tblUrunKayitAlt.FirstOrDefault(s => s.Uid == uid);
            int i = 0;
            foreach (var alt in Urunalt)
            {
                Liste.Rows.Add();
                Liste.Rows[i].Cells[0].Value = alt.GMDMKodu;
                Liste.Rows[i].Cells[1].Value = alt.UMSPCKodu;
                Liste.Rows[i].Cells[2].Value = alt.SB;
                Liste.Rows[i].Cells[3].Value = alt.KullanimDisi;
                Liste.Rows[i].Cells[4].Value = alt.Ubb;
                Liste.Rows[i].Cells[5].Value = alt.Sut;
                Liste.Rows[i].Cells[6].Value = alt.SutFiyat;
                Liste.Rows[i].Cells[7].Value = alt.SutAciklama;
                Liste.Rows[i].Cells[8].Value = alt.UTS;
                Liste.Rows[i].Cells[9].Value = false;
                Liste.Rows[i].Cells[10].Value = alt.Id;



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

            AnaSayfa.Aktarma = -1; // ne işe yaradığını sor ?
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
            Liste.AllowUserToAddRows = false; // Neden false???
            if (TxtUrunId.Text == "" || TxtUrunKodu.Text == "" ||
                TxtFirmaKodu.Text == "") // urunıd ve urunkodu boşsa hata ver
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
            if (pbResim.Image != null)
                ust.Resim = new System.Data.Linq.Binary(r.ResimYukle(pbResim.Image))
                    .ToArray(); // Binary tipinde veri almak istiyorum resim yükleye git ordan pbresimi çalıştır ve bun yaparkende image i gönder.
            ust.Uid = int.Parse(TxtUrunId.Text);
            ust.UrunKodu = TxtUrunKodu.Text;
            ust.KullanimSuresi = int.Parse(TxtSure.Text);

            _db.tblUrunKayitUst.Add(ust);

            tblUrunKayitAlt[]
                alt = new tblUrunKayitAlt[Liste
                    .RowCount]; // Bu array tipinde oluşturdum ve buna alt ismini verdim. Array benden bir sınır bekliyor, bu eleman sayisini listenin içerisinde count(Row.Count=satırların sayısı kadar anlamina geliyor.) yaparak vereceğim.

            for (int i = 0; i < Liste.RowCount; i++) // Burada yapmam gereken array in elemanlarını doldurmak
            {
                alt[i] = new tblUrunKayitAlt(); // newledik ve array alt 1 için yeni bir alan açacak
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
            foreach (Control item in SpcUrunKayit.Panel1.Controls) // control sınıfının uyelerinden turettik.
            {
                if (item is TextBox || item is ComboBox)
                {
                    if (item.Name != TxtUrunId.Name)
                    {
                        item.Text = "";
                    }

                }

                pbResim.Image = null;

            }

            Liste.Rows.Clear();
            //Liste.Rows.Add();
            TxtUrunId.Text = n.Uidno(); // Tekrardan database kontrol eder terse dödnduru ve bana sonuc verir.(refresh)
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

            List<tblUrunKayitAlt> alt = _db.tblUrunKayitAlt.Where(s => s.Uid == a).ToList();
            int ii = 0;
            foreach (var uAlt in alt)
            {
                if ((bool) Liste.Rows[ii].Cells[9].Value != true)
                {
                    int indexId = alt[ii].Id;
                    //alt[ii] = _db.tblUrunKayitAlt.FirstOrDefault(s => s.Id == indexId);
                    uAlt.Aciklama = TxtAciklamaTr.Text;
                    uAlt.Birimfiyat = Convert.ToDecimal(TxtBirimFiyat.Text);
                    uAlt.BransAdi = "";
                    uAlt.GMDMKodu = Liste.Rows[ii].Cells[0].Value.ToString();
                    uAlt.UMSPCKodu = Liste.Rows[ii].Cells[1].Value.ToString();
                    uAlt.KullanimDisi = Convert.ToBoolean(Liste.Rows[ii].Cells[3].Value);
                    uAlt.SB = Convert.ToBoolean(Liste.Rows[ii].Cells[2].Value);
                    uAlt.MinFiyat = Convert.ToDecimal(TxtMinFiyat.Text);
                    uAlt.ParaBirimi = TxtParaBirimi.Text;
                    uAlt.Sinif = TxtSinif.Text;
                    uAlt.Sut = Liste.Rows[ii].Cells[5].Value.ToString();
                    uAlt.SutFiyat = Convert.ToDecimal(Liste.Rows[ii].Cells[6].Value);
                    uAlt.SutAciklama = Liste.Rows[ii].Cells[7].Value != null
                        ? Liste.Rows[ii].Cells[7].Value.ToString()
                        : "";

                    uAlt.Ubb = Liste.Rows[ii].Cells[4].Value.ToString();
                    uAlt.UTS = Convert.ToBoolean(Liste.Rows[ii].Cells[8].Value);
                    uAlt.Uid = int.Parse(TxtUrunId.Text);
                    uAlt.UIKodu = TxtUrunKodu.Text;
                    ii++;
                }
            }

            tblUrunKayitAlt[] yeni = new tblUrunKayitAlt[Liste.RowCount].ToArray();
            for (int i = 0; i < Liste.RowCount; i++)
            {
                if ((bool) Liste.Rows[i].Cells[9].Value == true)
                {
                    yeni[i] = new tblUrunKayitAlt();
                    yeni[i].Aciklama = TxtAciklamaTr.Text;
                    yeni[i].Birimfiyat = Convert.ToDecimal(TxtBirimFiyat.Text);
                    yeni[i].BransAdi = "";
                    yeni[i].GMDMKodu = Liste.Rows[i].Cells[0].Value.ToString();
                    yeni[i].UMSPCKodu = Liste.Rows[i].Cells[1].Value.ToString();
                    yeni[i].KullanimDisi = Convert.ToBoolean(Liste.Rows[i].Cells[3].Value);
                    yeni[i].SB = Convert.ToBoolean(Liste.Rows[i].Cells[2].Value);
                    yeni[i].MinFiyat = Convert.ToDecimal(TxtMinFiyat.Text);
                    yeni[i].ParaBirimi = TxtParaBirimi.Text;
                    yeni[i].Sinif = TxtSinif.Text;
                    yeni[i].Sut = Liste.Rows[i].Cells[5].Value.ToString();
                    yeni[i].SutFiyat = Convert.ToDecimal(Liste.Rows[i].Cells[6].Value);
                    yeni[i].SutAciklama = Liste.Rows[i].Cells[7].Value != null
                        ? Liste.Rows[i].Cells[7].Value.ToString()
                        : "";
                    yeni[i].Ubb = Liste.Rows[i].Cells[4].Value.ToString();
                    yeni[i].UTS = Convert.ToBoolean(Liste.Rows[i].Cells[8].Value);
                    yeni[i].Uid = int.Parse(TxtUrunId.Text);
                    yeni[i].UIKodu = TxtUrunKodu.Text;
                    _db.tblUrunKayitAlt.Add(yeni[i]);
                }
            }

            _db.SaveChanges();

        } 
        private void BtnAddListeRow_Click(object sender, EventArgs e)
        {
            Liste.AllowUserToAddRows = Liste.AllowUserToAddRows != true;


            if (Liste.AllowUserToAddRows == true)
            {
                var srg = Liste.RowCount;
                if (Liste.CurrentRow != null) Liste.CurrentRow.Cells[9].Value = true;
            }
        }

        private void BtnRowsDelete_Click(object sender, EventArgs e)
        {
            if (secimId<0)
            {
                MessageBox.Show("Once kayit secin!");
                return;
            }


            tblUrunKayitAlt[] alt = new tblUrunKayitAlt[Liste.RowCount];
            int say = 0;
            for (int i = 0; i < Liste.RowCount; i++)
            {
                if ((bool)Liste.Rows[i].Cells[9].Value == true)  // (bool) cast işlemi
                {
                    var srg = _db.tblUrunKayitAlt.Find(Liste.Rows[i].Cells[10].Value);         // Find sadece Id lerle calısır.
                    _db.tblUrunKayitAlt.Remove(srg);
                    
                    say++;
                }

            }

            try
            {
                if (say == 0)
                {
                    MessageBox.Show("silinecek satir yok. silmek istediginiz satiri Durum hücresini işaretleyiniz.");
                    return;

                }

                if (_db.SaveChanges() > 0)     // Save changes metodu üzerine gelindiği anda bir kod blogunu tetikleyecek. Geri değer döndüren bir metod ve int tipinde değer döndürecek.
                {
                    MessageBox.Show("Satir silme islemi yapildi");
                    UrunAc(int.Parse(TxtUrunId.Text));
                }
                else
                {
                    MessageBox.Show("Islem bilinmeyen sebepten oturu yapilamadi.");
                }
            }
            catch (SqlException ex)
            {

                MessageBox.Show(ex.Message + "Sql- Silme Islemi bilinmeyen bir sebepten oturu yapilmadi");
            }

            catch (Exception exx)
            {

                MessageBox.Show(exx.Message + "C#- Silme Islemi bilinmeyen bir sebepten oturu yapilmadi");
            }

        }

        private void BtnSil_Click(object sender, EventArgs e)
        {
            var srg = _db.tblUrunKayitUst.Find(int.Parse(EtiketId.Text));
            var uid = _db.tblUrunKayitAlt.Where(s=>s.Uid==srg.Uid);
            _db.tblUrunKayitUst.Remove(srg);
            _db.tblUrunKayitAlt.RemoveRange(uid);

            try
            {
                if (_db.SaveChanges() > 0)
                {
                    MessageBox.Show("Satir silme islemi yapildi");
                    Close();
                }
            }
            catch (SqlException ex)
            {

                MessageBox.Show(ex.Message + "Sql- Silme Islemi bilinmeyen bir sebepten oturu yapilmadi");
            }

            catch (Exception exx)
            {

                MessageBox.Show(exx.Message + "C#- Silme Islemi bilinmeyen bir sebepten oturu yapilmadi");
            }

        }
    }

}

    
   

