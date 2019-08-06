using System;

namespace Fiskehandler
{
    public class Subscription{
        
        public DateTime Start { get; set; }
        public DateTime End { get; set; }
        public Customer Customers { get; }
        public int Price { get; set; }

        /// <summary>
        /// Creates a new Subscription
        /// </summary>
        /// <param name="Start"></param>
        /// <param name="End"></param>
        /// <param name="Customer"></param>
        /// <param name="Price"></param>
        public Subscription(DateTime Start, DateTime End, Customer Customer, int Price )
        {
            this.Start = Start;
            this.End = End;
            this.Customers = Customer;
            this.Price = Price;
        }
    }
}