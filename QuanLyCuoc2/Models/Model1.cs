namespace QuanLyCuoc2.Models
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class Model1 : DbContext
    {
        public Model1()
            : base("name=Model1")
        {
        }

        public virtual DbSet<ChiTietSuDung> ChiTietSuDungs { get; set; }
        public virtual DbSet<GiaCuoc> GiaCuocs { get; set; }
        public virtual DbSet<HoaDonDangKy> HoaDonDangKies { get; set; }
        public virtual DbSet<HoaDonTinhCuoc> HoaDonTinhCuocs { get; set; }
        public virtual DbSet<KhachHang> KhachHangs { get; set; }
        public virtual DbSet<ThongTinSIM> ThongTinSIMs { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ChiTietSuDung>()
                .Property(e => e.IDSIM)
                .IsUnicode(false);

            modelBuilder.Entity<ChiTietSuDung>()
                .Property(e => e.SoPhutSD7h23h)
                .HasPrecision(19, 3);

            modelBuilder.Entity<ChiTietSuDung>()
                .Property(e => e.SoPhutSD23h7h)
                .HasPrecision(19, 3);

            modelBuilder.Entity<GiaCuoc>()
                .Property(e => e.MaGiaCuoc)
                .IsUnicode(false);

            modelBuilder.Entity<GiaCuoc>()
                .Property(e => e.Giacuoc1)
                .HasPrecision(19, 3);

            modelBuilder.Entity<HoaDonDangKy>()
                .Property(e => e.MaHDDK)
                .IsUnicode(false);

            modelBuilder.Entity<HoaDonDangKy>()
                .Property(e => e.IDSIM)
                .IsUnicode(false);

            modelBuilder.Entity<HoaDonDangKy>()
                .Property(e => e.ChiPhiDangKy)
                .HasPrecision(19, 3);

            modelBuilder.Entity<HoaDonTinhCuoc>()
                .Property(e => e.MaHDTC)
                .IsUnicode(false);

            modelBuilder.Entity<HoaDonTinhCuoc>()
                .Property(e => e.IDSIM)
                .IsUnicode(false);

            modelBuilder.Entity<HoaDonTinhCuoc>()
                .Property(e => e.PhiHangThang)
                .HasPrecision(19, 3);

            modelBuilder.Entity<HoaDonTinhCuoc>()
                .Property(e => e.TongTien)
                .HasPrecision(19, 3);

            modelBuilder.Entity<KhachHang>()
                .Property(e => e.MaKH)
                .IsUnicode(false);

            modelBuilder.Entity<KhachHang>()
                .Property(e => e.CMND)
                .IsUnicode(false);

            modelBuilder.Entity<KhachHang>()
                .Property(e => e.Email)
                .IsUnicode(false);

            modelBuilder.Entity<ThongTinSIM>()
                .Property(e => e.IDSIM)
                .IsUnicode(false);

            modelBuilder.Entity<ThongTinSIM>()
                .Property(e => e.SoDienThoai)
                .IsUnicode(false);

            modelBuilder.Entity<ThongTinSIM>()
                .Property(e => e.MaKH)
                .IsUnicode(false);
        }
    }
}
