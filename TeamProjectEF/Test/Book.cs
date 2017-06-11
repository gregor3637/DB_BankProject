using System.Collections.Generic;

namespace Test
{
    public class Book
    {
        public Book()
        {
            this.Ganres = new HashSet<Genre>();
        }

        public int Id { get; set; }

        public string Title { get; set; }


        public string Description { get; set; }

        public virtual ICollection<Genre> Ganres { get; set; }

    }

}
