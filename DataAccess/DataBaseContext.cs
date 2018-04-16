namespace DataAccess
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;
    using DataAccess.Entities;

    public partial class DataBaseContext : DbContext, IDBContext
    {
        public DataBaseContext()
            : base("name=DataBaseContext")
        {
        }

        public virtual DbSet<Company> Companies { get; set; }
        public virtual DbSet<Datum> Data { get; set; }
        public virtual DbSet<Info> Infoes { get; set; }
        public virtual DbSet<Recovery> Recoveries { get; set; }
        public virtual DbSet<TypeEarning> TypeEarnings { get; set; }
        public virtual DbSet<User> Users { get; set; }
        public virtual DbSet<Сurrencies> Сurrencies { get; set; }
        public virtual DbSet<Image> Images { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Company>()
                .Property(e => e.Title)
                .IsUnicode(false);

            modelBuilder.Entity<Company>()
                .Property(e => e.Description)
                .IsUnicode(false);

            modelBuilder.Entity<Company>()
                .Property(e => e.Address)
                .IsUnicode(false);

            modelBuilder.Entity<Company>()
                .Property(e => e.Telephone)
                .IsUnicode(false);

            modelBuilder.Entity<Company>()
                .HasMany(e => e.Data)
                .WithRequired(e => e.Company)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Info>()
                .Property(e => e.Description)
                .IsUnicode(false);

            modelBuilder.Entity<Info>()
                .HasMany(e => e.Data)
                .WithRequired(e => e.Info)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Recovery>()
                .Property(e => e.Description)
                .IsUnicode(false);

            modelBuilder.Entity<Recovery>()
                .HasMany(e => e.Data)
                .WithRequired(e => e.Recovery)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<TypeEarning>()
                .Property(e => e.Title)
                .IsUnicode(false);

            modelBuilder.Entity<TypeEarning>()
                .Property(e => e.Description)
                .IsUnicode(false);

            modelBuilder.Entity<TypeEarning>()
                .HasMany(e => e.Infoes)
                .WithRequired(e => e.TypeEarning)
                .HasForeignKey(e => e.TypeEarningsId)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<User>()
                .Property(e => e.Login)
                .IsUnicode(false);

            modelBuilder.Entity<User>()
                .Property(e => e.Password)
                .IsUnicode(false);

            modelBuilder.Entity<User>()
                .Property(e => e.Email)
                .IsUnicode(false);

            modelBuilder.Entity<User>()
                .Property(e => e.Telephone)
                .IsUnicode(false);

            modelBuilder.Entity<User>()
                .HasMany(e => e.Data)
                .WithRequired(e => e.User)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Сurrencies>()
                .Property(e => e.Title)
                .IsUnicode(false);

            modelBuilder.Entity<Сurrencies>()
                .HasMany(e => e.Infoes)
                .WithRequired(e => e.Сurrencies)
                .HasForeignKey(e => e.СurrencyId)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Сurrencies>()
                .HasMany(e => e.Recoveries)
                .WithRequired(e => e.Сurrencies)
                .HasForeignKey(e => e.СurrencyId)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Image>()
                .Property(e => e.Title)
                .IsUnicode(false);

            modelBuilder.Entity<Image>()
                .Property(e => e.Description)
                .IsUnicode(false);
        }
    }
}
