using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using IEA_ErpProject.Entity;
using IEA_ErpProject.Fonksiyonlar;
using IEA_ErpProject.Properties;

namespace IEA_ErpProject.UrunGirisIslemleri
{
    public partial class UrunGiris : Form
    {
        private readonly Formlar f = new Formlar();
        private readonly ErpPro102SEntities _db = new ErpPro102SEntities(); // 1.Aşama

        private readonly Numaralar _n = new Numaralar();
        private int girisId = -1;

        private List<tblUrunGirisAlt> altlst = new List<tblUrunGirisAlt>();

        private  string[] MyArray { get; set; }  // MyArray adında bir property tanimladik.


        public UrunGiris()
        {
            InitializeComponent();
        }

        private void UrunGiris_Load(object sender, EventArgs e)
        {

            TxtGirisId.Text = _n.UGirisNo();
            MyArray = _db.tblUrunKayitUst.Select(x => x.UrunKodu).Distinct().ToArray(); //linq


        }

        private void ComboDoldur()
        {

            //TxtUrunKodlari.DataSource = _db.tblUrunKayitUst.Select(x => x.UrunKodu).Distinct().ToList(); // yukarıdan gelen UrunKod value string ama altta ki Urunkod  int bir değer beklediği için altta kini yorum satırı yaptik.

            //// TxtUrunKodlari.ValueMember = "Id";
            
            //TxtUrunKodlari.DisplayMember = "UrunKodu";  // combobox da neleri göstericeksen onu seçiyoruz
            //TxtUrunKodlari.SelectedIndex = -1;

            

            ////int dgv; // DataGridView in bas harfleri(dgv)
            ////dgv = TxtUrunKodlari.Items.Count; // Arrayler boyutsuz tanımlanamazlar
            //MyArray = new string[TxtUrunKodlari.Items.Count];  // yukarıdakileri yorum satırı yaptık çünkü, int dgv sizde aynı işlemi yapabiliyoruz.

            //for (int i = 0; i < TxtUrunKodlari.Items.Count; i++)
            //{
            //    MyArray[i] = TxtUrunKodlari.Items[i].ToString();
            //}

        }

        private void
            TxtCariTur_SelectedIndexChanged(object sender,
                EventArgs e) // combobox ın içinde hastane secilirse ne yapmnası gerektiğini soylıcek
        {
            //switch (TxtCariTur.Text)
            //{

            //    case "Hastane":
            //        TxtCariAdi.Text = "Acibadem";
            //        break;
            //    case "Doktor":
            //        TxtCariAdi.Text = "İsmail Gundogan";
            //        break;
            //    case "Personel":
            //        TxtCariAdi.Text = "Efe";
            //        break;
            //    case "Firma":
            //        TxtCariAdi.Text = "Google";
            //        break;
            //    case "Diger":
            //        TxtCariAdi.Text = "Bilmiyoz";
            //        break;
            //}
        }

        

        public void UrunAc(int secimId) // internal aynı projelerin içerisinde gözükebilir farklı bir projede tanımlanamaz
        {
            girisId = secimId;
            var srg = _db.tblUrunGirisUst.FirstOrDefault(x => x.GirisId == secimId);

            if (srg != null)
            {
                TxtGirisId.Text = srg.GirisId.ToString().PadLeft(7,'0');
                TxtCariTur.Text = srg.CariTip;
                TxtCariAdi.Text = srg.CariAdi;
                TxtGirisTuru.Text = srg.GirisTuru;
                TxtFaturaNo.Text = srg.FaturaNo;
                TxtGirisTarih.Text = srg.GirisTarih.ToString();
                TxtAciklama.Text = srg.Aciklama;
                

            }

            else
            {
                MessageBox.Show("Istek sirasinda bir sorun oldu tekrar deneyiniz");
                return;
            }
            
            Liste.Rows.Clear();
            Liste.AllowUserToAddRows = false;
            
            altlst = _db.tblUrunGirisAlt.Where(s => s.GirisId == secimId).ToList();

            for (int i = 0; i < altlst.Count; i++)
            {
                Liste.Rows.Add();

                Liste.Rows[i].Cells[0].Value = altlst[i].Id;
                Liste.Rows[i].Cells[1].Value = i + 1;
                Liste.Rows[i].Cells[2].Value = altlst[i].Barkod;
                Liste.Rows[i].Cells[3].Value = altlst[i].UrunKodu;
                Liste.Rows[i].Cells[4].Value = altlst[i].LotSeriNo;
                Liste.Rows[i].Cells[5].Value = altlst[i].GirisAdet;
                Liste.Rows[i].Cells[6].Value = altlst[i].Aciklama;
                Liste.Rows[i].Cells[7].Value = altlst[i].GirisId;
                Liste.Rows[i].Cells[8].Value = altlst[i].UtsDurum;
                Liste.Rows[i].Cells[9].Value = altlst[i].UTarih;
                Liste.Rows[i].Cells[10].Value = altlst[i].SKTarih;
                Liste.Rows[i].Cells[11].Value = false;
            }

        }

