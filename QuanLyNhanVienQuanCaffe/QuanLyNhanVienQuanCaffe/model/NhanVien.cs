namespace QuanLyNhanVienQuanCaffe.model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("NhanVien")]
    public partial class NhanVien
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public NhanVien()
        {
            LichTheoNgay = new HashSet<LichTheoNgay>();
        }

        [Key]
        [StringLength(10)]
        public string MaNV { get; set; }

        [Required]
        [StringLength(100)]
        public string TenNV { get; set; }

        [Column(TypeName = "date")]
        public DateTime NgaySinh { get; set; }

        [Column(TypeName = "money")]
        public decimal LuongTheoGio { get; set; }

        public bool GioiTinh { get; set; }

        [Required]
        [StringLength(12)]
        public string SDT { get; set; }

        [Required]
        [StringLength(50)]
        public string Email { get; set; }

        [Required]
        [StringLength(300)]
        public string Anh { get; set; }

        [Required]
        [StringLength(50)]
        public string ChucVu { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<LichTheoNgay> LichTheoNgay { get; set; }

        public virtual Login Login { get; set; }
    }
}
