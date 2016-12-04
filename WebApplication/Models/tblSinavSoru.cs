namespace WebApplication.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("tblSinavSoru")]
    public partial class tblSinavSoru
    {
        public int id { get; set; }

        public int? sinav_id { get; set; }

        [StringLength(250)]
        public string soru_text { get; set; }

        public double? soru_agirlik { get; set; }

        [StringLength(250)]
        public string soru_aciklama { get; set; }

        public virtual tblSinavBilgi tblSinavBilgi { get; set; }
    }
}
