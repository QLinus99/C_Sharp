using System;
using System.ComponentModel.DataAnnotations;

//Write a C# Sharp program that takes an age as input and prints something like "You look older than 20". 
class Program11
{
    public static void Run11()
    {
        int age;

        Console.WriteLine("Enter your age!");
        age = int.Parse(Console.ReadLine());

        Console.WriteLine("You don't look like " + age);
    }
}

//Write a C# program that takes a number as input and displays it four times in a row (separated by blank spaces), and then four times in the next row, with no separation
class Program12
{
    public static void Run12()
    {
        int num;

        Console.WriteLine("Enter a integer to display it 4 times");
        num = int.Parse(Console.ReadLine());

        Console.WriteLine($"{num} {num} {num} {num}");
        Console.WriteLine($"{num}{num}{num}{num}");
    }
}

//Write a C# program that takes a number as input and displays a rectangle of 3 columns wide and 5 rows tall using that digit
class Program13
{
    public static void Run13()
    {
        int num;

        Console.WriteLine("Enter number for Rectangel representation:");
        num = int.Parse(Console.ReadLine());

        Console.WriteLine($"{num}{num}{num}");
        Console.WriteLine($"{num} {num}");
        Console.WriteLine($"{num} {num}");
        Console.WriteLine($"{num} {num}");
        Console.WriteLine($"{num}{num}{num}");


    }
}
//Write a C# program to convert Celsius degrees to Kelvin and Fahrenheit.
class Program14
{
    public static void Run14()
    {
        double cels;

        Console.WriteLine("Enter Celcius degree");
        cels = int.Parse(Console.ReadLine());

        double kelv = cels + 273.15;
        double fahr = 32 + 1.8 * cels;

        Console.WriteLine($"{cels} degree Celsius match {kelv} degree Kelvin");
        Console.WriteLine($"{cels} degree Celsius match {fahr} degree Fahrenheit");
    }
}


//Write a program that removes a specified character from a non-empty string using the index of a character.
class Program15
{
    public static void Run15()
    {
        Console.WriteLine("Enter a word:");
        string word = Console.ReadLine();

        int length = word.Length;

        Console.WriteLine("Remove the ith character:");
        int index = int.Parse(Console.ReadLine());

        string word_left = word.Substring(0, index);
        string word_right = word.Substring(index + 1, length);

        string new_word = word_left + word_right;

        Console.WriteLine("New word, without ith character");

    }
} 

//main
class Program
{
    public static void Main()
    {
        Program15.Run15();
    }
}