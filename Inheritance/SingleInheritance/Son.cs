using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopsConceptsofCSharp.Inheritance.SingleInheritance
{
    internal class Son : Father
    {
        public void Books()
        {
            Console.WriteLine("Son is studying in 5th So He has study books\n");
        }
        public void games()
        {
            Console.WriteLine("Son has games like Chess,Ludo,etc...\n");
        }
        public void FatherProperty()
        {
            Console.WriteLine("Son also having his father Property");
        }
    }
}
