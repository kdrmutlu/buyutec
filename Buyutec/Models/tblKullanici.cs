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
    
    public partial class tblKullanici
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public tblKullanici()
        {
            this.tblKullaniciAltSurecs = new HashSet<tblKullaniciAltSurec>();
            this.tblKullaniciProjes = new HashSet<tblKullaniciProje>();
            this.tblKullaniciRols = new HashSet<tblKullaniciRol>();
            this.tblKullaniciSurecs = new HashSet<tblKullaniciSurec>();
            this.tblLogs = new HashSet<tblLog>();
            this.tblProjes = new HashSet<tblProje>();
        }
    
        public int kullaniciId { get; set; }
        public string kullaniciAdi { get; set; }
        public string kullaniciSoyadi { get; set; }
        public string email { get; set; }
        public string sifre { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tblKullaniciAltSurec> tblKullaniciAltSurecs { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tblKullaniciProje> tblKullaniciProjes { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tblKullaniciRol> tblKullaniciRols { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tblKullaniciSurec> tblKullaniciSurecs { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tblLog> tblLogs { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tblProje> tblProjes { get; set; }
    }
}
