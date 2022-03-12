using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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

        public DbSet<tblKonsinyeGonderim> TblKonsinyeGonderimler { get; set; } //Bu kod Declare işlemi yapıyor, amac db deki tblKonsinyeGonderi class olarak kullanmaya yarıyor.

        AnaSayfa ana = Application.OpenForms["AnaSayfa"] as AnaSayfa; // anasayfa ana = new anasayfa yerine  yaptık cünkü üst kısımdan createduser tarafından isim değil de *** ı alıyordu.

        public override int SaveChanges()
        {
            var datas=ChangeTracker.Entries<BaseEntity>();              // varlıklarımdan BaseEntity e ulaşacağım.  changetracker coklu bir yapı döndürebilir. Base entities içerisinde ki değişikleri datas a attım. ChangeTracker İşlemleri hafızasına alıyor ve savechages i çalıştırdıgımda changetracker sira sira işlemleri db ye aktarır.

            foreach (var data in datas)
            {

                if (data.State==EntityState.Added)
                {
                    data.Entity.CreatedDate=DateTime.Now;
                    data.Entity.CreatedUser = ana.LblUserNickName.Text;
                    data.Entity.isDeleted = false;

                }

                else if (data.State==EntityState.Modified)
                {
                    data.Entity.UpdatedDate = DateTime.Now;
                    data.Entity.UpdatedUser = ana.LblUserNickName.Text;
                }
            }

            return base.SaveChanges(); // Ana yapmasını ıstedıgım ise devam etmesini istedim.

        }

        //ChangeTracker Entitiyler üzerinde yapilan değişiklerin yada yeni eklenen verinin yakalanmasını sağlayan propertydir.
    }
}
