using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace Banking_App;
internal class Savings {
    private Account account = new Account("Savings Account");

    public decimal IntRate { get; set; } = 0.12m;

    public void CalcandPayInterest(int months) {
        var Interest = Balance() * (IntRate / 12) * months;
        Deposit(Interest);
            }
    public int AccountId() {
        return account.AccountId;
    }
    public string Description() {
        return account.Description;
    }
    public void Description(string description) {
        account.Description = description;
    }
    public decimal Balance() {
        return account.Balance;
    }
    public bool Deposit(decimal amount) {
        return account.Deposit(amount);
    }
    public bool Withdraw(decimal amount) {
        return account.Withdraw(amount);
    }
    public bool Transfer(decimal Amount, Savings savings) {
        if (account.Withdraw(Amount)){
            savings.Deposit(Amount);
        }
        return true;
    }
    public Savings(string description) {
    }
}




