using System;
using DomainDrivenSample.Interfaces;

namespace DomainDrivenSample.Events
{
    public class OrderFulfilledEvent : IDomainEvent
    {
        public DateTime DateTimeEventOccurred { get; private set; }
        public Guid Id { get; private set; }

        public OrderFulfilledEvent()
        {
            this.Id = Guid.NewGuid();
            DateTimeEventOccurred = DateTime.UtcNow;
        }
    }
}
