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
    
    public partial class CalismaAlanlaris
    {
        public CalismaAlanlaris()
        {
            this.DuyuruKapsamis = new HashSet<DuyuruKapsamis>();
            this.UyeCalismaAlanis = new HashSet<UyeCalismaAlanis>();
        }
    
        public int calismaAlani_id { get; set; }
        public string calismaAlani_adi { get; set; }
        public int bolum_Id { get; set; }
    
        public virtual Bolumlers Bolumlers { get; set; }
        public virtual ICollection<DuyuruKapsamis> DuyuruKapsamis { get; set; }
        public virtual ICollection<UyeCalismaAlanis> UyeCalismaAlanis { get; set; }
    }
}
