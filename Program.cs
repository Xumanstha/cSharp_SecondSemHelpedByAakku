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

            //Child c = new Child();
            //c.FProperty = "xadai xoina ";
            //Console.WriteLine(c.FProperty);
            ////c.Childname = "Suman";
            ////Console.WriteLine(c.Childname);
            //FullTimeEmployee employee = new FullTimeEmployee();
            //employee.Name = "Suman";
            //Console.WriteLine(employee.Name);
            //Console.ReadLine();
            //Console.ReadKey();
            Manager employee1 = new Manager();
            PartTimeEmployee employee2= new PartTimeEmployee();
            Console.WriteLine("Enter the name of the employee for full time");
            employee1.Name = Console.ReadLine();
            Console.WriteLine($"the address:");
            employee1.Address = Console.ReadLine();
            Console.WriteLine("The salary:");
            employee1.Salary = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("the position of the employee:");
            employee1.Position = Console.ReadLine();
            //employee1.benefit();
            Console.WriteLine("Enter the bonus for this employee:");
            employee1.bonus= Convert.ToInt32(Console.ReadLine());
            employee1.dhanimanxe();
            Console.ReadLine();

            ////Console.WriteLine("Enter the name of the employee for part time");
            ////employee2.Name=Console.ReadLine();
            ////Console.WriteLine($"the address:");
            ////employee2.Address = Console.ReadLine();
            ////Console.WriteLine("The salary:");
            ////employee2.Salary = Convert.ToInt32(Console.ReadLine());
            ////Console.WriteLine("the position of the employee:");
            ////employee2.Position = Console.ReadLine();
            ////employee2.benefit();
            ////Console.ReadLine();
        }
    }
}
