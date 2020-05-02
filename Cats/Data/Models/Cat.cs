using System.ComponentModel;

namespace Cats.Data.Models
{
    public class Cat
    {
        public int Id { get; set; }

        [DisplayName("Cat name:")]
        public string Name { get; set; }

        [DisplayName("Cat age:")]
        public int Age { get; set; }
    }
}
