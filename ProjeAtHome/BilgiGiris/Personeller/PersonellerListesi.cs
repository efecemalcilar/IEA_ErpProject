using ProjeAtHome.Entity;
using ProjeAtHome.Fonksiyonlar;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjeAtHome.BilgiGiris.Personeller
{
    public partial class PersonellerListesi : Form
    {
        private readonly ErpPro102SEntities2 _db = new ErpPro102SEntities2();
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
            listele();
        }

        private void listele()
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

            Liste.AllowUserToAddRows = false; 
            Liste.AllowUserToDeleteRows = false; 
            Liste.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            Liste.ReadOnly = true; 

        }

        private void Liste_DoubleClick(object sender, EventArgs e)
        {
            if (Liste.CurrentRow != null) secimId = (int?) Liste.CurrentRow.Cells[1].Value ?? -1;

            if (secimId>0 && Secim && Application.OpenForms["PersonelGiris"] == null)
            {
                AnaSayfa1.Aktarma = -1;
                Close();
                f.PersonelGirisAc(secimId);
            }
             
            else if (Application.OpenForms["PersonelGiris"] != null)
            {
                PersonelGiris frm = Application.OpenForms["PersonelGiris"] as PersonelGiris;
                
                frm.Ac(secimId);
                Close();
            }
            
        }

        private void BtnHastaneAra_Click(object sender, EventArgs e)
        {
            listele();
        }
    }
}
