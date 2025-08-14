using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankingSystem.Models {
    public class User {
        public int Id { get; private set; } // pkey
        public string Name { get; private set; }
        public string LastName { get; private set; }
        public string Email { get; private set; }
        public string Password { get; private set; }
        public Racun Racun { get; set; }

        // Mora sadrzavati prazan konstruktor kako bi mogo instancirati objekte iz baze ?
        public User() { }

        // regularni konstruktor za registraciju
        public User(int id, string name, string lastname, string email, string password, Racun racun) {
            Id = id;
            Name = name;
            LastName = lastname;
            Email = email;
            Password = password;
            Racun = racun;
           
        }

        // konstruktor za prijavu
        public User(string email, string password) {
            Password = password;
            Email = email;
        }








    }
}