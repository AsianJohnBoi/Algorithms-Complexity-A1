﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basic_Operations
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
            int basicOp = 0; //start counter at zero

            for (int i = 1; i <= A.Length - 1; i++)
            {
                basicOp++;
                if (A[i] > MaxValue)
                {
                    MaxValue = A[i]; //Assigns array element to MaxValue
                    basicOp++; //Adds one to counter
                }
                else
                {
                    basicOp++;
                    if (A[i] < MinValue)
                    {
                        MinValue = A[i]; //Assigns array element to MinValue
                        basicOp++; //Adds one to counter
                    }
                }
            }
            Console.WriteLine("minimum value is {0}, maximum value is {1}.", MinValue, MaxValue); //Prints min and max value found in array
            Console.WriteLine("{0}", basicOp); //prints the basic operation 
        }
    }
}
