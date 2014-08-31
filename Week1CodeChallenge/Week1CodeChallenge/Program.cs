using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week1CodeChallenge
{
    class Program
    {
        static void Main(string[] args)
        {
           // IsPrime(37);
            //loop to call Fizz Buzz function for numbers from 0 to 20
            for (int i = 0; i <= 20; i++)
            {
                FizzBuzz(i);
            }

            //loop to call Fizz Buzz function for numbers from 92 to 79
            for (int i = 92; i >= 79; i--)
            {
                FizzBuzz(i);
            }

            //calling Yodaizer function with a 3 words sentence
            Yodaizer("I Like Code");

            //calling Yodaizer function with 4 words sentence
            Yodaizer("My name is Jaya");

            //calling Yodaizer function with 2 words sentence
            Yodaizer("Hello World");

            //calling TextStats 
            TestStats("Jaya %*&");
            TestStats("I like coding");

            //loop to call IsPrime for all odd numbers from 1 to 25
            for (int i = 1; i <= 25; i++)
            {
                if ((i % 2) != 0)
                    IsPrime(i);
            }

            //calling is prime with an even number
            IsPrime(148);
            IsPrime(2);

            //calling DashInsert
            DashInsert(8675309);
            
        }

        //function to check FizzBuzz
        static void FizzBuzz(int num)
        {
            if((num % 3) == 0 && (num % 5) == 0)
            {
                Console.WriteLine("Fizz Buzz");
            }
            else if ((num % 3) == 0)
            {
                Console.WriteLine("Buzz");
            }
            else if ((num % 5) == 0)
            {
                Console.WriteLine("Fizz");
            }
            else
            {
                Console.WriteLine(num);
            }
        }

        //Function takes a string and prints the words in reverse order
        //If there are only 3 words in the string. Then prints a comma after the last word and rest of the words
        static void Yodaizer(string original)
        {
            //List<string> lOriginal = new List<string>();

            string[] wordsInOriginal = original.Split(' ');
            int wordCount = wordsInOriginal.Count();

            Console.WriteLine(); //to saparate different sentences if this function is called many times

            //checking if the list has only 3 words
            if (wordCount == 3)
            {
                //printing comma after the last word
                //printing rest of the words. Since there are only 2 more words, no need of a for loop
                Console.Write(wordsInOriginal[2] + ", " + wordsInOriginal[1] + " " + wordsInOriginal[0]);
            }
            else
            {
                //means words are not equal to 3. 
                for (int i = wordCount-1; i >= 0; i--)
                {
                    Console.Write(wordsInOriginal[i] +" ");
                }
            }  
                
        }

        //Function to print all the statistics of a string
        static void TestStats(string anyString)
        {
            //variable to keep track of number of vowels, consonants and special characters
            int noOfVowels = 0, noOfConsonants = 0, noOfSpecialChars = 0;

            //spilt the string into array of words
            List<string> words = new List<string>();
            words = anyString.Split(' ').ToList();
            
            //below variables are to keep track of lenths of Longest, 2nd Longest and Shortest words and also their indexes
            int longest = 0, secondLongest = 0, shortest = 0;
            int indOfLongest = 0, indOfSecondLongest = 0, indOfShortest = 0;

            //printing a line and original string
            Console.WriteLine("\n\nThe Original string is: " + anyString);

            //printing the number of characters in the string
            Console.WriteLine("Total number of characters in the current string are :" +anyString.Length);

            //Looping through each and every character of the string.
            //Converting the string to lower
            string lowerString = anyString.ToLower();
            for (int i = 0; i < lowerString.Length; i++)
            {
                //checking if the current letter is a vowel
                if("aeiou".Contains(lowerString[i]))
                {
                    noOfVowels++;
                }
                //Since checking for special characters is hard, checking if the current letter is a consonant. 
                else if ("bcdfghjklmnpqrstvwxyz".Contains(lowerString[i]))
                {
                    noOfConsonants++;
                }
                //rest of all characters are special charactes
                else 
                {
                    noOfSpecialChars++;
                }
            }

            //since looped through all the characters in the string, below printing the results
            Console.WriteLine("Total number of vowels in the current string are :" +noOfVowels);
            Console.WriteLine("Total number of consonants in the current string are :" +noOfConsonants);
            Console.WriteLine("Total number of special characters in the current string are :" +noOfSpecialChars);

            //performing operations on words.
            //printing the number of words in the string
            Console.WriteLine("Total number of words in the current string are :" + words.Count());

            //Looping through all the words in the string
            foreach (var word in words)
            {
                int lengthOfWord = word.Length;

                //verifying if this is loger than longest word
                if (lengthOfWord > longest)
                {
                    longest = lengthOfWord;
                    indOfLongest = words.IndexOf(word);
                }
            }

            //below is to find the shortest word. Put a saparate loop, because we need to initialize the shortest with the lenght of highest
            shortest = longest; 
            foreach (var word in words)
             {
                 int lengthOfWord = word.Length;

                //verifying if this is shorter than shortest word
                if (lengthOfWord < shortest)
                {
                    shortest = lengthOfWord;
                    indOfShortest = words.IndexOf(word);
                }
            }

            //below is to find the second longest word. Put a saparate loop, because we need to find longest word so that we can compare in if statement
            secondLongest = shortest;
            foreach (var word in words)
            {
                int lengthOfWord = word.Length;
                if((lengthOfWord > secondLongest) && (lengthOfWord < longest ))
                {
                    secondLongest = lengthOfWord;
                    indOfSecondLongest = words.IndexOf(word);
                }
            }
           
            //Finished looping through all the words in the sentence.
            //Printing longest, 2nd longest and shortest words
            Console.WriteLine("Longest word is: " + words[indOfLongest] + " it's length is: " + longest);
            Console.WriteLine("Second Longest word is: " + words[indOfSecondLongest] + " it's length is: " + secondLongest);
            Console.WriteLine("Shortest word is: " + words[indOfShortest] + " it's length is: " + shortest);
        }

        //function to find, if a number is a prime number or not
        static void IsPrime(int num)
        {
            //declaring a variable to keep track of the number of factor for the given number
            
            double doubleOfNum = double.Parse(num.ToString());
            double sqrtOfNum = Math.Round(Math.Sqrt(doubleOfNum));
            int count = 0; //variable to keep track of number of factors

            //checking if it's a even number, if so it's not a prime number
            if (num == 2)
            {
                Console.WriteLine("\n 2 is a prime number");
            }
            else if ((num % 2) == 0)
            {
                Console.WriteLine("\n" + num + "is not a prime number");
            }
            else
            {
                for (int i = 1; i <= sqrtOfNum; i++)
                {
                    if ((num % i) == 0)
                        count++;
                }
                //if the number has only 2 factors, then it's a prime number. 
                //But since we are checking until the square root only, it will have only one factor.
                if (count == 1)
                    Console.WriteLine("\n" + num + "is a prime number");
                else
                    Console.WriteLine("\n" + num + "is not a prime number");
            }

            
        }

        //function to insert a dash between 2 odd numbers
        static void DashInsert(int number)
        {
            string numInString = number.ToString();
            List<string> newNum = new List<string>();
            int j = 0;

            for(int i=0; i<numInString.Length; i++)       
            {
                newNum.Add(numInString[i].ToString());
                
                //making sure that the current number is not zero
                if (numInString[i] != 0)
                {
                    //making sure that the current number is not the last in array also it's odd number
                    if (((numInString[i] % 2) != 0) && (i != (numInString.Length-1)))
                    {
                        if (numInString[i + 1] % 2 != 0)
                        {
                            newNum.Add("-");
                        }
                    }
                }

            }

            //displaying the output
            foreach (var item in newNum)
                Console.Write(item);

            Console.WriteLine();
        }
    }
}
