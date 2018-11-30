namespace QuanLyCuoc2.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("KhachHang")]
    public partial class KhachHang
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public KhachHang()
        {
            ThongTinSIMs = new HashSet<ThongTinSIM>();
        }

        [Key]
        [StringLength(20)]
        public string MaKH { get; set; }

        [StringLength(50)]
        public string TenKH { get; set; }

        [StringLength(10)]
        public string CMND { get; set; }

        [StringLength(20)]
        public string Email { get; set; }

        [StringLength(50)]
        public string NgheNghiep { get; set; }

        [StringLength(50)]
        public string ChucVu { get; set; }

        [StringLength(100)]
        public string DiaChi { get; set; }

        public DateTime? NgayDangKy { get; set; }

        public bool? Flag { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ThongTinSIM> ThongTinSIMs { get; set; }
    }
}
