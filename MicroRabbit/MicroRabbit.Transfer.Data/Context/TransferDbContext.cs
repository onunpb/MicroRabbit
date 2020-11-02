namespace MicroRabbit.Transfer.Data.Context
{
    using MicroRabbit.Transfer.Domain.Models;
    using Microsoft.EntityFrameworkCore;

    public class TransferDbContext : DbContext
    {
        public TransferDbContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<TransferLog> TransferLogs { get; set; }
    }
}