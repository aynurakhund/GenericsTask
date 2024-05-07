using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3.Interfaces
{
    public interface IGeneric<T> where T : IProduct, new()
    {
        void Add(T product);
        IEnumerable<T> GetAll();
        void Delete(int id);
        T GetById(int id);
        void Update(int id,T product);
    }
}
