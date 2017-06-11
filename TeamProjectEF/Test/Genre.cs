using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test
{

    public class Genre
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public virtual Genre ParentGenre { get; set; }

        public virtual ICollection<Book> Books { get; set; }

        public virtual ICollection<Genre> ChildGenres { get; set; }
    }
}
