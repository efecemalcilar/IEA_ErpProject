//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ProjeAtHome
{
    using System;
    using System.Collections.Generic;
    
    public partial class tblHastaneler
    {
        public tblHastaneler()
        {
            this.tblDetaylar = new HashSet<tblDetaylar>();
        }
    
        public int Id { get; set; }
        public string Adi { get; set; }
        public Nullable<int> TipId { get; set; }
        public string Adres { get; set; }
        public Nullable<int> SehirId { get; set; }
        public string Tel { get; set; }
        public string CariAdi { get; set; }
        public string VergiDairesi { get; set; }
        public string VergiNo { get; set; }
    
        public virtual Sehirler Sehirler { get; set; }
        public virtual ICollection<tblDetaylar> tblDetaylar { get; set; }
        public virtual tblHastaneTipleri tblHastaneTipleri { get; set; }
    }
}