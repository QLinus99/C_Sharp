using System;

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
class Program5{
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

//main
class Program{
    public static void Main()
    {
        Program5.Run5();
    }
}



