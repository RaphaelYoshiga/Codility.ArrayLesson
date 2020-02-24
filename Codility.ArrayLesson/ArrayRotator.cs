using System;
using System.Linq;

// you can also use other imports, for example:
// using System.Collections.Generic;

// you can write to stdout for debugging purposes, e.g.
// Console.WriteLine("this is a debug message");

public class ArrayRotator
{
    public int[] solution(int[] A, int K)
    {
        int[] result = A;
        for (int i = 0; i < K; i++)
            result = Rotate(result);

        return result;
    }

    private static int[] Rotate(int[] A)
    {
        var newArray = new int[A.Length];
        for (int i = 0; i < A.Length; i++)
        {
            if (i == 0)
                newArray[0] = A[^1];
            else
                newArray[i] = A[i - 1];
        }
        return newArray;
    }
}