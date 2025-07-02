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


class Program {
    public static void Main() {
        Program2.Run2();
    }
}