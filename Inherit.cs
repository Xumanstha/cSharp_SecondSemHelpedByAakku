using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    internal class Inherit
    {

    }
    public class Father
    {
        public string Fathername;
        public string FProperty;
        public int FAge;
    }
    public class Child : Father
    {
        public string Childname;
        public int Childage;
    }
}
