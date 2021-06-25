using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;

namespace CodeFirstExcercise
{
    class StockContext : DbContext
    {

        public DbSet<Stock> Stocks { get; set;  }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=.\\MSSQLSERVER01;Database=StockDb;Trusted_Connection=True;");
        }

    }
}
