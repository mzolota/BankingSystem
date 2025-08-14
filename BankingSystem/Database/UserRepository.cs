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
        public void AddUser(Models.User user) {
            context.Users.Add(user);
            context.SaveChanges();
        }

        // dohvati email -> vjv koristit kod log in systema
        public User GetUserByEmail(string email) {
            return context.Users.First(x => x.Email == email);
        }

        // dohvati ime
        public User GetUserbyName(string name) {
            return context.Users.First(y => y.Name == name);
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

        
    }
}
