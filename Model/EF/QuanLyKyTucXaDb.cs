namespace Model.EF
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class QuanLyKyTucXaDb : DbContext
    {
        public QuanLyKyTucXaDb()
            : base("name=QuanLyKyTucXaDb")
        {
        }

        public virtual DbSet<Account> Accounts { get; set; }
        public virtual DbSet<Dien> Diens { get; set; }
        public virtual DbSet<GatDo> GatDoes { get; set; }
        public virtual DbSet<HDDienNuoc> HDDienNuocs { get; set; }
        public virtual DbSet<HDThuePhong> HDThuePhongs { get; set; }
        public virtual DbSet<HoaDonGiatDo> HoaDonGiatDoes { get; set; }
        public virtual DbSet<HoaDonSuaChua> HoaDonSuaChuas { get; set; }
        public virtual DbSet<KhuNha> KhuNhas { get; set; }
        public virtual DbSet<Nuoc> Nuocs { get; set; }
        public virtual DbSet<Phong> Phongs { get; set; }
        public virtual DbSet<SinhVien> SinhViens { get; set; }
        public virtual DbSet<VatTu> VatTus { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<SinhVien>()
                .HasMany(e => e.HDDienNuocs)
                .WithRequired(e => e.SinhVien)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<SinhVien>()
                .HasMany(e => e.HDThuePhongs)
                .WithRequired(e => e.SinhVien)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<VatTu>()
                .HasMany(e => e.HoaDonSuaChuas)
                .WithRequired(e => e.VatTu)
                .WillCascadeOnDelete(false);
        }
    }
}
