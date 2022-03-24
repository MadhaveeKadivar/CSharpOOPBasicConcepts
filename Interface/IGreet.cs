using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopsConceptsofCSharp.Interface
{
    internal interface IGreet
    {
        void Greetings();
    }
    class Morning : IGreet
    {
        public string n;
        public void Name()
        {
            Console.WriteLine("Enter your name : ");
            n = Console.ReadLine();
        }
        public void Greetings()
        {
            Console.WriteLine($"\nHello {n} ! Good Morning");
        }
    }
    class Night : IGreet
    {
        public string yourName;
        public void Name()
        {
            Console.WriteLine("Enter your name : ");
            yourName = Console.ReadLine();
        }
        public void Greetings()
        {
            Console.WriteLine($"\nHello {yourName} ! Good Night");
        }
    }
}
