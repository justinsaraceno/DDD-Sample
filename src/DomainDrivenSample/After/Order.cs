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
            #region This is a Rich Domain Model. There are private setters, properly named methods, and required method parameters.
            #endregion

            FulfilledDate = fulfilledDate;

            var orderFulfilledEvent = new OrderFulfilledEvent();
            // instead of concerning this code with other things that need to take place outside
            // of this domian, raise an event that an Order was completed and let those other domains
            // subscribe to this event if they wish.
            DomainEvents.Raise(orderFulfilledEvent);
        }

        public void ChangeOrderQuantity(int quantity)
        {
            
        }
    }
}
