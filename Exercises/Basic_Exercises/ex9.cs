using System;
using System.ComponentModel.DataAnnotations;


//Write a C# Sharp program to swap a two-digit number and check whether the given number is greater than its swap value. 
class Program81
{
    public static bool Run81()
    {
        Console.WriteLine("Enter 2-digit integer: ");

        int num = 0;
        while (num.ToString().Length != 2)
        {
            num = Convert.ToInt32(Console.ReadLine());
        }

        int first_digit = (int)(num / 10);
        int last_digit = (int)(num % 10);

        if (first_digit > last_digit)
        {
            return true;
        }
        else
        {
            return false;
        }


    }
}


//Write a C# Sharp program to remove all non-letter characters from a given string. 
class Program82
{
    public static void Run82()
    {
        string test = "P33y@th12on?";

        for (int i = test.Length - 1; i >= 0; i--)
        {
            if (!Char.IsLetter(test[i]))
            {
                test = test.Remove(i, 1);
            }
        }

        Console.WriteLine("New String: " + test);
    }
}


//Write a C# Sharp program to remove all vowels from a given string. 
class Program83
{
    public static void Run83()
    {
        string test = "Paulaner Hefeweizen";

        string vowels = "aeiouAEIOU";
        string output = "";

        foreach (char c in test)
        {
            if (!vowels.Contains(c))
            {
                output = output + c;
            }
        }
        Console.WriteLine("New String: " + output);
    }
}


//Write a C# Sharp program to get the index number of all lower case letters in a given string. 
class Program84
{
    public static void Run84()
    {
        Console.WriteLine("Enter string: ");
        string sentence = Console.ReadLine();

        List<int> list = new List<int>();

        int len = sentence.Length;

        for (int i = 0; i < len; i++)
        {
            if (sentence[i].ToString() == sentence[i].ToString().ToLower())
            {
                list.Add(i);
            }
        }

        Console.WriteLine("List of Indices with lowercase character: ");
        list.ForEach(x => Console.WriteLine(x));
    }
}


//Write a C# Sharp program to find the cumulative sum of an array of numbers. 
class Program85
{
    public static void Run85()
    {
        int[] numbers = { 1, 6, 2, 8, 4, 9, 2, 3, 7, 2 };
        int len = numbers.Length;
        int[] cumulative = new int[len];

        for (int i = 0; i < len; i++)
        {
            int sum = 0;
            for (int j = 0; j <= i; j++)
            {
                sum = sum + numbers[j];
                if (j == i)
                {
                    cumulative[j] = sum;
                }
            }
        }

        Console.WriteLine("Start Array: " + string.Join(',', numbers));
        Console.WriteLine("Cumulative Array " + string.Join(',', cumulative));

    }
}


//Write a C# Sharp program to get the number of letters and digits in a given string. 
class Program86
{
    public static void Run86()
    {
        Console.WriteLine("Enter string: ");
        string sentence = Console.ReadLine();

        int count_letter = 0;
        int count_digit = 0;

        foreach (char c in sentence)
        {
            if (Char.IsLetter(c) == true)
            {
                count_letter++;
            }
            if (Char.IsNumber(c) == true)
            {
                count_digit++;
            }
        }

        Console.WriteLine($"{count_letter} characters are letters.");
        Console.WriteLine($"{count_digit} characters are digits.");
    }
}


//Write a C# Sharp program to reverse a Boolean value. 
class Program87
{
    public static bool Run87(bool test)
    {
        if (test)
        {
            return false;
        }
        return true;
    }
}


//Write a C# Sharp program to find the sum of the interior angles (in degrees) of a given polygon.
//Input the number of straight lines. 
class Program88
{
    public static int Run88(int num)
    {
        if (num < 3)
        {
            return 0;
        }
        else
        {
            return 180 + (num - 3) * 180;
        }
    }
}


//Write a C# Sharp program to count positive and negative numbers in a given array of integers. 
class Program89
{
    public static void Run89()
    {
        int[] numbers = { 2, 2, 2, 2, -1, -4, -88, 23, -345, 12, -1, 0 };

        int count_pos = 0;
        int count_neg = 0;

        for (int i = 0; i < numbers.Length; i++)
        {
            if (numbers[i] >= 0)
            {
                count_pos++;
            }
            else
            {
                count_neg++;
            }
        }

        Console.WriteLine("Number of positive integers: " + count_pos);
        Console.WriteLine("Number of negative integers: " + count_neg);
    }
}


//Write a C# Sharp program to count the number of ones and zeros in the binary representation of a given integer. 
class Program90
{
    public static void Run90()
    {
        int[] binary = { 0, 0, 0, 0, 1, 1, 1, 0, 1, 1, 1, 0, 1, 1, 0, 1 };

        int len = binary.Length;
        int count0 = 0;
        int count1 = 1;

        for (int i = 0; i < len; i++)
        {
            if (binary[i] == 0)
            {
                count0++;
            }
            else
            {
                count1++;
            }
        }

        Console.WriteLine($"The binary string include {count0} 0's and {count1} 1's. ");
    }
}











