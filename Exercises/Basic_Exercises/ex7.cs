using System;
using System.Runtime.CompilerServices;
using Microsoft.VisualBasic;


//Write a C# program to sort the integers in ascending order without moving the number -5. 
class Program61
{
    public static int[] bubble_sort(int[] array)
    {

        int len = array.Length;

        for (int i = 0; i < len - 1; i++)
        {
            for (int j = 0; j < len - i - 1; j++)
            {
                if (array[j] > array[j + 1])
                {
                    int help = array[j];
                    array[j] = array[j + 1];
                    array[j + 1] = help;
                }
            }
        }
        return array;
        }
    
    //get position of -5 in array
    public static int getposition(int[] array)
    {
        int num = -5;
        int position = -1;

        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] == num)
            {
                position = i;
            }
        }
        return position;
    }

    //get -5 in previous position
    public static int[] Rearrange(int[] arr_start, int[] arr_sort)
    {
        int pos_start = getposition(arr_start);
        Console.WriteLine("Position Start_List: " + pos_start);
        int pos_sort = getposition(arr_sort);
        Console.WriteLine("Position Sort_List: " + pos_sort);

        //no -5 or same position , then nothing to do
        if (pos_start == -1 || pos_start == pos_sort)
        {
            return arr_sort;
        }

        int[] arr_rearrange = arr_sort;

        if (pos_start > pos_sort)
        {
            for (int i = pos_sort; i < pos_start; i++)
            {
                int swap_help = arr_rearrange[i];
                arr_rearrange[i] = arr_rearrange[i + 1];
                arr_rearrange[i + 1] = swap_help;
            }
        }
        else
        {
            for (int i = pos_sort; i > pos_start; i--)
            {
                int swap_helper = arr_rearrange[i];
                arr_rearrange[i] = arr_rearrange[i - 1];
                arr_rearrange[i - 1] = swap_helper;
            }
        }

        return arr_rearrange;
    }

    public static void Run61()
    {
        Console.WriteLine("Length of list of numbers: ");
        int len = Convert.ToInt32(Console.ReadLine());

        int[] arr = new int[len];

        for (int i = 0; i < len; i++)
        {

            Console.WriteLine($"Input number {i + 1}: ");
            arr[i] = Convert.ToInt32(Console.ReadLine());
        }

        Console.WriteLine("List Start: " + string.Join(',', arr));

        int[] list_sort = bubble_sort((int[]) arr.Clone());
        Console.WriteLine("List Sort: " + string.Join(',', list_sort));

        int[] list_final = new int[list_sort.Length];
        list_final = Rearrange(arr, list_sort);
        Console.WriteLine("List Rearrange: " + string.Join(',', list_final));
    }
}


//Write a C# program to reverse the strings contained in each pair of matching parentheses in a given string. 
//It should also remove the parentheses from the given string. 
// assume string has the structure: ...(.....).....
class Program62
{
    public static string Reverse(string word)
    {
        string reverse = "";

        for (int i = word.Length - 1; i >= 0; i--)
        {
            reverse = reverse + word[i].ToString();
        }

        return reverse;
    }


    public static string Merge(string sentence, string reverse, int ind_start, int ind_end)
    {
        string first = sentence.Substring(0, ind_start);
        string second = reverse;
        string third = sentence.Substring(ind_end + 1);

        return first + second + third;
    }


    public static void Run62()
    {
        Console.WriteLine("Enter string: ");
        string sentence = Console.ReadLine();

        int start_ind = sentence.IndexOf('(');
        int end_ind = sentence.IndexOf(')');

        if (start_ind == -1 || end_ind == -1 || start_ind > end_ind)
        {
            Console.WriteLine("New String: " + sentence);
        }
        else
        {
            string to_reverse = sentence.Substring(start_ind + 1, end_ind - start_ind - 1);
            string reverse = Reverse(to_reverse);

            string new_sentence = Merge(sentence, reverse, start_ind, end_ind);

            Console.WriteLine("New sentence: " + new_sentence);
        }
    }
}


