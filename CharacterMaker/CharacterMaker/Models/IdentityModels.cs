using System.Data.Entity;
using System.Security.Claims;
using System.Threading.Tasks;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using CharacterMaker.ADO;

namespace CharacterMaker.Models
{
    // You can add profile data for the user by adding more properties to your ApplicationUser class, please visit http://go.microsoft.com/fwlink/?LinkID=317594 to learn more.
    public class ApplicationUser : IdentityUser
    {
        public async Task<ClaimsIdentity> GenerateUserIdentityAsync(UserManager<ApplicationUser> manager)
        {
            // Note the authenticationType must match the one defined in CookieAuthenticationOptions.AuthenticationType
            var userIdentity = await manager.CreateIdentityAsync(this, DefaultAuthenticationTypes.ApplicationCookie);
            // Add custom user claims here
            return userIdentity;
        }
    }

    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public ApplicationDbContext()
            : base("name=ADODandD", throwIfV1Schema: false)
        {
        }

        public static ApplicationDbContext Create()
        {
            return new ApplicationDbContext();
        }

        public virtual DbSet<Alignments> Alignments { get; set; }
        public virtual DbSet<Classes> Classes { get; set; }
        public virtual DbSet<Deities> Deities { get; set; }
        public virtual DbSet<Feats> Feats { get; set; }
        public virtual DbSet<ItemCategories> ItemCategories { get; set; }
        public virtual DbSet<Items> Items { get; set; }
        public virtual DbSet<Player> Player { get; set; }
        public virtual DbSet<Races> Races { get; set; }
        public virtual DbSet<Skills> Skills { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Alignments>()
                .HasMany(e => e.Player)
                .WithRequired(e => e.Alignments)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Classes>()
                .HasMany(e => e.Player)
                .WithRequired(e => e.Classes)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Classes>()
                .HasMany(e => e.Races)
                .WithOptional(e => e.Classes)
                .HasForeignKey(e => e.PreferredClassID);

            modelBuilder.Entity<Deities>()
                .HasMany(e => e.Player)
                .WithRequired(e => e.Deities)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<ItemCategories>()
                .HasMany(e => e.Items)
                .WithRequired(e => e.ItemCategories)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Races>()
                .HasMany(e => e.Player)
                .WithRequired(e => e.Races)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Skills>()
                .Property(e => e.KeyAbility)
                .IsFixedLength();

            base.OnModelCreating(modelBuilder);
        }

    }
}