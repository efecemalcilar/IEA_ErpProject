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
using ProjeAtHome.Properties;

namespace ProjeAtHome.BilgiGiris.Urunler
{
    public partial class UrunKayit : Form
    {
        private readonly ErpPro102SEntities2 _db = new ErpPro102SEntities2();
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
                "Jpg(*.jpg)|*.jpg|Jpeg(*.jpeg)|*.jpeg";

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

        private void BtnFirma_Click(object sender, EventArgs e)
        {
            int id = f.FirmalarListesiAc(true);
            if (id > 0)
            {
                FirmaAc(id);

            }

            AnaSayfa1.Aktarma = -1;
        }

        private void FirmaAc(int id)
        {
            int cariId = id;

            tblFirmalar frm = _db.tblFirmalar.First(s => s.Id == cariId);
            TxtFirmaAdi.Text = frm.Adi;
        }

        private void BtnUrun_Click(object sender, EventArgs e)
        {
            int id = f.UrunKayitListesiAc(true);

            if (id > 0)
            {
                UrunAc(id);
            }

            AnaSayfa1.Aktarma = -1;

        }

        public void UrunAc(int uid)
        {
            Temizle();
            secimId = uid;
            Liste.AllowUserToAddRows = false;

            tblUrunKayitUst lst = _db.tblUrunKayitUst.FirstOrDefault(s => s.Uid == uid);

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
                pbResim.Image = r.ResimGetirme(lst.Resim);

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

        }

        private void Temizle()
        {
            foreach (Control item in SpcUrunKayit.Panel1.Controls)
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
            TxtUrunId.Text = n.Uidno();
        }

        private void BtnKaydet_Click(object sender, EventArgs e)
        {
            YeniKaydet();
        }

        private void YeniKaydet()
        {
            Liste.AllowUserToAddRows = false;
            if (TxtUrunId.Text == "" || TxtUrunKodu.Text == "" || TxtFirmaKodu.Text == "")
            {
                MessageBox.Show("Ilgili alanlari doldurunuz !");
                Liste.AllowUserToAddRows = true;
                return;

            }

            tblUrunKayitUst ust = new tblUrunKayitUst();

            ust.AciklamaEng = TxtAciklamaEng.Text;
            ust.AciklamaTr = TxtAciklamaTr.Text;
            ust.GirisTarih = TxtTarih.Value;
            ust.FirmaId = int.Parse(TxtFirmaKodu.Text);

            if (pbResim.Image != null)
                ust.Resim = new System.Data.Linq.Binary(r.ResimYukle(pbResim.Image)).ToArray();

            ust.Uid = int.Parse(TxtUrunId.Text);
            ust.UrunKodu = TxtUrunKodu.Text;
            ust.KullanimSuresi = int.Parse(TxtSure.Text);

            _db.tblUrunKayitUst.Add(ust);

            tblUrunKayitAlt[] alt = new tblUrunKayitAlt[Liste.RowCount];

            for (int i = 0; i < Liste.RowCount; i++)
            {
                alt[i] = new tblUrunKayitAlt();
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

            MessageBox.Show("Kayit Islemi Gerceklesti");
            Temizle();

        }
    }
}
