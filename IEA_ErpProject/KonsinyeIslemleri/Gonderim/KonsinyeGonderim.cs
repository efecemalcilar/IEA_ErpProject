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

namespace IEA_ErpProject.KonsinyeIslemleri.Giris
{
    public partial class KonsinyeGiris : Form
    {
        private readonly ErpPro102SEntities _db = new ErpPro102SEntities();


        public KonsinyeGiris()
        {
            InitializeComponent();
        }

        private void KonsinyeGiris_Load(object sender, EventArgs e)
        {

        }
    }
}
