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
    
    public partial class OgrenimDurumlaris
    {
        public OgrenimDurumlaris()
        {
            this.UyeOgrenimDurumus = new HashSet<UyeOgrenimDurumus>();
        }
    
        public int ogrenimD_id { get; set; }
        public string ogrenimD_tanim { get; set; }
    
        public virtual ICollection<UyeOgrenimDurumus> UyeOgrenimDurumus { get; set; }
    }
}
