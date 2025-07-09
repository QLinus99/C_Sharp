using System;
using System.Runtime.CompilerServices;
using System.Threading.Tasks.Dataflow;


//Write a C# Sharp program to remove all values except integer values from a given array of mixed values. 
class Program91
{
    public static void Run91()
    {
        object[] mixedArray = new object[5];
        mixedArray[0] = 25;
        mixedArray[1] = "Anna";
        mixedArray[2] = false;
        mixedArray[3] = System.DateTime.Now;
        mixedArray[4] = 112.22;

        for (int i = 0; i < mixedArray.Length; i++)
        {
            if (mixedArray[i] is not int) {
                mixedArray[i] = 0;
            }
        }

        Console.WriteLine("New Array: " + string.Join(',', mixedArray));
    }
}


//Write a C# Sharp program to find the next prime number of a given number. 
//If the given number is a prime number, return the number.
class Program92
{
    public static bool Check_prime(int x)
    {
        for (int i = 2; i <= Math.Round(Math.Pow(x, 0.5)); i++)
        {
            if (x % i == 0)
            {
                return false;
            }
        }
        return true;
    }

    public static void Run92()
    {
        Console.WriteLine("Enter number: ");
        int num = Convert.ToInt32(Console.ReadLine());

        int start = num;

        while (Check_prime(start) == false)
        {
            start = start + 1;
        }
        Console.WriteLine($"The next prime nunber of {num} is: {start}");
    }
}


//Write a C# Sharp program to calculate the square root of a given number. 
//Return the integer part of the result instead of using any built-in functions.
class Program93
{
    public static void Run93()
    {
        Console.WriteLine("Enter number");
        int num = Convert.ToInt32(Console.ReadLine());

        int root = (int)(Math.Pow(num, 0.5));

        Console.WriteLine($"The square root of {num} is: {root}");
    }
}


//Write a C# program that finds the longest common prefix from an array of strings. 
class Program95
{
    public static bool test(string s)
    {
        Stack<char> ch = new Stack<char>();

        foreach (var item in s.ToCharArray())
        {
            if (item == '(')
                ch.Push(')');
            else if (item == '<')
                ch.Push('>');
            else if (item == '[')
                ch.Push(']');
            else if (item == '{')
                ch.Push('}');
            else if (ch.Count == 0 || ch.Pop() != item)
                return false; // If the closing parentheses don't match the top of the stack or stack is empty, return false
        }

        return ch.Count == 0;
    }

    public static void Run95()
    {
        string test1 = "<>";
        string test2 = "<>()[]{}";
        string test3 = "(<>";
        string test4 = "[<>()[]{}]";

        Console.WriteLine(test(test1));
        Console.WriteLine(test(test2));
        Console.WriteLine(test(test3));
        Console.WriteLine(test(test4));

    }
}


//Write a C# Sharp program to check whether all characters in a string are the same. 
//Return true if all the characters in the string are the same, otherwise false.
class Program96
{
    public static bool Run96()
    {
        Console.WriteLine("Enter string: ");
        string word = Console.ReadLine();

        int len = word.Length;
        char letter = word[0];

        for (int i = 0; i < len; i++)
        {
            if (word[i] != letter)
            {
                return false;
            }
        }
        return true;
    }
}


//Write a C# Sharp program to check if a given string (floating point and negative numbers included) is numeric or not. 
//Return True if the string is numeric, otherwise false. 
class Program97
{
    public static bool Run97()
    {
        Console.WriteLine("Enter string: ");
        string word = Console.ReadLine();

        double result;

        return double.TryParse(word, out result);
    }
}


//Write a C# Sharp program to create and display all prime numbers in strictly descending decimal digit order.
class Program98
{
    public static void Run98()
    {
        Console.WriteLine("Enter number");
        int num = Convert.ToInt32(Console.ReadLine());

        List<int> prime = new List<int>();
        prime.Add(2);

        int start = 3;

        while (prime.Count != num)
        {
            if (Program92.Check_prime(start) == true)
            {
                prime.Add(start);
            }
            start += 1;
        }

        Console.WriteLine($"First {num} primes in descending order: " + string.Join(',', prime));
    }
}

//main
class Program
{
    static void Main(string[] args)
    {
        Program98.Run98();
    }
}
