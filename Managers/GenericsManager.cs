using ConsoleApp3.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3.Managers
{
    public class GenericsManager<T> : IGeneric<T> where T:IProduct,new()
    {

        protected readonly List<T> _Products;

        public GenericsManager(List<T> values)
        {
            _Products = values;
        }
        public void Add(T product)
        {
            Console.WriteLine($"product id: {product.Id} product name:  {product.Name}, price: {product.Price}");
            _Products.Add(product);
            Console.WriteLine($" {product.Id}, {product.Name} {product.Price} Product added");
        }

        public void Delete(int id)
        {
            _Products.RemoveAt(id);
            Console.WriteLine($"{id} product deleted");
        }

        public IEnumerable<T> GetAll()
        {
            return _Products;
        }

        public T GetById(int id)
        {
            T data = _Products[id];
                
            foreach(T item in _Products)
            {
                if (item.Id == id)
                {
                    return item;
                }
            }
            return data;

        }

        public void Update(int id,T product)
        {
            //Console.WriteLine($"{product.Name}");
            foreach (var item in _Products)
            {
                if(item.Id == id)
                {
                    
                    item.Name=product.Name;
                    item.Price=product.Price;

                    //Console.WriteLine($"{item.Name}");
                }
            }
            Console.WriteLine("updated");
        }
    }
}
