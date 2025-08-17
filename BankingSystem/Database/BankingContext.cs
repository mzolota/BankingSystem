using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using BankingSystem.Models;
using System.Configuration;

namespace BankingSystem.Database {
    public class BankingContext : DbContext {
        public BankingContext()
            : base(GetConnectionString()) // dohvaćamo connection string sa zamijenjenom lozinkom

        {
            // Logiranje svih SQL upita i EF akcija
            this.Database.Log = s => System.Diagnostics.Debug.WriteLine(s);
        }

        // Tablice u bazi
        public DbSet<User> Users { get; set; }
        public DbSet<Racun> Racuni { get; set; }
        public DbSet<Transactions> Transactions { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder) {
            base.OnModelCreating(modelBuilder);

            // USER -> RACUN (jedan-na-jedan)
            modelBuilder.Entity<User>()
                .ToTable("users", "public")
                .HasRequired(u => u.Racun)
                .WithOptional();


            // RACUN -> TRANSACTIONS (jedan-na-više)
            modelBuilder.Entity<Racun>()
                .ToTable("accounts", "public")
                .HasMany(r => r.Transactions)
                .WithRequired(t => t.Account);
               

            // Mapiranje Transactions entiteta na tablicu
            modelBuilder.Entity<Transactions>()
                .ToTable("transactions", "public")
                .Property(t => t.Type)
                .HasColumnName("type")       
                .IsRequired();


            // Primary keys
            modelBuilder.Entity<User>().HasKey(u => u.Id);
            modelBuilder.Entity<Racun>().HasKey(r => r.Id);
            modelBuilder.Entity<Transactions>().HasKey(t => t.Id);
        }

        public static string GetConnectionString() {
            // Dohvat connection stringa iz App.config
            var connString = ConfigurationManager.ConnectionStrings["BankingDb"].ConnectionString;

            // Dohvat passworda iz environment variable
            var password = Environment.GetEnvironmentVariable("POSTGRES_PASSWORD");

            // Zamjena placeholdera sa stvarnom lozinkom
            return connString.Replace("{POSTGRES_PASSWORD}", password);
        }
    }
}

