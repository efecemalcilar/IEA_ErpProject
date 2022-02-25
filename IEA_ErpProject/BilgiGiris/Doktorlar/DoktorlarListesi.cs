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

namespace IEA_ErpProject.BilgiGiris.Doktorlar
{
    public partial class DoktorlarListesi : Form
    {
        private int secimId = -1;
        Formlar f = new Formlar();
        private List<tblDoktorlar> dktList;
        private readonly Entity.ErpPro102SEntities _db = new Entity.ErpPro102SEntities();
        public bool Secim = false;

        public DoktorlarListesi()
        {
            InitializeComponent();
        }

        private void DoktorlarListesi_Load(object sender, EventArgs e)
        {
            listele();
        }

        private void listele()
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

        private void Liste_DoubleClick(object sender, EventArgs e)
        {
            if (Liste.CurrentRow != null) secimId = (int?)
            Liste.CurrentRow.Cells[1].Value ?? -1;

            if (secimId > 0 )
            {
                if (Application.OpenForms["DoktorGiris"] == null && Application.OpenForms["UrunGiris"]== null)
                {
                    AnaSayfa.Aktarma = secimId;
                    Close();
                    f.DoktorlarGirisAc(secimId);
                }

                else if (Application.OpenForms["UrunGiris"] != null)
                {
                    AnaSayfa.Aktarma = secimId;
                    Close();
                }
                
            }                     // tıkladığımda hangi satır seçiliyse currentRow kullanırız.
                                  // Eğer normal bir değer gelirse burdaki değeri al int e cevir , eger null gelirse -1 yaz.

            else if (Application.OpenForms["DoktorGiris"] != null)
            {
                DoktorGiris frm = Application.OpenForms["DoktorGiris"] as DoktorGiris;  // Acık olan formdan bilgileri al frm nin içerisine getir.

                frm.Ac(secimId);
                Close();
            }
        }
    }
}
