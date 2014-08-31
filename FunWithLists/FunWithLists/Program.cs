using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FunWithLists
{
    class Program
    {
        static void Main(string[] args)
        {
            //declare a new list of strings for a menu
            List<string> menu = new List<string>() {"Pulihora", "Payasam" };

            menu.Add("Appadalu");
            menu.Add("Mamidi pallu");

            //for (int i = 0; i < menu.Count; i++)
            //{
            //    Console.WriteLine(menu[i]);
            //}

            //foreach is more easy than a regular for loop for lists
            foreach (var item in menu)
            {
                Console.WriteLine(item);
            }

            //removing an item from the lsit
            menu.Remove("Pulihora");
           // menu.RemoveAt(2);

            foreach (var item in menu)
            {
                Console.WriteLine(item);
            }

            //easy way to join printing out a list
            Console.WriteLine(string.Join(", ", menu));
            Console.WriteLine(string.Join("\n", menu));

            //Loop through list to make some operations
            for (int i = 0; i < menu.Count; i++)
            {
                string item = menu[i];
                if (item.ToLower().Contains("mamidi"))
                {
                    Console.WriteLine(item.ToUpper());
                }
                else
                {
                    Console.WriteLine(item);
                }
            }

        }
    }
}
