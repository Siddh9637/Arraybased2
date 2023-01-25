using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Nm5
{
    internal class CMain
    {
        static void SingleArray()
        {
            /*
            //illustration 1
            int[] arr = new int[3];
            arr[0] = 111;
            arr[1] = 222;
            arr[2] = 333;
            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine("arr[{0}]={1}", i, arr[i]);
            }
            */

            /*
            //illustration 2
            int[] arr = new int[3] {111,222,333};
            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine("arr[{0}]={1}", i, arr[i]);
            }
            */

            /*
            //illustration 3
            int[] arr = new int[] { 111, 222, 333 };
            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine("arr[{0}]={1}", i, arr[i]);
            }
            */

            /*
            //illustration 4
            int[] arr = { 111, 222, 333 };
            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine("arr[{0}]={1}", i, arr[i]);
            }
            */

            /*
            //illustration 4
            int[] arr = new int[10];

            for (int i = 0; i < arr.Length; i++)
            {
                if (i < 2)
                    arr[i] = i;
                else
                    arr[i] = arr[i - 1] + arr[i - 2];
                Console.Write("{0,5}", arr[i]);
            }
            Console.WriteLine();
            */


            //illustration 5
            int[] arr1 = new int[5] { 10, 20, 30, 40, 50 };
            int[] arr2 = { 11, 22, 33, 44, 55 };


            int choice = 1;
            int index = 2;
            int val = 999;

            //if(choice == 1)
            //    arr1[index] = val;
            //else
            //    arr2[index] = val;

            //Conditional reference
            ((choice == 1) ? ref arr1[index] : ref arr2[index]) = val;
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("arr1[{0}]={1}\t arr2[{0}]={2}", i, arr1[i], arr2[i]);
            }
        }

        static void DoubleDimensionArray()
        {
            int[,] arr = new int[2, 3] { { 1, 2, 3 }, { 4, 5, 6 } };

            arr[1, 2] = 999;
            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Console.Write("{0,10}", arr[i, j]);
                }
                Console.WriteLine();
            }
        }

        static void JaggedArray()
        {
            int[][] arr = new int[5][];
            arr[0] = new int[5] { 1, 2, 3, 4, 5 };
            arr[1] = new int[3] { 11, 22, 33 };
            arr[2] = new int[4] { 100, 200, 300, 400 };
            arr[3] = new int[2] { 999, 888 };
            arr[4] = new int[1] { 777 };
            /*
            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine("Values of arr {0}",i);
                for (int j = 0; j < arr[i].Length; j++)
                {
                    Console.Write("{0,10}", arr[i][j]);
                }
                Console.WriteLine();
            }
            */

            foreach (int[] itemArr in arr)
            {
                foreach (int item in itemArr)
                {
                    Console.Write("{0,-10}", item);
                }
                Console.WriteLine();
            }
        }


        static void ArrayOperations()
        {
            string[] arr = { "Sachin", "Sewag", "Rahul", "VVS", "Yuvraj", "Dhoni", "Anil", "Harbajan", "Zaheer", "Ravi" };
            foreach (string item in arr)
            {
                Console.Write("{0,-10}", item);
            }
            Console.WriteLine();
            //1 
            Array.Reverse(arr);
            foreach (string item in arr)
            {
                Console.Write("{0,-10}", item);
            }
            Console.WriteLine();
            //2
            Array.Clear(arr, 2, 3);
            foreach (string item in arr)
            {
                Console.Write("{0,-10}", item);
            }
            Console.WriteLine();
            //3
            string[] arr1 = { "apple", "orange", "pine" };
            foreach (string item in arr1)
            {
                Console.Write("{0,-10}", item);
            }
            Console.WriteLine();
            Array.Copy(arr, arr1, 2);
            foreach (string item in arr1)
            {
                Console.Write("{0,-10}", item);
            }
            Console.WriteLine();
        }

        static void ArrayRangeIndex()
        {
            string[] arr = { "Sachin", "Sewag", "Rahul", "VVS", "Yuvraj", "Dhoni", "Anil", "Harbajan", "Zaheer", "Ravi" };
            /*
            for (int i = 0; i < arr.Length; i++)
            {
                Index idx = i;
                Console.Write(arr[idx] +',');
            }
            Console.WriteLine(); 
            */

            /*
            foreach (var item in arr)
            {
                Console.Write(item + ',');
            }
            Console.WriteLine();
            */

            /*
            foreach (var item in arr[0..4])
            {
                Console.Write(item + ',');
            }
            Console.WriteLine();

            */

            /*
            foreach (var item in arr[3..7])
            {
                Console.Write(item + ',');
            }
            Console.WriteLine();
            */

            /*
            Range rng = 1..4;
            foreach (var item in arr[rng])
            {
                Console.Write(item + ',');
            }
            Console.WriteLine();
            */

            /*
            Index i1 = 1;
            Index i2 = 4;

            Range rng = i1..i2;
            foreach (var item in arr[rng])
            {
                Console.Write(item + ',');
            }
            Console.WriteLine();
            */

            /*
            Console.WriteLine(arr[..].Length);
            Console.WriteLine(arr[0..3].Length);
            Console.WriteLine(arr[0..4].Length);
            */

            /*
            Array.ForEach(arr, x => Console.Write("{0,-10}", x));
            Console.WriteLine();
            Console.WriteLine("{0,-20}{1,-20}", arr[1], arr[^1]);
            Console.WriteLine("{0,-20}{1,-20}", arr[2], arr[^2]);
            */
            Array.ForEach(arr, x => Console.Write("{0,-10}", x));
            Console.WriteLine();
            for (int i = 1; i <= arr.Length; i++)
            {
                int idx = i;
                Console.Write("{0,-10}", arr[idx]);
            }
            Console.WriteLine();
        }

        static void Main(string[] args)
        {
            //SingleArray();
            //DoubleDimensionArray();
            //JaggedArray();
            //ArrayOperations();
            ArrayRangeIndex();
        }
    }
}
