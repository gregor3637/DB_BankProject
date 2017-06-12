using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TeamProject.Models
{
    public class Person 
    {
        public  Person()
        {
            this.Hobbies = new HashSet<Hobby>();
        }

        [Key]
        public int ID { get; set; }

        public string Nickname { get; set; }

        public virtual IdentityCard IdentityCard { get; set; }

        public int AccountID { get; set; }

        public virtual ICollection<Hobby> Hobbies { get; set; }
    }
}
