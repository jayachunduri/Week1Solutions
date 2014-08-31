using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week1Review
{
    class Program
    {
        //declare a global varibale to hold the total number of loops executed
        static int loopCount = 0;
        
        static void Main(string[] args)
        {
            Boolean userChoice = true;
            char choice = null;
            do
            {
                Console.WriteLine("Enter any string: ");
                string input = Console.ReadLine();
                StringBuilding(input);

                Console.WriteLine("\nDo you want to enter another string? \n Enter Y for Yes, N for No");
                choice = Convert.ToChar((Console.ReadLine());
                if ((choice == 'n') || (choice == 'N'))
                {
                    userChoice = false;
                }
            } while (userChoice);

            ListPractice();
            //printout the number of loops performed
            Console.WriteLine(loopCount);
        }

        //building a string
        //take in a string and output a string with all vowels capitalized and all consonants lower case
        static void StringBuilding(string input)
        {
            string output = null;
             string inputInLower = input.ToLower();
             for (int i = 0; i < inputInLower.Length; i++)
             {
                 if ("aeiou".Contains(inputInLower[i]))
                 {
                     output = output + inputInLower[i].ToString().ToUpper();
                 }
                 else
                 {
                     output = output + inputInLower[i].ToString().ToLower();
                 }
                 //we did a loop, hooray!
                 //add one to loop count
                 loopCount++;

                 //Note: Instead of switch statement Dustin used like: "aeiou".Contains(inputInLower[i]). That is more good becuase in switch code got repeated.
                 //switch (inputInLower[i])
                 //{
                 //    case 'a':
                 //        output = output + inputInLower[i].ToString().ToUpper();
                 //        break;
                 //    case 'e':
                 //        output = output + inputInLower[i].ToString().ToUpper();
                 //        break;
                 //    case 'i':
                 //        output = output + inputInLower[i].ToString().ToUpper();
                 //        break;
                 //    case 'o':
                 //        output = output + inputInLower[i].ToString().ToUpper();
                 //        break;
                 //    case 'u':
                 //        output = output + inputInLower[i].ToString().ToUpper();
                 //        break;
                 //    default:
                 //        output = output + inputInLower[i].ToString().ToLower();
                 //        break;
                 //}
             }
            
             Console.WriteLine("\n" + output);
        }

        //working with lists
        static void ListPractice()
        {
            List<string> sportsList = new List<string>(){"Baseball", "Basketball", "Cricket", "Soccer", "Football"};

            //printout the content of a list using a for loop in ascending order
            for (int i = 0; i < sportsList.Count; i++)
            {
                Console.WriteLine(sportsList[i]);
                //count using global variable
                loopCount++;
            }

            //printout the content of a list using a for loop in decending order
            for (int i = sportsList.Count-1; i >= 0 ; i--)
            {
                Console.WriteLine(sportsList[i]);
                //count using global variable
                loopCount++;
            }
        }
    }
}



