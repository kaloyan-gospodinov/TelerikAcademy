using System;
using System.Collections.Generic;
using System.Linq;

    class CalculateAnyType
    {
        static void Main()
        {
            //Console.Write("Number of variables = ");
            //int size = int.Parse(Console.ReadLine());

            //dynamic[] array = new dynamic[size];


            //for (dynamic i = 0; i < size; i++)
            //{
            //    Console.Write("arr[{0}] = ", i);
            //    array[i] = Console.ReadLine();
            //}

            Console.WriteLine("The minimal element in the array is: {0}", MinInt(1,2,3,4,5,6));
            Console.WriteLine("The maximal element in the array is: {0}", MaxInt(1, 2, 3, 4, 5, 6));
            Console.WriteLine("The average is: {0}", Average(1, 2, 3, 4, 5, 6));
            Console.WriteLine("The sum is: {0}", Sum(1, 2, 3, 4, 5, 6));
            Console.WriteLine("The product is: {0}", Product(1, 2, 3, 4, 5, 6));
        }


        static T MinInt<T>(params T[] array)
        {
            return array.Min();
        }

        static T MaxInt<T>(params T[] array)
        {
            return array.Max();
        }

        static T Average<T>(params T[] array)
        {

            dynamic sum = 0;
            for (int i = 0; i < array.Length; i++)
            {
                sum +=  array[i];
            }
            return (sum / array.Length);
        }

        static T Sum<T>(params T[] array)
        {
            dynamic sum = 0;
            for (int i = 0; i < array.Length; i++)
            {
                sum +=  array[i];
            }
            return sum;
        }

        static T Product<T>(params T[] array)
        {
            dynamic prod = 1;
            foreach (dynamic value in array)
            {
                prod *= value;
            }

            return prod;
        }
    }

