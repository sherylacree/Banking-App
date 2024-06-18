using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks; 

namespace Banking_App;
public class Practice1 {
    private static int NextId { get; set; } = 1;

    public int AccountId { get; set; } = 0;
    public string Description { get; set; } = string.Empty;
    public decimal Balance { get; set; } = 0;
    public bool Deposit(decimal Amount) {
        if (Amount <= 0) return false;
        Console.WriteLine("Amount cannot be zero or negative!");
        Balance += Amount;
        return true;
        Console.WriteLine("New Balance is {Balance}");
    }

    public bool Withdraw(decimal Amount) {
        if (Amount > Balance) {
            Console.WriteLine("Insufficient Funds!");
            return false;
        }

        if (Amount < 0) {
            Console.WriteLine("Amount cannot be zero");
            return false;
        }

        Balance -= Amount;
        return true;
    }
    
    public bool Transfer(decimal Amount, Account account) {
    var success = Withdraw(Amount) ;
    if (success == true) {
        account.Deposit(Amount);
    }
    return true;
}
    

}


