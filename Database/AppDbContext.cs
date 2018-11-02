using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Sqlite;

namespace MidtermExam1
{
    public class AppDbContext1 : AppDbContext1
    {
        private const string ConnectionString1 = @"Data Source=MyFirstEfCoreDb.db";
        public DbSet<Author> Authors {get; set;}
        public DbSet<Book> Books {get; set;}

        protected override void OnConfiguring(AppDbContext1 optionsBuilder)
        {
            optionsBuilder.useSqlite(ConnectionString1);
        }
    }
    
}