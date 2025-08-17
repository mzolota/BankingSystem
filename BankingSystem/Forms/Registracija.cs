using BankingSystem.Controllers;
using BankingSystem.Database;
using BankingSystem.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TaskbarClock;

namespace BankingSystem.Forms {
    public partial class Registracija : Form {
        public Registracija() {
            InitializeComponent();
            
        }

        private void btnKreirajRacun_Click(object sender, EventArgs e) {

            try {
                // 1. Pokupi podatke iz textBoxova
                string ime = txtBoxFirstName.Text;
                string prezime = txtBoxLastName.Text;
                string email = txtBoxEmail.Text;
                string lozinka = txtBoxPassword.Text;

                // 2. Kreiraj repozitorij i kontroler
                using (var context = new BankingContext()) {
                    var userRepo = new UserRepository(context);
                    var userController = new UserController(userRepo);

                    // 3. Pozovi register metodu
                    userController.Register(ime, prezime, lozinka, email);

                    MessageBox.Show("Korisnik uspješno registriran!");
                    this.Close();
                    
                }
            } catch (Exception ex) {
                MessageBox.Show(ex.ToString());
                System.Diagnostics.Debug.WriteLine(ex.ToString());
                MessageBox.Show("Pogledaj Output window za detalje");
                throw;
            }
        }

       
    }
}

