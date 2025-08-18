using BankingSystem.Database;
using BankingSystem.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankingSystem.Controllers {
    internal class TransactionController {
        private readonly TransactionsRepository _transactionRepo;

        public TransactionController(TransactionsRepository transactionRepo) {
            _transactionRepo = transactionRepo;
        }

        // Dohvat svih transakcija za određeni račun
        public List<Transactions> GetTransactionsByAccount(Racun account) {
            return _transactionRepo.GetAllTransactionsbyAccount(account);
        }

        // Dohvat transakcija po tipu (Deposit, Withdraw, Transfer)
        public List<Transactions> GetTransactionsByType(Racun account, string transactionType) {
            return _transactionRepo.GetTransactionsByType(account, transactionType);
        }
    }
}
