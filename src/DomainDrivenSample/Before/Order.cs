using System;

namespace DomainDrivenSample.Before
{
    public class Order
    {
        public int Id { get; set; }
        public DateTime DateTimeCreated { get; set; }
        public Customer Customer { get; set; } // navigation property to customer that placed the order
        public DateTime DateTimeComplete { get; set; }

        #region more properties...
            // just kidding!
        #endregion

        public void Update()
        {
            #region save logic will go here...
            #endregion
        }
    }

}
