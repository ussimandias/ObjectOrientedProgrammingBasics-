using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using OOP;

namespace OOP
{
    public class Item
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public virtual void Purchase()
        {
            Console.WriteLine("Purchasing {0}", Name);
        }

        public static Item GeItem()
        {
            var newItem = new Item()
            {
                ID = 101,
                Name = "MyItem"
            };
            return newItem;
        }
    }

    class Software : Item
    {
        public string ISBN { get; set; }
        public override void Purchase()
        {
            //base.Purchase();
            Console.WriteLine("My Id is {0} and my ISBN is {1}", ID, ISBN);

        }
    }

    class Hardware : Item
    {
        public string SerialNumber { get; set; }        
    }

    class Computer : Hardware
    {
        public string CPUType { get; set; }
        public string Disk { get; set; }
        public override void Purchase()
        {
            //base.Purchase();
            Console.WriteLine("My CPUType is{0}", CPUType);
        }
    }

    class Peripheral : Hardware
    {
        public string Description { get; set; }
    }
}
