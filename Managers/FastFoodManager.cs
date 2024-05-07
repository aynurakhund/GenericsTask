using ConsoleApp3.classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3.Managers
{
    public class FastFoodManager : GenericsManager<FastFood>
    {
        public FastFoodManager() : base(
            new List<FastFood>
            {
                new FastFood{ Id = 1,Name="Burger", Price = 10,Indrigients="Beef"},
                new FastFood{ Id = 2,Name="Nugets", Price = 7,Indrigients="Chicken"},
                new FastFood{ Id = 3,Name="Pizza", Price = 11,Indrigients="Margarita"}


            })
        {
        }
    }
}
