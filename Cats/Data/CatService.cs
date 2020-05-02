namespace Cats.Data
{
    using Cats.Data.Models;
    using System.Collections.Generic;
    using System.Linq;

    public class CatService : ICatService
    {
        public void Edit(Cat cat)
        {
            using var db = new ApplicationDbContext();
            var catToEdit = db.Cats.FirstOrDefault(x => x.Id == cat.Id);
            if (catToEdit != null)
            {
                catToEdit.Name = cat.Name;
                catToEdit.Age = cat.Age;
                db.SaveChanges();
            }
        }

        public IEnumerable<Cat> GetAll()
        {
            using var db = new ApplicationDbContext();
            return db.Cats.ToList();
        }

        public Cat GetById(int id)
        {
            using var db = new ApplicationDbContext();
            return db.Cats.FirstOrDefault(x => x.Id == id);
        }
    }
}
