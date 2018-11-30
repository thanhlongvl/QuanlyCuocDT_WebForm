namespace QuanLyCuoc2.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("HoaDonDangKy")]
    public partial class HoaDonDangKy
    {
        [Key]
        [StringLength(20)]
        public string MaHDDK { get; set; }

        [StringLength(20)]
        public string IDSIM { get; set; }

        public decimal? ChiPhiDangKy { get; set; }

        public DateTime? NgayDangKy { get; set; }

        public bool? Flag { get; set; }

        public virtual ThongTinSIM ThongTinSIM { get; set; }
    }
}
