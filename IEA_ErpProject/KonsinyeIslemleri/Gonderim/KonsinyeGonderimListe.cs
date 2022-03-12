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
using IEA_ErpProject.Fonksiyonlar;

namespace IEA_ErpProject.KonsinyeIslemleri.Giris
{
    public partial class KonsinyeGonderimListe : Form
    {
        public bool secim = false;
        private int GonderimId = -1;
        private readonly ErpProContext _code;

        public bool Secim = false;
        public KonsinyeGonderimListe(ErpProContext code)
        {
            _code = code;
            InitializeComponent();
        }

        private void KonsinyeGonderimListe_Load(object sender, EventArgs e)
        {
            Listele();
        }

        private void Listele()
        {
            Liste.Rows.Clear();
            int i = 0;

            //var srg = (from s in _code.TblKonsinyeGonderimler select new
            //    {
            //        id = s.GonderimId,
            //        cariTur = s.CariTur,
            //        cariAdi = s.CariAdi,
            //        gonTarih = s.GonderimTarih,
            //        acik = s.Aciklama,
                    
            //    }).Distinct().ToList();

            var srg1 = (from s in _code.TblKonsinyeGonderimler where s.isDeleted!= true where s.CariAdi.Contains(TxtGirisAra.Text) select s).GroupBy(s => new { s.GonderimId }).Select(group => group.FirstOrDefault()).ToList();     // GonderimId ye göre gruplandırma yapıp grupları tekilleştiriyor(Firstorder) ardından listeye ceviriyor.
            foreach (var s in srg1)
            {
                Liste.Rows.Add();

                Liste.Rows[i].Cells[0].Value = i + 1;
                Liste.Rows[i].Cells[1].Value = s.Id;
                Liste.Rows[i].Cells[2].Value = s.CariTur;
                Liste.Rows[i].Cells[3].Value = s.CariAdi;
                Liste.Rows[i].Cells[4].Value = s.GonderimTarih;
                Liste.Rows[i].Cells[5].Value = s.Aciklama;
                Liste.Rows[i].Cells[6].Value = s.GonderimId;
                
                
                
                i++;
            }

            Liste.AllowUserToAddRows = false;
            Liste.AllowUserToDeleteRows = false;
            Liste.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            Liste.ReadOnly = true;
        }

        private void Liste_DoubleClick(object sender, EventArgs e)
        {
            Sec();
            if (Secim && GonderimId>0)
            {
                AnaSayfa.Aktarma = GonderimId;
                
            }

            else if (!Secim && GonderimId > 0)
            {
                KonsinyeGonderim urn = new KonsinyeGonderim(new ErpProContext(), new ErpPro102SEntities() , new Numaralar(), new Formlar());
                urn.MdiParent = Form.ActiveForm;
                urn.StartPosition = FormStartPosition.CenterScreen;
                urn.Show();
                urn.KonGonderimAc(GonderimId);
                
            }

            Close();
        }

        private void Sec()
        {
            if(Liste.CurrentRow != null) GonderimId = Convert.ToInt32(Liste.CurrentRow.Cells[6].Value);

        }

        private void TxtGirisAra_TextChanged(object sender, EventArgs e)
        {
            Listele();
        }

        private void BtnGirisBul_Click(object sender, EventArgs e)
        {
            Listele();
        }
    }
}
