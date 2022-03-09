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
using IEA_ErpProject.Entity.Code;

namespace IEA_ErpProject.KonsinyeIslemleri.Giris
{
    public partial class KonsinyeGonderim : Form
    {
        public bool Secim = false;

        private  ErpPro102SEntities _db;

        private  ErpProContext _code;

        private string[] MyArray { get; set; }

        public KonsinyeGonderim()
        {
            InitializeComponent();
        }

        public KonsinyeGonderim(ErpProContext code,ErpPro102SEntities db)  // dependcy injecetion
        {
            _code = code;    // _code artık bu alanda ki database classlarına ulasabılıyorum.
            _db = db;
            InitializeComponent();
        }

        private void KonsinyeGiris_Load(object sender, EventArgs e)
        {
            MyArray = _db.tblUrunKayitUst.Select(x => x.UrunKodu).Distinct().ToArray(); //linq
        }

        private void BtnKaydet_Click(object sender, EventArgs e)
        {
            YeniKayit();
        }

        private void YeniKayit()
        {
            Liste.AllowUserToAddRows = false;

            tblKonsinyeGonderim[] kon = new tblKonsinyeGonderim[Liste.RowCount];

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
                kon[i].CreatedDate = DateTime.Now;
                kon[i].UpdatedDate = DateTime.Now;
                kon[i].CreatedUser = 1;
                kon[i].UpdatedUser = 1;
                kon[i].isDeleted = false;
                kon[i].CariId = 1.ToString();

            }

            _code.TblKonsinyeGonderimler.AddRange(kon);
            _code.SaveChanges();


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
    }
}
