using IEA_ErpProject.Entity;
using IEA_ErpProject.Fonksiyonlar;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IEA_ErpProject.BilgiGiris.Hastaneler
{
    public partial class HastanelerListesi : Form
    {

        private readonly IEA_ErpProject.Entity.ErpPro102SEntities _db = new Entity.ErpPro102SEntities(); // bu _db yazdıktan sonra tablolarıma ulaşabilmemi sağlayacak.
        private List<tblHastaneler> hstList;    // hstList adlı bir tablo oluştur ama türü tblHastaneler olsun.
        private int secimId = -1;
        public bool Secim = false;
        Formlar f = new Formlar();

        public HastanelerListesi()
        {
            InitializeComponent();
        }

        private void HastanelerListesi_Load(object sender, EventArgs e)
        {
            Listele();
        }

        private void Listele()
        {
            Liste.Rows.Clear();   // Bütün satırları temizliyor.

            int i = 0, sira = 1;

            hstList = (from s in _db.tblHastaneler where s.Adi.Contains(TxtHastaneAra.Text) select s).ToList();           // linq sorguları fromla başlıyor.(linq sql de ki temel select* from işlemini yapıyor.) _db database e bağlanacağım tablonun ismi. Bu işlem db ye gidip bir liste alacak.Bu sorgu s adında nesne türetip bütün bilgileri s nin içine atıyor

            foreach (var item in hstList)
            {
                Liste.Rows.Add();
                Liste.Rows[i].Cells[0].Value = sira;   // row 0 ın 0. cell inde Value si itemden gelen
                Liste.Rows[i].Cells[1].Value = item.Id;
                Liste.Rows[i].Cells[2].Value = item.Adi;
                Liste.Rows[i].Cells[3].Value = item.tblHastaneTipleri.TipAdi;
                Liste.Rows[i].Cells[4].Value = item.Tel;
                Liste.Rows[i].Cells[5].Value = item.Sehirler.name;              // Kodu yazarken dataGrid de ki columb lara verdiğimiz isime bakıp yapacağız.  

                i++;
                sira++;



            }

            Liste.AllowUserToAddRows = false; // iş bittikten sonra kullanıcı yeni bir satır ekleyemesin.
            Liste.AllowUserToDeleteRows = false; // kullanıcı bir kaydı silemesin.
            Liste.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            Liste.ReadOnly = true; // Burası sadece okunur olsun değiştirilemesin anlamına gelir.






        }

        private void Liste_DoubleClick(object sender, EventArgs e)
        {
            if (Liste.CurrentRow != null) secimId = (int?)
            Liste.CurrentRow.Cells[1].Value ?? -1;
           
            if (secimId>0 )
            {
                if (Application.OpenForms["HastaneGiris"] == null && Application.OpenForms["Urungiris"]==null)
                {
                    AnaSayfa.Aktarma = secimId;
                    Close();
                    f.HastaneGirisAc(secimId); 
                }
                else if (Application.OpenForms["UrunGiris"] != null)
                {
                    AnaSayfa.Aktarma = secimId;
                    Close();
                }



            }                     // tıkladığımda hangi satır seçiliyse currentRow kullanırız.
                                  // Eğer normal bir değer gelirse burdaki değeri al int e cevir , eger null gelirse -1 yaz.
                                    
            else if (Application.OpenForms["HastaneGiris"]!=null)
            {
                HastaneGiris frm = Application.OpenForms["HastaneGiris"] as HastaneGiris;  // Acık olan formdan bilgileri al frm nin içerisine getir.
                
                frm.Ac(secimId);
                Close();
            }
        
        }

        private void BtnHastaneAra_Click(object sender, EventArgs e)
        {
            Listele();
        }
    }
}
