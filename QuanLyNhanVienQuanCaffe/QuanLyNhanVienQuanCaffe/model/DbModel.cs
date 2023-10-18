using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace QuanLyNhanVienQuanCaffe.model
{
    public partial class DbModel : DbContext
    {
        public DbModel()
            : base("name=DbModel")
        {
        }

        public virtual DbSet<CaSangTheoNgay> CaSangTheoNgay { get; set; }
        public virtual DbSet<CaToiTheoNgay> CaToiTheoNgay { get; set; }
        public virtual DbSet<CaTruaTheoNgay> CaTruaTheoNgay { get; set; }
        public virtual DbSet<LichTheoNgay> LichTheoNgay { get; set; }
        public virtual DbSet<Login> Login { get; set; }
        public virtual DbSet<NhanVien> NhanVien { get; set; }
        public virtual DbSet<LuongTheoNgay> LuongTheoNgay { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<CaSangTheoNgay>()
                .Property(e => e.CaSang)
                .IsFixedLength();

            modelBuilder.Entity<CaSangTheoNgay>()
                .Property(e => e.NVPC)
                .IsFixedLength();

            modelBuilder.Entity<CaSangTheoNgay>()
                .Property(e => e.NVPV)
                .IsFixedLength();

            modelBuilder.Entity<CaSangTheoNgay>()
                .Property(e => e.NVBV)
                .IsFixedLength();

            modelBuilder.Entity<CaSangTheoNgay>()
                .HasMany(e => e.LichTheoNgay)
                .WithRequired(e => e.CaSangTheoNgay)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<CaToiTheoNgay>()
                .Property(e => e.CaToi)
                .IsFixedLength();

            modelBuilder.Entity<CaToiTheoNgay>()
                .Property(e => e.NVPC)
                .IsFixedLength();

            modelBuilder.Entity<CaToiTheoNgay>()
                .Property(e => e.NVPV)
                .IsFixedLength();

            modelBuilder.Entity<CaToiTheoNgay>()
                .Property(e => e.NVBV)
                .IsFixedLength();

            modelBuilder.Entity<CaToiTheoNgay>()
                .HasMany(e => e.LichTheoNgay)
                .WithRequired(e => e.CaToiTheoNgay)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<CaTruaTheoNgay>()
                .Property(e => e.CaTrua)
                .IsFixedLength();

            modelBuilder.Entity<CaTruaTheoNgay>()
                .Property(e => e.NVPC)
                .IsFixedLength();

            modelBuilder.Entity<CaTruaTheoNgay>()
                .Property(e => e.NVPV)
                .IsFixedLength();

            modelBuilder.Entity<CaTruaTheoNgay>()
                .Property(e => e.NVBV)
                .IsFixedLength();

            modelBuilder.Entity<CaTruaTheoNgay>()
                .HasMany(e => e.LichTheoNgay)
                .WithRequired(e => e.CaTruaTheoNgay)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<LichTheoNgay>()
                .Property(e => e.MaLichTheoNgay)
                .IsFixedLength();

            modelBuilder.Entity<LichTheoNgay>()
                .Property(e => e.NguoiLap)
                .IsFixedLength();

            modelBuilder.Entity<LichTheoNgay>()
                .Property(e => e.CaSang)
                .IsFixedLength();

            modelBuilder.Entity<LichTheoNgay>()
                .Property(e => e.CaTrua)
                .IsFixedLength();

            modelBuilder.Entity<LichTheoNgay>()
                .Property(e => e.CaToi)
                .IsFixedLength();

            modelBuilder.Entity<Login>()
                .Property(e => e.MaNV)
                .IsFixedLength();

            modelBuilder.Entity<Login>()
                .Property(e => e.UserName)
                .IsFixedLength();

            modelBuilder.Entity<Login>()
                .Property(e => e.Password)
                .IsFixedLength();

            modelBuilder.Entity<NhanVien>()
                .Property(e => e.MaNV)
                .IsFixedLength();

            modelBuilder.Entity<NhanVien>()
                .Property(e => e.LuongTheoGio)
                .HasPrecision(19, 4);

            modelBuilder.Entity<NhanVien>()
                .Property(e => e.SDT)
                .IsFixedLength();

            modelBuilder.Entity<NhanVien>()
                .Property(e => e.Email)
                .IsFixedLength();

            modelBuilder.Entity<NhanVien>()
                .Property(e => e.Anh)
                .IsFixedLength();

            modelBuilder.Entity<NhanVien>()
                .HasMany(e => e.LichTheoNgay)
                .WithRequired(e => e.NhanVien)
                .HasForeignKey(e => e.NguoiLap)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<NhanVien>()
                .HasOptional(e => e.Login)
                .WithRequired(e => e.NhanVien);

            modelBuilder.Entity<LuongTheoNgay>()
                .Property(e => e.MaLichTheoNgay)
                .IsFixedLength();

            modelBuilder.Entity<LuongTheoNgay>()
                .Property(e => e.MaNV)
                .IsFixedLength();

            modelBuilder.Entity<LuongTheoNgay>()
                .Property(e => e.Luong)
                .HasPrecision(19, 4);
        }
    }
}
