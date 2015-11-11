using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
    class Program
    {
        static void Main(string[] args)
        {
            //var newWareHouse = new WareHouse("WareHouse1", 101);
            //var myItem = newWareHouse.FindAndReturnItem(101);
            //Console.WriteLine("My new Item is "+ myItem.Name, myItem.ID);

            Computer myComputer = new Computer();
            myComputer.ID = 102;

            Item mySecondComputer = new Computer();
            mySecondComputer.ID = 102;
            Computer mySecondComputer2 = mySecondComputer as Computer;
            mySecondComputer2.CPUType = " iOS 10 El Capitan..";

            //string myCPUType = mySecondComputer2.CPUType;
            //Console.WriteLine(myCPUType);

            mySecondComputer2.Name = "Mercury";

            mySecondComputer2.Purchase();

            Software mySoftware = new Software();
            mySoftware.ISBN = "1234";
            mySoftware.Name = "ios";
            mySoftware.ID = 103;
            mySoftware.Purchase();
           
            Console.ReadLine();
        }
    }
}
