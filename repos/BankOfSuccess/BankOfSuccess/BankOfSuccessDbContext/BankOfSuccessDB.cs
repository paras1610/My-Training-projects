using BankOfSuccess.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankOfSuccess.BankOfSuccessDbContext
{
    internal class BankOfSuccessDB : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {

            optionsBuilder.UseSqlServer(@"Data Source=(localdb)\mssqllocaldb;Initial Catalog=BankOfSuccessDB;Integrated Security=True;Pooling=False");

        }
        public DbSet<AccountRecords> accountrecord { get; set; }
    }
}