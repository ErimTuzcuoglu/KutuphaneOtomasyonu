//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace KutuphaneOtomasyonu.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Kitap
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Kitap()
        {
            this.OduncAlma = new HashSet<OduncAlma>();
        }
    
        public int kitapID { get; set; }
        public string kitapAd { get; set; }
        public int yazarID { get; set; }
        public int yayinEviID { get; set; }
        public int turID { get; set; }
        public bool kitapStok { get; set; }
    
        public virtual Tur Tur { get; set; }
        public virtual YayinEvi YayinEvi { get; set; }
        public virtual Yazar Yazar { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<OduncAlma> OduncAlma { get; set; }
    }
}