//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ProjeAtHome.Entity
{
    using System;
    using System.Collections.Generic;
    
    public partial class Sehirler
    {
        public Sehirler()
        {
            this.tblDoktorlar = new HashSet<tblDoktorlar>();
            this.tblFirmalar = new HashSet<tblFirmalar>();
            this.tblHastaneler = new HashSet<tblHastaneler>();
            this.tblPersoneller = new HashSet<tblPersoneller>();
        }
    
        public int Id { get; set; }
        public string code { get; set; }
        public string name { get; set; }
    
        public virtual ICollection<tblDoktorlar> tblDoktorlar { get; set; }
        public virtual ICollection<tblFirmalar> tblFirmalar { get; set; }
        public virtual ICollection<tblHastaneler> tblHastaneler { get; set; }
        public virtual ICollection<tblPersoneller> tblPersoneller { get; set; }
    }
}
