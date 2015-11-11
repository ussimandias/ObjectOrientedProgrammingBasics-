using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DictionaryDemo
{
    public class State
    {
        public string Capital { get; set; }
        public int  Population { get; set; }
        public int Size { get; set; }

        public State(string capital, int pop, int size)
        {
            Capital = capital;
            Population = pop;
            size = Size;
        }

        public static Dictionary<string, State> GetStates()
        {
            var states = new Dictionary<string, State>();
            var theState = new State("Montgomery", 123456, 123);
            states.Add("Alabama", theState);
            theState = new State("New York", 4000000, 250);
            states.Add("New York", theState);

            return states;
        } 

    }
}
