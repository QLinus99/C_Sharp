using System;


//Write a C# program to get the largest value between the first and last element of an array (length 3) of integers. 
class Program51
{
    public static void Run51()
    {
        int[] arr = { 1, 4, 5, 22, 94, 32, 234, 44, 1, 2 };

        int first = arr[0];
        int last = arr[arr.Length - 1];

        if (first > last)
        {
            Console.WriteLine("Largest number: " + first);
        }
        else
        {
            Console.WriteLine("Largest number: " + last);
        }
           
    }
}


//Write a C# program to create a new array of length containing the middle elements of three arrays (each length 3) of integers. 
class Program52
{
    public static void Run52()
    {
        int[] arr1 = { 1, 2, 3 };
        int[] arr2 = { 4, 5, 6, };
        int[] arr3 = { 7, 8, 9 };

        int[][] arrays = { arr1, arr2, arr3 };

        int[] arr4 = new int[3];

        for (int i = 0; i < 3; i++)
        {
            arr4[i] = arrays[i][1];
        }
        Console.WriteLine("New array: " + string.Join(',', arr4));
    }
}


//Write a C# program to check if an array contains an odd number. 
class Program53
{
    public static void Run53()
    {
        int[] arr = { 1, 4, 5, 22, 94, 32, 234, 44, 1, 2 };
        int count_odd = 0;

        for (int i = 0; i < arr.Length; i++)
        {
            if (arr[i] % 2 == 1)
            {
                count_odd++;
            }
        }
        Console.WriteLine("Number of odd numbers in array:" + count_odd);

    }
}


//Write a C# program to get the century of a year
class Program54
{
    public static void Run54()
    {
        int year = DateTime.Now.Year;
        int century = Convert.ToInt32(year / 100) + 1;

        Console.WriteLine($"We are living in the {century} century");
    }
}


//Write a C# program to find the pair of adjacent elements that has the largest product of the given array. 
class Program55
{
    public static void Run55()
    {
        int[] arr = { 1, 4, 5, 22, 94, 32, 234, 44, 1, 2 };

        int adj_prod = 0;
        int first_ele = 0;
        int second_ele = 0;

        for (int i = 0; i < arr.Length - 1; i++)
        {
            if (arr[i] * arr[i + 1] > adj_prod)
            {
                adj_prod = arr[i] * arr[i + 1];
                first_ele = arr[i];
                second_ele = arr[i + 1];
            }
        }
        Console.WriteLine($"The adjacent pair: {first_ele}, {second_ele} have largest Product of adjacent elemnets.");
    }
}


//Write a C# program to check if a given string is a palindrome or not.
class Program56
{
    public static void Run56()
    {
        Console.WriteLine("Input string: ");
        string sentence = Console.ReadLine().ToLower();

        string backwords = "";

        for (int i = sentence.Length - 1; i >= 0; i--)
        {
            backwords = backwords + sentence[i].ToString();
        }

        Console.WriteLine(sentence == backwords);
    }
}


//Write a C# program to find the pair of adjacent elements that has the highest product of an array of integers. 
class Program57
{
    public static void Run57()
    {
        int[] arr = { 1, 4, 5, 22, 94, 32, 234, 44, 1, 2 };

        int adj_prod = 0;
        int first_ele = 0;
        int second_ele = 0;

        for (int i = 0; i < arr.Length - 1; i++)
        {
            if (arr[i] * arr[i + 1] > adj_prod)
            {
                adj_prod = arr[i] * arr[i + 1];
                first_ele = arr[i];
                second_ele = arr[i + 1];
            }
        }
        Console.WriteLine($"The adjacent pair: {first_ele}, {second_ele} have largest Product of adjacent elemnets.");
    }
}

//Write a C# program that accepts a list of integers and checks how many integers are needed to complete the range. 
class Program58
{
    public static void Run58()
    {
        Console.WriteLine("Length of list of numbers: ");
        int len = Convert.ToInt32(Console.ReadLine());

        int[] arr = new int[len];

        for (int i = 0; i < len; i++)
        {
            while (arr[i] < 1 || arr[i] > 9)
            {
                Console.WriteLine($"Input number {i + 1} between 1-9: ");
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }
        }

        int[] complete = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };

        int count_present = 0;

        for (int i = 0; i < complete.Length; i++)
        {
            for (int j = 0; j < arr.Length; j++)
            {
                if (complete[i] == arr[j])
                {
                    count_present++;
                    break;
                }
            }
        }

        int count_missing = 9 - count_present;

        Console.WriteLine("Input array: " + string.Join(',', arr));
        Console.WriteLine("Number of missing elements to complete: " + count_missing);

    }
}

//Check whether it is possible to create a strictly increasing sequence from a given sequence of integers as an array. 
class Program59
{
    public static int[] bubble_sort(int[] array)
    {
        int len = array.Length;

        for (int i = 0; i < len - 1; i++)
        {
            for (int j = 0; j < len - i - 1; j++) {
                if (array[j] > array[j + 1])
                {
                    int help = array[j];
                    array[j] = array[j+1];
                    array[j+1] = help;
                }
            }
        }
        return array;
    }

    public static void Run59()
    {
        Console.WriteLine("Length of list of numbers: ");
        int len = Convert.ToInt32(Console.ReadLine());

        int[] arr = new int[len];

        for (int i = 0; i < len; i++)
        {
            while (arr[i] < 1)
            {
                Console.WriteLine($"Input number {i + 1}: ");
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }
        }

        int [] list_sort = bubble_sort(arr);

        Console.WriteLine("List: " + string.Join(',', arr));
        Console.WriteLine("List Sort: " + string.Join(',', list_sort));
    }
}


// Write a C# program to calculate the sum of all integers in a rectangular matrix. 
// However, exclude those integers located below an integer of value 0. 
class Program60
{
    public static void Run60()
    {
        int[,] matrix = { { 1, 2, 3, 4 }, { -23, 77, 24, -10 }, { 24, 5, 2, -70 } };

        int num_rows = matrix.GetLength(0);
        int num_columns = matrix.GetLength(1);
        int sum = 0;

        for (int i = 0; i < num_rows; i++)
        {
            for (int j = 0; j < num_columns; j++)
            {
                if (matrix[i, j] >= 0)
                {
                    sum = sum + matrix[i, j];
                }
            }
        }
        Console.WriteLine("Sum of positive Elements in Matrix: " + sum);
    }
}



