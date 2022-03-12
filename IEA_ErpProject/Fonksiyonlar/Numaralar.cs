using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using IEA_ErpProject.Entity;
using IEA_ErpProject.Entity.Code;

namespace IEA_ErpProject.Fonksiyonlar
{
    public class Numaralar
    {
        private readonly ErpPro102SEntities _db = new ErpPro102SEntities();
        private readonly ErpProContext _code = new ErpProContext();
        public string Uidno()
        {
            try
            {
                var numara = (from s in _db.tblUrunKayitUst orderby s.Id descending select s).First()
                    .Uid; // linq tipinde bir sql sorgusu, id baz alınarak ters ceviriliyor.
                numara++;
                string num = numara.ToString().PadLeft(7, '0');
                return num;
            }
            catch (Exception)
            {
                return "0000001"; // bir kayit yoksa catch e düşecek burdan da 1 vererek devam edecek.


            }
        }


        public string UGirisNo()
        {
            try
            {
                var numara = (from s in _db.tblUrunGirisUst orderby s.Id descending select s).First().GirisId;

                numara++;

                string num = numara.ToString().PadLeft(7, '0');
                return num;
            }
            catch (Exception e)
            {
                return "0000001";
            }
        }


        public string KonGonderimNo()
        {
            try
            {
                var numara = (from s in _code.TblKonsinyeGonderimler orderby s.Id descending select s).First().GonderimId;

                numara++;

                //string num = numara.ToString().PadLeft(7, '0');
                return numara.ToString().PadLeft(7, '0');
            }
            catch (Exception e)
            {
                return "0000001";
            }
            

        }

    }
}
