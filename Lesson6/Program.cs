using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson6
{
    class Program
    {
        static void Main(string[] args)
        {
            ////ex1
            //int[] myArray = new int[5];
            //for (int i = 0; i < myArray.Length; i++)
            //{
            //    Console.WriteLine("please enter a number");
            //    myArray[i] = int.Parse(Console.ReadLine());
            //}
            //Array.Reverse(myArray);
            //for (int i = 0; i < myArray.Length; i++)
            //{
            //    Console.WriteLine("number is {0}",myArray[i]);
            //}

            ////ex2
            //int[] myArray = new int[5];
            //for (int i = 0; i < myArray.Length; i++)
            //{
            //    Console.WriteLine("please enter a number");
            //    myArray[i] = int.Parse(Console.ReadLine());
            //}
            //for (int i = 0; i < myArray.Length; i++)
            //{
            //    if (myArray[i] % 2 == 0)
            //    {
            //        Console.WriteLine("number is {0}", myArray[i]);
            //    }
            //}

            ////ex3
            //int[] myArray = new int[5];
            //for (int i = 0; i < myArray.Length; i++)
            //{
            //    Console.WriteLine("please enter a number");
            //    myArray[i] = int.Parse(Console.ReadLine());
            //}
            //for (int i = 0; i < myArray.Length; i++)
            //{
            //    if (myArray[i] < 0)
            //    {
            //        Console.WriteLine("number is {0}", myArray[i]);
            //    }
            //}

            ////ex4 - get 5 numbers and print the biggest
            //int max = 0;
            //int[] myArray = new int[5];
            //for (int i = 0; i < myArray.Length; i++)
            //{
            //    Console.WriteLine("please enter a number");
            //    myArray[i] = int.Parse(Console.ReadLine());
            //}
            //for (int i = 0; i < myArray.Length; i++)
            //{
            //    if (myArray[i] > max)
            //    {
            //        max = myArray[i];
            //    }
            //}
            //Console.WriteLine("the max number is {0}", max);

            ////ex5 - get 5 numbers and print the smallest
            //int min = int.MaxValue;
            //int[] myArray = new int[5];
            //for (int i = 0; i < myArray.Length; i++)
            //{
            //    Console.WriteLine("please enter a number");
            //    myArray[i] = int.Parse(Console.ReadLine());
            //}
            //for (int i = 0; i < myArray.Length; i++)
            //{
            //    if (myArray[i] < min)
            //    {
            //        min = myArray[i];
            //    }
            //}
            //Console.WriteLine("the min number is {0}", min);

            ////ex6 - get 5 numbers and sort them form the biggest to the smallest in a new array
            //int max = 0;
            //int[] myArray = new int[5];
            //int[] myNewArray = new int[5];
            //int temp = 0;
            //for (int i = 0; i < myArray.Length; i++)
            //{
            //    Console.WriteLine("please enter a number");
            //    myArray[i] = int.Parse(Console.ReadLine());
            //}
            //for (int i = 0; i < myArray.Length; i++)
            //{
            //    max = 0;
            //    for (int j = 0; j < myArray.Length; j++)
            //    {
            //        if (myArray[j] > max)
            //        {
            //            max = myArray[j];
            //            temp = j;
            //        }
            //    }
            //    myArray[temp] = 0;
            //    myNewArray[i] = max;
            //}
            //for (int i = 0; i < myNewArray.Length; i++)
            //{
            //    Console.WriteLine("the number is {0}", myNewArray[i]);
            //}


            ////ex7 - get 5 numbers and sort them form the the smallest to the biggest in a new array
            //int min = int.MaxValue;
            //int[] myArray = new int[5];
            //int[] myNewArray = new int[5];
            //int temp = 0;
            //for (int i = 0; i < myArray.Length; i++)
            //{
            //    Console.WriteLine("please enter a number");
            //    myArray[i] = int.Parse(Console.ReadLine());
            //}
            //for (int i = 0; i < myArray.Length; i++)
            //{
            //    min = int.MaxValue;
            //    for (int j = 0; j < myArray.Length; j++)
            //    {
            //        if (myArray[j] < min)
            //        {
            //            min = myArray[j];
            //            temp = j;
            //        }
            //    }
            //    myArray[temp] = int.MaxValue;
            //    myNewArray[i] = min;
            //}
            //for (int i = 0; i < myNewArray.Length; i++)
            //{
            //    Console.WriteLine("the number is {0}", myNewArray[i]);
            //}


            //ex7 - get 5 numbers and sort them form the smallest to the biggest in the same array
            
            int[] myArray = new int[5];
            
            for (int i = 0; i < myArray.Length; i++)
            {
                Console.WriteLine("please enter a number");
                myArray[i] = int.Parse(Console.ReadLine());
            }
            for (int i = 0; i < myArray.Length; i++)
            {
                
                for (int j = 0; j < myArray.Length-1; j++)
                {
                    if (myArray[j] > myArray[j+1])
                    {
                        myArray[j] = myArray[j] * myArray[j + 1];
                        myArray[j + 1] = myArray[j] / myArray[j + 1];
                        myArray[j] = myArray[j] / myArray[j + 1];
                    }
                }
            }
            for (int i = 0; i < myArray.Length; i++)
            {
                Console.WriteLine("the number is {0}", myArray[i]);
            }
        }
    }
}