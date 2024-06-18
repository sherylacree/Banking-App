using System;
using System.Data;

namespace Banking_App;

//Create a Console Project called Banking App
//Create properties for :
//AccountId integer
// Description string - like Checking, Savings, Joint, etc
//Balance decimal

//Create methods for :
//Depositing into the Balance property-This method will have parameters-The value cannot be negative
//Withdrawing from the Balance property-This method has required parameters. The value cannot be negative. The value cannot exceed Balance. 
//Display the Current Balance-This method does not have any parameters. It returns the value of the Balance as decimal.  
//When run, the prompt should show the user that they can list the function they want followed by a parameter (if needed)

//Examples: $ deposit 100 $deposit 40 $ withdraw 30 $ withdraw 120 $ balance (responds with the current value of the Balance property

internal class Program {
    static void Main(string[] args) {

     var a1 = new Savings("Savings1");
     var a2 = new Savings ("Savings2");

    Console.WriteLine($"Balance is {a1.Balance:C}");
    a1.Deposit(500);
    Console.WriteLine($"Balance is {a1.Balance:C}");
    a1.Withdraw(230);
     Console.WriteLine($"Balance is {a1.Balance:C}");
    a1.Withdraw(300);
    Console.WriteLine($"Balance is {a1.Balance:C}");
    a1.Deposit(-200);
        a1.Transfer(100, a2);
        a2.Transfer(50, a1);

        Console.WriteLine(($"Balance is {a1.Balance:C}"));
        a1.CalcandPayInterest(1);
        Console.WriteLine($"Balance is {a1.Balance}");



    }
}
