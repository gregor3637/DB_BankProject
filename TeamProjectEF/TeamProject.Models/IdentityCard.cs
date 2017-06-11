using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TeamProject.Models
{
    public class IdentityCard
    {
        [Key]
        public int ID { get; set; }

        [Required]
        public virtual Person Person { get; set; }

        [Range(1,10)]
        public int EGN { get; set; }

        [StringLength(40)]
        public string FirstName { get; set; }

        [StringLength(40)]
        public string MiddleName { get; set; }

        [StringLength(40)]
        public string LastName { get; set; }

        [Range(1, 10)]
        public int Age { get; set; }

        public virtual AgeType AgeType { get; set; }
        
        [Required]
        public virtual Address Address { get; set; }

        [Column(TypeName = "ntext")]
        public string DistinctiveElements { get; set; }
    }
}
