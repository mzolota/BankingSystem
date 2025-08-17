using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankingSystem.Models {

    [Table("users")]
    public class User {
        [Key]
        [Column("id")]
        public int Id { get;  set; }
        [Column("name")]
        public string Name { get;  set; }
        [Column("last_name")]
        public string LastName { get;  set; }
        [Column("email")]
        public string Email { get;  set; }
        [Column("password")]
        public string Password { get;  set; }
        [Column("account_id")]


        public int? AccountId { get; set; }
        public virtual Racun Racun { get; set; }

        // Mora sadrzavati prazan konstruktor kako bi mogo instancirati objekte iz baze ?
        public User() { }

        // full konstruktor ako mi budeo bio potreban
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
        // konstruktor za registraciju
        public User (string name, string lastName, string password, string email) {
            Name = name;
            LastName = lastName;
            Password = password;
            Email = email;

        }








    }
}