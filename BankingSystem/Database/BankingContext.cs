using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using BankingSystem.Models;

namespace BankingSystem.Database {
    public class BankingContext : DbContext {
        // Ime connection string-a iz App.config , kako bi se mogo connectat?
        public BankingContext() : base("name=BankingDb") {}

        // Tablice u bazi
        public DbSet<User> Users { get; set; }
        public DbSet<Racun> Racuni { get; set; }
        public DbSet<Transactions> Transactions { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder) {
            base.OnModelCreating(modelBuilder);

            // USER -> RACUN (jedan-na-jedan)
            modelBuilder.Entity<User>()
                .HasRequired(u => u.Racun)
                .WithOptional()
                .Map(m => m.MapKey("RacunId")); // ovo stvara foreign key u User tablici

            // RACUN -> TRANSACTIONS (jedan-na-više)
            modelBuilder.Entity<Racun>()
                .HasMany(r => r.Transactions)
                .WithRequired(t => t.Account)
                .Map(m => m.MapKey("RacunId")); // foreign key u Transactions tablici

            // Postavljanje primary key-a ako je potrebno
            modelBuilder.Entity<User>().HasKey(u => u.Id);
            modelBuilder.Entity<Racun>().HasKey(r => r.Id);
            modelBuilder.Entity<Transactions>().HasKey(t => t.Id);
        }
    }
}
