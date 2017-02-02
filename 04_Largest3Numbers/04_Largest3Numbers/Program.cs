using System;
using System.Linq;

namespace _04_Largest3Numbers
{
    class Program
    {
        static void Main(string[] args)
        {

            var result=Console.ReadLine().Split(' ').Select(double.Parse).OrderByDescending(n => n).Take(3).ToList();

            Console.WriteLine(string.Join(" ",result));
        }
    }
}
