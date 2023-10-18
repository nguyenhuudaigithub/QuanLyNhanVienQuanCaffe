namespace QuanLyNhanVienQuanCaffe.model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("CaTruaTheoNgay")]
    public partial class CaTruaTheoNgay
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public CaTruaTheoNgay()
        {
            LichTheoNgay = new HashSet<LichTheoNgay>();
        }

        [Key]
        [StringLength(10)]
        public string CaTrua { get; set; }

        [Required]
        [StringLength(10)]
        public string NVPC { get; set; }

        [Required]
        [StringLength(10)]
        public string NVPV { get; set; }

        [Required]
        [StringLength(10)]
        public string NVBV { get; set; }

        public int SoGioLam { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<LichTheoNgay> LichTheoNgay { get; set; }
    }
}
