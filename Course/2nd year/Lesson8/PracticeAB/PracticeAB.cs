namespace PracticeAB;

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

    //4


    // 5
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

        // 5
        Console.WriteLine("Enter a number of your pay per month.");
        int a5 = int.Parse(Console.ReadLine() );
        Console.WriteLine("Your pay per year is " + payPerYear(a5));
    }
}
