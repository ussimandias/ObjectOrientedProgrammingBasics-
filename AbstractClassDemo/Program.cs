using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClassDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            var emp1 = new Worker();
            emp1.Name = "David";
            emp1.Salary = 32000;

            var emp2 = new Worker();
            emp2.Name = "Goliath";
            emp2.Salary = 55000;

            var emp3 = new Manager();
            emp3.Name = "Esther";
            emp3.Salary = 100000;


             var employees = new List<Employee>();
            employees.Add(emp1);
            employees.Add(emp2);
            employees.Add(emp3);

            foreach (Employee emp in employees)
            {
                Console.WriteLine("My name is {0} and I used to make {1}", emp.Name, emp.Salary );

                emp.GiveRaise();
                Console.WriteLine("now {0} makes {1} ", emp.Name, emp.Salary + "\n");
            }

            Console.ReadLine();
        }
    }
}