        protected override void OnLoad(EventArgs e)
        {

            var btnGiris = new Button();
            btnGiris.Size = new Size(22, TxtGirisId.ClientSize.Height);
            btnGiris.Location = new Point(TxtGirisId.ClientSize.Width - btnGiris.Width - 1);
            btnGiris.Cursor = Cursors.Default;
            btnGiris.BackgroundImage = Resources.Ara32x32;
            btnGiris.BackgroundImageLayout = ImageLayout.Stretch;
            btnGiris.Anchor = (AnchorStyles.Top | AnchorStyles.Right);
            TxtGirisId.Controls.Add(btnGiris);


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
            btnGiris.Click += btnGiris_Click;
        }

        private void btnGiris_Click(object sender, EventArgs e)
        {
            int id = f.UrunGirisListesiAc(true);
            if (id > 0)
            {
                UrunAc(id);

            }

            AnaSayfa.Aktarma = -1;
        }

        private void btn_Click(object sender, EventArgs e)
        {
            int CariId = -1;
            switch (TxtCariTur.Text)
            {
                case "Hastane":
                    CariId = f.HastanelerListesiAc(true);
                    if (CariId > 0)
                    {
                        HastaneAc(CariId);
                    }
                    break;
                case "Doktor":
                    CariId = f.DoktorlarListesiAc(true);
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
                    CariId = f.FirmalarListesiAc(true);
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

        private void FirmaAc(int cariId)
        {
            TxtCariAdi.Text = _db.tblFirmalar.FirstOrDefault(s => s.Id == cariId)?.Adi;
        }

        private void HastaneAc(int cariId)
        {
            TxtCariAdi.Text = _db.tblHastaneler.FirstOrDefault(s => s.Id == cariId)?.Adi;
        }

        private void DoktorAc(int id)
        {
            TxtCariAdi.Text = _db.tblDoktorlar.FirstOrDefault(s => s.Id == id)?.Adi;
        }

        private void BtnKapat_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Liste_EditingControlShowing(object sender,    DataGridViewEditingControlShowingEventArgs e)
        {
            try                // SOR ULAN BURAYI *************************************
            {
                //TextBox txt = e.Control as TextBox; // amacım daagridview in kontrollerine ulaşıp textbox özelliklerini çalıştırmak.
                if (Liste.CurrentCell.ColumnIndex==3 && e.Control is TextBox txt) //UrunId 3. Indexde yer alıyor.
                {
                    txt.AutoCompleteMode = AutoCompleteMode.SuggestAppend; //
                    txt.AutoCompleteSource = AutoCompleteSource.CustomSource; // Kaynak tipini soruyor.
                    txt.AutoCompleteCustomSource.AddRange(MyArray);   // Dışarıdan vereceğim veri kaynanığının ne oldugunu bana soruyor.



                }
                else if (Liste.CurrentCell.ColumnIndex != 3 && e.Control is TextBox txt1)
                {
                    txt1.AutoCompleteMode = AutoCompleteMode.None;
                }


            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
                throw;
            }
        }

        private void Liste_CellEndEdit(object sender, DataGridViewCellEventArgs e)  // BUNU BIR SOR???
        {
            if (e.ColumnIndex==4)             // 3 ve 4. hücre arasinda islem yapicaz.
            {
                foreach (DataGridViewCell cell in Liste.SelectedCells)
                {
                    if (cell.Value != null)
                    {
                        if (Liste.CurrentRow != null)
                        {
                            string ukod = Liste.CurrentRow.Cells[3].Value.ToString();
                            string lot = Liste.CurrentRow.Cells[4].Value.ToString();
                            string barkod = ukod + "/" + lot;
                            Liste.CurrentRow.Cells[2].Value = barkod;


                            var sonuc = _db.tblStokDurum
                               .Where(x => x.UrunKodu == ukod && x.LotSeriNo == lot).Select(s=>s.Id).ToList(); // Burda ki id yi alıp cell de ki urunid ye kayıt edecez.

                            //var sonuc = _db.tblStokDurum.FirstOrDefault(x => x.Barkod == barkod).Id;

                            //var sonuc1 = (from s in _db.tblStokDurum where s.Barkod == barkod select s).First();

                            //int idd = sonuc1.Id;

                            if (sonuc.Count>0)
                            {
                                Liste.CurrentRow.Cells[7].Value = sonuc[0]; // 0 ı bi sor hele

                            }

                            else
                            {
                                Liste.CurrentRow.Cells[7].Value = 0;
                            }

                            
                        }
                    }
                }
            }

            if (e.ColumnIndex==9)
            {
                if (Liste.CurrentRow.Cells[9].Value != null || Liste.CurrentRow.Cells[9].Value.ToString()!="")
                {

                    var ukod = Liste.CurrentRow.Cells[3].Value.ToString();
                    var lst = (from s in _db.tblUrunKayitUst
                        where s.UrunKodu == ukod
                        select s.KullanimSuresi).FirstOrDefault();  // lst içerisine kullanim suresi bilgisini aldım


                    try
                    {
                        

                        if (lst != null)
                        {
                            DateTime ay = Convert.ToDateTime(Liste.CurrentRow.Cells[9].Value.ToString());
                            Liste.CurrentRow.Cells[10].Value = ay.AddMonths(Convert.ToInt32(lst)).ToShortDateString();
                        }

                        else
                        {
                            Liste.CurrentRow.Cells[10].Value = "01.01.0001";
                        }

                    }
                    catch (Exception exx)
                    {
                        MessageBox.Show("Lutfen girilen tarihi kontrol edin \n Ornek : 30.12.2022 ");
                        Liste.CurrentRow.Cells[9].Value = "";
                        return;
                    }
                }
            }
        }

        private void BtnKaydet_Click(object sender, EventArgs e)
        {
            YeniKaydet();
        }

        private void YeniKaydet()
        {
            tblUrunGirisUst ust = new tblUrunGirisUst();
            ust.CariAdi = TxtCariAdi.Text;
            if (TxtCariTur.Text == "Doktor")
            {
                ust.CariId = _db.tblDoktorlar.FirstOrDefault(x => x.Adi == TxtCariAdi.Text).Id;

            }

            else if (TxtCariTur .Text == "Hastane")
            {
                ust.CariId = _db.tblHastaneler.FirstOrDefault(x => x.Adi == TxtCariAdi.Text).Id;
            }

            else if (TxtCariTur.Text == "Firma")
            {
                ust.CariId = _db.tblFirmalar.FirstOrDefault(x => x.Adi == TxtCariAdi.Text).Id;
            }

            else
            {
                ust.CariId = -1;
            }

            ust.CariTip = TxtCariTur.Text;
            ust.CreatedDate = DateTime.Now;
            ust.CreatedUser = -1;
            ust.FaturaNo = TxtFaturaNo.Text;
            ust.GirisId = int.Parse(TxtGirisId.Text);
            ust.GirisTarih = TxtGirisTarih.Value;
            ust.GirisTuru = TxtGirisTuru.Text;
            ust.UpdateDate = DateTime.Now;
            ust.UpdateUser = -1;
            ust.IsDeleted = false;
            ust.Aciklama = TxtAciklama.Text;

            _db.tblUrunGirisUst.Add(ust);
            _db.SaveChanges();

            Liste.AllowUserToAddRows = false; // Aşşağıda bir satır acıkda kalmasını engellemiş olduk.
           
            tblUrunGirisAlt[] alts = new tblUrunGirisAlt[Liste.RowCount]; // Burada array oluşturuyoruz çünkü veriler alttan her biri ayrı bir columb halinde bulunduğu için hepsini bir array içine ekleyip oradan çağırıyoruz.

            // Islem trigger a yonlendirildiginden bu kod kapatıldı.

            tblStokDurum[] durums = new tblStokDurum[Liste.RowCount];

            




            for (int i = 0; i < Liste.RowCount; i++)    
            {



                #region Trigger a yaptırılan StokDurum kaydi bilgileri
                //if (Convert.ToInt32(Liste.Rows[i].Cells[7].Value)==0) //== 0  durumu bi kayıt yok bi kayit yapmalıyız anlamına gelir. 0 sa yeni kayıt anlamı gelir.
                //{
                //    durums[i] = new tblStokDurum();
                //    durums[i].UrunKodu = Liste.Rows[i].Cells[3].Value.ToString();
                //    durums[i].Barkod = Liste.Rows[i].Cells[2].Value.ToString();
                //    durums[i].BransNo = "";
                //    durums[i].KonsinyeAdet = 0;
                //    durums[i].LotSeriNo = Liste.Rows[i].Cells[4].Value.ToString();
                //    durums[i].RafAdet = Convert.ToInt32(Liste.Rows[i].Cells[5].Value.ToString());
                //    durums[i].StokAdet = Convert.ToInt32(Liste.Rows[i].Cells[5].Value.ToString());
                //    durums[i].SKTarih= Convert.ToDateTime(Liste.Rows[i].Cells[10].Value.ToString());
                //    durums[i].SubeAdet = 0;
                //    durums[i].SutKodu = "";
                //    durums[i].UTarih = Convert.ToDateTime(Liste.Rows[i].Cells[9].Value.ToString());
                //    durums[i].Uts = Convert.ToBoolean(Liste.Rows[i].Cells[8].Value);
                //    durums[i].UrunHareketAdet = 0;

                //    _db.tblStokDurum.Add(durums[i]);


                //}

                //else
                //{
                //    var urunId = Convert.ToInt32(Liste.Rows[i].Cells[7].Value);
                //    var srg = _db.tblStokDurum.FirstOrDefault(s => s.Id == urunId);
                //    srg.StokAdet += Convert.ToInt32(Liste.Rows[i].Cells[5].Value);
                //    srg.RafAdet += Convert.ToInt32(Liste.Rows[i].Cells[5].Value);

                //} 
                #endregion



                alts[i] = new tblUrunGirisAlt();
                alts[i].Barkod = Liste.Rows[i].Cells[2].Value.ToString();
                alts[i].UrunKodu = Liste.Rows[i].Cells[3].Value.ToString();
                alts[i].LotSeriNo = Liste.Rows[i].Cells[4].Value.ToString();
                alts[i].GirisAdet = Convert.ToInt32(Liste.Rows[i].Cells[5].Value);
                alts[i].Aciklama = Convert.ToString(Liste.Rows[i].Cells[6].Value);
                alts[i].BransNo = "";
                alts[i].UtsDurum = Convert.ToBoolean(Liste.Rows[i].Cells[8].Value);
                alts[i].UTarih = Convert.ToDateTime(Liste.Rows[i].Cells[9].Value);
                alts[i].SKTarih = Convert.ToDateTime(Liste.Rows[i].Cells[10].Value);
                alts[i].GirisId = int.Parse(TxtGirisId.Text);
                alts[i].GirisTarih = TxtGirisTarih.Value;
                
                
                
                

                
            }


            _db.tblUrunGirisAlt.AddRange(alts);
            _db.SaveChanges();
            MessageBox.Show("Bilgiler Kayit Edildi.");
            Temizle();

        }

        private void Temizle()
        {
            foreach (Control item in SpcUrunGiris.Panel2.Controls)
            {
                if (item is TextBox || item is ComboBox || item is DateTimePicker ) // Datetime ın default parametleri içerisinde bugün tanımlı
                {
                    item.Text = "";
                }
            }

            TxtGirisId.Text = _n.UGirisNo();
            Liste.Rows.Clear();



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
            if (girisId == -1)
            {
                MessageBox.Show("Guncelle icim secim yapiniz.");
                return;
            }


            var srg = _db.tblUrunGirisUst.FirstOrDefault(x => x.GirisId == girisId);

            srg.GirisId = int.Parse(TxtGirisId.Text);
            srg.CariTip = TxtCariTur.Text;
            srg.CariAdi = TxtCariAdi.Text;
            srg.GirisTuru = TxtGirisTuru.Text;
            srg.FaturaNo = TxtFaturaNo.Text;
            srg.GirisTarih = TxtGirisTarih.Value;
            srg.Aciklama = TxtAciklama.Text;

            _db.SaveChanges();

            var lst = (from s in _db.tblUrunGirisAlt where s.GirisId == girisId select s).ToList();

           

            for (int i = 0; i < Liste.RowCount; i++)
            {
                if ((bool)Liste.Rows[i].Cells[11].Value ==false)
                {

                    string newBarkod= Liste.Rows[i].Cells[3].Value.ToString() + "/" +Liste.Rows[i].Cells[4].Value
                        .ToString();

                    var stk = _db.tblStokDurum.FirstOrDefault(s => s.Barkod == Liste.Rows[i].Cells[4].Value.ToString());

                    //stk.Barkod = newBarkod;
                    //stk.UrunKodu= Liste.Rows[i].Cells[3].ToString();  
                    //stk.LotSeriNo= Liste.Rows[i].Cells[4].ToString();
                    var adet = altlst[i].GirisAdet-Convert.ToInt32(Liste.Rows[i].Cells[5].Value);

                    // Eski kayıt : 100 yeni kayit : 80 = +20 
                    // Eski 100 yeni 120 = -20
                    stk.StokAdet -= adet;
                    stk.RafAdet -= adet;

                    


                    lst[i].Barkod = Liste.Rows[i].Cells[2].Value.ToString();
                    lst[i].UrunKodu = Liste.Rows[i].Cells[3].ToString();
                    lst[i].LotSeriNo = Liste.Rows[i].Cells[4].ToString();
                    lst[i].GirisAdet = Convert.ToInt32(Liste.Rows[i].Cells[5].Value);
                    lst[i].Aciklama = Liste.Rows[i].Cells[6].Value.ToString();
                    lst[i].GirisTarih = TxtGirisTarih.Value;
                    lst[i].BransNo = "";
                    lst[i].UtsDurum = Convert.ToBoolean(Liste.Rows[i].Cells[8].Value);
                    lst[i].UTarih = Convert.ToDateTime(Liste.Rows[i].Cells[9].Value);
                    lst[i].SKTarih = Convert.ToDateTime(Liste.Rows[i].Cells[10].Value);
                    

                    


                }

                else
                {
                    lst.Add(null);
                    lst[i] = new tblUrunGirisAlt();
                    lst[i].GirisId = Convert.ToInt32(TxtGirisId);
                    lst[i].Barkod = Liste.Rows[i].Cells[2].Value.ToString();
                    lst[i].UrunKodu = Liste.Rows[i].Cells[3].Value.ToString();
                    lst[i].LotSeriNo = Liste.Rows[i].Cells[4].Value.ToString();
                    lst[i].GirisAdet = Convert.ToInt32( Liste.Rows[i].Cells[5].Value.ToString());
                    lst[i].Aciklama = Liste.Rows[i].Cells[6].Value.ToString();
                    lst[i].GirisTarih = TxtGirisTarih.Value;
                    lst[i].BransNo = "";
                    lst[i].UtsDurum = Convert.ToBoolean(Liste.Rows[i].Cells[8].Value);
                    lst[i].UTarih = Convert.ToDateTime(Liste.Rows[i].Cells[9].Value);
                    lst[i].SKTarih = Convert.ToDateTime(Liste.Rows[i].Cells[10].Value);

                    _db.tblUrunGirisAlt.Add(lst[i]);






                }

            }

            _db.SaveChanges();
        }

        private void BtnAddListeRow1_Click(object sender, EventArgs e)
        {
            Liste.AllowUserToAddRows = Liste.AllowUserToAddRows != true;


            if (Liste.AllowUserToAddRows == true)
            {
                var srg = Liste.RowCount;
                if (Liste.CurrentRow != null) Liste.CurrentRow.Cells[11].Value = true;
            }
        }
    }
}
