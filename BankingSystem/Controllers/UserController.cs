using BankingSystem.Database;
using BankingSystem.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankingSystem.Controllers {
    public class UserController {


        // bridge za logiku iz GUIA i repozitorija
        private readonly UserRepository _userRepository;
        public UserController(UserRepository userRepository) {
            _userRepository = userRepository;
        }

        // Registracija korisnika
        public void Register( string name, string lastName, string password, string email) {
            // Provjera jel postoji korisnik s istim emailom
            var existingUser = _userRepository.GetUserByEmail(email);
            if (existingUser != null) { throw new Exception("Korisnik s ovim emailom vec postoji"); }


            Random rn = new Random();
            int randomAccountNumber = rn.Next(1, 501);
            // kreiranje racuna za usera , prvo se mora kreirati Racun tek onda User zbog constrainta
            var racun = new Racun { Balance = 0,RacunId = randomAccountNumber };

            // kreira korisnika
            var newUser = new User {
                Name = name,
                LastName = lastName,
                Password = password,
                Email = email,
                Racun = racun
            };

            // dodaj korisnika u bazu
            _userRepository.AddUser(newUser);
        }

        public User Prijava(string password, string email) {
            var user = _userRepository.GetUserByEmailAndPassword(email, password);
            if (user == null) {
                throw new Exception("Pogresan email ili lozinka");
            }
            return user;
        }
    
    
    
    
    }

    }

