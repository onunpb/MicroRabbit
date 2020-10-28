namespace MicroRabbit.Domain.Core.Events
{
    using System;

    public abstract class Event
    {
        public DateTime Timestamp { get; protected set; }

        protected Event()
        {
            Timestamp = DateTime.Now;
        }
    }
}