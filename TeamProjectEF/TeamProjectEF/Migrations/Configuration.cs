namespace TeamProjectEF.Migrations
{
    using System;
    using System.Collections.Generic;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;
    using ExternalDataReader;
    using Newtonsoft.Json;
    using TeamProject.Models;

    internal sealed class Configuration : DbMigrationsConfiguration<TeamProjectEF.LibraryDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(TeamProjectEF.LibraryDbContext context)
        {

            var fileReader = new CustomFileReader();
            List<string> peopleData = fileReader.GetPeopleData();

            foreach (var dataOfPerson in peopleData)
            {
                Person person = JsonConvert.DeserializeObject<Person>(dataOfPerson);
                var sameNamedCities = context.Towns.Where(s => s.Name == person.IdentityCard.Address.Town.Name).ToList();

                if (sameNamedCities.Count > 0)
                {
                    person.IdentityCard.Address.Town = sameNamedCities[0];
                }

                context.Persons.Add(person);
                context.SaveChanges();
            }
        }
    }
}
