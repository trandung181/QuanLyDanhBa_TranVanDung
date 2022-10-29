using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace QuanLyDanhBaSInhVien.Model
{
    public partial class AppDBContext : DbContext
    {
        public AppDBContext()
            : base("name=AppDBContext1")
        {
        }

        public virtual DbSet<LienLac> LienLacs { get; set; }
        public virtual DbSet<NhomLienLac> NhomLienLacs { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<NhomLienLac>()
                .HasMany(e => e.LienLacs)
                .WithRequired(e => e.NhomLienLac)
                .HasForeignKey(e => e.MaNhom)
                .WillCascadeOnDelete(false);
        }
    }
}
