using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IEA_ErpProject.Entity.Code
{

    [Table("tblKonsinyeGonderimler")]
    public class tblKonsinyeGonderim :BaseEntity  // Inheritance Miras alma. BaseEntity de ki bütün propertyler burası calıstıgında buranın ıcerisine yerleşecek.
    {
        public int GonderimId { get; set; }
        [StringLength(15)]
        public string CariTur { get; set; }       // Inheritance farklı farklı classlarda ortak kullanılabiliyor. Inheritler 1 kere kullanılabiliyor.
        
        [StringLength(200)]
        public string CariAdi { get; set; }
        public string CariId { get; set; }
        public DateTime GonderimTarih { get; set; }
        
        [StringLength(250)]
        public string Aciklama { get; set; }
        public int UrunId { get; set; }
        public int Adet { get; set; }

        [ForeignKey("UrunId")]

        public tblStokDurum TblStokDurum { get; set; }
       
        

        

    }

    

    
}

