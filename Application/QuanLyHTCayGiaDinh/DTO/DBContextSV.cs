using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace QuanLyBanHoa.DTO
{
    public partial class DBContextSV : DbContext
    {
        public DBContextSV()
            : base("name=DBContextSV4")
        {
        }
        public DBContextSV(string connectString)
            : base(connectString)
        {
        }

        public virtual DbSet<chinhanh> chinhanhs { get; set; }
        public virtual DbSet<chitiethoadon> chitiethoadons { get; set; }
        public virtual DbSet<chitietphieunhap> chitietphieunhaps { get; set; }
        public virtual DbSet<hoadon> hoadons { get; set; }
        public virtual DbSet<kho> khoes { get; set; }
        public virtual DbSet<nhacc> nhaccs { get; set; }
        public virtual DbSet<nhanvien> nhanviens { get; set; }
        public virtual DbSet<phieunhap> phieunhaps { get; set; }
        public virtual DbSet<sanpham> sanphams { get; set; }
        public virtual DbSet<taikhoan> taikhoans { get; set; }
        public virtual DbSet<tonkho> tonkhoes { get; set; }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<chinhanh>()
                .Property(e => e.macn)
                .IsUnicode(false);

            modelBuilder.Entity<chinhanh>()
                .Property(e => e.sodt)
                .IsUnicode(false);

            modelBuilder.Entity<chinhanh>()
                .HasMany(e => e.hoadons)
                .WithRequired(e => e.chinhanh)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<chinhanh>()
                .HasMany(e => e.khoes)
                .WithRequired(e => e.chinhanh)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<chinhanh>()
                .HasMany(e => e.nhanviens)
                .WithRequired(e => e.chinhanh)
                .WillCascadeOnDelete(false);

   

            modelBuilder.Entity<chitiethoadon>()
                .Property(e => e.mahd)
                .IsUnicode(false);

            modelBuilder.Entity<chitiethoadon>()
                .Property(e => e.masp)
                .IsUnicode(false);

            modelBuilder.Entity<chitietphieunhap>()
                .Property(e => e.mapn)
                .IsUnicode(false);

            modelBuilder.Entity<chitietphieunhap>()
                .Property(e => e.masp)
                .IsUnicode(false);
            modelBuilder.Entity<hoadon>()
                .Property(e => e.mahd)
                .IsUnicode(false);

            modelBuilder.Entity<hoadon>()
                .Property(e => e.manv)
                .IsUnicode(false);

            modelBuilder.Entity<hoadon>()
                .Property(e => e.macn)
                .IsUnicode(false);

            modelBuilder.Entity<hoadon>()
                .Property(e => e.sdt)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<hoadon>()
                .HasMany(e => e.chitiethoadons)
                .WithRequired(e => e.hoadon)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<kho>()
                .Property(e => e.makho)
                .IsUnicode(false);

            modelBuilder.Entity<kho>()
                .Property(e => e.macn)
                .IsUnicode(false);

            modelBuilder.Entity<kho>()
                .HasMany(e => e.tonkhoes)
                .WithRequired(e => e.kho)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<nhacc>()
                .Property(e => e.mancc)
                .IsUnicode(false);

            modelBuilder.Entity<nhacc>()
                .Property(e => e.email)
                .IsUnicode(false);

            modelBuilder.Entity<nhacc>()
                .HasMany(e => e.sanphams)
                .WithOptional(e => e.nhacc1)
                .HasForeignKey(e => e.nhacc);

            modelBuilder.Entity<nhanvien>()
                .Property(e => e.manv)
                .IsUnicode(false);

            modelBuilder.Entity<nhanvien>()
                .Property(e => e.sdt)
                .IsUnicode(false);

            modelBuilder.Entity<nhanvien>()
                .Property(e => e.macn)
                .IsUnicode(false);

            modelBuilder.Entity<nhanvien>()
                .Property(e => e.cnmd)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<phieunhap>()
                .Property(e => e.mapn)
                .IsUnicode(false);

            modelBuilder.Entity<phieunhap>()
                .Property(e => e.makho)
                .IsUnicode(false);

            modelBuilder.Entity<phieunhap>()
                .Property(e => e.mancc)
                .IsUnicode(false);

            modelBuilder.Entity<phieunhap>()
                .HasMany(e => e.chitietphieunhaps)
                .WithRequired(e => e.phieunhap)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<sanpham>()
                .Property(e => e.masp)
                .IsUnicode(false);

            modelBuilder.Entity<sanpham>()
                .Property(e => e.nhacc)
                .IsUnicode(false);

            modelBuilder.Entity<sanpham>()
                .HasMany(e => e.chitiethoadons)
                .WithRequired(e => e.sanpham)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<sanpham>()
                .HasMany(e => e.chitietphieunhaps)
                .WithRequired(e => e.sanpham)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<sanpham>()
                .HasMany(e => e.tonkhoes)
                .WithRequired(e => e.sanpham)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<taikhoan>()
                .Property(e => e.manv)
                .IsUnicode(false);

            modelBuilder.Entity<taikhoan>()
                .Property(e => e.tentaikhoan)
                .IsUnicode(false);

            modelBuilder.Entity<taikhoan>()
                .Property(e => e.matkhau)
                .IsUnicode(false);

            modelBuilder.Entity<tonkho>()
                .Property(e => e.makho)
                .IsUnicode(false);

            modelBuilder.Entity<tonkho>()
                .Property(e => e.masp)
                .IsUnicode(false);
        }
    }
}
