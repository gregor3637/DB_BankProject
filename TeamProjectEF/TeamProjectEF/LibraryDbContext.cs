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

        public DbSet<Person> Person { get; set; }
        public DbSet<IdentityCard> IdentityCard { get; set; }
        public DbSet<Town> Town { get; set; }


    }
}