using System;
using System.Collections.Generic;
using System.Linq;

class Tubes
{
    static void Main(string[] args)
    {
        int N = int.Parse(Console.ReadLine());
        int M = int.Parse(Console.ReadLine());
        int[] answers = new int[N];

        for (int i = 0; i < N; i++)
        {
            answers[i]= (int.Parse(Console.ReadLine()));
        }

        int min = 0;
        int max = 2000000000;
        int possibleAnswer = (max + min) / 2;
        int numberOfTubes = 0;

        while (min <= max)
        {
            numberOfTubes = 0;

            for (int i = 0; i < answers.Length; i++)
            {
                numberOfTubes += answers[i] / possibleAnswer;
            }

            if (numberOfTubes < M)
            {
                max = possibleAnswer - 1;
            }
            else
            {
                min = possibleAnswer + 1;
            }

            possibleAnswer = (min + max) / 2;
        }

        Console.WriteLine(possibleAnswer);


    }
}

