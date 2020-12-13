using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Questions_01
{
    class Program
    {
        //Given an array of ints, write a C# method to total all the values that are even numbers.
        static void Main(string[] args)
        {
            var numbers = new long[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            var sum = GetTotal(numbers);

            Console.WriteLine(sum);
            Console.ReadLine();

        }
        public static long GetTotal(long[] numbers)
        {
             return numbers.Where(x => x % 2 == 0).Sum(x => (long)x);
           // return (from n in numbers where n % 2 == 0 select (long)n).Sum();
        }
    }
}
