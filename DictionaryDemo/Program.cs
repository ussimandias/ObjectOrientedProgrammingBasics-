using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DictionaryDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            //Dictionary<string, string> capitals = new Dictionary<string, string>();
            //capitals.Add("Alabama","Montgomery");
            //capitals.Add("Alaska", "Juneau");
            //capitals.Add("Arizona", "Phoenix");
            //capitals.Add("Massachusetts", "Boston");
            //capitals.Add("Wyoming", "Cheyenne");

            //string capitalOfMass = capitals["Massachusetts"];
            //Console.WriteLine("The capital of Massachusetts is {0}", capitalOfMass);

            var theStates = State.GetStates();
            //string captialOfNewYork = theStates["New York"].Capital;
            //Console.WriteLine(  "The Capital of New York City is {0}", captialOfNewYork);

            var theState = theStates["Alabama"];
            Console.WriteLine("The Capital of Alabama is {0}, Its population is {1}, and its square miles is {2}", theState.Capital, theState.Population, theState.Size);
            Console.ReadLine();
        }
    }
}
