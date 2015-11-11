using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceDemo
{
    public class DBEntry : Storable
    {
        public void Write(object obj)
        {
            Console.WriteLine("Writing obj to disk...");
        }

        public string Read()
        {
              return "Reading note from disk...";
        }

        private ReturnStatus _status;
        public ReturnStatus Status
        {
            get { return _status; }

            set { _status = value; }
        }
    }
}
