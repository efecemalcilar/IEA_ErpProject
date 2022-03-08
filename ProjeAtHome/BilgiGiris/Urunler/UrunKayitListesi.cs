using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ProjeAtHome.Entity;
using ProjeAtHome.Fonksiyonlar;

namespace ProjeAtHome.BilgiGiris.Urunler
{
    public partial class UrunKayitListesi : Form
    {
        private readonly ErpPro102SEntities2 _db = new ErpPro102SEntities2();
        private Numaralar n = new Numaralar();
        private Resimler r = new Resimler();

        public UrunKayitListesi()
        {
            InitializeComponent();
        }

        private void UrunKayitListesi_Load(object sender, EventArgs e)
        {
            TxtUrunId.Text = 
        }
    }
}
