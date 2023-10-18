namespace QuanLyNhanVienQuanCaffe.model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("CaSangTheoNgay")]
    public partial class CaSangTheoNgay
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public CaSangTheoNgay()
        {
            LichTheoNgay = new HashSet<LichTheoNgay>();
        }

        [Key]
        [StringLength(10)]
        public string CaSang { get; set; }

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
