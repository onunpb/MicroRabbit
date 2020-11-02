namespace MicroRabbit.Banking.Domain.Commands
{
    using MicroRabbit.Domain.Core.Commands;

    public class TransferCommand : Command
    {
        public int From { get; protected set; }
        public int To { get; protected set; }
        public decimal Amount { get; protected set; }
    }
}