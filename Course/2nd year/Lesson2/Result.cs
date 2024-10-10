using System;
Console.WriteLine ( "Hello! Please, enter your full name." );
string Name = Console.ReadLine();
Console.WriteLine ( "Your full name is " + Name + ", right?" );

Console.WriteLine ("Please enter your year of date.");
int yearOfDate = int.Parse(Console.ReadLine ());
int year = 2024;
int age = year - yearOfDate;
Console.WriteLine ("Your age is " + age);

Console.WriteLine ("Enter the name and number of phone.");
string name = Console.ReadLine ();
string numberOfPhone = Console.ReadLine ();
Console.WriteLine ("Succesful!");
Console.WriteLine ("Name: " + name);
Console.WriteLine ("Number of phone: " + numberOfPhone);

Console.WriteLine ("Enter 2 numbers.");
int a = int.Parse (Console.ReadLine ());
int b = int.Parse (Console.ReadLine ());
if (a > b)
{
Console.WriteLine ("Bigger number is " + a);
Console.WriteLine ("Smallest number is " + b);
}
if (b > a)
{
Console.WriteLine ("Bigger number is " + b);
Console.WriteLine ("Smallest number is " + a);
}

Console.WriteLine ("Enter a number (1-999).");
int number = int.Parse(Console.ReadLine ());
int a1 = number / 100;
int b1 = (number - (a1 * 100)) / 10;
int c = (number - (a1 * 100)) - (b1 * 10);
Console.WriteLine ("Your number have: " + a1 + " hundreds, " + b1 + " tens and " + c + " units");

Console.WriteLine ("Enter a 2 numbers.");
int a2 = int.Parse(Console.ReadLine ());
int b2 = int.Parse(Console.ReadLine ());
int c2 = a2 + b2;
Console.WriteLine (a2 + " + " + b2 + " = " + c2);

Console.WriteLine ("You have a number, but you don't know what a number. This number is x. x >= 1 and x <= 9. What is this number?");
int numberr = int.Parse (Console.ReadLine ());
int x = 5;
    if (numberr > x)
    {
        Console.WriteLine ("You are wrong! X is smaller. Try again.");
    }
  if (numberr < x)
    {
        Console.WriteLine ("You are wrong! X is bigger. Try again.");
    }
  if (numberr == x)
    {
    Console.WriteLine ("You are right! X is " + numberr + ".");
    }
