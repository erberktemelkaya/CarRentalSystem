//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ArabaKiralama
{
    using System;
    using System.Collections.Generic;
    
    public partial class Tbl_Satis
    {
        public int Satis_ID { get; set; }
        public Nullable<System.DateTime> Satis_AlisTarihi { get; set; }
        public Nullable<System.DateTime> Satis_TeslimTarihi { get; set; }
        public Nullable<int> Araba_ID { get; set; }
        public Nullable<int> Musteri_ID { get; set; }
    
        public virtual Tbl_Araba Tbl_Araba { get; set; }
        public virtual Tbl_Musteri Tbl_Musteri { get; set; }
    }
}