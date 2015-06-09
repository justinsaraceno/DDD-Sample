using System;
using DomainDrivenSample.Events;

namespace DomainDrivenSample.After
{
    public class Order
    {
        private Order(Guid orderId)
        {
            throw new NotImplementedException();
        }

        public Guid OrderId { get; private set; }
        public DateTime OrderDate { get; private set; }
        public int CustomerId { get; private set; }
        public DateTime FulfilledDate { get; private set; }

        #region more properties...
        // just kidding!
        #endregion


        // factory method for creation
        public void FulfillOrder(DateTime fulfilledDate)
        {
            FulfilledDate = fulfilledDate;

            var orderFulfilledEvent = new OrderFulfilledEvent();
            DomainEvents.Raise(orderFulfilledEvent);
        }
    }
}
