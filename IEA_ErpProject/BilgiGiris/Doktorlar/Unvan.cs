using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IEA_ErpProject.BilgiGiris.Doktorlar
{
    public enum Unvan       // enum kucuk bilgileri tanıtabildimiz bir şeydir. Combo box dan bilgileri cekmek icin kullanılabilir.
    {
        // [Display(Name="Prof. Dr. ")]
        // ProfDr,

        //[Display(Name = "Opt. Dr. ")]
        //OptDr,

        //[Display(Name = "Doc. Dr. ")]
        //DocDr,

        //[Display(Name = "Yrd. Doc. Dr. ")]
        //YrdDocDr,

        //[Display(Name = "Uzman. Dr. ")]
        //UzmanDr,
        //Dr,
        //Asistan

        [Description("Prof. Dr.")] ProfDr,
        [Description("Opt. Dr.")] OptDr,
        [Description("Doc. Dr.")] DocDr,
        [Description("Yrd. Doc. Dr.")] YrdDocDr,           // Bu kod Kaan tarafından internetten alınmış olup Unvan kısmında ki unvanların aralarına boşluk gelmesi için yazılmıştır.
        [Description("Dr.")] Dr,
        [Description("Uzman Dr.")] UzmanDr,
        [Description("Asistan")] Asistan


    }
}
