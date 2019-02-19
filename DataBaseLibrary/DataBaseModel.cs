namespace DataBaseLibrary
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class DataBaseModel : DbContext
    {
        public DataBaseModel()
            : base("name=DataBaseModel")
        {
        }

        public virtual DbSet<AutentnData> AutentnDatas { get; set; }
        public virtual DbSet<Book> Books { get; set; }
        public virtual DbSet<Library> Libraries { get; set; }
        public virtual DbSet<UserInfo> UserInfoes { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<AutentnData>()
                .Property(e => e.Email)
                .IsUnicode(false);

            modelBuilder.Entity<AutentnData>()
                .Property(e => e.Password)
                .IsUnicode(false);

            modelBuilder.Entity<AutentnData>()
                .HasMany(e => e.UserInfoes)
                .WithRequired(e => e.AutentnData)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Book>()
                .Property(e => e.Cost)
                .HasPrecision(19, 4);

            modelBuilder.Entity<Book>()
                .HasMany(e => e.Libraries)
                .WithRequired(e => e.Book)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<UserInfo>()
                .Property(e => e.Balance)
                .HasPrecision(19, 4);

            modelBuilder.Entity<UserInfo>()
                .HasMany(e => e.Libraries)
                .WithRequired(e => e.UserInfo)
                .HasForeignKey(e => e.BookOwner)
                .WillCascadeOnDelete(false);
        }
    }
}
