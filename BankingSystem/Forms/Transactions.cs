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

namespace BankingSystem.Forms {
    public partial class Transactions : Form {
        private Form _mainForm;
        private int _racunId;
        private readonly TransactionsRepository _transRepo;
        private readonly RacunRepository _racunRepo;
        public Transactions(Form mainForm, int racunId) {
            InitializeComponent();
            _mainForm = mainForm;
            _racunId = racunId;

            var context = new BankingContext();
            _racunRepo = new RacunRepository(context);
            _transRepo = new TransactionsRepository(context);

            LoadTransactions();

        }

        private void btnPovratak_Click(object sender, EventArgs e) {
            this.Close(); // zatvara trenutnu formu
            _mainForm.Show(); // ponovno prikazujemo glavnu formu
        }

        private void LoadTransactions() {
            try {
                var racun = _racunRepo.GetRacunById(_racunId);
                if (racun == null) throw new Exception("Račun ne postoji.");

                var transactions = _transRepo.GetAllTransactionsbyAccount(racun)
                                  .AsEnumerable() 
                                  .Select(t => new {
                                  Iznos = t.Amount,
                                  Datum = t.Date,
                                  Tip = t.TransactionType
                 })
                                  .ToList();

                dgvTransakcije.DataSource = transactions;

                dgvTransakcije.Columns["Iznos"].HeaderText = "Iznos";
                dgvTransakcije.Columns["Datum"].HeaderText = "Datum";
                dgvTransakcije.Columns["Tip"].HeaderText = "Tip";

            } catch (Exception ex) {
                MessageBox.Show("Greška pri učitavanju transakcija: " + ex.Message);
            }
        }




















        // ne brisati kreira error jer eto takve su windows forme
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e) {

        }

        private void dgvTransakcije_CellContentClick(object sender, DataGridViewCellEventArgs e) {

        }
    }
}
