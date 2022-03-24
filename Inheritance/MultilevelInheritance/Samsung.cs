using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopsConceptsofCSharp.Inheritance.MultilevelInheritance
{
    internal class Samsung : Mobile
    {
        public void Brand()
        {
            Console.WriteLine("Mobile Brand : Samsung");
        }
        public void OS()
        {
            Console.WriteLine("Mobile Operating System : Android");
        }
    }
}
