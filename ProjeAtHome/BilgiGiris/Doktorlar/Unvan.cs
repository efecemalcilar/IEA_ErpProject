using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjeAtHome.BilgiGiris.Doktorlar
{
    public enum Unvan
    {

        [Description("Prof. Dr.")] ProfDr,
        [Description("Opt. Dr.")] OptDr,
        [Description("Doc. Dr.")] DocDr,
        [Description("Yrd. Doc. Dr.")] YrdDocDr,           // Bu kod Kaan tarafından internetten alınmış olup Unvan kısmında ki unvanların aralarına boşluk gelmesi için yazılmıştır.
        [Description("Dr.")] Dr,
        [Description("Uzman Dr.")] UzmanDr,
        [Description("Asistan")] Asistan




    }
}
