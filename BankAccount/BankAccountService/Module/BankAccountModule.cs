using BankAccount.BankAccountService.Database;
using BankAccount.BankAccountService.Models;
using BankAccount.BankAccountService.Database;
using Nancy;
using Nancy.ModelBinding;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BankAccount.BankAccountService.Module
{
    public class BankAccountModule: NancyModule
    {
        public BankAccountModule(): base("/ynov")
        {
            Post("/update", parameters =>
            {
                var bankAccountUpdateRequest = this.Bind<BankAccountUpdateRequest>();
                return this.UpdateBankAccount(bankAccountUpdateRequest);
            });
            Get("/{email}/{id}", parameters =>
            {
                var request = this.Bind<BankAccountRequest>();
                return GetBankAccountDetail(request);
            }
                
            );
        }
        private BankAccountResponse GetBankAccountDetail(BankAccountRequest request)
        {
            BankAccountResponse r = new BankAccountResponse();
            Database.BankAccount ba = BankAccountDatabase.Comptes[request.ID];
            if (ba.Email.Equals(request.Email, StringComparison.InvariantCultureIgnoreCase))
            {
                r.BankAccount = ba;
                r.Code = HttpStatusCode.OK;
            }
            else
            {
                r.Code = HttpStatusCode.Unauthorized;
            }

            return r;
        }
        private BankAccountResponse UpdateBankAccount(BankAccountUpdateRequest request)
        {
            BankAccountResponse r = new BankAccountResponse();
            Database.BankAccount ba = BankAccountDatabase.Comptes[request.ID];
            if(ba.Email.Equals(request.Email, StringComparison.InvariantCultureIgnoreCase))
            {
                ba.Solde += request.Montant;
                r.BankAccount = ba;
                r.Code = HttpStatusCode.OK;
            }
            else
            {
                r.Code = HttpStatusCode.Unauthorized;
            }

            return r;
        }
    }
}
