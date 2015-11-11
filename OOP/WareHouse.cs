using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
    class WareHouse
    {
        public int ID { get; set; }
        public string WareHouseName { get; set; }

        //WareHouse Constructor
        public WareHouse(string Name, int ID)
        {
            WareHouseName = Name;
            this.ID = ID;
        }


        public Item FindAndReturnItem(int itemId)
        {
            Item returnItem = new Item()
            {
                ID = itemId,
                Name = "MicroSoft Office."
            };

            return returnItem;
        }
    }
}
