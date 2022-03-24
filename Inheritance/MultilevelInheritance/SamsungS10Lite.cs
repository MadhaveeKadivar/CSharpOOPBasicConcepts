using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopsConceptsofCSharp.Inheritance.MultilevelInheritance
{
    internal class SamsungS10Lite : Samsung
    {
        public void model()
        {
            Console.WriteLine("Mobile Model name : Samsung S10 Lite");
        }
        public void Specifications()
        {
            Console.WriteLine("Samsung S10 Lite mobile Specification");
            Console.WriteLine("Battery : 6000mah");
            Console.WriteLine("Camera : 64mp");
            Console.WriteLine("RAM : 16 GB");
            Console.WriteLine("Storage : 500GB");
        }
    }
}
