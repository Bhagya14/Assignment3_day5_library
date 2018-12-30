using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console_library_assignment
{
    class Program
    {
        static void Main(string[] args)
        {
        
                Console.WriteLine("enter n1 value:");
                int n1 = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("enter n2 value:");
                int n2 = Convert.ToInt32(Console.ReadLine());

                ClassLibrary_assignment.Class1 obj = new ClassLibrary_assignment.Class1();
                int sum = obj.Getsum(n1, n2);
                Console.WriteLine("sum" + sum);
                int multiply = obj.Getmultiply(n1, n2);
                Console.WriteLine("multiply: " + multiply);
                int divide = obj.Getdivide(n1, n2);
                Console.WriteLine("divide :" + divide);
                int subtract = obj.Getsubtract(n1, n2);
                Console.WriteLine("subtract:" + subtract);
                Console.ReadLine();


            }
        }
    }

