using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banking_App;
//inherit from Exception by adding space : Exception as below
internal class InsufficientFundsException : Exception{
    //constructor with no parameters is called a default construct
    //to display curret balance when exception is thrown
    public decimal Balance { get; set; }
    public decimal Amount { get; set; }
    public InsufficientFundsException() { }
    public InsufficientFundsException(string message) : base(message) { }
    public InsufficientFundsException (string message, Exception Exception) : base(message, Exception) { }

}
