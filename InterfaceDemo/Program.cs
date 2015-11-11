using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            var storableObjects = new List<Storable>();
            Note myNote = new Note();
            storableObjects.Add(myNote);
            DBEntry myDbEntry = new DBEntry();
            storableObjects.Add(myDbEntry);
            myDbEntry = new DBEntry();
            storableObjects.Add(myDbEntry);
            myNote = new Note();
            storableObjects.Add(myNote);
            myDbEntry = new DBEntry();
            storableObjects.Add(myDbEntry);
            myNote = new Note();
            storableObjects.Add(myNote);

            foreach (Storable storable in storableObjects)
            {
                storable.Write(null);
                Console.WriteLine(storable.Read());
            }

            Console.ReadLine();
        }
    }
}
