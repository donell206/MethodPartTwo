using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Params
{
    class Program
    {
        static void Main(string[] args)
        {
            Sum(2, 4);
            Sum(5, 8,2);
            Sum(9,1,25,6);
        }

        #region
        //static void Main(int number , int numberTwo)
        //{
        //    Console.WriteLine(number + numberTwo);
        //}
        //static void Main(int number, int numberTwo, int thirdNumber)
        //{
        //    Console.WriteLine(number + numberTwo + int thirdNumber);
        //}
        //static void Main(int number, int numberTwo+ int thirdNumber+ int fourthNumber)
        //{
        //    Console.WriteLine(number + numberTwo+ thirdNumber+ fourthNumber);
        //}

        #endregion

        static void Sum(params int[] numbers) 
        {
            int sum = 0;
            foreach (int item in numbers)
            {
                //sum += item;
                Console.WriteLine(sum+=item);
            }

        }


    }
}
