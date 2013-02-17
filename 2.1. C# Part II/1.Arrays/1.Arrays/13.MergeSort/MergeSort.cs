using System;
using System.Linq;


class MergeSort
{
    static void Main()
    {

        int[] arrayOfIntegers = { 1, 5, 7, 8, 9, 3, 5, 6, 7 };
        int[] sortedArray = MergeSortAlgo(arrayOfIntegers);

        PrintArray(sortedArray);
    }

    static int[] MergeSortAlgo(int[] array)
    {
        if (array.Length <= 1)
        {
            return array;
        }

        int middle = array.Length / 2;
        int[] leftArray = new int[middle];
        int[] rightArray = new int[array.Length - middle];

        for (int i = 0; i < middle; i++)
        {
            leftArray[i] = array[i];
        }

        for (int i = middle, j = 0; i < array.Length; i++, j++)
        {
            rightArray[j] = array[i];
        }

        leftArray = MergeSortAlgo(leftArray);
        rightArray = MergeSortAlgo(rightArray);

        return MergeArrays(leftArray, rightArray);
    }

    static int[] MergeArrays(int[] left, int[] right)
    {
        int[] result = new int[left.Length + right.Length];

        int leftIncrease = 0;
        int rightIncrease = 0;

        for (int i = 0; i < result.Length; i++)
        {
            if (rightIncrease == right.Length || ((leftIncrease < left.Length) && (left[leftIncrease] <= right[rightIncrease])))
            {
                result[i] = left[leftIncrease];
                leftIncrease++;
            }
            else if (leftIncrease == left.Length || ((rightIncrease < right.Length) && (right[rightIncrease] <= left[leftIncrease])))
            {
                result[i] = right[rightIncrease];
                rightIncrease++;
            }
        }

        return result;
    }

    static void PrintArray(int[] array)
    {
        for (int i = 0; i < array.Length; i++)
        {
            Console.Write(array[i] + " ");
        }
        Console.WriteLine();
    }

    
    
}   


    

