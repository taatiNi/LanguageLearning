using System;
using System.Collections.Generic;
using System.Text;
using Language.Domain;
using Microsoft.EntityFrameworkCore;

namespace Language.Data
{
    public class LanguageEntityContext : DbContext
    {
        public DbSet<Profile> Profiles { get; set; }
        public DbSet<Experience> Experiences { get; set; }
        public DbSet<Package> Packages { get; set; }
        public DbSet<Principal> Principals { get; set; }
        public DbSet<Summary> Summaries { get; set; }
        public DbSet<WordItem> WordItems { get; set; }
        public DbSet<Message> Messages { get; set; }
        public DbSet<Package_Principal> Package_Principals { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {

            optionsBuilder
                .UseSqlServer("Data Source= .; Integrated Security=true;Initial Catalog=LanguageLearning; uid=sa; Password=sa; ");

        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Principal>(msg =>
            {
                msg.HasOne(field => field.Profile).WithOne(fk => fk.Principal)
                    .HasForeignKey<Principal>(f => f.ProfileId);
                msg.ToTable("Principal");
            });
            modelBuilder.Entity<Profile>(msg =>
            {
                msg.HasOne(field => field.Summary).WithOne(fk => fk.Profile)
                    .HasForeignKey<Profile>(f => f.SummaryId);
            });
            modelBuilder.Entity<Message>(msg =>
            {
                (msg.HasOne(field => field.Sender).WithMany(fk => fk.SendMessages)).HasForeignKey(fk => fk.SenderId).Metadata.DeleteBehavior = DeleteBehavior.NoAction;
                msg.HasOne(field => field.Receiver).WithMany(fk => fk.ReceivedMessages).HasForeignKey(fk => fk.ReceiverId).Metadata.DeleteBehavior = DeleteBehavior.NoAction; ;
            });
            modelBuilder.Entity<Package_Principal>(pp =>
            {
                pp.HasKey(field => new { field.PackageId, field.PrincipalId });
                pp.HasOne(field => field.Principal).WithMany(field => field.PackagePrincipals).HasForeignKey(field => field.PrincipalId);
                pp.HasOne(field => field.Package).WithMany(field =>
                    field.PackagePrincipals).HasForeignKey(field => field.PackageId);
            });
        }
    }
}
