using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListCollection
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Fruit> fruits = new List<Fruit>();
            fruits.Add(new Fruit{ Name = "Mango", Weight = 1, Color = "yellow"});

            foreach (Fruit ft in fruits)
            {
                Console.WriteLine("{0} {1} {2}", ft.Name, ft.Weight, ft.Color);
            }
            Console.ReadLine();
        }
    }
}
