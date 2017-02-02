using System;
using System.Linq;

namespace _06_FoldSum
{
    class Program
    {
        static void Main(string[] args)
        {
            var numbers = Console.ReadLine().
                Split(' ')
                .Select(int.Parse)
                .ToArray();

            int k = numbers.Length/4;

            var firstRowLeft = numbers
                .Take(k).
                Reverse()
                .ToArray();

            var firstRowRight = numbers
                .Reverse()
                .Take(k)
                .ToArray();
            var firstRow = firstRowLeft.Concat(firstRowRight);

            var secondRow = numbers.Skip(k).Take(2*k).ToArray();

            var result = firstRow.Zip(secondRow, (x, y) => x + y).ToList();

            Console.WriteLine(string.Join(" ",result));
            
        }
    }
}
