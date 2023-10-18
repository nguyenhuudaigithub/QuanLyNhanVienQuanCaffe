namespace QuanLyNhanVienQuanCaffe.model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("LichTheoNgay")]
    public partial class LichTheoNgay
    {
        [Key]
        [StringLength(8)]
        public string MaLichTheoNgay { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime NgayLap { get; set; }

        [Required]
        [StringLength(10)]
        public string NguoiLap { get; set; }

        [Required]
        [StringLength(10)]
        public string CaSang { get; set; }

        [Required]
        [StringLength(10)]
        public string CaTrua { get; set; }

        [Required]
        [StringLength(10)]
        public string CaToi { get; set; }

        public virtual CaSangTheoNgay CaSangTheoNgay { get; set; }

        public virtual CaToiTheoNgay CaToiTheoNgay { get; set; }

        public virtual CaTruaTheoNgay CaTruaTheoNgay { get; set; }

        public virtual NhanVien NhanVien { get; set; }
    }
}