//Write a C# program to check if a given number is present in an array of numbers. 
class Program63
{
    public static void Run63()
    {
        int[] numbers = { 1, 2, 5, 6, 7, 88, 44, 3, 3 };

        Console.WriteLine("Number to check in array: ");
        int check = Convert.ToInt32(Console.ReadLine());

        int counter = 0;

        for (int i = 0; i < numbers.Length; i++)
        {
            if (numbers[i] == check)
            {
                counter++;
            }
        }
        Console.WriteLine($"The number {check} is {counter} times in the given array");

    }
}


//Write a C# Sharp program to get the file name (including extension) from a given path. 
class Program64
{
    public static void Run64()
    {
        string path = "/home/linus/Documents/IAESTE/IAESTE_Nepal/acceptance_note";

        string filename = Path.GetFileName(path);
        string extension = Path.GetExtension(path);

        Console.WriteLine("Filename: " + filename);
        Console.WriteLine("Extension: " + extension);

    }
}


//Write a C# Sharp program to multiply all elements of a given array of numbers by array length. 
class Program65
{
    public static void Run65()
    {
        int[] numbers = { 22, 45, 55, 53, 2, 3, 3, 1, 12 };
        int[] new_numbers = (int[])numbers.Clone();

        int len = numbers.Length;

        for (int i = 0; i < len; i++)
        {
            new_numbers[i] = new_numbers[i] * len;
        }


        Console.WriteLine("Array Start: " + string.Join(',', numbers));
        Console.WriteLine("Array End: " + string.Join(',', new_numbers));
    }
}


//Write a C# Sharp program to find the minimum value from two numbers given to you, represented as a string. 
class Program66
{
    public static void Run66()
    {
        string num1 = "23";
        string num2 = "567";

        int num_first = Convert.ToInt32(num1);
        int num_second = Convert.ToInt32(num2);

        Console.WriteLine(num_first > num_second ? num_second : num_first);
    }
}


//Write a C# Sharp program to create a coded string from a given string, using a specified formula.
//Replace all 'P' with '9', 'T' with '0', 'S' with '1', 'H' with '6' and 'A' with '8'.
class Program67
{
    public static void Run67()
    {
        Console.WriteLine("Enter string");
        string sentence = Console.ReadLine();

        sentence = sentence.Replace('P', '9');
        sentence = sentence.Replace('T', '0');
        sentence = sentence.Replace('S', '1');
        sentence = sentence.Replace('H', '6');
        sentence = sentence.Replace('A', '8');

        Console.WriteLine("New string: " + sentence);
    }
}


//Write a C# Sharp program to count a specified character (both cases) in a given string. 
class Program68
{
    public static void Run68()
    {
        Console.WriteLine("Enter string: ");
        string sentence = Console.ReadLine();

        string charac = "";

        Console.WriteLine("Enter character to count: ");

        while (charac.Length != 1)
        {
            charac = Console.ReadLine();
        }

        int count = 0;

        for (int i = 0; i < sentence.Length; i++)
        {
            if (sentence[i].ToString() == charac)
            {
                count++;
            }
        }

        Console.WriteLine($"The character {charac} appears {count} times in {sentence}");
    }
}


//Write a C# Sharp program to check if a given string contains only lowercase or uppercase characters. 
class Program69
{
    public static void Run69()
    {
        Console.WriteLine("Enter string: ");
        string sentence = Console.ReadLine();

        bool upper = (sentence == sentence.ToUpper());
        bool lower = (sentence == sentence.ToLower());

        Console.WriteLine("Only Uppercase? --> " + upper);
        Console.WriteLine("Only Lowercase? -->" + lower);
    }
}


//Write a C# Sharp program to remove the first and last elements from a given string.
class Program70
{
    public static void Run70()
    {
        Console.WriteLine("Enter string: ");
        string sentence = Console.ReadLine();

        string new_sentence = sentence.Substring(1, sentence.Length - 2);

        Console.WriteLine("New sentence: " + new_sentence);
    }
}