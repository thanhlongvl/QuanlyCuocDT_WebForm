namespace QuanLyCuoc2.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ChiTietSuDung")]
    public partial class ChiTietSuDung
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ID { get; set; }

        [StringLength(20)]
        public string IDSIM { get; set; }

        public DateTime? TGBD { get; set; }

        public DateTime? TGKT { get; set; }

        public decimal? SoPhutSD7h23h { get; set; }

        public decimal? SoPhutSD23h7h { get; set; }

        public virtual ThongTinSIM ThongTinSIM { get; set; }
    }
}
