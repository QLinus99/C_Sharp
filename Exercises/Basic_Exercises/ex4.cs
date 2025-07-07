using System;
using System.Linq.Expressions;
using System.Reflection.Emit;


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

//create a string of four copies, taking the last four characters from a given string. If the given string is less than 4, return the original one. 
class Program32
{
    public static void Run32()
    {
        Console.WriteLine("Input string:");
        string sentence = Console.ReadLine();

        int len = sentence.Length;

        if (len < 4)
        {
            Console.WriteLine(sentence);
        }
        else
        {
            string last4characters = sentence.Substring(len - 4);

            for (int i = 0; i < 4; i++)
            {
                Console.WriteLine(last4characters);
            }
        }

    }
}

//Write a C# program to check if a given positive number is a multiple of 3 or 7. 
class Program33
{
    public static void Run33()
    {
        Console.WriteLine("Input integer: ");
        int num = int.Parse(Console.ReadLine());

        if (num % 7 == 0 & num % 3 == 0)
        {
            Console.WriteLine("Integer is divisible by 7 and 3");
        }
        else if (num % 7 == 0)
        {
            Console.WriteLine("Integer is divisible by 7");
        }
        else if (num % 3 == 0)
        {
            Console.WriteLine("Integer is divisible by 3");
        }
        else
        {
            Console.WriteLine("Integer is not divisible by 7 and 3");
        }
    }
}


// Write a C# program to check if a string starts with a specified word. 
class Program34
{
    public static void Run34()
    {
        string check = "Hello";

        Console.WriteLine("Input string");
        string sentence = Console.ReadLine();

        Console.WriteLine(check == sentence.Substring(0, 5));
    }
}


//Write a C# program to check two given numbers where one is less than 100 and the other is greater than 200. 
class Program35
{
    public static void Run35()
    {
        Console.WriteLine("Input 1. number:");
        int num1 = int.Parse(Console.ReadLine());

        Console.WriteLine("Input 2. number:");
        int num2 = int.Parse(Console.ReadLine());

        Console.WriteLine((num1 < 100 & num2 > 200) || (num2 < 100 & num1 > 200));
    }
}


//Write a C# program to check if an integer (from the two given integers) is in the range -10 to 10. 
class Program36
{
    public static void Run36()
    {
        Console.WriteLine("Input 1. number:");
        int num1 = int.Parse(Console.ReadLine());

        Console.WriteLine("Input 2. number:");
        int num2 = int.Parse(Console.ReadLine());

        Console.WriteLine(( (num1 >= -10) && (num1 <= 10)) || ((num2 >= -10) && (num2 <= 10)));
    }
}


//Write a C# program to check if "HP" appears at the second position in a string and return the string without "HP". 
class Program37
{
    public static void Run37()
    {
        Console.WriteLine("Input string: ");
        string sentence = Console.ReadLine();

        string word = "HP";

        bool check = (word == sentence.Substring(1, 2));

        if (check)
        {
            string word1 = sentence.Substring(0, 1);
            string word2 = sentence.Substring(3);

            string word_new = word1 + word2;

            Console.WriteLine("New snetence: " + word_new);
        }
        else
        {
            Console.WriteLine("No 'HP' at the position found:");
        }
    }
}

//Write a C# program to get a string of two characters from a given string. The first and second characters of the given string must be "P" and "H", so PHP will be "PH".
class Program38
{
    public static void Run38()
    {
        Console.WriteLine("Inpput string: ");
        string sentence = Console.ReadLine();

        string check = "PH";
        if (sentence.Substring(0, 2) == check)
        {
            Console.WriteLine("The sentence stars with: 'PH': ");
        }
        else
        {
            Console.WriteLine("The sentence stars with: 'PH': ");
        }



    }
}


//Write a C# program to find the largest and lowest values from three integer values. 
class Program39
{
    public static void Run39()
    {
        Console.WriteLine("Input 1. number: ");
        int num1 = int.Parse(Console.ReadLine());
        Console.WriteLine("Input 2. number: ");
        int num2 = int.Parse(Console.ReadLine());
        Console.WriteLine("Input 3. number: ");
        int num3 = int.Parse(Console.ReadLine());

        // lowest
        if (num1 <= num2 & num1 <= num3)
        {
            Console.WriteLine("The lowest number is: " + num1);
        }
        else if (num2 <= num1 & num2 <= num3)
        {
            Console.WriteLine("The lowest number is: " + num2);
        }
        else
        {
            Console.WriteLine("The lowest number is: " + num3);
        }

        //largest
        if (num1 >= num2 & num1 >= num3)
        {
            Console.WriteLine("The largest number is: " + num1);
        }
        else if (num2 >= num1 & num2 >= num3)
        {
            Console.WriteLine("The largest number is: " + num2);
        }
        else
        {
            Console.WriteLine("The largest number is: " + num3);
        }
    }
}

//Write a C# program that checks the nearest value of 20 of two given integers and return 0 if two numbers are same. 
class Program40
{
    public static void Run40()
    {
        Console.WriteLine("Input first number: ");
        int num1 = int.Parse(Console.ReadLine());
        Console.WriteLine("Input second number: ");
        int num2 = int.Parse(Console.ReadLine());

        int diff1 = Math.Abs(20 - num1);
        int diff2 = Math.Abs(20 - num2);

        if (diff1 < diff2)
        {
            Console.WriteLine("Nearest number to 20 is: " + num1);
        }
        else if (diff2 < diff1)
        {
            Console.WriteLine("Nearest number to 20 is: " + num2);
        }
        else
        {
            Console.WriteLine(0);
        }
    }
}

