using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringsDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            string drinks = "Coffee @@@@@   !!!! *** water cocacola pepsi 7up wine";


            char[] splitCharacters = { ' ', '!', '@', '[', ']', '!', '$', '%', 'µ', '^', };

            string[] splitDrinks = drinks.Split(splitCharacters,StringSplitOptions.RemoveEmptyEntries);

            foreach (var drink in splitDrinks)
            {
                Console.WriteLine(drink);
            }
        }
    }
}
