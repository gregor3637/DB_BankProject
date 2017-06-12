using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TeamProjectEF;

namespace TeamProject.Models.CRUDActions
{
    public class Create
    {
        public static void User(LibraryDbContext dbContext)
        {
            using (dbContext)
            {
                Console.WriteLine("  Provide FirstName:");
                string firstName = Console.ReadLine();

                Console.WriteLine("  Provide MiddleName:");
                string middleName = Console.ReadLine();

                Console.WriteLine("  Provide LastName:");
                string lastName = Console.ReadLine();

                Console.WriteLine("  Provide Nickname:");
                string nickname = Console.ReadLine();

                Console.WriteLine("  Provide EGN (must contain only numbers):");
                long egn = GetEng();

                Console.WriteLine("  Provide Address:");
                string address = Console.ReadLine();

                Console.WriteLine("  Provide Town:");
                string town = Console.ReadLine();

                Console.WriteLine("  Provide Hobby:");
                string hobbyName = Console.ReadLine();
                Hobby hobby = new Hobby { Name = hobbyName };

                Console.WriteLine("  Provide Age:");
                int age = int.Parse(Console.ReadLine());

                string ageType = CalculateAgeType(age);

                Console.WriteLine("  Provide AccountID:");
                int accountID = int.Parse(Console.ReadLine());

                dbContext.Persons.Add(new Person
                {
                    AccountID = accountID,
                    Nickname = nickname,
                    IdentityCard = new IdentityCard
                    {
                        EGN = egn.ToString(),
                        FirstName = firstName,
                        MiddleName = middleName,
                        LastName = lastName,
                        Address = new Address
                        {
                            AddressText = address,
                            Town = new Town
                            {
                                Name = town
                            }
                        },
                        Age = age,
                        AgeType = new AgeType
                        {
                            Type = ageType
                        }
                    },
                    Hobbies = new HashSet<Hobby> { hobby }
                });

                dbContext.SaveChanges();
            }
        }


        private static string CalculateAgeType(int age)
        {
            var type = string.Empty;

            if (age < 10)
            {
                type = "kid";
            }
            else if (age > 10 && age < 20)
            {
                type = "teen";
            }
            else
            {
                type = "adult";
            }

            return type;
        }

        private static long GetEng()
        {
            long number;
            bool check;
            do
            {
                check = long.TryParse(Console.ReadLine(), out number);
            }
            while (!check);

            return number;
        }

    }
}
