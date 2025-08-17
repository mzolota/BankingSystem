using BankingSystem.Database;
using BankingSystem.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;

namespace BankingSystem.Controllers {
    public class MainController {


        // bridge za logiku iz GUI-a i repozitorija
        private readonly RacunRepository _racunRepository;
        private readonly TransactionsRepository _transactionRepository;

        public MainController(RacunRepository racunRepository, TransactionsRepository transactionRepository) {
            _racunRepository = racunRepository;
            _transactionRepository = transactionRepository;
        }

        // Isplata (Withdraw)
        public void Isplata(int racunId, decimal isplata) {
            var racun = _racunRepository.GetRacunById(racunId);
            if (racun == null) throw new Exception("Račun ne postoji");

            if (racun.Balance - isplata < 0)
                throw new Exception("Nemate dovoljno sredstava");

            racun.Balance -= isplata;

            // dodavanje transakcije
            var transakcija = new Transactions(racun, TransactionType.Withdraw, isplata, DateTime.Now);
            _transactionRepository.AddTransaction(transakcija);

            _racunRepository.Save();
        }

        // Uplata (Deposit)
        public void Uplata(int racunId, decimal uplata) {
            var racun = _racunRepository.GetRacunById(racunId);
            if (racun == null) throw new Exception("Račun ne postoji");

            if (uplata <= 0)
                throw new Exception("Unesite pozitivan broj");

            racun.Balance += uplata;

            var transakcija = new Transactions(racun, TransactionType.Deposit, uplata, DateTime.Now);
            _transactionRepository.AddTransaction(transakcija);

            _racunRepository.Save();
        }

        // Transfer
        public void Transfer(int fromRacunId, decimal amount, int toRacunBroj) {
            var fromRacun = _racunRepository.GetRacunById(fromRacunId);
            var toRacun = _racunRepository.GetRacunByBroj(toRacunBroj);

            if (fromRacun == null || toRacun == null)
                throw new Exception("Jedan od računa ne postoji");

            if (fromRacun.Balance < amount)
                throw new Exception("Nemate dovoljno sredstava na računu");

            fromRacun.Balance -= amount;
            toRacun.Balance += amount;

            _transactionRepository.AddTransaction(new Transactions(fromRacun, TransactionType.Transfer, -amount, DateTime.Now));
            _transactionRepository.AddTransaction(new Transactions(toRacun, TransactionType.Transfer, amount, DateTime.Now));

            _racunRepository.Save();
        }

        public Racun GetRacun(int racunId) {
            var racun = _racunRepository.GetRacunById(racunId);
            if (racun == null) throw new Exception("Račun ne postoji");
            return racun;
        }









    }

}
       

