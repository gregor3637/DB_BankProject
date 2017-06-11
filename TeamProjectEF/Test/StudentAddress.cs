using System.ComponentModel.DataAnnotations;

namespace Test
{
    public class StudentAddress
    {
        [Key]
        public int StudentID { get; set; }
        public string Address1 { get; set; }
        public string Address2 { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        [Required]
        public virtual Student Student { get; set; }
    }

}
