namespace CharacterMaker.ADO
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class ADODandD : DbContext
    {
        public ADODandD()
            : base("name=ADODandD")
        {
        }

        public virtual DbSet<Alignments> Alignments { get; private set; }
        public virtual DbSet<Classes> Classes { get; private set; }
        public virtual DbSet<Deities> Deities { get; private set; }
        public virtual DbSet<Feats> Feats { get; private set; }
        public virtual DbSet<ItemCategories> ItemCategories { get; private set; }
        public virtual DbSet<Items> Items { get; private set; }
        public virtual DbSet<Player> Player { get; set; }
        public virtual DbSet<Races> Races { get; private set; }
        public virtual DbSet<Skills> Skills { get; private set; }

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
        }
    }
}
