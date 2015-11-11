using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericList
{
    class Item
    {
        public int ID { get; set; }
        public string Name { get; set; }

        public static List<Item> GetItems(int numToGet)
        {
            var random = new Random();
            var newList = new List<Item>();
            Item newItem;
            for (int i = 0; i < numToGet; i++)
            {
                newItem = new Item()
                {
                    ID = random.Next(),
                    Name = "MyItem " + i.ToString()
                };
                newList.Add(newItem);
            }
            return newList;
        }

    }
}
