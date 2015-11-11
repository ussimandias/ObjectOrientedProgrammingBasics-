using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericList
{
    class Program
    {
        static void Main(string[] args)
        {
            //Random r = new Random();

            //List<int> myList = new List<int>();
            //for (int i = 0; i < 10; i++)
            //{
            //    myList.Add(r.Next());
            //}

            //myList.Sort();

            //foreach (var indx in myList)
            //{
            //   Console.WriteLine(indx);  
            //}

            List<Item> myItems = Item.GetItems(20);
            foreach (var item in myItems)
            {
                Console.WriteLine("New Item ID = {0}, Name = {1}", item.ID, item.Name);
            }
           
            Console.ReadLine();
        }
    }
}
