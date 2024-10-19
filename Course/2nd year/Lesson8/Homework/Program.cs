using System;
class Program
{
    //loan_approval
    static string loan_approval(int balance1)
    {
        if (balance1 <= 0)
        return "Your loan approved!";
        else
        return "With your balance bank can't approve loan to you.";
    }
    
    //deposit_withdrawal
    static int deposit_withdrawal(int balance2, int deposit2)
    {
        return balance2 - deposit2;
    }

    static void Main(string[] args)
    {
    //loan_approval
    Console.WriteLine("Enter a your balance to see, can you get a loan or no.");
    int balance1 = int.Parse(Console.ReadLine());
    Console.WriteLine(loan_approval(balance1));
    //deposit_withdrawa
    Console.WriteLine("Enter a balance and deposit");
    int balance2 = int.Parse(Console.ReadLine());
    int deposit2 = int.Parse(Console.ReadLine());
    Console.WriteLine(deposit_withdrawal(balance2, deposit2));
    }
}