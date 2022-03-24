using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopsConceptsofCSharp.Polymorphism.MethodOverriding
{
    internal class BackEndDeveloper : Employee
    {
        public BackEndDeveloper(string name, int age, int id, long mobileNumber) : base(name, age, id, mobileNumber)
        {
        }
        public void EmployeeSalary(int s)
        {
            Console.WriteLine($"{name} is a Back End Developer and salary is : {s}");
        }

    }
}
