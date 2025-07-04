using System;
using System.Linq.Expressions;


//Write a C# program to multiply the corresponding elements of two integer arrays. 
class Program31
{
    public static void Run31()
    {
        int[] arr1 = { 1, 2, 3, 4 };
        int[] arr2 = { 2, -2, 99, 34 };

        for (int index = 0; index <= 3; index++)
        {
            Console.Write(arr1[index] * arr2[index] + " ");
        }

    }
}



//main
class Program
{
    public static void Main()
    {
        Program31.Run31();
    }
}