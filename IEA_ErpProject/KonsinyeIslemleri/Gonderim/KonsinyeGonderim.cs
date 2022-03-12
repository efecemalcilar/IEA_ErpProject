using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using IEA_ErpProject.Entity;
using IEA_ErpProject.Entity.Code;
using IEA_ErpProject.Fonksiyonlar;
using IEA_ErpProject.Properties;

namespace IEA_ErpProject.KonsinyeIslemleri.Giris
{
    public partial class KonsinyeGonderim : Form
    {
        public bool Secim = false;
        public int gondId = -1;

        private readonly ErpPro102SEntities _db;
        private readonly ErpProContext _code;
        private readonly Numaralar _n;
        private readonly Formlar _f;
        
        private string[] MyArray { get; set; }

        
        public KonsinyeGonderim()
        {
            InitializeComponent();
        }

        public KonsinyeGonderim(ErpProContext code,ErpPro102SEntities db,Numaralar n,Formlar f)  // dependcy injecetion
        {
            _f = f;
            _n = n;
            _code = code;    // _code artık bu alanda ki database classlarına ulasabılıyorum.
            _db = db;
            InitializeComponent();
        }

        private void KonsinyeGiris_Load(object sender, EventArgs e)
        {
            TxtKonGonderimId.Text = _n.KonGonderimNo();
            MyArray = _db.tblUrunKayitUst.Select(x => x.UrunKodu).Distinct().ToArray(); //linq
        }

        private void BtnKaydet_Click(object sender, EventArgs e)
        {
            YeniKayit();
        }

        private void YeniKayit()
        {
            Liste.AllowUserToAddRows = false;

            tblKonsinyeGonderim[] kon = new tblKonsinyeGonderim[Liste.RowCount]; // Arraylerin her zaman limitini belirlemek zorundasın.

            for (int i = 0; i < Liste.RowCount; i++)
            {
                kon[i] = new tblKonsinyeGonderim();
                
                kon[i].Aciklama = TxtKonGonderimAciklama.Text;
                kon[i].CariAdi = TxtCariAdi.Text;
                kon[i].Adet = Convert.ToInt32(Liste.Rows[i].Cells[6].Value);
                kon[i].CariTur = TxtCariTur.Text;
                kon[i].GonderimTarih = TxtKonGonderimTarih.Value;
                var brk = Liste.Rows[i].Cells[2].Value;
                kon[i].UrunId = _db.tblStokDurum.FirstOrDefault(s => s.Barkod == brk).Id;
                //kon[i].CreatedDate = DateTime.Now;
                //kon[i].UpdatedDate = DateTime.Now;
                //kon[i].CreatedUser = 1;
                //kon[i].UpdatedUser = 1;
                //kon[i].isDeleted = false;
                kon[i].CariId = 1.ToString();
                kon[i].GonderimId = int.Parse(_n.KonGonderimNo());


                var srgStok = _db.tblStokDurum.Find(kon[i].UrunId);
                srgStok.RafAdet -= Convert.ToInt32(Liste.Rows[i].Cells[6].Value);
                srgStok.KonsinyeAdet += Convert.ToInt32(Liste.Rows[i].Cells[6].Value);
                _db.SaveChanges();


            }

            _code.TblKonsinyeGonderimler.AddRange(kon);
            _code.SaveChanges();
            MessageBox.Show("Kayit islemi basarili");


        }

        public void KonGonderimAc(int id)
        {
            Liste.Rows.Clear();
            var srg = _code.TblKonsinyeGonderimler.Where(s => s.GonderimId == id).ToList();
            var srgStok = _db.tblStokDurum;
            
            
            if (srg.Count>0)
            {
                

                for (int i = 0; i < srg.Count; i++)
                {
                    Liste.Rows.Add();
                    Liste.Rows[i].Cells[0].Value = srg[i].Id;
                    Liste.Rows[i].Cells[1].Value = i + 1;

                    Liste.Rows[i].Cells[2].Value = _db.tblStokDurum.FirstOrDefault(s => s.Id == srg[i].UrunId)?.Barkod;
;                   Liste.Rows[i].Cells[3].Value = _db.tblStokDurum.FirstOrDefault(s => s.Id == srg[i].UrunId)?.UrunKodu;
                    Liste.Rows[i].Cells[4].Value = _db.tblStokDurum.FirstOrDefault(s => s.Id == srg[i].UrunId)?.LotSeriNo; 
                    Liste.Rows[i].Cells[5].Value = _db.tblStokDurum.FirstOrDefault(s => s.Id == srg[i].UrunId)?.RafAdet;
                    Liste.Rows[i].Cells[6].Value = srg[i].Adet;
                    Liste.Rows[i].Cells[7].Value = srg[i].Aciklama;
                    Liste.Rows[i].Cells[8].Value = srg[i].UrunId;
                    Liste.Rows[i].Cells[9].Value = srgStok.FirstOrDefault(s => s.Id == srg[i].UrunId)?.Uts;
                    Liste.Rows[i].Cells[10].Value = srgStok.FirstOrDefault(s => s.Id == srg[i].UrunId)?.UTarih;
                    Liste.Rows[i].Cells[11].Value = srgStok.FirstOrDefault(s => s.Id == srg[i].UrunId)?.SKTarih;
                    //Liste.Rows[i].Cells[12].Value = srg[i].TblStokDuru
                    TxtKonGonderimId.Text = srg[i].GonderimId.ToString();
                    TxtCariTur.Text = srg[i].CariTur;
                    TxtCariAdi.Text = srg[i].CariAdi;
                    TxtKonGonderimTarih.Text = srg[i].GonderimTarih.ToShortDateString();
                    TxtKonGonderimAciklama.Text = "";
                    //TxtKonGonderimTuru.Text = srg[i] //gonderimturunu ekle.
                    // Aciklama alani ekle 2 ayri alan olmali.

                }
            }

        }

