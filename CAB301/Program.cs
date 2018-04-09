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
            int ArraySize = 1;
            for (int i = 0; i < 101; i++)
            {
                int[] array = new int[ArraySize];
                for (int x = 0; x < ArraySize; x++)
                {
                    array[x] = rnd.Next(1, 1000);
                }
                MaxMin2(array, 0, 0);
                ArraySize += 100;
                if (ArraySize == 101) //array size control
                {
                    ArraySize--;
                }
            }
            Console.ReadKey();
        }

        static void MaxMin2(int[] A, int MaxValue, int MinValue)
        {
            MaxValue = A[0];
            MinValue = A[0];
            int basicOp = 0;

            for (int i = 1; i <= A.Length - 1; i++)
            {
                basicOp++;
                if (A[i] > MaxValue)
                {
                    MaxValue = A[i];
                    basicOp++;
                }
                else
                {
                    basicOp++;
                    if (A[i] < MinValue)
                    {
                        MinValue = A[i];
                        basicOp++;
                    }
                }
            }
            string arrayStr = string.Join(", ", A);
            Console.WriteLine("In the array, the minimum value is {0}, and the maximum value is {1}.", MinValue, MaxValue);
            Console.WriteLine("Basic operations: {0}. array contains {1} item/s", basicOp, A.Length);

        }
    }
}
