namespace MicroRabbit.Transfer.Application.Interfaces
{
    using MicroRabbit.Transfer.Domain.Models;
    using System.Collections.Generic;

    public interface ITransferService
    {
        IEnumerable<TransferLog> GetTransferLogs();
    }
}