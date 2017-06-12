using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test
{
    public class Ninja
    {
        public Ninja()
        {
            this.Weapons = new HashSet<Weapon>();
        }

        public int Id { get; set; }

        public virtual ICollection<Weapon> Weapons { get; set; }
    }
}
