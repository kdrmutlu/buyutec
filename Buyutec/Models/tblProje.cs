//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Buyutec.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class tblProje
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public tblProje()
        {
            this.tblKullaniciProjes = new HashSet<tblKullaniciProje>();
            this.tblSurecs = new HashSet<tblSurec>();
        }
    
        public int projeId { get; set; }
        public string projeAdi { get; set; }
        public string projeAciklama { get; set; }
        public Nullable<int> olusturanKullaniciId { get; set; }
        public Nullable<System.DateTime> olusturmaTarihi { get; set; }
        public Nullable<System.DateTime> baslangicTarihi { get; set; }
        public Nullable<System.DateTime> bitisTarihi { get; set; }
    
        public virtual tblKullanici tblKullanici { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tblKullaniciProje> tblKullaniciProjes { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tblSurec> tblSurecs { get; set; }
    }
}
