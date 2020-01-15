using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BankAccount.BankAccountService.Models
{
    public class BankAccountUpdateRequest: BankAccountRequest
    {        
        public float Montant { get; set; }
    }
}
