using BankingSystem.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankingSystem.Database {
    public class RacunRepository {

        
        private readonly BankingContext _context;

        public RacunRepository(BankingContext context) {
            _context = context;
        }


        // dodavanje racuna  u db 
        public void AddRacun(Models.Racun Racun) {
            _context.Racuni.Add(Racun);
        }

     
        // dohvati racun putem id-a
        public Racun GetRacunById(int id) {
            return _context.Racuni.FirstOrDefault(r => r.Id == id);
        }



        // balance update ako bude trebalo
        public void UpdateBalance(int racunId, decimal newBalance) {
            var racun = _context.Racuni.FirstOrDefault(r => r.Id == racunId);
            if (racun == null) {
                throw new Exception("Racun ne postoji");
            }

            racun.Balance = newBalance;
            
        }

        // ako bude trebalo za kasnije
        public Racun GetRacunByUser(User user) {
            return _context.Racuni.FirstOrDefault(r => r.Id == user.Racun.Id);
        }

        public void Save() {
            _context.SaveChanges();
        }


        // dohvati account_id , sluzi za transfer
        public Racun GetRacunByBroj(int racunBroj) {
            return _context.Racuni.FirstOrDefault(r => r.RacunId == racunBroj);
        }

    }
}
