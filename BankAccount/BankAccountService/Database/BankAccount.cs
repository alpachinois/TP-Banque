using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BankAccount.BankAccountService.Database
{
    public enum AccountType
    {
        Courant,
        Epargne
    }
    public class BankAccount
    {
        public string Email { get; set; }
        public string ID { get; set; }
        public float Solde { get; set; }
        public AccountType Type { get; set; }
    }
}
