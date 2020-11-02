namespace MicroRabbit.Transfer.Domain.Interfaces
{
    using MicroRabbit.Transfer.Domain.Models;
    using System.Collections.Generic;

    public interface ITransferRepository
    {
        IEnumerable<TransferLog> GetTransferLogs();

        void Add(TransferLog transferLog);
    }
}