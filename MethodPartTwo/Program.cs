using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodPartTwo
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = { 1,2,3,4 };
            Show(array);

        }
        static void Show(int[] x)
        {
            foreach(var item in x)
            {
                Console.WriteLine(item);
            }
            CopyArray(x);
        }
        static void CopyArray(int[] c)
        {
            Console.WriteLine("****************COPIEDARRAY**************");
            int[] copiedArray = { 0,0,0,0};
            for (int i = 0; i < c.Length; i++)
            {
                copiedArray[i] = c[i];
                Console.WriteLine();
            }

        }
        static void ShowCopiedArray(int[] copiedArray)
        {
            foreach (var item in copiedArray)
            {
                Console.WriteLine(item);
            }
            CopyArray(copiedArray);
        }



    }
}
