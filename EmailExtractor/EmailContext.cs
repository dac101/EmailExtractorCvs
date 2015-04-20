namespace EmailExtractor
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class EmailContext : DbContext
    {
        public EmailContext()
            : base("name=EmailContext")
        {
        }

        public virtual DbSet<MassPromotionContact> MassPromotionContacts { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<MassPromotionContact>()
                .Property(e => e.firstName)
                .IsUnicode(false);

            modelBuilder.Entity<MassPromotionContact>()
                .Property(e => e.lastName)
                .IsUnicode(false);

            modelBuilder.Entity<MassPromotionContact>()
                .Property(e => e.email)
                .IsUnicode(false);

            modelBuilder.Entity<MassPromotionContact>()
                .Property(e => e.phoneNumber)
                .IsUnicode(false);

            modelBuilder.Entity<MassPromotionContact>()
                .Property(e => e.address)
                .IsUnicode(false);

            modelBuilder.Entity<MassPromotionContact>()
                .Property(e => e.country)
                .IsUnicode(false);

            modelBuilder.Entity<MassPromotionContact>()
                .Property(e => e.state)
                .IsUnicode(false);
        }
    }
}
