using System;
class ATM
{
    static void Main()
    {
        string name;
        double account_balance = 0;
        double withdrawel_ammount = 0;
        DateTime now = DateTime.Now;

        Console.WriteLine("Enter account balance: ");
        account_balance = double.Parse(Console.ReadLine());
        Console.WriteLine("Enter withdrawel amount:");
        withdrawel_ammount = double.Parse(Console.ReadLine());

        account_balance = account_balance - withdrawel_ammount;

        Console.WriteLine("Withdrawal Successful!");
        Console.WriteLine("Updated Account balance: " + account_balance);
        Console.WriteLine("Transaction Time " + now);

    }
}