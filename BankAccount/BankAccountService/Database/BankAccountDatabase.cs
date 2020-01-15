using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BankAccount.BankAccountService.Database
{
    public class BankAccountDatabase
    {
        public static Dictionary<string, BankAccount> Comptes = new Dictionary<string, BankAccount>();
        public BankAccountDatabase()
        {
            BankAccount account = new BankAccount()
            {
                Email = "Kent.clark@ynovcorp.com",
                ID = "12345678910",
                Solde = 1500,
                Type = AccountType.Courant
            };
            Comptes.Add(account.ID, account);
            account = new BankAccount()
            {
                Email = "Kent.clark@ynovcorp.com",
                ID = "12345678911",
                Solde = 15000,
                Type = AccountType.Epargne
            };
            Comptes.Add(account.ID, account);
            account = new BankAccount()
            {
                Email = "Cooper.sheldon@ynovcorp.com",
                ID = "12345678912",
                Solde = 500,
                Type = AccountType.Courant
            };
            Comptes.Add(account.ID, account);

        }
    }
}
