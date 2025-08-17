using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankingSystem.Models {
    [Table("accounts")]
    public class Racun {
        [Key]
        [Column("id")]
        public int Id { get; private set; } 
        [Column("racun_id")]
        public int RacunId { get; set; }
        [Column("balance")]
        public decimal Balance { get; set; }
        public List<Transactions> Transactions { get; private set; }

        // Mora sadrzavati prazan konstruktor kako bi mogo instancirati objekte iz baze ?
        public Racun() { }

        // regularni konstruktor
        public Racun(int id, int racunid, decimal balance) {
            Id = id;
            RacunId = racunid;
            Balance = balance;
            Transactions = new List<Transactions>();
        }













    }
}
