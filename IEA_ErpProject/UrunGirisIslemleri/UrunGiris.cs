using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
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
        
        private  string[] MyArray { get; set; }  // MyArray adında bir property tanimladik.


        public UrunGiris()
        {
            InitializeComponent();
        }

        private void UrunGiris_Load(object sender, EventArgs e)
        {
            MyArray = _db.tblUrunKayitUst.Select(x => x.UrunKodu).Distinct().ToArray();
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
            MessageBox.Show("Islem calisiyor.");
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

        private void Liste_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            try
            {
                TextBox txt = e.Control as TextBox; // amacım daagridview in kontrollerine ulaşıp textbox özelliklerini çalıştırmak.
                if (Liste.CurrentCell.ColumnIndex==3 && txt != null) //UrunId 3. Indexde yer alıyor.
                {
                    txt.AutoCompleteMode = AutoCompleteMode.SuggestAppend; //
                    txt.AutoCompleteSource = AutoCompleteSource.CustomSource; // Kaynak tipini soruyor.
                    txt.AutoCompleteCustomSource.AddRange(MyArray);   // Dışarıdan vereceğim veri kaynanığının ne oldugunu bana soruyor.



                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
                throw;
            }
        }

        private void Liste_CellEndEdit(object sender, DataGridViewCellEventArgs e)
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
                            //string barkod = ukod + "/" + lot;

                            var sonuc = _db.tblStokDurum
                               .Where(x => x.UrunKodu == ukod && x.LotSeriNo == lot).Select(s=>s.Id).ToList(); // Burda ki id yi alıp cell de ki urunid ye kayıt edecez.

                            //var sonuc = _db.tblStokDurum.FirstOrDefault(x => x.Barkod == barkod).Id;

                            //var sonuc1 = (from s in _db.tblStokDurum where s.Barkod == barkod select s).First();

                            //int idd = sonuc1.Id;

                            if (sonuc.Count>0)
                            {
                                Liste.CurrentRow.Cells[7].Value = sonuc[0];

                            }

                            else
                            {
                                Liste.CurrentRow.Cells[7].Value = 0;
                            }

                            
                        }
                    }
                }
            }             
        }
    }
}
