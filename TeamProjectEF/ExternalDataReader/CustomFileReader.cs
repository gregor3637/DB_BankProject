using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using TeamProject.Models;

namespace ExternalDataReader
{
    public class CustomFileReader
    {
        public CustomFileReader()
        {
        }

        public List<string> GetPeopleData()
        {
            List<string> peopleData = new List<string>();
            string[] fileEntries = Directory.GetFiles(@"C:\Users\Misho\Desktop\DB_BankProject\TeamProjectEF\ExternalDataReader\Data\");

            foreach (var filePath in fileEntries)
            {
                string personsDataAsTest = File.ReadAllText(filePath);
                peopleData.Add(personsDataAsTest);
            }

            return peopleData;
        }
    }
}
