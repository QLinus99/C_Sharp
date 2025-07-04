using System;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics.Tracing;
using System.Globalization;
using System.Reflection.Emit;
using System.Threading.Tasks.Dataflow;


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
        string word = "";

        while (word == "" || word == null)
        {
            Console.WriteLine("Enter a word:");
            word = Console.ReadLine();
        }
        int length = word.Length;

        int index = -1;
        while (index < 0 || index > length)
        {
            Console.WriteLine("Remove the ith character:");
            index = int.Parse(Console.ReadLine());
        }

        string word_left = word.Substring(0, index);
        string word_right = word.Substring(index + 1, length - index - 1);

        string new_word = word_left + word_right;

        Console.WriteLine("New word, without ith character: " + new_word);
    }
}

//Write a C# program to create a string from a given string (length 1 or more) with the first character added at the front and back. 
class Program16
{
    public static void Run16()
    {
        string word = "";

        while (word == "" || word == null)
        {
            Console.WriteLine("Enter a word: ");
            word = Console.ReadLine();
        }

        string letter = word[0].ToString();
        string new_word = letter + word + letter;

        Console.WriteLine("New word: " + new_word);

    }
}

//Write a C# program to create a new string from a given string where the first and last characters change their positions.
class Program17
{
    public static void Run17()
    {
        string word = "";
        while (word == "" || word == null)
        {
            Console.WriteLine("Enter a word:");
            word = Console.ReadLine();
        }

        int length_word = word.Length;

        string first_letter = word[0].ToString();
        string last_letter = word[length_word - 1].ToString();

        string middle_word = word.Substring(1, length_word - 2);

        string new_word = last_letter + middle_word + first_letter;

        Console.WriteLine("New word: " + new_word);
    }
}

//Write a C# program to check a pair of integers and return true if one is negative and one is positive.
class Program18
{
    public static void Run18()
    {
        Console.WriteLine("Check 2 integer about different sign:");

        Console.WriteLine("\nNumber 1:");
        int num1 = int.Parse(Console.ReadLine());

        Console.WriteLine("Number 2:");
        int num2 = int.Parse(Console.ReadLine());

        int result = num1 * num2;

        Console.WriteLine(result > 0);
    }
}

//Write a C# program to compute the sum of two given integers. If two values are the same, return the triple of their sum. 
class Program19
{
    public static void Run19()
    {
        Console.WriteLine("Enter 2 interger numbers: ");

        Console.WriteLine("\nNumber 1:");
        int num1 = int.Parse(Console.ReadLine());

        Console.WriteLine("\nNumber 2:");
        int num2 = int.Parse(Console.ReadLine());

        int sum = num1 + num2;
        int triple_sum = 3 * sum;

        if (num1 != num2)
        {
            Console.WriteLine("Sum:" + sum);
        }
        else
        {
            Console.WriteLine("Triple of Sum: " + triple_sum);
        }
    }
}

//Write a C# program to get the absolute value of the difference between two given numbers. 
//Return double the absolute value of the difference if the first number is greater than the second number. 
class Program20
{
    public static int Absolut(int a) {

        if (a < 0)
        {
            return -a;
        }
        else
        {
            return a;
        }
    }

    public static void Run20()
    {
        Console.WriteLine("Enter 2 integers");

        Console.WriteLine("\nEnter first Number: ");
        int num1 = int.Parse(Console.ReadLine());

        Console.WriteLine("Enter second Number: ");
        int num2 = int.Parse(Console.ReadLine());

        int dif_abs = Absolut(num1 - num2);
        int double_dif_abs = 2 * dif_abs;

        if (num1 > num2)
        {
            Console.WriteLine("Double of Absolute Difference: " + double_dif_abs);
        }
        else
        {
            Console.WriteLine("Absolut difference: " + dif_abs);
        }
    }
}