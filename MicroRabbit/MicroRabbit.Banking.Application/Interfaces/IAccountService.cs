namespace MicroRabbit.Banking.Application.Interfaces
{
    using MicroRabbit.Banking.Application.Models;
    using MicroRabbit.Banking.Domain.Model;
    using System.Collections.Generic;

    public interface IAccountService
    {
        IEnumerable<Account> GetAccounts();

        void Transfer(AccountTransfer accountTransfer);
    }
}