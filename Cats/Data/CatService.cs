namespace Cats.Data
{
    using Cats.Data.Models;
    using System.Collections.Generic;
    using System.Linq;
    using System.Security.Cryptography.X509Certificates;

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

        public void Add(string name, int age)
        {
            using var db = new ApplicationDbContext();
            db.Cats.Add(new Cat { Name = name, Age = age});
            db.SaveChanges();
        }

        public void Delete(int id)
        {
            using var db = new ApplicationDbContext();
            var catToDelete = db.Cats.FirstOrDefault(x => x.Id == id);
            db.Cats.Remove(catToDelete);
            db.SaveChanges();
        }
    }
}
