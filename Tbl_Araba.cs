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
    
    public partial class Tbl_Araba
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Tbl_Araba()
        {
            this.Tbl_Satis = new HashSet<Tbl_Satis>();
        }
    
        public int Araba_ID { get; set; }
        public string Araba_Model { get; set; }
        public string Araba_Renk { get; set; }
        public string Araba_YakitTuru { get; set; }
        public string Araba_VitesTuru { get; set; }
        public Nullable<byte> Araba_Yas { get; set; }
        public Nullable<byte> Araba_Kapasite { get; set; }
        public Nullable<byte> Araba_EhliyetYasSarti { get; set; }
        public string Araba_Sehir { get; set; }
        public Nullable<bool> Araba_Durum { get; set; }
        public string Araba_Foto { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Tbl_Satis> Tbl_Satis { get; set; }
    }
}