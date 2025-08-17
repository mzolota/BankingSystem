using BankingSystem.Controllers;
using BankingSystem.Database;
using BankingSystem.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

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
                
                string email = txtBoxEmail.Text;
                string lozinka = txtBoxPassword.Text;

                //Kreira repozitorije i kontrolere
                using (var context = new BankingContext()) {
                    var userRepo = new UserRepository(context);
                    var racunRepo = new RacunRepository(context);
                    var transactionRepo = new TransactionsRepository(context);

                    var userController = new UserController(userRepo);
                    var mainController = new MainController(racunRepo, transactionRepo);

                    //  Pozovi metodu za prijavu i dohvati usera
                    var user = userController.Prijava(lozinka, email);

                    MessageBox.Show("Uspjesno ste prijavljeni!");

                    //  Dohvati racunId
                    int racunId = user.Racun.Id;

                    
                    this.Hide(); // sakrij login formu
                    var main = new MainPage(mainController, racunId);
                    main.ShowDialog();

                    this.Close(); // zatvori login nakon što se MainPage zatvori
                }
            } catch (Exception ex) {
                MessageBox.Show(ex.Message);
                System.Diagnostics.Debug.WriteLine(ex.ToString());
            }
        }
    }
}













