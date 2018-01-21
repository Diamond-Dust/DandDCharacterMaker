namespace ADOHelper
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class ADOO : DbContext
    {
        public ADOO()
            : base("name=ADOO")
        {
        }

        public virtual DbSet<Alignments> Alignments { get; set; }
        public virtual DbSet<Classes> Classes { get; set; }
        public virtual DbSet<Deities> Deities { get; set; }
        public virtual DbSet<Feats> Feats { get; set; }
        public virtual DbSet<ItemCategories> ItemCategories { get; set; }
        public virtual DbSet<Items> Items { get; set; }
        public virtual DbSet<ModifierSets> ModifierSets { get; set; }
        public virtual DbSet<Player> Player { get; set; }
        public virtual DbSet<Races> Races { get; set; }
        public virtual DbSet<Skills> Skills { get; set; }
        public virtual DbSet<SkillSets> SkillSets { get; set; }
        public virtual DbSet<sysdiagrams> sysdiagrams { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Alignments>()
                .HasMany(e => e.Player)
                .WithRequired(e => e.Alignments)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Alignments>()
                .HasMany(e => e.Classes)
                .WithMany(e => e.Alignments)
                .Map(m => m.ToTable("AlignmentSets").MapLeftKey("AlignmentID").MapRightKey("ClassID"));

            modelBuilder.Entity<Classes>()
                .HasMany(e => e.Player)
                .WithRequired(e => e.Classes)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Classes>()
                .HasMany(e => e.Races)
                .WithOptional(e => e.Classes)
                .HasForeignKey(e => e.PreferredClassID);

            modelBuilder.Entity<Classes>()
                .HasMany(e => e.SkillSets)
                .WithRequired(e => e.Classes)
                .HasForeignKey(e => e.ClassPlayerModifierID)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Deities>()
                .HasMany(e => e.Player)
                .WithRequired(e => e.Deities)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Feats>()
                .HasMany(e => e.Player)
                .WithMany(e => e.Feats)
                .Map(m => m.ToTable("FeatSets").MapLeftKey("FeatID").MapRightKey("PlayerID"));

            modelBuilder.Entity<ItemCategories>()
                .HasMany(e => e.Items)
                .WithRequired(e => e.ItemCategories)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Items>()
                .HasMany(e => e.Player)
                .WithMany(e => e.Items)
                .Map(m => m.ToTable("ItemSets").MapLeftKey("ItemID").MapRightKey("PlayerID"));

            modelBuilder.Entity<ModifierSets>()
                .HasMany(e => e.Classes)
                .WithRequired(e => e.ModifierSets)
                .HasForeignKey(e => e.ModifiersID)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<ModifierSets>()
                .HasMany(e => e.Feats)
                .WithRequired(e => e.ModifierSets)
                .HasForeignKey(e => e.ModifiersID)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<ModifierSets>()
                .HasMany(e => e.Races)
                .WithRequired(e => e.ModifierSets)
                .HasForeignKey(e => e.ModifiersID)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<ModifierSets>()
                .HasMany(e => e.SkillSets)
                .WithRequired(e => e.ModifierSets)
                .HasForeignKey(e => e.ClassPlayerModifierID)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Player>()
                .HasMany(e => e.SkillSets)
                .WithRequired(e => e.Player)
                .HasForeignKey(e => e.ClassPlayerModifierID)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Races>()
                .HasMany(e => e.Player)
                .WithRequired(e => e.Races)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Skills>()
                .Property(e => e.KeyAbility)
                .IsFixedLength();

            modelBuilder.Entity<Skills>()
                .HasMany(e => e.SkillSets)
                .WithRequired(e => e.Skills)
                .WillCascadeOnDelete(false);
        }
    }
}
