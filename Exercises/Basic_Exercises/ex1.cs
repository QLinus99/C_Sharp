using System;
using System.Security.Cryptography;

//Write a C# Sharp program to print Hello and your name in a separate line. 
class Program1{
    public static void Run1(){
        Console.WriteLine("Hello");
        Console.WriteLine("Linus");
    }
}

//Write a C# Sharp program to print the sum of two numbers.
class Program2{
    public static void Run2(){
        int a = 2;
        int b = 6;
        Console.WriteLine(a + b);
    }
}

//Write a C# Sharp program to print the result of dividing two numbers.
class Program3{
    public static void Run3(){
        int a = 88;
        int b = 22;
        Console.WriteLine(a / b);
    }
}

//Write a C# Sharp program to print the results of the specified operations.
class Program4{
    public static void Run4(){
        Console.WriteLine(-1 + 4 * 6);
        Console.WriteLine((35 + 5) % 7);
        Console.WriteLine(14 + -4 * 6 / 11);
        Console.WriteLine(2 + 15 / 6 * 1 - 7 % 2);
    }
}


//Write a C# Sharp program to swap two numbers.
class Program5
{
    public static void Run5()
    {
        int first_num = 5;
        int second_num = 6;
        int swap_help;

        swap_help = first_num;
        first_num = second_num;
        second_num = swap_help;

        Console.WriteLine("First Number: {0}", first_num);
        Console.WriteLine("Second_Number: {0}", second_num);
    }
}


//Write a C# Sharp program to print the output of the multiplication of three numbers entered by the user. 
class Program6
{
    public static void Run6()
    {
        int num1, num2, num3;

        Console.WriteLine("Multiplication 3 integer numbers:");
        Console.Write("\nInput the first number:");
        num1 = int.Parse(Console.ReadLine());
        Console.Write("Input the second number:");
        num2 = int.Parse(Console.ReadLine());
        Console.Write("Input the third number:");
        num3 = int.Parse(Console.ReadLine());

        int mult_num = num1 * num2 * num3;

        Console.WriteLine("Multiplication Result: " + mult_num);

    }
}


//Write a C# Sharp program to print on screen the output of adding, subtracting, multiplying and dividing two numbers entered by the user. 
class Program7
{
    public static void Run7()
    {
        Console.WriteLine("Input 2 interger numbers for mathematicaloperations: ");

        Console.WriteLine("Number 1: ");
        int num1 = int.Parse(Console.ReadLine());
        Console.WriteLine("Number 2: ");
        int num2 = int.Parse(Console.ReadLine());

        int add = num1 + num2;
        int minus = num1 - num2;
        int mult = num1 * num2;
        int div = num1 / num2;

        Console.WriteLine("Addition:" + add);
        Console.WriteLine("Subtraction:" + minus);
        Console.WriteLine("Multiplication:" + mult);
        Console.WriteLine("Division:" + div);
    }
}


//Write a C# Sharp program that prints the multiplication table of a number as input.
class Program8
{
    public static void Run8()
    {
        int num_multtable;

        Console.WriteLine("Input Number for Multiplication table:");
        num_multtable = int.Parse(Console.ReadLine());

        for (int a = 0; a <= 10; a++)
        {
            int mult_res = a * num_multtable;
            Console.WriteLine($"{a} * {num_multtable} = " + mult_res);
        }
    }
}

//Write a C# Sharp program that takes four numbers as input to calculate and print the average.
class Program9
{
    public static void Run9()
    {
        int num1, num2, num3, num4;

        Console.WriteLine("Input 4 integers to calculate the average");

        Console.WriteLine("Number 1:");
        num1 = int.Parse(Console.ReadLine());
        Console.WriteLine("Number 2:");
        num2 = int.Parse(Console.ReadLine());
        Console.WriteLine("Number 3:");
        num3 = int.Parse(Console.ReadLine());
        Console.WriteLine("Number 4:");
        num4 = int.Parse(Console.ReadLine());

        int average = (num1 + num2 + num3 + num4) / 4;

        Console.WriteLine("Average:" + average);
    }
}

//Write a C# Sharp program that takes three numbers (x,y,z) as input and outputs (x+y).z and x.y + y.z.
class Program10
{
    public static void Run10()
    {
        int num1, num2, num3;

        Console.WriteLine("Input 3 intergers for calculations:");

        Console.WriteLine("\nInput number 1:");
        num1 = int.Parse(Console.ReadLine());
        Console.WriteLine("Input number 2:");
        num2 = int.Parse(Console.ReadLine());
        Console.WriteLine("Input number 3:");
        num3 = int.Parse(Console.ReadLine());

        int calc1 = (num1 + num2) * num3;
        int calc2 = num1 * num2 + num2 * num3;

        Console.WriteLine($"({num1} + {num2}) * {num3} = " + calc1);
        Console.WriteLine($"{num1} * {num2} + {num2} * {num3} = "+  calc2);
    }
} 




