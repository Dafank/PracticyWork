namespace Library
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class LibraryModel : DbContext
    {
        public LibraryModel()
            : base("name=LibraryModel")
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

            modelBuilder.Entity<Book>()
                .Property(e => e.Cost)
                .HasPrecision(19, 4);

            modelBuilder.Entity<UserInfo>()
                .Property(e => e.Balance)
                .HasPrecision(19, 4);

            modelBuilder.Entity<UserInfo>()
                .HasMany(e => e.Libraries)
                .WithOptional(e => e.UserInfo)
                .HasForeignKey(e => e.BookOwner);
        }
    }
}
