namespace WebApplication.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("tblKisi")]
    public partial class tblKisi
    {
        public int id { get; set; }

        [StringLength(50)]
        public string kisi_ad { get; set; }

        [StringLength(50)]
        public string kisi_soyad { get; set; }

        [StringLength(20)]
        public string kisi_tel { get; set; }

        [StringLength(50)]
        public string sifre { get; set; }

        [StringLength(100)]
        public string email { get; set; }

        public int? sehir_id { get; set; }

        public int? dept_id { get; set; }

        public int? pozisyon_id { get; set; }

        public int? sirket_id { get; set; }
    }
}
