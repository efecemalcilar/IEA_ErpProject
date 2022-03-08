using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IEA_ErpProject.Entity.Code
{

    [Table("tblUsers")]        // Database de oluşmasını istediğim tablo ve ismi.
    
    public class tblUser
    {
      
        [Key,DatabaseGenerated(DatabaseGeneratedOption.Identity)] // Bu dataautonationsdur, kod bu yapının identitysinin bir bir artacağını söylüyor. Her eklediğim dataautonations bir altında ki satırı ekler.
        
        public int Id { get; set; } // Id yi primary key olarak ekler.
        
        [DisplayName("Ad"),StringLength(50,ErrorMessage = "{0} alani max{1} karakterdir.")]
        [Required(ErrorMessage = "{0} alani girilmesi zorunludur}")]

        public string Name { get; set; }

        [DisplayName("Sifre"), StringLength(maximumLength:10,MinimumLength = 5,ErrorMessage = "{0} alani max{1} min.{2 karakter olmalidir.}")]
        [Required(ErrorMessage = "{0} alani girilmesi zorunludur}")]
        public string Password { get; set; }

        [DisplayName("Kullanici Adi"), StringLength(maximumLength: 10, MinimumLength = 5, ErrorMessage = "{0} alani max{1} min.{2 karakter olmalidir.}")]
        [Required(ErrorMessage = "{0} alani girilmesi zorunludur}")]

        public string UserName { get; set; }  // String ifadeler database kayıt olurken değişiklik yapmazsam nvarchar(max) olarak kayıt olur.



    }
}
