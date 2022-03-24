using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopsConceptsofCSharp.Polymorphism.MethodOverriding
{
    internal class Employee
    {
        public string name;
        public int age;
        public int id;
        public long mobileNumber;

        public Employee(string name , int age,int id,long mobileNumber)
        {
            this.name = name;
            this.age = age;
            this.id = id;
            this.mobileNumber = mobileNumber;
        }
        public void EmployeeDetails()
        {
            Console.WriteLine($"Employee Name : {name}");
            Console.WriteLine($"Employee Age : {age}");
            Console.WriteLine($"Employee Id : {id}");
            Console.WriteLine($"Employee Moile Number : {mobileNumber}");
        }
        public void EmployeeSalary(int s)
        {
            Console.WriteLine("Employee salary " + s);
        }
    }
}
