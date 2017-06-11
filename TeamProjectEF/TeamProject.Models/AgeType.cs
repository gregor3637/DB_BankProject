using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TeamProject.Models
{
    public class AgeType
    {
        public AgeType()
        {
            this.IdentityCards = new HashSet<IdentityCard>();
        }

        public int ID { get; set; }
        public string Type { get; set; }

        public virtual ICollection<IdentityCard> IdentityCards { get; set; }
    }
}
