using BankingSystem.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace BankingSystem.Database {
    public class UserRepository {

        // Entity framework context koji sadrzava dbSet<Users>User 
        private readonly BankingContext context;

        public UserRepository(BankingContext Context) { context = Context;  }

        // dodaj korisnika u bazu i spremi promjene
        public void AddUser(User user) {
            context.Racuni.Add(user.Racun);
            context.SaveChanges(); // Racun dobije Id
            user.AccountId = user.Racun.Id;
            context.Users.Add(user);
            context.SaveChanges();
        }



        // dohvati email 
        public User GetUserByEmail(string email) {
            return context.Users.FirstOrDefault(x => x.Email == email);
        }

        // dohvati ime
        public User GetUserbyName(string name) {
            return context.Users.FirstOrDefault(y => y.Name == name);
        }
        // updatea user-a
        public void UpdateUser(Models.User user) {
            context.Users.AddOrUpdate(user);
            context.SaveChanges();
        }

        // dohvati korisnika po id-u
        public User GetUserById(int id) {
            return context.Users.FirstOrDefault(x => x.Id == id); 
        }


        // pretrazivanje po emailu i passwordu iskljucivo za prijavu korisnika
        public User GetUserByEmailAndPassword(string email, string password) {
            return context.Users.FirstOrDefault(u => u.Email == email && u.Password == password);
        } 

        
    }
}
