using Cats.Data.Models;
using System.Collections.Generic;

namespace Cats.Data
{
    public interface ICatService
    {
        IEnumerable<Cat> GetAll();

        Cat GetById(int id);

        void Edit(Cat cat);

        void Add(string name, int age);

        void Delete(int id);
    }
}
