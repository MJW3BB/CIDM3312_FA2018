using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Sqlite;

namespace Assignment 04
{
    public class AppDbContext : DbContext
    {
        private const string ConnectionString = @"Data Source=MyFirstEfCoreDb.db";
        protected override void OnConfiguring(
            DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite(ConnectionString);
        }        
        public DbSet<Student> Students { get; set; }  
        public DbSet<Team> Teams {get; set; } 
        public DbSet<Client> Clients {get; set; }
        public DbSet<Orginization> Orginizations {get; set; }
    }    
}