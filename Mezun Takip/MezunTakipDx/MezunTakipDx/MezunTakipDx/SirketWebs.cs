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
    
    public partial class SirketWebs
    {
        public int sirketWeb_id { get; set; }
        public string sirket_web { get; set; }
        public int sirket_Id { get; set; }
    
        public virtual Sirketlers Sirketlers { get; set; }
    }
}
