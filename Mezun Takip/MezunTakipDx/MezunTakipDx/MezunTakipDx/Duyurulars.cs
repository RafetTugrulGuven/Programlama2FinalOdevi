//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace MezunTakipDx
{
    using System;
    using System.Collections.Generic;
    
    public partial class Duyurulars
    {
        public Duyurulars()
        {
            this.DuyuruBasvurus = new HashSet<DuyuruBasvurus>();
            this.DuyuruKapsamis = new HashSet<DuyuruKapsamis>();
        }
    
        public int duyuru_id { get; set; }
        public string duyuru_Basligi { get; set; }
        public string duyuru_Metin { get; set; }
        public byte[] duyuru_Resim { get; set; }
        public Nullable<System.DateTime> duyuru_yayinTarihi { get; set; }
        public Nullable<System.DateTime> duyuru_bitisTarihi { get; set; }
        public string duyuru_sahibiTc { get; set; }
    
        public virtual ICollection<DuyuruBasvurus> DuyuruBasvurus { get; set; }
        public virtual ICollection<DuyuruKapsamis> DuyuruKapsamis { get; set; }
        public virtual Uyelers Uyelers { get; set; }
    }
}
