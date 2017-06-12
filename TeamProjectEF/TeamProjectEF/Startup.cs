using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ExternalDataReader;
using Newtonsoft.Json;
using TeamProject.Models;
using TeamProject.Models.CRUDActions;

namespace TeamProjectEF
{
    class Startup
    {
        static void Main()
        {

            var dbContext = new LibraryDbContext();

            StartUserCommunication(dbContext);



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

        private static void StartUserCommunication(LibraryDbContext dbContext)
        {
            Console.WriteLine("Hello! Please select which CRUD operation you want to execute");
            Console.WriteLine("1(Create) , 2 (Retrieve), 3 (Update), 4(Delete)");
            var userOperationChoice = int.Parse(Console.ReadLine());

            ProceedWithUserOperationChoice(userOperationChoice, dbContext);
        }

        private static void ProceedWithUserOperationChoice(int userOperationChoice, LibraryDbContext dbContext)
        {
            switch (userOperationChoice)
            {
                case 1:
                    Create.User(dbContext);
                    break;
                case 2:
                    ExecuterRetrieveSteps();
                    break;
                case 3:
                    ExecuterUpdateSteps();
                    break;
                case 4:
                    ExecuterDeleteSteps();
                    break;

                default: break;
            }
        }

        private static void ExecuterDeleteSteps()
        {
           
        }

        private static void ExecuterUpdateSteps()
        {
            
        }

        private static void ExecuterRetrieveSteps()
        {
            
        }

        private static void ExecuteCreationSteps(LibraryDbContext dbContext)
        {
            
        }

        private static void CreatePeople(List<string> peopleData, LibraryDbContext dbContext)
        {   
            
        }

        
    }
}
