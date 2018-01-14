namespace Practice.Models
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class MovieContext : DbContext
    {
        public MovieContext()
            : base("name=MovieContext")
        {
        }

        public virtual DbSet<GENRE> GENRE { get; set; }
        public virtual DbSet<MOVIE> MOVIE { get; set; }
        public virtual DbSet<PERSON> PERSON { get; set; }
        public virtual DbSet<REVIEW> REVIEW { get; set; }
        public virtual DbSet<STAFFROLE> STAFFROLE { get; set; }
        public virtual DbSet<STUDIO> STUDIO { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<GENRE>()
                .HasMany(e => e.MOVIE)
                .WithMany(e => e.GENRE)
                .Map(m => m.ToTable("MOVIEGENRE").MapLeftKey("GENREID").MapRightKey("MOVIEID"));

            modelBuilder.Entity<MOVIE>()
                .HasMany(e => e.MOVIESTAFF)
                .WithRequired(e => e.MOVIE)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<MOVIE>()
                .HasMany(e => e.REVIEW)
                .WithRequired(e => e.MOVIE)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<MOVIE>()
                .HasMany(e => e.STUDIO)
                .WithMany(e => e.MOVIE)
                .Map(m => m.ToTable("MOVIESTUDIO").MapLeftKey("MOVIEID").MapRightKey("STUDIOID"));

            modelBuilder.Entity<PERSON>()
                .HasMany(e => e.MOVIESTAFF)
                .WithRequired(e => e.PERSON)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<STAFFROLE>()
                .HasMany(e => e.MOVIESTAFF)
                .WithRequired(e => e.STAFFROLE)
                .WillCascadeOnDelete(false);
        }
    }
}
