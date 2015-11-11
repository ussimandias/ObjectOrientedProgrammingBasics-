using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exceptions
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("First line in a program");
            //var x = 0;
            //var y = 12 / x;
            //Console.WriteLine("After the division");

            Tester t = new Tester();
            t.Method1();

            Console.ReadLine();
        }
    }
}
