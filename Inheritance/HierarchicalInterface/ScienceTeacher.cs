using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopsConceptsofCSharp.Inheritance.HierarchicalInterface
{
    internal class ScienceTeacher : Teacher
    {
        public ScienceTeacher(string name, int age, long mobileNumber, string schoolName) : base(name, age, mobileNumber, schoolName)
        {
        }

        public void Subject()
        {
            Console.WriteLine($"{name} is teaching Science subject");
        }
    }
}
