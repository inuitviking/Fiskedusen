using System;

namespace Fiskehandler
{
    public class Customer{
        
        public string Name { get; set; }
        public string Address { get; set; }
        public string Email { get; set; }

        /// <summary>
        /// Creates a new Customer
        /// </summary>
        /// <param name="Name"></param>
        /// <param name="Address"></param>
        /// <param name="Email"></param>
        public Customer(string Name, string Address, string Email)
        {
            this.Name = Name;
            this.Address = Address;
            this.Email = Email;
        }

    }
}