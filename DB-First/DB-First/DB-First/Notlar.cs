//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DB_First
{
    using System;
    using System.Collections.Generic;
    
    public partial class Notlar
    {
        public int İd { get; set; }
        public Nullable<int> OGR_İD { get; set; }
        public Nullable<int> DersİD { get; set; }
        public Nullable<short> Sinav1 { get; set; }
        public Nullable<short> Sinav2 { get; set; }
        public Nullable<short> Sinav3 { get; set; }
        public Nullable<decimal> Ortalama { get; set; }
        public Nullable<bool> Durum { get; set; }
    
        public virtual Dersler Dersler { get; set; }
        public virtual Ogrenci Ogrenci { get; set; }
    }
}
