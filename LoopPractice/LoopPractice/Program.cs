using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoopPractice
{
    class Program
    {
        static void Main(string[] args)
        {
            //WhileLoopTest();

           // FlipCoinCount(10062);

            FlipForHeads(100);
        }

        //testing of while loop
        static void WhileLoopTest()
        {
            int i = 0;
            while (i <= 10)
            {
                Console.WriteLine(i);
                i++;
            }
        }

       //example of counters
        static void FlipCoinCount(int count)
        {
            int countHeads=0, countTails=0;

            //create a random number generator
            Random rng = new Random();

            for (int i = 0; i < count; i++)
            {
                //flip that coin
                int flip = rng.Next(0, 2);

                if (flip == 0)
                {
                    countTails++;
                }
                else
                {
                    countHeads++;
                }
            }

            Console.WriteLine("Plipped the coin " + count + " number of times /n Result");
            Console.WriteLine("The number of Heads: " + countHeads);
            Console.WriteLine("The number of Tails: " + countTails);
        }

        //same function with the while loop
        static void FlipForHeads(int numHeads)
        {
            int countHeads = 0; //countTails = 0;
            Random numGenerator = new Random();

            int totalFlips = 0;
            while (countHeads != numHeads)
            {
                if (numGenerator.Next(2) == 0)
                {
                    countHeads++;
                }
                totalFlips++;
             }

            Console.WriteLine("Total flips are: " +totalFlips + " \nHeads count is: " +countHeads);
        }
    }
}
