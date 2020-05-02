using System.Collections.Generic;

namespace Cats.Data.Models
{
    public class Owner
    {
        public Owner()
        {
            Cats = new List<Cat>();
        }

        public int Id { get; set; }

        public string Name { get; set; }

        public int Age { get; set; }

        public virtual IEnumerable<Cat> Cats { get; set; }
    }
}
