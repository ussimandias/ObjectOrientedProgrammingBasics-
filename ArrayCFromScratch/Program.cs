using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace ArrayCFromScratch
{
    class Program
    {
        static void Main(string[] args)
        {
        //    var items = new Item[5];
        //    Random r = new Random();
        //    for (int i = 0; i < items.Length; i++)
        //    {
        //        items[i] = new Item(r.Next());
        //    }

        //    Console.WriteLine("Items: ");
        //    foreach (Item indxItem in items)
        //    {
        //        Console.WriteLine("ItemID = {0}", indxItem.ID);
        //    }


        //    Item myItem = items[4];
        //    Console.WriteLine( "My item in index 4 is: {0}", myItem.ID );

            var Authors = new String[5];

            Authors[0] = "A";
            Authors[1] = "O";
            Authors[2] = "I";
            Authors[3] = "E";
            Authors[4] = "U";
            
            Console.WriteLine("Authors..");
            foreach (var auth in Authors)
            {
                Console.WriteLine(auth);
            }
            Console.WriteLine( "\n");

            Array.Sort(Authors);
            Console.WriteLine("Authors..");
            foreach (var auth in Authors)
            {
                Console.WriteLine(auth);
            }


            Console.ReadLine();
        }
    }
}
