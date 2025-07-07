using System;
using System.ComponentModel;
using System.Reflection.Metadata.Ecma335;


//Write a C# program to check if a given string contains the 'w' character between 1 and 3 times. 
class Program41
{
    public static void Run41()
    {
        Console.WriteLine("Input string: ");
        string sentence = Console.ReadLine();

        int len = sentence.Length;
        int count_w = 0;
        sentence = sentence.ToLower();

        for (int i = 0; i < len; i++)
        {
            if (sentence[i] == 'w')
            {
                count_w++;
            }
        }

        if (0 < count_w & count_w < 4)
        {
            Console.WriteLine("Given string contains 'w' between 1 and 3 times. ");
        }
        else
        {
            Console.WriteLine(false);
        }

    }
}

//Write a C# program to create a string where the first 4 characters are in lower case. 
//If the string is less than 4 letters, make the whole string in upper case.
class Program42
{
    public static void Run42()
    {
        Console.WriteLine("Input string: ");
        string sentence = Console.ReadLine();

        int len = sentence.Length;

        if (len < 4)
        {
            Console.WriteLine(sentence.ToUpper());
        }
        else
        {
            string word1 = sentence.Substring(0, 4).ToLower();
            string word2 = sentence.Substring(4);
            string word_new = word1 + word2;

            Console.WriteLine("New sentence: " + word_new);
        }
    }
}

//Write a C# program to create a string of every other character (odd position) from the first position of a given string. 
class Program44
{
    public static void Run44()
    {
        Console.WriteLine("Input string: ");
        string sentence = Console.ReadLine();

        int len = sentence.Length;
        string word = "";

        for (int i = 0; i < len; i = i + 2)
        {
            word = word + sentence[i];
        }
        Console.WriteLine("New word: " + word);
    }
}

//Write a C# program to count a specified number in a given array of integers. 
class Program45
{
    public static void Run45()
    {
        int[] arr = { 1, 34, 34, 2, 5, 7, 9, 2, 44, 79, 2, 1 };

        int counter = 0;
        int numb_check = 2;
        int len = arr.Length;

        for (int i = 0; i < len; i++)
        {
            if (arr[i] == numb_check)
            {
                counter++;
            }
        }
        Console.WriteLine($"The number: {numb_check} appears {counter} times in the array");
    }
}


//Write a C# program to check if a number appears as the first or last element of an array of integers. 
//The array length is 1 or more. 
class Program46
{
    public static void Run46()
    {
        int[] arr = { 1, 4, 5, 22, 94, 32, 234, 44, 1, 2};

        int num = 2;

        if (arr[0] == num || arr[arr.Length - 1] == num)
        {
            Console.WriteLine(true);
        }
        else
        {
            Console.WriteLine(false);
        }
    }
}

//Write a C# program to compute the sum of all the elements of an array of integers.
class Program47
{
    public static void Run47()
    {
        int[] arr = { 1, 4, 5, 22, 94, 32, 234, 44, 1, 2 };
        int sum = 0;
        int len = arr.Length;

        for (int i = 0; i < len; i++)
        {
            sum = sum + arr[i];
        }
        Console.WriteLine("Sum of Elements in array: " + sum);
    }
}


//Write a C# program that checks if the first element and the last element of an array of integers are equal. 
class Program48
{
    public static void Run48()
    {
        int[] arr = { 1, 4, 5, 22, 94, 32, 234, 44, 1, 2 };

        Console.WriteLine(arr[0] == arr[arr.Length - 1]);
    }
}


//Write a C# program to check if the first or the last element of the two arrays (length 1 or more) are equal. 
class Program49
{
    public static void Run49()
    {
        int[] arr1 = { 1, 2, 2, 3, 3, 4, 5, 6, 5, 7, 7, 7, 8, 8, 1 };
        int[] arr2 = { 1, 2, 2, 3, 3, 4, 5, 6, 5, 7, 8, 8, 5 };

        Console.WriteLine(arr1[0] == arr2[0] || arr1[arr1.Length - 1] == arr2[arr2.Length - 1]);
    }
}


//Write a C# program to rotate an array (length 3) of integers in the left direction. 
class Program50
{
    public static void Run50()
    {
        int[] arr = { 1, 4, 5, 22, 94, 32, 234, 44, 1, 2 };
        int[] arr_new = new int[arr.Length];

        for (int i = 0; i < arr.Length; i++)
        {
            arr_new[i] = arr[arr.Length - 1 - i];
        }
        Console.WriteLine("Array reverse: " + string.Join(',', arr_new));
    }
}
