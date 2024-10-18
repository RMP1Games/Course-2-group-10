using System;
internal class Program
{
    //1
    // static long Factorial(int number)//Factorial
    // {
    //     if (number == 1)
    //     return 1;
    //     return number * Factorial(number - 1);
    // }

    //2
    //  static long Fibonachchi(int numberOfFibonachchi)//Fibonachchi
    //  {
    //      if (numberOfFibonachchi == 0)
    //      return 0;
    //      if (numberOfFibonachchi == 1)
    //      return 1;
    //      return Fibonachchi(numberOfFibonachchi - 1) + Fibonachchi(numberOfFibonachchi - 2);
    //  } 

    //3
        // static string TextRecycle(string text3)
        // {
        // char[] charArray = text3.ToCharArray();
        // Array.Reverse(charArray);
        // return new string(charArray);
        // }

    //4
        // static int sum (int[] arr4, int i, int a4)
        // {
        //     if (i < arr4.Length)
        //     {
        //         a4 += arr4[i];
        //         i += 1;
        //         return sum(arr4, i++, a4);
        //     }
        //     return a4;
        // }
        
    //5
    // static int NOD(int a, int b) //NOD
    // {// a
    //     if (a > b)
    //     {
    //         return NOD(a - b, b);
    //     }// b
    //     if (b > a)
    //     {
    //         return NOD(a, b - a);
    //     }// 0
    //     if (b - a == 0 | a - b == 0)
    //     {
    //         return b;
    //     }
    //     return NOD(a, b);
    // }

    //6
    static bool palindrom(string text6)
    {
        char[] charArray = text6.ToCharArray();
        Array.Reverse(charArray);
        string text62 = new string(charArray);
        if (text6 == text62)
        return true; 
        else return false;
    }
    static void Main(string[] args)
    {
        //Factorial
        // Console.WriteLine ("Enter number to get a factorial of this number.");
        // int number = int.Parse(Console.ReadLine() );
        // Console.WriteLine(Factorial(number));

        //Fibonachchi numbers
        // Console.WriteLine("Enter a position(number) of Fibonachchi's numbers.");
        // int numberOfFibonachchi = int.Parse(Console.ReadLine() );
        // Console.WriteLine("The " + numberOfFibonachchi + " number in Fibonachchi's numbers is " + Fibonachchi(numberOfFibonachchi) + ".");

        //Recycle
        // Console.WriteLine("Enter text");
        // string text3 = Console.ReadLine();
        // Console.WriteLine(TextRecycle(text3));

        //4
        // int[] arr4 = {3, 92, 61, 234, 88};
        // int i = 0;
        // int a4 = 0;
        // Console.WriteLine(sum(arr4, i, a4));

        // NOD
        // Console.WriteLine ("Enter a 2 numbers to get NOD of this numbers.");
        // int a = int.Parse(Console.ReadLine());
        // int b = int.Parse(Console.ReadLine());
        // Console.WriteLine ("NOD is " + NOD(a, b));

        //6
        Console.WriteLine ("Enter text for what? for because");
        string text6 = Console.ReadLine();
        Console.WriteLine(palindrom(text6));
    }
}
