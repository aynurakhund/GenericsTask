using ConsoleApp3.classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3.Managers
{
    public class MealManager : GenericsManager<Meals>
    {
        public MealManager() : base(
            new List<Meals>
            {
                new Meals{Id=1,Name="Dolma",Price=15,Indrigients="Lamb"},
                new Meals{Id=2,Name="Plov",Price=20,Indrigients="rice"},
                new Meals{Id=3,Name="Chicken",Price=15,Indrigients="Chicken"},


            })
        {
        }
    }
}
