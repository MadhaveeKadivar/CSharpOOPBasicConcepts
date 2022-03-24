using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopsConceptsofCSharp.Polymorphism.MethodOverloading
{
    internal class Calculator
    {
        public int a = 30, b = 90;
        public void add()
        {
            Console.WriteLine("Method witout parameters is called");
            Console.WriteLine($"The addition of {a} and {b} is : {a + b}\n");
        }
        public void add(int a, int b)
        {
            Console.WriteLine("Method having 2 int type parameters is called");
            Console.WriteLine($"The addition of {a} and {b} is : {a + b}\n");
        }
        public void add(int a, int b, int c)
        {
            Console.WriteLine("Method having 3 int type parameters is called");
            Console.WriteLine($"The addition of {a} and {b} is : {a + b + c}\n");
        }
        public void add(string a, string b)
        {
            Console.WriteLine("Method having 2 string type parameters is called");
            Console.WriteLine($"The addition of {a} and {b} is : {a + b}\n");
        }
        public void add(int a, double b, int c)
        {
            Console.WriteLine("Method having first int type parameter,second double type parameters and third int type parameter is called");
            Console.WriteLine($"The addition of {a} and {b} is : {a + b + c}\n");
        }
        public void add(int a, int b, double c)
        {
            Console.WriteLine("Method having first int type parameter,second int type parameters and third double type parameter is called");
            Console.WriteLine($"The addition of {a} and {b} is : {a + b + c}\n");
        }
    }
}
