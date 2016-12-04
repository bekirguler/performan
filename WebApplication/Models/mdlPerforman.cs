namespace WebApplication.Models
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class mdlPerforman : DbContext
    {
        public mdlPerforman()
            : base("name=mdlPerforman")
        {
        }

        public virtual DbSet<AspNetRole> AspNetRoles { get; set; }
        public virtual DbSet<AspNetUserClaim> AspNetUserClaims { get; set; }
        public virtual DbSet<AspNetUserLogin> AspNetUserLogins { get; set; }
        public virtual DbSet<AspNetUser> AspNetUsers { get; set; }
        public virtual DbSet<sysdiagram> sysdiagrams { get; set; }
        public virtual DbSet<tblCevap> tblCevaps { get; set; }
        public virtual DbSet<tblDept> tblDepts { get; set; }
        public virtual DbSet<tblFirma> tblFirmas { get; set; }
        public virtual DbSet<tblKisi> tblKisis { get; set; }
        public virtual DbSet<tblPozisyon> tblPozisyons { get; set; }
        public virtual DbSet<tblSehir> tblSehirs { get; set; }
        public virtual DbSet<tblSinavBilgi> tblSinavBilgis { get; set; }
        public virtual DbSet<tblSinavSoru> tblSinavSorus { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<AspNetRole>()
                .HasMany(e => e.AspNetUsers)
                .WithMany(e => e.AspNetRoles)
                .Map(m => m.ToTable("AspNetUserRoles").MapLeftKey("RoleId").MapRightKey("UserId"));

            modelBuilder.Entity<AspNetUser>()
                .HasMany(e => e.AspNetUserClaims)
                .WithRequired(e => e.AspNetUser)
                .HasForeignKey(e => e.UserId);

            modelBuilder.Entity<AspNetUser>()
                .HasMany(e => e.AspNetUserLogins)
                .WithRequired(e => e.AspNetUser)
                .HasForeignKey(e => e.UserId);

            modelBuilder.Entity<tblDept>()
                .HasMany(e => e.AspNetUsers)
                .WithOptional(e => e.tblDept)
                .HasForeignKey(e => e.Dept_Id);

            modelBuilder.Entity<tblFirma>()
                .HasMany(e => e.AspNetUsers)
                .WithOptional(e => e.tblFirma)
                .HasForeignKey(e => e.Firma_Id);

            modelBuilder.Entity<tblPozisyon>()
                .HasMany(e => e.AspNetUsers)
                .WithOptional(e => e.tblPozisyon)
                .HasForeignKey(e => e.Posizyon_Id);

            modelBuilder.Entity<tblSehir>()
                .HasMany(e => e.AspNetUsers)
                .WithOptional(e => e.tblSehir)
                .HasForeignKey(e => e.Sehir_Id);

            modelBuilder.Entity<tblSinavBilgi>()
                .HasMany(e => e.tblSinavSorus)
                .WithOptional(e => e.tblSinavBilgi)
                .HasForeignKey(e => e.sinav_id);
        }
    }
}
