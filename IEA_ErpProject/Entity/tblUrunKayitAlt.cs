//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace IEA_ErpProject.Entity
{
    using System;
    using System.Collections.Generic;
    
    public partial class tblUrunKayitAlt
    {
        public int Id { get; set; }
        public Nullable<int> Uid { get; set; }
        public string UIKodu { get; set; }
        public string GMDMKodu { get; set; }
        public string UMSPCKodu { get; set; }
        public Nullable<bool> SB { get; set; }
        public Nullable<bool> KullanimDisi { get; set; }
        public Nullable<decimal> Birimfiyat { get; set; }
        public string ParaBirimi { get; set; }
        public Nullable<decimal> MinFiyat { get; set; }
        public string Ubb { get; set; }
        public string Sut { get; set; }
        public Nullable<decimal> SutFiyat { get; set; }
        public string SutAciklama { get; set; }
        public string Aciklama { get; set; }
        public string Sinif { get; set; }
        public string BransAdi { get; set; }
        public Nullable<bool> UTS { get; set; }
    }
}
