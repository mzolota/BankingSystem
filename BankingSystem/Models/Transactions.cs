using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;

namespace BankingSystem.Models {

    
    [Table("transactions")]
    public class Transactions {
        [Key]
        [Column("id")]
        public int Id { get; set; } // pkey

        [ForeignKey("Account")]
        [Column("account_id")]
        public int AccountId { get; set; }

        public Racun Account { get; set; } // veza prema računu
        [Column("type")]
        public string TransactionType  { get; set; }
        [Column("amount")]
        public decimal Amount  { get; set; }
        [Column("date")]
        public DateTime Date { get; set; }

        // Mora sadrzavati prazan konstruktor kako bi mogo instancirati objekte iz baze ?
        public Transactions() { }


        // regularni konstruktor 
        public Transactions(int id , Racun racun , string transactiontype, decimal amount, DateTime date) {
            Id = id;
            Account = racun;
            TransactionType = transactiontype;
            Amount = amount;
            Date = date;

        }

        // konstruktor bez id-a za bazu
        public Transactions(Racun racun, string transactiontype, decimal amount, DateTime date) {
            Account  = racun;
            TransactionType = transactiontype;
            Amount = amount;
            Date = date;
        }
    }
}
