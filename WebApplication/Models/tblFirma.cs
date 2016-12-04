namespace WebApplication.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("tblFirma")]
    public partial class tblFirma
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public tblFirma()
        {
            AspNetUsers = new HashSet<AspNetUser>();
        }

        public int id { get; set; }

        [StringLength(100)]
        public string firma_ad { get; set; }

        [StringLength(50)]
        public string firma_tel { get; set; }

        [StringLength(250)]
        public string firma_adres { get; set; }

        public int? firma_personel_sayi { get; set; }

        [StringLength(250)]
        public string firma_logo { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<AspNetUser> AspNetUsers { get; set; }
    }
}
