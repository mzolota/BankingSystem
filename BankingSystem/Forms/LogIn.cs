using BankingSystem.Controllers;
using BankingSystem.Database;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BankingSystem.Forms {
    public partial class LogIn : Form {
        public LogIn() {
            InitializeComponent();
        }

        private void btnRegistracija_Click(object sender, EventArgs e) {
            var myForm = new Registracija();
            myForm.ShowDialog(this);
           

        }

        private void BtnPrijava_Click(object sender, EventArgs e) {
            try {
                // 1. Pokupi podatke iz textBoxova
                string email = txtBoxEmail.Text;
                string lozinka = txtBoxPassword.Text;

                // 2. Kreiraj repozitorij i kontroler
                using (var context = new BankingContext()) {
                    var userRepo = new UserRepository(context);
                    var userController = new UserController(userRepo);

                    // 3. Pozovi metodu za prijavu
                    userController.Prijava(lozinka, email);
                    MessageBox.Show("Uspjesno ste prijavljeni!");
                    this.Close();

                    // otvori main dio app-a
                    var Main = new Main();
                    Main.Show();
                    

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
