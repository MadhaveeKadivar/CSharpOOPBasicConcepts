using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopsConceptsofCSharp.Abstarction
{
    abstract class Shape
    {
        public abstract void Area();
    }


    class Circle : Shape
    {
        public double r;
        public void Radius()
        {
            Console.WriteLine("Enter radius of Circle : ");
            r = Convert.ToDouble(Console.ReadLine());
        }
        public override void Area()
        {
            double a = 3.14 * r * r;
            Console.WriteLine($"Area of Circle is : {a}");
        }
    }

    class Square : Shape
    {
        public double l;
        public void Length()
        {
            Console.WriteLine("Enter length of Square : ");
            l = Convert.ToDouble(Console.ReadLine());
        }
        public override void Area()
        {
            double ar = l * l;
            Console.WriteLine($"Area of Circle is : {ar}");
        }
    }
}


