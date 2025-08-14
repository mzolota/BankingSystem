using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankingSystem.Models {

    // enum koristen za tip transakcije
    public enum TransactionType {
        Deposit,
        Withdraw,
        Transfer
    }
    public class Transactions {
        public int Id { get; set; } // pkey
        public Racun Account { get; set; } // veza prema računu
        public TransactionType Type { get; set; }
        public decimal Amount { get; set; }
        public DateTime Date { get; set; }

        // Mora sadrzavati prazan konstruktor kako bi mogo instancirati objekte iz baze ?
        public Transactions() { }


        // regularni konstruktor 
        public Transactions(int id , Racun racun , TransactionType type, decimal amount, DateTime date) {
            Id = id;
            Account = racun;
            Type = type;
            Amount = amount;
            Date = date;

        }

        // konstruktor bez id-a za bazu
        public Transactions(Racun racun, TransactionType type, decimal amount, DateTime date) {
            Account  = racun;
            Type = type;
            Amount = amount;
            Date = date;
        }













    }
}
