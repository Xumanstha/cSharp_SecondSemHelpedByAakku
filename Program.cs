using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Child c = new Child();
            c.FProperty = "xadai xoina ";
            Console.WriteLine(c.FProperty);
            //c.Childname = "Suman";
            //Console.WriteLine(c.Childname);
            FullTimeEmployee employee = new FullTimeEmployee();
            employee.Name = "Suman";
            Console.WriteLine(employee.Name);
            Console.ReadLine();
        }
    }
}
