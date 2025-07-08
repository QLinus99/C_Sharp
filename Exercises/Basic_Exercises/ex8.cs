using System;
using System.Threading.Tasks.Dataflow;


//Write a C# Sharp program to check if a given string contains two similar consecutive letters. 
class Program71
{
    public static void Run71()
    {
        Console.WriteLine("Enter string: ");
        string sentence = Console.ReadLine();

        int len = sentence.Length;
        bool check = true;

        for (int i = 0; i < len - 1; i++)
        {
            if (sentence[i] == sentence[i + 1])
            {
                Console.WriteLine("String has at least 2 similar consecutive letters.");
                check = false;
                break;
            }
        }
        if (check)
        {
            Console.WriteLine("String has no 2 consectutive letters.");
        }

    }
}


//Write a C# Sharp program to check whether the average value of the elements of a given array of numbers is a whole number or not. 
class Program72
{
    public static bool IsInteger(double number)
    {
        return (number % 1 == 0);
    }

    public static void Run72()
    {
        int[] numbers = { 2, 46, 20, 33, 2, 3, 21, 88, 7, 65, 49, 24 };

        double len = numbers.Length;
        double sum = 0;

        for (int i = 0; i < len; i++)
        {
            sum = sum + numbers[i];
        }

        double average = sum / len;

        if (IsInteger(average))
        {
            Console.WriteLine("The average is an integer:" + average);
        }
        else
        {
            Console.WriteLine("The average is not an integer: " + average);
        }

    }
}


//Write a C# Sharp program to convert the letters of a given string (same case-upper/lower) into alphabetical order. 
class Program73
{
    public static void Run73()
    {
        Console.WriteLine("Enter string: ");
        string sentence = Console.ReadLine();

        sentence = sentence.ToLower();
        int len = sentence.Length;

        int[] array_num = new int[len];

        for (int i = 0; i < len; i++)
        {
            array_num[i] = (int)sentence[i]; // ascii value of character
        }

        //sort
        int[] array_sort = Program59.bubble_sort(array_num);

        //num to char
        char[] character_sort = new char[len];

        for (int i = 0; i < len; i++)
        {
            character_sort[i] = (char)array_sort[i];
        }

        string final_word = "";
        for (int i = 0; i < len; i++)
        {
            final_word = final_word + character_sort[i];
        }

        Console.WriteLine("Sentence: " + sentence);
        Console.WriteLine("Array Sort: " + string.Join(',', array_sort));
        Console.WriteLine("Array Char: " + string.Join(',', final_word));

    }
}


//Write a C# Sharp program to check the length of a given string is odd or even.
//Return 'Odd length' if the string length is odd otherwise 'Even length'
class Program74
{
    public static void Run74()
    {
        Console.WriteLine("Enter string: ");
        string sentence = Console.ReadLine();

        int len = sentence.Length;

        if (len % 2 == 0)
        {
            Console.WriteLine("Even string");
        }
        else
        {
            Console.WriteLine("Odd string");
        }
    }
}


//Write a C# Sharp program that takes a positive number and returns the nth odd number. 
class Program75
{
    public static void Run75()
    {
        Console.WriteLine("Enter a positive number: ");
        int num = Convert.ToInt32(Console.ReadLine());

        int num_start = 1;

        for (int i = 1; i < num; i++)
        {
            num_start = num_start + 2;
        }

        Console.WriteLine($"The {num}-th odd number is: {num_start}");
    }
}


// Write a C# Sharp program to get the ASCII value of a given character. 
class Program76
{
    public static void Run76()
    {
        Console.WriteLine("Enter character vor ASCII value");
        string cha = Console.ReadLine();

        foreach (char c in cha)
        {
            Console.WriteLine((int)c);
        }
    }
}


//Write a C# Sharp program to check whether a word is plural or not. 
class Program77
{
    public static void Run77()
    {
        Console.WriteLine("Enter word: ");
        string word = Console.ReadLine();

        if (word[word.Length - 1] == 's')
        {
            Console.WriteLine("Word is possible plural");
        }
        else
        {
            Console.WriteLine("Word is possible not plural");
        }
    }
}


//Write a C# Sharp program to find the sum of squares of elements in a given array of integers. 
class Program78
{
    public static void Run78()
    {
        int[] arr = { 1, 4, 3, 2, 6, 5 };
        int[] square = new int[arr.Length];

        for (int i = 0; i < arr.Length; i++)
        {
            square[i] = Convert.ToInt32(Math.Pow(arr[i], 2));
        }

        int sum = 0;

        for (int i = 0; i < arr.Length; i++)
        {
            sum = sum + square[i];
        }

        Console.WriteLine("The sum of square is: " + sum);
    }
}


//Write a C# Sharp program to convert all the values of a given array of mixed values to string values. 
class Program80
{
    public static void Run80()
    {
        object[] mixedArray = new object[5];
        mixedArray[0] = 25;
        mixedArray[1] = "Anna";
        mixedArray[2] = false;
        mixedArray[3] = System.DateTime.Now;
        mixedArray[4] = 112.22;

        string[] array_con = new string[mixedArray.Length];

        array_con = Array.ConvertAll(mixedArray, x => x.ToString());

        Console.WriteLine("New Array: " + string.Join(',', array_con));
    }
}