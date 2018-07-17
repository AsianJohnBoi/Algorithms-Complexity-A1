using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Testing_functionality
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random(); //import random value
            int ArraySize = 1; //Start array size of one
            for (int i = 0; i < 101; i++)
            {
                int[] array = new int[ArraySize];
                for (int x = 0; x < ArraySize; x++)
                {
                    array[x] = rnd.Next(1, 1000); //picks a value between 1 and 1000
                }
                MaxMin2(array, 0, 0);
                ArraySize += 100; //Adds 100 to the array size
                if (ArraySize == 101) //array size control
                {
                    ArraySize--;
                }
            }
            Console.ReadKey();
        }

        static void MaxMin2(int[] A, int MaxValue, int MinValue)
        {
            MaxValue = A[0]; //assign first array element to the variable MaxValue
            MinValue = A[0]; //assign first array element to the variable MinValue

            for (int i = 1; i <= A.Length - 1; i++)
            {
                if (A[i] > MaxValue)
                {
                    MaxValue = A[i]; //Assigns array element to MaxValue
                }
                else
                {
                    if (A[i] < MinValue)
                    {
                        MinValue = A[i]; //Assigns array element to MinValue
                    }
                }
            }

            /// <summary>
            /// The following code tests the functionality of the program. Tested to see if the program did go through
            /// all the elements, and retrieves the correct minimum and maximum numbers with random numbers, sorted and 
            /// unsorted arrays
            /// </summary>
            int amount = 0; //counter to count the number of elements in array.
            foreach (int i in A) //loop goes through each element in array.
            {
                amount++;
            }
            string arrayStr = string.Join(", ", A); //converts array to string
            Console.Write("The array [{0}] has {1} items", arrayStr, amount);
            Console.Write("The array [{0}] has has the minimum number {1} and the maximum number {2}", arrayStr, MinValue, MaxValue);

            Array.Sort(A); //testing the algorithm with sorted array
            Console.Write("The array [{0}] has has the minimum number {1} and the maximum number {2}", arrayStr, MinValue, MaxValue);

            Array.Reverse(A); //testing the algorithm with reversed sorted array
            Console.Write("The array [{0}] has has the minimum number {1} and the maximum number {2}", arrayStr, MinValue, MaxValue);


        }
    }
}
