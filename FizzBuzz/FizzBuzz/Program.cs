using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FizzBuzz
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 1; i <= 35; i++)
            {
                FizzBuzzFunction(i);
            }
        }

        static void FizzBuzzFunction(int num)
        {
            if ((num % 3 == 0) && (num % 5 == 0))
            {
                Console.WriteLine("Fizz Buzz");
            }
            else if (num % 5 == 0)
            {
                Console.WriteLine("Fizz");
            }
            else if (num % 3 == 0)
            {
                Console.WriteLine("Buzz");
            }
            else
            {
                Console.WriteLine(num);
            }
        }
    }
}
