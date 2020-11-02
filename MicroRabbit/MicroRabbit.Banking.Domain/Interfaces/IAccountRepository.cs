namespace MicroRabbit.Banking.Domain.Interfaces
{
    using MicroRabbit.Banking.Domain.Model;
    using System.Collections.Generic;

    public interface IAccountRepository
    {
        IEnumerable<Account> GetAccounts();
    }
}