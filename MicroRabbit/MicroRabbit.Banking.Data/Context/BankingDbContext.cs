namespace MicroRabbit.Banking.Data.Context
{
    using MicroRabbit.Banking.Domain.Model;
    using Microsoft.EntityFrameworkCore;

    public class BankingDbContext : DbContext
    {
        public BankingDbContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<Account> Accounts { get; set; }
    }
}