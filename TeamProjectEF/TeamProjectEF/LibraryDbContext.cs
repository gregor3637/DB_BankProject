using System;
using System.Collections.Generic;
using System.Data.Entity;
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


    }
}