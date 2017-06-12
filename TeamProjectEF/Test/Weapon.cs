using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test
{
    public class Weapon
    {
        public Weapon()
        {
            this.Ninjas = new HashSet<Ninja>();
        }

        public int Id { get; set; }

        public virtual ICollection<Ninja> Ninjas { get; set; }
    }
}
