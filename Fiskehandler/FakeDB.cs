using System;

namespace Fiskehandler
{
    public class FakeDB
    {
        public List<Customer> Customers {get;set;}
        public List<Subscription> Subscriptions {get;set;}
        public List<Campaign> Campaigns {get;set;}
        public List<Product> Products {get;set;}
        public List<Category> Categories {get;set;}

        public FakeDB(){
            Customers = new List<Customer>();
            Subscriptions = new List<Subscription>();
            Campaigns = new List<Campaign>();
            Products = new List<Product>();
            Categories = new List<Category>();
        }
    }
}
