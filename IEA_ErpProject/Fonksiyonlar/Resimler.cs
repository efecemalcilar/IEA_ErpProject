using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IEA_ErpProject.Fonksiyonlar
{
    public class Resimler
    {
        public byte[] ResimYukle(Image resim)
        {

            using (MemoryStream ms = new MemoryStream()) // Referans alacağım sınıf
            {
                resim.Save(ms, ImageFormat.Jpeg);
                return ms.ToArray(); // Resmi sql ye gönderirken yapacağım çevirme işlemi
            }

        }

        public Image ResimGetirme(byte[] gelenByteArray)
        {
            using (MemoryStream ms = new MemoryStream(gelenByteArray))
            {
                Image resim = Image.FromStream(ms);     // Memorystream adındaki sınıfı kullanıyorum. normal bir fromatta ki resim byte array e döndü, databaseden gelen byte convert edilerek resim e dönüştürülüyor.
                return resim;
            }
        }
    

    }
}
