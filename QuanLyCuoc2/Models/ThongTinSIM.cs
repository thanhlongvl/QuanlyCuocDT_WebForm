namespace QuanLyCuoc2.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ThongTinSIM")]
    public partial class ThongTinSIM
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public ThongTinSIM()
        {
            ChiTietSuDungs = new HashSet<ChiTietSuDung>();
            HoaDonDangKies = new HashSet<HoaDonDangKy>();
            HoaDonTinhCuocs = new HashSet<HoaDonTinhCuoc>();
        }

        [Key]
        [StringLength(20)]
        public string IDSIM { get; set; }

        [StringLength(10)]
        public string SoDienThoai { get; set; }

        public DateTime? NgayDangKy { get; set; }

        public DateTime? NgayHetHan { get; set; }

        public bool? Flag { get; set; }

        [StringLength(20)]
        public string MaKH { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ChiTietSuDung> ChiTietSuDungs { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<HoaDonDangKy> HoaDonDangKies { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<HoaDonTinhCuoc> HoaDonTinhCuocs { get; set; }

        public virtual KhachHang KhachHang { get; set; }
    }
}
