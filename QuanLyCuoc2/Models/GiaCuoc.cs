namespace QuanLyCuoc2.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("GiaCuoc")]
    public partial class GiaCuoc
    {
        [Key]
        [StringLength(20)]
        public string MaGiaCuoc { get; set; }

        public TimeSpan? TGBD { get; set; }

        public TimeSpan? TGKT { get; set; }

        [Column("Giacuoc")]
        public decimal? Giacuoc1 { get; set; }
    }
}
