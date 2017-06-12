using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ExternalDataReader;
using Newtonsoft.Json;
using TeamProject.Models;

namespace TeamProjectEF
{
    class Startup
    {
        static void Main()
        {

            var dbContext = new LibraryDbContext();

            //Console.WriteLine("Started !");


            var bp = 3;
            //var result = dbContext.Towns.Where(s => s.Name == "Sofiaaa").ToList();
            //Console.WriteLine(" ~~~~~~~~~~~~~ " + result);

            //dbContext.Persons.Add(new Person
            //{
            //    AccountID = 155,
            //    IdentityCard = new IdentityCard
            //    {
            //        EGN = 890330999,
            //        FirstName = "Ivan",
            //        MiddleName = "Ivanov",
            //        LastName = "Simeonov",
            //        Address = new Address
            //        {
            //            AddressText = "Mladost 5",
            //            Town = new Town
            //            {
            //                Name = "Sofia"
            //            }
            //        },
            //        Age = 15,
            //        AgeType = new AgeType
            //        {
            //            Type = "child"
            //        }
            //    }

            //});

        }

        private static void CreatePeople(List<string> peopleData, LibraryDbContext dbContext)
        {   
            
        }
    }
}
