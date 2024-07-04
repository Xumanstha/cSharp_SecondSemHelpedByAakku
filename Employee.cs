using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    public class Employee
    {
        public int ID;
        public string Name;
        public string Address;
        public string Position;
        public int Salary;
    }
   public class FullTimeEmployee:Employee
    {
        public int bonus;
        public void benefit()
        {
            Console.WriteLine($"{Name} is a full time employer getting more money who live in {Address} with {Position} and of {Salary} rupees salary");
        }
    }
   public  class PartTimeEmployee:Employee
    {

        public void benefit()
        {
            Console.WriteLine($"{Name} is a part time employer getting more money who live in {Address} with {Position} and of {Salary} rupees salary");
        }
    }
    public class Manager : FullTimeEmployee
    {
public void dhanimanxe()
        {
            Console.WriteLine("Ma lastai kamauxu yarr");
            Console.WriteLine($"{Name} is a full time employer getting more money who live in {Address} with {Position} and of {Salary+bonus} rupees salary including bonus");
        }
    }
    public class Marketing_manager : PartTimeEmployee
    {

    }

}
