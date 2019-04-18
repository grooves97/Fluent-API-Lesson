using System;
using System.Data.Entity;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;

namespace FluentAPI
{


    public partial class UserContext : DbContext
    {
        public UserContext()
            : base("name=UserContext")
        {}

        public DbSet<User> Users { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder
                .Entity<User>()
                .ToTable("users")
                .HasRequired(user => user.Login);

            modelBuilder
                .Entity<User>()
                .Property(user => user.Login)
                .HasColumnName("login").IsRequired();//и так далее

            modelBuilder
                .Entity<User>()
                .ToTable("users")
                .HasRequired(user => user.Password);

            modelBuilder
                .Entity<User>()
                .HasKey(user => user.Id);

           /*modelBuilder
                .Entity<Book>()
                .HasMany(book => book.Authors)
                .WithMany( author => author.Books) яв€зь Many to Many*/
        }
    }
}
