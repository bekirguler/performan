namespace WebApplication.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("tblSinavBilgi")]
    public partial class tblSinavBilgi
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public tblSinavBilgi()
        {
            tblSinavSorus = new HashSet<tblSinavSoru>();
        }

        public int id { get; set; }

        [StringLength(100)]
        public string sinav_ad { get; set; }

        [StringLength(50)]
        public string sinav_tur { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tblSinavSoru> tblSinavSorus { get; set; }
    }
}
