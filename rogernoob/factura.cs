//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace rogernoob
{
    using System;
    using System.Collections.Generic;
    
    public partial class factura
    {
        public int n_Factura { get; set; }
        public Nullable<int> id_Client { get; set; }
        public Nullable<System.DateTime> Data { get; set; }
        public Nullable<int> Descompte { get; set; }
        public Nullable<int> IVA { get; set; }
    
        public virtual clients clients { get; set; }
    }
}
