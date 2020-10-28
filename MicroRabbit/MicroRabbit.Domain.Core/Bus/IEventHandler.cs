namespace MicroRabbit.Domain.Core.Bus
{
    using MicroRabbit.Domain.Core.Events;
    using System.Threading.Tasks;

    public interface IEventHandler<in TEvent> : IEventHandler
        where TEvent : Event
    {
        Task Handle(TEvent @event);
    }

    public interface IEventHandler
    {
    }
}