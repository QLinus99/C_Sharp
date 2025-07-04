using System;
using System.ComponentModel.DataAnnotations;
using System.Runtime.InteropServices;
using System.Security.Cryptography.X509Certificates;
using System.Text.RegularExpressions;
using System.IO;
using System.Globalization;


//Write a C# program to check the sum of the two given integers. 
//Return true if one of the integers is 20 or if their sum is 20.
class Program21
{
    public static void Run21()
    {
        Console.WriteLine("Number 1:");
        int num1 = int.Parse(Console.ReadLine());

        Console.WriteLine("Number 2:");
        int num2 = int.Parse(Console.ReadLine());

        int sum = num1 + num2;

        Console.WriteLine(sum == 20 || num1 == 20 || num2 == 20);

    }
}

//Write a C# program to check if the given integer is within 20 of 100 or 200.
class Program22
{
    public static void Run22()
    {
        Console.WriteLine("Enter number:");
        int num = int.Parse(Console.ReadLine());

        Console.WriteLine(num == 200 || (num >= 0 & num <= 20));
    }
}


//Write a C# program to convert a given string into lowercase. 
class Program23
{
    public static void Run23()
    {
        Console.WriteLine("Enter word:");
        string word = Console.ReadLine();

        word = word.ToLower();

        Console.WriteLine("Word to lower:" + word);
    }
}


//Write a C# program to find the longest word in a string.
class Program24
{
    public static void Run24()
    {
        Console.WriteLine("Enter a string: ");
        string word = Console.ReadLine();

        string[] parts = Regex.Split(word,  @"\P{L}+"); //splitting if not a character in all languages

        int num_words = parts.Length;

        int max_length = 0;
        string longest_word = "";

        for (int i = 0; i < num_words; i++)
        {
            string new_word = parts[i];

            if (new_word.Length > max_length)
            {
                max_length = new_word.Length;
                longest_word = new_word;
            }
        }

        Console.WriteLine($"The Longest word in the String with a Length of {max_length} is {longest_word}");
    }
}

//Write a C# program to print odd numbers from 1 to 99. Prints one number per line. 
class Program25
{
    public static void Run25()
    {
        for (int a = 1; a < 100; a = a + 2)
        {
            Console.WriteLine($"{a}");
        }
    }
}

// Write a C# program to compute the sum of the first 500 prime numbers. 
class Program26
{
    public static bool IsPrime(int a)
    {
        for (int i = 2; i <= Math.Round(Math.Sqrt(a)); i++)
        {
            if (a % i == 0)
            {
                return false;
            }
        }
        return true;
    }

    public static void Run26()
    {
        int sum = 0;
        int num = 2;
        int count_prime = 0;

        while (count_prime < 500)
        {
            if (IsPrime(num))
            {
                sum = sum + num;
                count_prime++;
            }
            num++;
        }
        Console.WriteLine("Sum of first 500 prime numbers is: " + sum);
    }
}

//Write a C# program and compute the sum of an integer's digits. 
class Program27
{
    public static void Run27()
    {
        Console.WriteLine("Enter a number: ");
        int num = int.Parse(Console.ReadLine());

        int sum = 0;
        string number_as_string = num.ToString();
        int count_digits = number_as_string.Length;

        for (int index = 0; index < count_digits; index++)
        {
            sum = sum + int.Parse(number_as_string[index].ToString());
        }

        Console.WriteLine("The Sum of digits is: "+ sum);
    }
}


//Write a C# program to reverse the words of a sentence. 
class Program28
{
    public static void Run28()
    {
        Console.WriteLine("Enter a string:");
        string sentence = Console.ReadLine();

        string reverse = "";

        int length_sentence = sentence.Length;

        for (int index = length_sentence - 1; index >= 0; index--)
        {
            reverse = reverse + sentence[index];
        }
        Console.WriteLine("The String reverse is: " + reverse);
    }
}

//Write a C# program to find the size of a specified file in bytes. 
class Program29
{
    public static void Run29()
    {
        string fileName = "/home/linus/Documents/IAESTE/IAESTE_Nepal/nomination_form.pdf";
        FileInfo fi = new FileInfo(fileName);

        long size = fi.Length;
        Console.WriteLine("File Size in Bytes:" + size);
    }
}

//Write a C# program to convert a hexadecimal number to a decimal number. 
class Program30
{
    public static void Run30()
    {
        string hexvalue = "AA5BB";
        int decimal_value = int.Parse(hexvalue, NumberStyles.HexNumber); //using System.Globalization

        Console.WriteLine($"The decimal value of {hexvalue} is {decimal_value}");
    }
}

