using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OopsConceptsofCSharp.Abstarction;
using OopsConceptsofCSharp.ClassandObjects;
using OopsConceptsofCSharp.Encapsulation;
using OopsConceptsofCSharp.Inheritance.HierarchicalInterface;
using OopsConceptsofCSharp.Inheritance.MultilevelInheritance;
using OopsConceptsofCSharp.Inheritance.SingleInheritance;
using OopsConceptsofCSharp.Interface;
using OopsConceptsofCSharp.Polymorphism.MethodOverloading;
using OopsConceptsofCSharp.Polymorphism.MethodOverriding;

namespace OopsConceptsofCSharp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while(true)
            {
                Console.WriteLine("\n\nBasic OOPs Concept\n");
                Console.Write("1.Simple Class and Object Demo\n2.Polymorphism\n3.Inheritence\n");
                Console.WriteLine("4.Abstarction\n5.Interface\n6.Encapsulation\n7.Exit");
                Console.WriteLine("Enter any choice : ");
                int c = Convert.ToInt32(Console.ReadLine());

                switch (c)
                {
                    case 1:
                        Car car1 = new Car("Lamborghini", "Black");
                        car1.CarDetails();

                        Car car2 = new Car("Jaguar", "White");
                        car2.CarDetails();
                        break;
                    case 2:
                        Console.WriteLine("1.Method Overloading\n2.Method Overriding");
                        Console.WriteLine("Enter any choice : ");
                        int ch = Convert.ToInt32(Console.ReadLine());
                        if (ch == 1)
                        {
                            Console.WriteLine("\nMethod Overloading Example\n");
                            Calculator calculator = new Calculator();
                            calculator.add(33, 99);
                            calculator.add("33", "99");
                            calculator.add(33, 99.63, 45);
                            calculator.add(33, 99, 17.221);
                            calculator.add();
                        }
                        else if (ch == 2)
                        {
                            Console.WriteLine("\nMethod Overriding Example\n");
                            DataScientist dataScientist = new DataScientist("Alice", 24, 105, 9998999899);
                            dataScientist.EmployeeDetails();
                            dataScientist.EmployeeSalary(600000);
                            Console.WriteLine();
                            BackEndDeveloper backEndDeveloper = new BackEndDeveloper("John", 25, 101, 9789878978);
                            backEndDeveloper.EmployeeDetails();
                            backEndDeveloper.EmployeeSalary(400000);

                        }
                        else
                        {
                            Console.WriteLine("Enter valid choice");
                        }
                        break;
                    case 3:
                        Console.WriteLine("1.Simple Inheritance\n2.Hierarchical Inheritance\n3.Multilevel Inheritance");
                        Console.WriteLine("Enter any choice : ");
                        int choice = Convert.ToInt32(Console.ReadLine());
                        if (choice == 1)
                        {
                            Console.WriteLine("\nSimple Inheritance Example\n");
                            Son son = new Son();
                            son.Books();
                            son.games();
                            son.FatherProperty();
                            son.Property();
                        }
                        else if (choice == 2)
                        {
                            Console.WriteLine("\nHierarchical Inheritance Example\n");
                            MathsTeacher mathsTeacher = new MathsTeacher("Kyara", 25, 9797979797, "Saint Marry Public school");
                            mathsTeacher.TeacherDetails();
                            mathsTeacher.Subject();
                            Console.WriteLine("");
                            ScienceTeacher scienceTeacher = new ScienceTeacher("Myra", 25, 9989989595, "Delhi Public school");
                            scienceTeacher.TeacherDetails();
                            scienceTeacher.Subject();

                        }
                        else if (choice == 3)
                        {
                            Console.WriteLine("\nMultilevel Inheritance Example\n");
                            SamsungS10Lite samsungS10Lite = new SamsungS10Lite();
                            samsungS10Lite.Brand();
                            samsungS10Lite.model();
                            samsungS10Lite.OS();
                            samsungS10Lite.MobileFeatures();
                            samsungS10Lite.Specifications();

                        }
                        else
                        {
                            Console.WriteLine("Enter valid choice");
                        }
                        break;
                    case 4:

                        Console.WriteLine("Abstraction Example\n");
                        Circle circle = new Circle();

                        circle.Radius();
                        circle.Area();

                        Square square = new Square();
                        square.Length();
                        square.Area();
                        break;

                    case 5:
                        Console.WriteLine("\nInterface Example\n");

                        Morning morning = new Morning();
                        morning.Name();
                        morning.Greetings();
                        Console.WriteLine();
                        Night night = new Night();
                        night.Name();
                        night.Greetings();
                        break;

                    case 6:
                        Console.WriteLine("\nEncapsulation Example");
                        Bank bank = new Bank();
                        bank.Withdraw(20000);
                        bank.Credit(50000);
                        Console.WriteLine($"\nTotal avilable Balance in your Account is : {bank.getBalance()}");
                        break;
                    case 7:
                        System.Environment.Exit(0);
                        break;
                    default:
                        Console.WriteLine("Enter valid choice");
                        break;

                }
                
            }
            
           
            
        }
    }
}
