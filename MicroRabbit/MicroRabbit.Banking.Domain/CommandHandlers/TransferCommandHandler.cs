namespace MicroRabbit.Banking.Domain.CommandHandlers
{
    using MediatR;
    using MicroRabbit.Banking.Domain.Commands;
    using MicroRabbit.Banking.Domain.Events;
    using MicroRabbit.Domain.Core.Bus;
    using System.Threading;
    using System.Threading.Tasks;

    public class TransferCommandHandler : IRequestHandler<CreateTransferCommand, bool>
    {
        private readonly IEventBus _bus;

        public TransferCommandHandler(IEventBus bus)
        {
            _bus = bus;
        }

        public Task<bool> Handle(CreateTransferCommand request, CancellationToken cancellationToken)
        {
            //publish event to RabbitMQ
            _bus.Pusblish(new TransferCreatedEvent(request.From, request.To, request.Amount));

            return Task.FromResult(true);
        }
    }
}