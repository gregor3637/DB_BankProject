using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TeamProject.Models
{
    public class Address
    {
        public Address()
        {
            this.IdentityCards = new HashSet<IdentityCard>();
        }

        public int ID { get; set; }
        public string AddressText { get; set; }

        public virtual ICollection<IdentityCard> IdentityCards { get; set; }

        public virtual Town Town { get; set; }
    }
}
