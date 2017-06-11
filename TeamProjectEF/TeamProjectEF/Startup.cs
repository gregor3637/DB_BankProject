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
            //var dbContext = new LibraryDbContext();
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

            //dbContext.SaveChanges();

            //Console.WriteLine("Started !");

            var fileReader = new CustomFileReader();
            List<string> peopleData = fileReader.GetPeopleData();
            List<Person> people = CreatePeople(peopleData);

            var bp = "dasd";
        }

        private static List<Person> CreatePeople(List<string> peopleData)
        {   
            List<Person> people = new List<Person>();
            foreach (var dataOfPerson in peopleData)
            {
                Person person = JsonConvert.DeserializeObject<Person>(dataOfPerson);
                people.Add(person);
            }

            return people;
        }
    }
}
