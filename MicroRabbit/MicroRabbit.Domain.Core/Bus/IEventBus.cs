namespace MicroRabbit.Domain.Core.Bus
{
    using MicroRabbit.Domain.Core.Commands;
    using MicroRabbit.Domain.Core.Events;
    using System.Threading.Tasks;

    public interface IEventBus
    {
        Task SendCommand<T>(T commmand) where T : Command;

        void Pusblish<T>(T @event) where T : Event;

        void Subscrive<T, TH>()
            where T : Event
            where TH : IEventHandler<T>;
    }
}