using Nancy;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BankAccount.BankAccountService.Models
{
    public class BankAccountResponse
    {
        public HttpStatusCode Code { get; set; }
        public Database.BankAccount BankAccount { get; set; }
    }
}
