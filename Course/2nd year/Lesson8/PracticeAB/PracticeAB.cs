namespace PracticeAB;
using System;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.Linq;
using System.Runtime.CompilerServices;

class Program
{

    
    // Творим тут


    // //1
    // static int summary(int a1, int b1)
    // {
    //     return a1 + b1;
    // }
    
    // //2
    // static bool idk(int a2)
    // {
    //     return a2 % 2 == 0;
    // }

    //3
    // static string reverseText(string text3)
    // {
    //     char[] charArray = text3.ToCharArray();
    //     Array.Reverse(charArray);
    //     return new string(charArray);
    // }

    //4 how to do this
    // static int maxNumber(int[] array4)
    // {
    //     int a4 = array4.Max();
    //     return a4;
    // }

    // // 5
    // static long payPerYear(int a5)
    // {
    //     return a5 * 12;
    // }


    //6
    // static int convertation(int a6)
    // {
    //     return a6 * 9/5 + 32;
    // }

    //7
        // static int count_vowels(string text7, int count)
        // {
            // string vowels = "аАеЕёЁиИоОуУыЫэЭюЮяЯaAeEyYuUoO";
            // char[] lol = {'a'};
            // int l7 = 0;
            // for (int i = 0; i < text7.Length; i++)
            // {
            //     lol[0] = text7[l7];
            //     if (vowels.IndexOfAny(lol) != -1)
            //     {
            //     count += 1;
            //     l7 += 1;
            //     }
            //     else
            //     l7 += 1;
            // }
            // return count;
        //}

    //8
    // static int generatePassword(int password, int generatedPassword)
    // {
    //     for (int x = 0; x < 10; x++)
    //     {
    //         for (int y = 0; y < 10; y++)
    //         {
    //             for (int z = 0; z < 10; z++)
    //             {
    //                 for (int l = 0; l < 10; l++)
    //                 {
    //                 generatedPassword = ((x * 1000) + (y * 100) + (z * 10) + l);
    //                 if (generatedPassword == password)
    //                 return 1;
    //                 }
    //             }
    //         }
    //     }
    //     return generatedPassword;
    // }

    static void Main(string[] args)
    {
        // //1
        // Console.WriteLine("Enter a 2 numbers");
        // int a1 = int.Parse(Console.ReadLine() );
        // int b1 = int.Parse(Console.ReadLine() );
        // Console.WriteLine(summary(a1, b1));
        
        // // 2
        // Console.WriteLine("Enter a number.");
        // int a2 = int.Parse(Console.ReadLine() );
        // Console.WriteLine("Number % 2 = 0: " + idk(a2));

        // //3
        // Console.WriteLine("Enter a text");
        // string text3 = Console.ReadLine();
        // Console.WriteLine(reverseText(text3));

        //4
        // int [] array4 = {1, 2, 5, 8, 1, 123, 23, 99};
        // Console.WriteLine(maxNumber(array4));

        // // 5
        // Console.WriteLine("Enter a number of your pay per month.");
        // int a5 = int.Parse(Console.ReadLine() );
        // Console.WriteLine("Your pay per year is " + payPerYear(a5));

        //6
        // Console.WriteLine("Enter celsus");
        // int a6 = int.Parse(Console.ReadLine());
        // Console.WriteLine(convertation(a6));

        //7
        // Console.WriteLine("Enter text");
        // string text7 = Console.ReadLine();
        // int count = 0;
        // Console.WriteLine(count_vowels(text7, count));

        //8
        // Console.WriteLine("Enter a password to know can my program can generate password or no");
        // int password = int.Parse(Console.ReadLine());
        // generatePassword(password, 0);
        // Console.WriteLine("yeah program can get a password wohoo");
    }
}
