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
    public partial class MainPage : Form {

        private readonly MainController _controller;
        private readonly int _racunId; // id računa trenutnog korisnika
        public MainPage(MainController controller, int racunId) {
            InitializeComponent();
          
            _racunId = racunId;

            // inicijalizirani kontroler iz parametra
            _controller = controller;

            // Učitaj trenutni balance u formu
            LoadBalance();
            LoadAccountId();
        }

        // Funkcija za rad sa balansom 
        private void LoadBalance() {
            try {
                var racun = _controller.GetRacun(_racunId);
                lblBalance.Text = $"Balance: {racun.Balance:C}";
            } catch (Exception ex) {
                MessageBox.Show(ex.Message);
            }
        }

        private void LoadAccountId() {
            try {
                var racun = _controller.GetRacun(_racunId); // dohvat trenutnog racuna
                lblVasAccId.Text = $"Account ID: {racun.RacunId}"; // prikaz u labeli
            } catch (Exception ex) {
                MessageBox.Show(ex.Message);
            }
        }



        private void lblIsplata_Click(object sender, EventArgs e) {
           
        }

        private void btnUplata_Click(object sender, EventArgs e) {
            try {
                decimal iznos = decimal.Parse(txtBoxUplati.Text);
                _controller.Uplata(_racunId, iznos);
                LoadBalance();
                MessageBox.Show("Uplata uspješna!");
            } catch (Exception ex) {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnDeposit_Click(object sender, EventArgs e) {
            try {
                decimal iznos = decimal.Parse(txtBoxAmount.Text);
                int toRacun = int.Parse(txtBoxAccount_idTransfer.Text);
                _controller.Transfer(_racunId, iznos, toRacun);
                LoadBalance();
                MessageBox.Show("Transfer uspješan!");
            } catch (Exception ex) {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnIsplata_Click(object sender, EventArgs e) {
            try {
                decimal iznos = decimal.Parse(txtBoxIsplati.Text);
                _controller.Isplata(_racunId, iznos);
                LoadBalance();
                MessageBox.Show("Isplata uspješna!");
            } catch (Exception ex) {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
