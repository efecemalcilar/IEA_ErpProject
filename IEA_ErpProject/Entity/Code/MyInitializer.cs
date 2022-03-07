using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IEA_ErpProject.Entity.Code
{
    public class MyInitializer:CreateDatabaseIfNotExists<ErpProContext>                 // erpprocontext den türetilmiş bir db yok createdatabseifnotexist kullanılır, ise Seed bilgisi oluşturulacak bir sınıftaki işlemleri yapmamı sağlayacak.
    {
        protected override void Seed(ErpProContext context) // eğer bir db yoksa db nin oluşmasına kadar bekle oluştuktan sonra seed dosyansına erpcontextden türettiğim elemanları taşı.
        {
            //Adding admin user

            tblUser admin = new tblUser();
            admin.Name = "Efe";
            admin.Password = "1234";
            admin.UserName = "Ilhanity";

            context.TblUsers.Add(admin);
            context.SaveChanges();



            base.Seed(context);
        }
    }
}
