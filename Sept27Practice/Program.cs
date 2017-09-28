using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sept27Practice
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hi there! How about you enter a number for me.");
            //int numberOne = int.Parse(Console.ReadLine());

            //Console.WriteLine("Let's enter one more number.");
            //int numberTwo = int.Parse(Console.ReadLine());

            //Console.WriteLine("I'm going to check if you've entered the same number twice now.");

            //if(numberOne == numberTwo)
            //{ Console.WriteLine("The numbers " + numberOne + " and " + numberTwo + " are not the same!");
            //}
            //else
            //{ Console.WriteLine("The numbers " + numberOne + " and " + numberTwo + " are not the same.");
            //}

            //Console.WriteLine("How about you give me a number, and I'll tell you if it's even or odd.");
            //int aNumberForMe = int.Parse(Console.ReadLine());

            //if(aNumberForMe % 2 == 0)
            //{ Console.WriteLine(aNumberForMe + " is an even number.");
            //}
            //if(aNumberForMe % 2 != 0)
            //{ Console.WriteLine(aNumberForMe + " is an odd number.");
            //}

            //Console.WriteLine("How about you give me a number, and I'll tell you if it's positive or negative!");
            //int anotherNumber = int.Parse(Console.ReadLine());

            //if(anotherNumber > 0)
            //{ Console.WriteLine("The number you gave me is positive.");
            //}

            //if(anotherNumber < 0)
            //{ Console.WriteLine("The number you gave me is negative.");
            //}

            //Console.WriteLine("Give me a letter, and I'll tell you whether or not it's a vowel.");
            //char someLetter = char.Parse(Console.ReadLine());

            //if (someLetter == 'a')
            //{
            //    Console.WriteLine(someLetter + " is a vowel.");
            //}
            //else if (someLetter == 'e')
            //{
            //    Console.WriteLine(someLetter + " is a vowel.");
            //}
            //else if (someLetter == 'i')
            //{
            //    Console.WriteLine(someLetter + " is a vowel.");
            //}
            //else if (someLetter == 'o')
            //{
            //    Console.WriteLine(someLetter + " is a vowel.");
            //}
            //else if (someLetter == 'u')
            //{
            //    Console.WriteLine(someLetter + " is a vowel.");
            //}
            //else
            //{
            //    Console.WriteLine(someLetter + " is not a vowel at all.");
            // }
            //IF A SWITCH: use "default" instead of case and go from there. 
            //COULD ALSO (someLetter == 'a' || someLetter == 'e' || someLetter == i || o || u

            Console.WriteLine("Type a whole number for me.");
            int numberOne = int.Parse(Console.ReadLine());

            Console.WriteLine("Type another whole number for me.");
            int numberTwo = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter another whole number.");
            int numberThree = int.Parse(Console.ReadLine());



            if (numberTwo > numberOne && > numberThree)
            { }
                Console.WriteLine(numberTwo + " is the greater number.");
            }
            else if (numberOne > numberTwo)
            {
                Console.WriteLine(numberOne + " is the greater number.");
            }
            else
            {
                Console.WriteLine(numberTwo + " is the same as " + numberTwo);
            }
            




        }
    }
}

