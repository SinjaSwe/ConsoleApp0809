using System;
using System.Reflection.Metadata.Ecma335;

namespace ConsoleApp0809
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Welcome to my comparsion!");


            CompareNumbers();//use method

        }

        static void CompareNumbers ()

        {

            int numberOne;
            int numberTwo;

            Console.WriteLine("Please enter a number: ");
            numberOne = TextToNumber(Console.ReadLine());
         

            Console.WriteLine("Please enter a number: ");
            numberTwo = TextToNumber(Console.ReadLine());

            if (numberOne > numberTwo)
            {

                Console.WriteLine("The first number is the biggest");
            }

            else

            {

                Console.WriteLine("The second number is biggest");
            
            }
            
        }


        static int TextToNumber(string textNumber)

        {

            int number = 0;

            int.TryParse(textNumber, out number);

            return number;
        }
           

    }
}
