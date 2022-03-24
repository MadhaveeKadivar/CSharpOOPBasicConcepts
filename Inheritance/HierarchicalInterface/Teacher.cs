using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopsConceptsofCSharp.Inheritance.HierarchicalInterface
{
    internal class Teacher
    {
        public string name,schoolName;
        public int age;
        public long mobileNumber;
        

        public Teacher(string name, int age,long mobileNumber, string schoolName)
        {
            this.name = name;
            this.age = age;
            this.mobileNumber = mobileNumber;
            this.schoolName = schoolName;
        }
        public void TeacherDetails()
        {
            Console.WriteLine($"Teacher's Name : {name}");
            Console.WriteLine($"Teacher's Age : {age}");
            Console.WriteLine($"Teacher's Moile Number : {mobileNumber}");
            Console.WriteLine($"Teacher's School Name : {schoolName}");
        }
    }
}
