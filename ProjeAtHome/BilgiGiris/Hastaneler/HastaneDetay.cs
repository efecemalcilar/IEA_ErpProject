using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjeAtHome.BilgiGiris.Hastaneler
{
    public partial class HastaneDetay : Form
    {

        private readonly ProjeAtHome.Entity.ErpPrp102SEntities _db = new Entity.Erp102Sentities();
        
        
        
        public HastaneDetay()
        {
            InitializeComponent();
        }

        private void HastaneDetay_Load(object sender, EventArgs e)
        {
            ComboDoldur();
        }

        private void ComboDoldur()
        {
            TxtDepartman.DataSource = _db.tblDepartmanlar.Where(x => x.DepartmanKodu == 'H').ToList();
            TxtDepartman.ValueMember = "Id";
            TxtDepartman.DisplayMember = "Adi";
            TxtDepartman.SelectedIndex = -1;
        }
    
        private void BtnEkle_Click(object sender, EventArgs e)
        {
            Liste.AllowUserToAddRows = false;
            int i = -1;

            if (Liste.Rows.Count >=0)
            {
                i = Liste.Rows.Count; 
                Liste.Rows.Add();                
                Liste.Rows[i].Cells[0].Value = i + 1;  
                Liste.Rows[i].Cells[1].Value = LblHastaneId.Text;
                Liste.Rows[i].Cells[2].Value = 'H';
                Liste.Rows[i].Cells[3].Value = TxtYetkili.Text;
                Liste.Rows[i].Cells[4].Value = TxtDepartman.SelectedValue;   
                Liste.Rows[i].Cells[5].Value = TxtTel.Text;
                Liste.Rows[i].Cells[6].Value = TxtGsm.Text;
                Liste.Rows[i].Cells[7].Value = TxtEmail.Text;
            }
        
        
        
        }
    
    
    }
}
