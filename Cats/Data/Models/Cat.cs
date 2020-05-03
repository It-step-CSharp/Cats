namespace Cats.Data.Models
{
    using System.ComponentModel;
    using System.ComponentModel.DataAnnotations;

    public class Cat
    {
        public int Id { get; set; }

        [Required, DisplayName("Cat name:")]
        public string Name { get; set; }

        [Range(1, 100) ,DisplayName("Cat age:")]
        public int Age { get; set; }
    }
}
