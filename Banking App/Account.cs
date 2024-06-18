using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Banking_App;
public class Account {
    private static int nextId { get; set; } = 1;

    public int AccountId { get; private set; } = 0;
    public string Description { get; set; } = string.Empty;
    public decimal Balance { get; set; } = 0;

    public bool Deposit(decimal Amount) {
        if (Amount <= 0) return false;
        Console.WriteLine("Amount cannot be zero or negative!");
        Balance += Amount;
        return true;
    }

    public bool Withdraw(decimal Amount) {
        if (Amount <= 0) {
            Console.WriteLine("Amount cannot be zero or negative!");
            return false;
        }

        if (Amount > Balance) {
            Console.WriteLine("Insufficient funds!");
            return false;
        }
            Balance -= Amount;
            return true;
        }
  
    
    public bool Transfer(decimal Amount, Account account) {
        var success = Withdraw(Amount);
        if (success == true) { 
            account.Deposit(Amount);
        }
        return true;
    }
    public Account(string description) {
        AccountId = nextId++;
        Description = description; 
        Balance = 0;

    }
}