        private void Liste_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            try              
            {
                
                if (Liste.CurrentCell.ColumnIndex == 3 && e.Control is TextBox txt) 
                {
                    txt.AutoCompleteMode = AutoCompleteMode.SuggestAppend; 
                    txt.AutoCompleteSource = AutoCompleteSource.CustomSource; 
                    txt.AutoCompleteCustomSource.AddRange(MyArray);   



                }
                else if (Liste.CurrentCell.ColumnIndex != 3 && e.Control is TextBox txt1)
                {
                    txt1.AutoCompleteMode = AutoCompleteMode.None;
                }

                if (Liste.CurrentCell.ColumnIndex ==4)
                {
                    LotBul bul = new LotBul();
                    bul.ShowDialog();
                }

            }
            catch (Exception ex)
            {
                
            }
        }

        private void Liste_SelectionChanged(object sender, EventArgs e)
        {
            if (Liste.CurrentCell.ColumnIndex == 4)
            {

                
                LotBul bul = new LotBul();
                if (Liste.CurrentRow.Cells[3].Value != null)
                {
                    bul.ukod = Liste.CurrentRow.Cells[3].Value.ToString();
                }
                
                
                bul.ShowDialog();

            }
        }


        protected override void OnLoad(EventArgs e)
        {

            var btnGonderim = new Button();
            btnGonderim.Size = new Size(22, TxtKonGonderimId.ClientSize.Height);
            btnGonderim.Location = new Point(TxtKonGonderimId.ClientSize.Width - btnGonderim.Width - 1);
            btnGonderim.Cursor = Cursors.Default;
            btnGonderim.BackgroundImage = Resources.Ara32x32;
            btnGonderim.BackgroundImageLayout = ImageLayout.Stretch;
            btnGonderim.Anchor = (AnchorStyles.Top | AnchorStyles.Right);
            TxtKonGonderimId.Controls.Add(btnGonderim);


            var btn = new Button();
            btn.Size = new Size(22, TxtCariAdi.ClientSize.Height);
            btn.Location = new Point(TxtCariAdi.ClientSize.Width - btn.Width - 1);
            btn.Cursor = Cursors.Default;
            btn.BackgroundImage = Resources.Ara32x32;
            btn.BackgroundImageLayout = ImageLayout.Stretch;
            btn.Anchor = (AnchorStyles.Top | AnchorStyles.Right);
            TxtCariAdi.Controls.Add(btn);

            base.OnLoad(e);
            btn.Click += btn_Click;
            btnGonderim.Click += btnGonderim_Click;
        }

        private void btn_Click(object sender, EventArgs e)
        {
            int CariId = -1;
            switch (TxtCariTur.Text)
            {
                case "Hastane":
                    CariId = _f.HastanelerListesiAc(true);
                    if (CariId > 0)
                    {
                        HastaneAc(CariId);
                    }
                    break;
                case "Doktor":
                    CariId = _f.DoktorlarListesiAc(true);
                    if (CariId > 0)
                    {
                        DoktorAc(CariId);
                    }
                    break;
                case "Personel":
                    //CariId = f.PersonellerListesiAc(true);
                    //if (CariId > 0)
                    //{
                    //    DoktorAc(CariId);
                    //}
                    TxtCariAdi.Text = "Yapim Asamasinda";
                    break;
                case "Firma":
                    CariId = _f.FirmalarListesiAc(true);
                    if (CariId > 0)
                    {
                        FirmaAc(CariId);
                    }
                    break;
                case "Diger":
                    TxtCariAdi.Text = "Bilinmiyor";
                    break;
            }
            AnaSayfa.Aktarma = -1;
        }

        private void DoktorAc(int cariId)
        {
            TxtCariAdi.Text = _db.tblDoktorlar.FirstOrDefault(s => s.Id == cariId)?.Adi;
        }

        private void FirmaAc(int cariId)
        {
            TxtCariAdi.Text = _db.tblFirmalar.FirstOrDefault(s => s.Id == cariId)?.Adi;
        }

        private void HastaneAc(int cariId)
        {
            TxtCariAdi.Text = _db.tblHastaneler.FirstOrDefault(s => s.Id == cariId)?.Adi;
        }

        private void btnGonderim_Click(object sender, EventArgs e)
        {
            int id = _f.KonsinyeGonderimListesiAc(true);

            if (id>0)
            {
                KonGonderimAc(id);

            }

            AnaSayfa.Aktarma = -1;
        }

        private void BtnSil_Click(object sender, EventArgs e)
        {
            Sil();
        }

        private void Sil()
        {
            //ilgili alanları silmesinin istiyoruz o yuzden foreach ile döndürebiliriz.

            if (gondId>0)
            {
                int i = 0;
                int gId = Convert.ToInt32(TxtKonGonderimId.Text);
                var srg = _code.TblKonsinyeGonderimler.Where(x => x.GonderimId == int.Parse(TxtKonGonderimId.Text))
                        .ToList();

                foreach (var item in srg)
                {
                    item.isDeleted = true;

                    var srgStok = _db.tblStokDurum.FirstOrDefault(x => x.Id == item.UrunId);
                    _code.SaveChanges();

                    srgStok.KonsinyeAdet -= Convert.ToInt32(Liste.Rows[i].Cells[6].Value);
                    srgStok.RafAdet += Convert.ToInt32(Liste.Rows[i].Cells[6].Value);



                    _db.SaveChanges();
                   
                }



            }
        }
    }
}
