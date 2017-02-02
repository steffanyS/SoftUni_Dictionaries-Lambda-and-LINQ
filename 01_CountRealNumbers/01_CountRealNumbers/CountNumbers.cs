using System;
using System.Collections.Generic;
using System.Linq;

namespace _01_CountRealNumbers
{
    class CountNumbers
    {
        static void Main(string[] args)
        {
            var numbers = Console.ReadLine().Split(' ').Select(double.Parse);
            var result=new SortedDictionary<double,int>();

            foreach (var number in numbers)
            {
                if (!result.ContainsKey(number))
                {
                    result[number] = 0;
                }
                result[number]++;
            }

            foreach (var item in result)
            {
                Console.WriteLine("{0} -> {1}",item.Key,item.Value);
            }
            {
                
            }
        }
    }
}
