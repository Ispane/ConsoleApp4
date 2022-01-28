using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    internal class Program
    {
       
        static void Main(string[] args)
        {
            double a, x0, eps = 0.001;
 
            Console.WriteLine("Введите a: ");
            a = Convert.ToDouble(Console.ReadLine());
            double x = 0.5 * (1 + a);
            do
            {
                x0 = x;
                x = 0.5 * (x0 + a / x0);
            }
            while (Math.Abs(x - x0) > eps);
 
            Console.WriteLine("Простой X = {0}", simple(x0, x, a, eps));
            Console.WriteLine("Рекурсия X = {0}", recursion(x0, x, a, eps));
            Console.ReadKey();
            
        }
 
        static double simple(double x0, double x, double a, double eps) {
            do
            {
                x0 = x;
                x = 0.5 * (x0 + a / x0);
            }
            while (Math.Abs(x - x0) > eps);
            return x;
        }
        static double recursion(double x0, double x, double a, double eps) {
            x0 = x;
            x = 0.5 * (x0 + a / x0);
            
            if (Math.Abs(x - x0) > eps)
            {
                recursion(x0, x, a, eps);
            }
            return x;
 
        }
    }
}

