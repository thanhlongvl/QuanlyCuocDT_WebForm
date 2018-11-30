namespace QuanLyCuoc2.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("HoaDonTinhCuoc")]
    public partial class HoaDonTinhCuoc
    {
        [Key]
        [StringLength(20)]
        public string MaHDTC { get; set; }

        [StringLength(20)]
        public string IDSIM { get; set; }

        public DateTime? TuNgay { get; set; }

        public DateTime? DenNgay { get; set; }

        public decimal? PhiHangThang { get; set; }

        public decimal? TongTien { get; set; }

        public DateTime? NgayXuat { get; set; }

        public bool? ThanhToan { get; set; }

        public bool? Flag { get; set; }

        public virtual ThongTinSIM ThongTinSIM { get; set; }
    }
}
