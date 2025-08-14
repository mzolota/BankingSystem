using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankingSystem.Models {
    public class Racun {
        public int Id { get; private set; } // pkey
        public int RacunId { get; set; }
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
