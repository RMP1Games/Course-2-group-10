using System;
using System.ComponentModel;
internal class Program
{
    // static long Factorial(int number)
    // {
    //     if (number == 1)
    //     return 1;
    //     return number * Factorial(number - 1);
    // }
    //  static long Fibonachchi(int numberOfFibonachchi)
    //  {
    //      if (numberOfFibonachchi == 0)
    //      return 0;
    //      if (numberOfFibonachchi == 1)
    //      return 1;
    //      return Fibonachchi(numberOfFibonachchi - 1) + Fibonachchi(numberOfFibonachchi - 2);
    //  } 
    //  static string TextRecycle(string text)
    //  {
    //     if (text.Length <= 1)
    //     return text;
    //     return TextRecycle(text.Substring(0, 6));
    //  }
    static int NOD(int a, int b)
    {// a
        if (a > b)
        {
            return NOD(a - b, b);
        }// b
        if (b > a)
        {
            return NOD(a, b - a);
        }// 0
        if (b - a == 0 | a - b == 0)
        {
            return b;
        }
        return NOD(a, b);
    }
    static void Main(string[] args)
    {
        // Console.WriteLine ("Enter number to get a factorial of this number.");
        // int number = int.Parse(Console.ReadLine() );
        // Console.WriteLine(Factorial(number));

        // Console.WriteLine("Enter a position(number) of Fibonachchi's numbers.");
        // int numberOfFibonachchi = int.Parse(Console.ReadLine() );
        // Console.WriteLine("The " + numberOfFibonachchi + " number in Fibonachchi's numbers is " + Fibonachchi(numberOfFibonachchi) + ".");

        // Console.WriteLine ("Write something");
        // string text = Console.ReadLine();
        // int Symbols = text.Count();
        // Console.WriteLine (text.Substring(1) + text[0]);
        // Console.WriteLine (text.Substring(0, 5) + text[0]);
        // Console.WriteLine (text[5] + text.Substring(0, 5));
        // Console.WriteLine (text[5] + text.Substring(0, 5));
        // Console.WriteLine ("Reversed original is: " + TextRecycle);

        Console.WriteLine ("Enter a 2 numbers to get NOD of this numbers.");
        int a = int.Parse(Console.ReadLine());
        int b = int.Parse(Console.ReadLine());
        Console.WriteLine ("NOD is " + NOD(a, b));
    }
}
