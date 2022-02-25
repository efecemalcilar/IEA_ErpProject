using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading.Tasks;
using IEA_ErpProject.Entity;

namespace IEA_ErpProject.Fonksiyonlar
{
    public class Numaralar
    {
        private readonly ErpPro102SEntities _db = new ErpPro102SEntities();
        public string Uidno()
        {
            try
            {
                var numara = (from s in _db.tblUrunKayitUst orderby s.Id descending select s).First().Uid;                              // linq tipinde bir sql sorgusu, id baz alınarak ters ceviriliyor.
                numara++;
                string num = numara.ToString().PadLeft(7,'0');
                return num;
            }
            catch (Exception)
            {
                return "0000001";    // bir kayit yoksa catch e düşecek burdan da 1 vererek devam edecek.
            }
        }
    }
}
