using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace WebApplication1.Models
{
    public partial class EstateDbContext : DbContext
    {
        public EstateDbContext()
            : base("name=EstateDbContext")
        {
        }

        public virtual DbSet<BATDONGSAN> BATDONGSAN { get; set; }
        public virtual DbSet<GIAODICHKHACHHANG> GIAODICHKHACHHANG { get; set; }
        public virtual DbSet<HOPTACKHACHHANG> HOPTACKHACHHANG { get; set; }
        public virtual DbSet<LICHHEN> LICHHEN { get; set; }
        public virtual DbSet<LOAIHINHBDS> LOAIHINHBDS { get; set; }
        public virtual DbSet<PICTURES> PICTURES { get; set; }
        public virtual DbSet<UNGCUVIEN> UNGCUVIEN { get; set; }
        public virtual DbSet<USERS> USERS { get; set; }
        public virtual DbSet<VIECLAM> VIECLAM { get; set; }
        public virtual DbSet<VITRI> VITRI { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<BATDONGSAN>()
                .Property(e => e.HINHANH)
                .IsUnicode(false);

            modelBuilder.Entity<BATDONGSAN>()
                .HasMany(e => e.PICTURES)
                .WithOptional(e => e.BATDONGSAN)
                .HasForeignKey(e => e.BDS);

            modelBuilder.Entity<LICHHEN>()
                .Property(e => e.SDT)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<LICHHEN>()
                .Property(e => e.EMAIL)
                .IsUnicode(false);

            modelBuilder.Entity<LOAIHINHBDS>()
                .HasMany(e => e.BATDONGSAN)
                .WithOptional(e => e.LOAIHINHBDS1)
                .HasForeignKey(e => e.LOAIHINHBDS);

            modelBuilder.Entity<PICTURES>()
                .Property(e => e.LINKANH)
                .IsUnicode(false);

            modelBuilder.Entity<UNGCUVIEN>()
                .Property(e => e.SDT)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<USERS>()
                .Property(e => e.SDT)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<USERS>()
                .Property(e => e.EMAIL)
                .IsUnicode(false);

            modelBuilder.Entity<USERS>()
                .Property(e => e.TENNGUOIDUNG)
                .IsUnicode(false);

            modelBuilder.Entity<USERS>()
                .Property(e => e.MATKHAU)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<USERS>()
                .HasMany(e => e.BATDONGSAN)
                .WithOptional(e => e.USERS)
                .HasForeignKey(e => e.NVQUANLYBDS);

            modelBuilder.Entity<USERS>()
                .HasMany(e => e.BATDONGSAN1)
                .WithOptional(e => e.USERS1)
                .HasForeignKey(e => e.CHUSOHUU);

            modelBuilder.Entity<USERS>()
                .HasMany(e => e.GIAODICHKHACHHANG)
                .WithOptional(e => e.USERS)
                .HasForeignKey(e => e.BENGIAO);

            modelBuilder.Entity<USERS>()
                .HasMany(e => e.GIAODICHKHACHHANG1)
                .WithOptional(e => e.USERS1)
                .HasForeignKey(e => e.BENNHAN);

            modelBuilder.Entity<USERS>()
                .HasMany(e => e.HOPTACKHACHHANG)
                .WithOptional(e => e.USERS)
                .HasForeignKey(e => e.NHANVIENKY);

            modelBuilder.Entity<USERS>()
                .HasMany(e => e.HOPTACKHACHHANG1)
                .WithOptional(e => e.USERS1)
                .HasForeignKey(e => e.KHACHHANG);

            modelBuilder.Entity<USERS>()
                .HasMany(e => e.LICHHEN)
                .WithOptional(e => e.USERS)
                .HasForeignKey(e => e.NVTIEPNHAN);

            modelBuilder.Entity<USERS>()
                .HasMany(e => e.UNGCUVIEN)
                .WithOptional(e => e.USERS)
                .HasForeignKey(e => e.QLNS);

            modelBuilder.Entity<USERS>()
                .HasMany(e => e.VIECLAM)
                .WithOptional(e => e.USERS)
                .HasForeignKey(e => e.QLNHANSU);

            modelBuilder.Entity<VITRI>()
                .HasMany(e => e.BATDONGSAN)
                .WithOptional(e => e.VITRI1)
                .HasForeignKey(e => e.VITRI);
        }
    }
}
