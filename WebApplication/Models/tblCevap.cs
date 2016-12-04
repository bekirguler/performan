namespace WebApplication.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("tblCevap")]
    public partial class tblCevap
    {
        public int id { get; set; }

        public int? kisi_id { get; set; }

        public int? hedef_kisi_id { get; set; }

        public int? sinav_id { get; set; }

        public int? soru_id { get; set; }

        public int? cevap { get; set; }

        [StringLength(150)]
        public string cevap_text { get; set; }
    }
}
