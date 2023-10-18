namespace QuanLyNhanVienQuanCaffe.model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("LuongTheoNgay")]
    public partial class LuongTheoNgay
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(8)]
        public string MaLichTheoNgay { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(10)]
        public string MaNV { get; set; }

        [Key]
        [Column(Order = 2)]
        [StringLength(100)]
        public string TenNV { get; set; }

        [Key]
        [Column(Order = 3)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int SoGioLam { get; set; }

        [Key]
        [Column(Order = 4, TypeName = "money")]
        public decimal Luong { get; set; }
    }
}
