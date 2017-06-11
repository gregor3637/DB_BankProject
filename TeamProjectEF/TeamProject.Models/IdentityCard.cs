using System.ComponentModel.DataAnnotations;

namespace TeamProject.Models
{
    public class IdentityCard
    {
        [Key]
        public int ID { get; set; }

        [Required]
        public virtual Person Person { get; set; }

        public int EGN { get; set; }

        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }

        public virtual AgeType AgeType { get; set; }
        public virtual Address Address { get; set; }
    }

    //public class Address
    //{
    //}

    //public class Town
    //{
    //}

    //public class AgeType
    //{
    //}

}
