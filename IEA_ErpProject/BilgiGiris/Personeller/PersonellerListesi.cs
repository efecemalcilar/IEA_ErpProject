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

namespace IEA_ErpProject.BilgiGiris.Personeller
{
    public partial class PersonellerListesi : Form
    {

        private readonly IEA_ErpProject.Entity.ErpPro102SEntities _db = new IEA_ErpProject.Entity.ErpPro102SEntities();
        private List<tblPersoneller> prsList;
        private Formlar f = new Formlar();
        public bool Secim = false;
        public int secimId = -1;
        public PersonellerListesi()
        {
            InitializeComponent();
        }

        private void PersonellerListesi_Load(object sender, EventArgs e)
        {
            Listele();
        }

        private void Listele()
        {
            Liste.Rows.Clear();

            int i = 0;


            prsList = (from s in _db.tblPersoneller select s).ToList();

            foreach (var item in prsList)
            {
                Liste.Rows.Add();
                Liste.Rows[i].Cells[0].Value = i + 1;
                Liste.Rows[i].Cells[1].Value = item.Id;
                Liste.Rows[i].Cells[2].Value = item.Adi;
                Liste.Rows[i].Cells[3].Value = item.Unvan;
                Liste.Rows[i].Cells[4].Value = item.Tel;

                i++;


                if (item.Sehirler != null)
                {
                    Liste.Rows[i].Cells[5].Value = item.Sehirler.name;
                }




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

            if (secimId > 0 && Secim && Application.OpenForms["PersonelGiris"] == null)
            {
                AnaSayfa.Aktarma = secimId;
                Close();
                f.PersonelGirisAc(secimId);

            }                     // tıkladığımda hangi satır seçiliyse currentRow kullanırız.
            // Eğer normal bir değer gelirse burdaki değeri al int e cevir , eger null gelirse -1 yaz.

            else if (Application.OpenForms["PersonelGiris"] != null)
            {
                PersonelGiris frm = Application.OpenForms["PersonelGiris"] as PersonelGiris;  // Acık olan formdan bilgileri al frm nin içerisine getir.

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

