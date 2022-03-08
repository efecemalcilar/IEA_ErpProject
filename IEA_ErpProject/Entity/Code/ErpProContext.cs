using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IEA_ErpProject.Entity.Code
{
    public class ErpProContext: DbContext  // amacımız class oluşturarak tablolar oluşturacaz , oluşturduğum classları databse e atmak için context oluşturuyoruz. 
    // Class oluşturup classın isminin yanına : koyduktan sonra miras alma işlemi yapılabilir. Artık base im DbContext oldu.
    {
        public ErpProContext() : base("name=ErpPro102SCode") // Constructer cons+tab,
        {
            Database.SetInitializer(new MyInitializer()); // 
        }


        public DbSet<tblUser> TblUsers { get; set; }  //DBset databse de ki karşılaştırmamızı yapacak

        public DbSet<tblKonsinyeGonderim> TblKonsinyeGonderimler { get; set; } //Bu kod Declare işlemi yapıyor, amac db deki tblkonsinyegonderi class olarak kullanmaya yarıyor.

       
    }
}
