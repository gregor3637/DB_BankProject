using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TeamProject.Models
{
    public class Hobby
    {
        public Hobby()
        {
            this.Persons = new HashSet<Person>();
        }

        [Key]
        public int ID { get; set; }

        public virtual ICollection<Person> Persons { get; set; }
    }


}
