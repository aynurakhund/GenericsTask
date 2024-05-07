using ConsoleApp3.classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3.Managers
{
    public class SweetsManager : GenericsManager<Sweets>
    {
        public SweetsManager() : base(
            new List<Sweets>
            {
                new Sweets{Id=1,Name="apple Pie", Price=3},
                new Sweets{Id=2,Name="Chocolate", Price=2},

            })
        {
        }
    }
}
