using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopsConceptsofCSharp.Polymorphism.MethodOverriding
{
    internal class DataScientist : Employee
    {
        public DataScientist(string name, int age, int id, long mobileNumber) : base(name, age, id, mobileNumber)
        {
           
        }
        public void EmployeeSalary(int s)
        { 
            Console.WriteLine($"{name} is a Data scientist and salary is : {s}");
        }
    }
}
