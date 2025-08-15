using BankingSystem.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankingSystem.Database {
    public class RacunRepository {

        
        private readonly BankingContext context;
        public RacunRepository(BankingContext Context) { context = Context; }


        // dodavanje racuna  u db 
        public void AddRacun(Models.Racun Racun) {
            context.Racuni.Add(Racun);
            context.SaveChanges();
        }

        // dohvati racun preko id-a
        public Models.Racun GetRacunbyId(int id) {
            return context.Racuni.FirstOrDefault(r => r.Id == id);
        }

        // balance
        public void UpdateBalance(int racunId, decimal newBalance) {
            var racun = context.Racuni.FirstOrDefault(r => r.Id == racunId);
            if (racun == null) {
                throw new Exception("Racun ne postoji");
            }

            racun.Balance = newBalance;
            context.SaveChanges();
        }

        // ako bude trebalo za kasnije
        public Racun GetRacunByUser(User user) {
            return context.Racuni.FirstOrDefault(r => r.Id == user.Racun.Id);
        }



















    }
}
