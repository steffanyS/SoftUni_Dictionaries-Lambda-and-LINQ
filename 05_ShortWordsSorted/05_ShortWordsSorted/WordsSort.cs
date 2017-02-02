using System;
using System.Linq;

namespace _05_ShortWordsSorted
{
    class WordsSort
    {
        static void Main(string[] args)
        {
            var words = Console.ReadLine()
                .ToLower()
                .Split(new[] {' ', '.', ',', ':', ';', ')', '(', '[', ']', '{', '}','"','/','\\','?','!'}, StringSplitOptions.RemoveEmptyEntries)
                .ToList();

            var result = words
                .OrderBy(x => x)
                .Distinct()
                .Where(x => x.Length < 5)
                .ToList();

            Console.WriteLine(string.Join(", ",result));
        }
    }
}
