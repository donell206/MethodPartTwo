using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OptionalParameters
{
    class Program
    {
        static void Main(string[] args)
        {
            Multiplication(2,4,ConsoleColor.Green);
        }

        static void Multiplication(int numberOne, int numberTwo, ConsoleColor color= ConsoleColor.Cyan)
        {

            // int result = numberOne * numberTwo* numberThree;
            //return numberOne * numberTwo * numberThree;

            Console.BackgroundColor = color;
            Console.WriteLine(numberOne * numberTwo);
            Console.ResetColor();

            string fullName = GetFullName(lastName: "Kurda", firstName: "Kenan");


        static void GetFullName(string firstName, string lastName)
        {
                return firstName + " " + lastName;
        }




        }
    }
}
