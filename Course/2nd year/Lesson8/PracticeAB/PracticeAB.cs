namespace PracticeAB;
using System;
using System.Linq;

class Program
{

    
    // Творим тут


    //1
    static int summary(int a1, int b1)
    {
        return a1 + b1;
    }
    
    //2
    static bool idk(int a2)
    {
        return a2 % 2 == 0;
    }

    //3
    static string reverseText(string text3)
    {
        char[] charArray = text3.ToCharArray();
        Array.Reverse(charArray);
        return new string(charArray);
    }

    //4 how to do this
    // static int maxNumber(int[] array4)
    // {
    //     int a4 = array.Max(array4);
    //     return a4;
    // }

    // // 5
    static long payPerYear(int a5)
    {
        return a5 * 12;
    }


    // 6


    //7


    //8

    static void Main(string[] args)
    {
        //1
        Console.WriteLine("Enter a 2 numbers");
        int a1 = int.Parse(Console.ReadLine() );
        int b1 = int.Parse(Console.ReadLine() );
        Console.WriteLine(summary(a1, b1));
        
        // 2
        Console.WriteLine("Enter a number.");
        int a2 = int.Parse(Console.ReadLine() );
        Console.WriteLine("Number % 2 = 0: " + idk(a2));

        //3
        Console.WriteLine("Enter a text");
        string text3 = Console.ReadLine();
        Console.WriteLine(reverseText(text3));

        // //4
        // Console.WriteLine("Enter some numbers");
        // //we think i can do this yeah 100%
        // int [] array4 = {1, 2, 5, 8, 1, 23, 99};
        // Console.WriteLine();

        // 5
        Console.WriteLine("Enter a number of your pay per month.");
        int a5 = int.Parse(Console.ReadLine() );
        Console.WriteLine("Your pay per year is " + payPerYear(a5));
    }
}
