using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CAB301
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            int ArraySize = rnd.Next(1, 101);
            int[] array = new int[ArraySize];
            for (int i = 0; i < ArraySize; i++)
            {
                array[i] = rnd.Next(1, ArraySize);
            }
            MaxMin2(array, 0, 0);
            Console.ReadKey();

            //bool validInput = false;
            //while (validInput == false)
            //{
            //    Console.Write("How big is the array? ");

            //    if (int.TryParse(Console.ReadLine(), out ArraySize))
            //    {
            //        int[] array = new int[ArraySize];
            //        for (int i = 0; i < ArraySize; i++)
            //        {
            //            array[i] = i + 1;
            //            //Console.WriteLine("{0}", array[i]);
            //        }
            //        MaxMin2(array, 0, 0);
            //        validInput = true;
            //    }
            //    else
            //    {
            //        Console.WriteLine("Invalid input, please enter a whole number.");
            //        validInput = false;
            //    }
            //}
            //Console.Write("Press any key to exit");
            Console.ReadKey();
        }

        static void MaxMin2(int[] A, int MaxValue, int MinValue)
        {
            MaxValue = A[0];
            MinValue = A[0];
            int basicOp = 0;

            for (int i = 1; i <= A.Length - 1; i++)
            {
                basicOp = basicOp + 1; ;
                if (A[i] > MaxValue)
                {
                    MaxValue = A[i];
                }
                else
                {
                    if (A[i] < MinValue)
                    {
                        MinValue = A[i];
                    }
                }
            }
            string arrayStr = string.Join(", ", A);
            Console.WriteLine("In the array, the minimum value is {0}, and the maximum value is {1}.", MinValue, MaxValue);
            Console.WriteLine("No. of basic operations: {0}", basicOp);
            Console.WriteLine("The array is [{0}] containing {1} items", arrayStr, A.Length);

        }
    }
}
