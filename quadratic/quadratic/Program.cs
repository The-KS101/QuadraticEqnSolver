using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace quadratic
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Quadratic Equation Solver");
            Console.WriteLine("ax^2 + bx +  c");
            Console.WriteLine("Please input a");
            double a = double.Parse(Console.ReadLine());
            Console.WriteLine("Please input b");
            double b = double.Parse(Console.ReadLine());
            Console.WriteLine("Please input c");
            double c = double.Parse(Console.ReadLine());
            double discriminant = (b * b) - (4 * a * c);
            double solution1;
            double solution2;
            if (discriminant >= 0)
            {
                solution1 = (-b + Math.Sqrt(discriminant)) / (2 * a * c);
                solution2 = (-b - Math.Sqrt(discriminant)) / (2 * a * c);

                Console.WriteLine("x1 = {0} \nx2 = {1}", solution1, solution2);

            }

            else
            {
                Console.WriteLine("The solution does not exist in a real form only");
            }

            Console.ReadKey();
        }
    }
}
