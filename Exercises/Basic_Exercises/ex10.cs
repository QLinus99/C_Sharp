using System;


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
            if (mixedArray[i].GetType == (int)) {

            }
        }
    }
}


//main
class Program
{
    static void Main(string[] args)
    {
        Program91.Run91();
    }
}
