using BankingSystem.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankingSystem.Database {
    public class TransactionsRepository {
        private readonly BankingContext context;

        public TransactionsRepository(BankingContext Context) { context = Context; }


        // provjerava jel postoji account u useru , ako da dodaje transakciju ako ne baca error
        public void AddTransaction(Models.Transactions transaction) {
            var account = context.Racuni.FirstOrDefault(r => r.Id == transaction.Account.Id);
            if (account == null) {
                throw new Exception("Racun ne postoji");
            }
            // dodavanje transakcije
            context.Transactions.Add(transaction);
            
        }

        // dohvati transakcije
        public List<Models.Transactions> GetAllTransactionsbyAccount(Racun account) {

            return context.Transactions.Where(t => t.Account.Id == account.Id)
                                        .OrderByDescending(t => t.Date)
                                        .ToList();
        }

        // filtriranje podataka ( koristeno za ispis transakcija formu)
        public List<Transactions> GetTransactionsByType(Racun account, TransactionType type) {
            return context.Transactions
                          .Where(t => t.Account.Id == account.Id && t.Type == type)
                          .OrderByDescending(t => t.Date)
                          .ToList();
        }






    }
}
