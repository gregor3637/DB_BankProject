using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Data.Entity.Infrastructure.Annotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TeamProject.Models;
using Test;

namespace TeamProjectEF
{
    public class LibraryDbContext : DbContext
    {
        public LibraryDbContext()
            : base("LibraryConnection")
        {

        }

        public DbSet<Person> Persons { get; set; }

        public DbSet<IdentityCard> IdentityCards { get; set; }

        public DbSet<Town> Towns { get; set; }

        public DbSet<Address> Addresses { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            this.OnAddressModelCreating(modelBuilder);
            this.OnAgeTypeModelCreating(modelBuilder);
            this.OnTownModelCreating(modelBuilder);

            base.OnModelCreating(modelBuilder);
        }

        private void OnAddressModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Address>()
                .Property(a => a.AddressText)
                .IsRequired();

            modelBuilder.Entity<Address>()
              .Property(a => a.AddressText)
              .IsRequired()
              .HasMaxLength(40);
        }

        private void OnAgeTypeModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<AgeType>()
               .HasKey(a => a.ID);

            modelBuilder.Entity<AgeType>()
               .Property(a => a.Type)
               .IsRequired()
               .HasMaxLength(40);
        }

        private void OnTownModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Town>()
               .HasKey(t => t.ID);

            modelBuilder.Entity<Town>()
               .Property(t => t.Name)
               .IsRequired()
               .HasMaxLength(40)
               .HasColumnAnnotation(
                    "Index",
                    new IndexAnnotation(
                        new IndexAttribute("IX_Name")
                        {
                            IsUnique = true
                        }
                    )
                );
        }
    }
}