using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using ProjeAtHome.Entity;

namespace ProjeAtHome.Fonksiyonlar
{
    internal class Numaralar
    {

        private readonly ErpPro102SEntities2 _db = new ErpPro102SEntities2();


        public string Uidno()
        {
            try
            {
                var numara = (from s in _db.tblUrunKayitUst orderby s.Id descending select s).First().Uid;
                numara++;
                string num = numara.ToString().PadLeft(7, '0');
                return num;
            }
            catch (Exception)
            {

                return "0000001";
            }


        }


        

        public string UGirisno()
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
    }
}
