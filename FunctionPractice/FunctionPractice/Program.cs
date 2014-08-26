using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FunctionPractice
{
    class Program
    {
        static void Main(string[] args)
        {
            //function calls in main
            HelloWorld();
            Greet("Jaya");

            int number = DoubleIt(20);
            Console.WriteLine("Doubled number: " + number);

            Console.WriteLine("Doubled number: " + DoubleIt(number));

            int result = Multiply(100, 20);
            //Console.WriteLine("Result of Multiplication: " + result);

           //No need to store in a variable
            Console.WriteLine(Multiply(100, 20));

            //loop from 1 to 10 to triple each number
            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine("The number " + i + "got trippled");
                Console.WriteLine(Multiply(i, 3));
            }
        }

        //functions are standalone
        static void HelloWorld()
        {
            Console.WriteLine("Hello World!");
        }

        static void Greet(string name)
        {
            Console.WriteLine("Hello " + name);
        }

        //double a number
        static int DoubleIt(int number)
        {
            return (number * 2);
        }

        //multiply two numbers
        static int Multiply(int num1, int num2)
        {
            return (num1 * num2);
        }
    }
}
