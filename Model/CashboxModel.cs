namespace GraduationProject
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class CashboxModelContext : DbContext
    {
        public CashboxModelContext()
            : base("name=CashboxModel")
        {
        }

        public virtual DbSet<Item> Items { get; set; }
        public virtual DbSet<Return> Returns { get; set; }
        public virtual DbSet<Sale> Sales { get; set; }
        public virtual DbSet<Shift> Shifts { get; set; }
        public virtual DbSet<User> Users { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Item>()
                .Property(e => e.IId)
                .IsUnicode(false);

            modelBuilder.Entity<Item>()
                .Property(e => e.Name)
                .IsUnicode(false);

            modelBuilder.Entity<Item>()
                .Property(e => e.Price)
                .HasPrecision(18, 0);

            modelBuilder.Entity<Return>()
                .Property(e => e.IId)
                .IsUnicode(false);

            modelBuilder.Entity<Sale>()
                .Property(e => e.IId)
                .IsUnicode(false);

            modelBuilder.Entity<Shift>()
                .Property(e => e.UId)
                .IsUnicode(false);

            modelBuilder.Entity<Shift>()
                .Property(e => e.CashReceived)
                .HasPrecision(18, 0);

            modelBuilder.Entity<Shift>()
                .Property(e => e.CashReturned)
                .HasPrecision(18, 0);

            modelBuilder.Entity<Shift>()
                .Property(e => e.CashAdded)
                .HasPrecision(18, 0);

            modelBuilder.Entity<Shift>()
                .Property(e => e.CashWithdrawn)
                .HasPrecision(18, 0);

            modelBuilder.Entity<User>()
                .Property(e => e.UId)
                .IsUnicode(false);

            modelBuilder.Entity<User>()
                .Property(e => e.Password)
                .IsUnicode(false);

            modelBuilder.Entity<User>()
                .Property(e => e.SurName)
                .IsUnicode(false);

            modelBuilder.Entity<User>()
                .Property(e => e.Name)
                .IsUnicode(false);

            modelBuilder.Entity<User>()
                .Property(e => e.FatherName)
                .IsUnicode(false);
        }
    }
}
