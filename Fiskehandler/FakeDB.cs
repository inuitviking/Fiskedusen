using System;
using System.Collections.Generic;

namespace Fiskehandler
{
    public class FakeDB
    {
        public List<Customer> Customers {get;set;}
        public List<Subscription> Subscriptions {get;set;}
        public List<Campaign> Campaigns {get;set;}
        public List<Product> Products {get;set;}
        public List<Category> Categories {get;set;}

        /// <summary>
        /// Initialises the fake database (just a bunch of lists)
        /// </summary>
        public FakeDB(){
            Customers = new List<Customer>();
            Subscriptions = new List<Subscription>();
            Campaigns = new List<Campaign>();
            Products = new List<Product>();
            Categories = new List<Category>();
        }

        /// <summary>
        /// Creates a new category and puts it in the FakeDB Categories List.
        /// </summary>
        /// <param name="name"></param>
        public void CreateCategory(string name){
            Category category = new Category(name);
            this.Categories.Add(category);
        }

        /// <summary>
        /// Creates a new campaign and puts it in the FakeDB Campaigns List.
        /// </summary>
        /// <param name="name"></param>
        /// <param name="start"></param>
        /// <param name="end"></param>
        /// <param name="rate"></param>
        /// <param name="categories"></param>
        public void CreateCampaign(string name, DateTime start, DateTime end, double rate, List<Category> categories){
            Campaign campaign = new Campaign(name, start, end, rate, categories);
            this.Campaigns.Add(campaign);
        }

        /// <summary>
        /// Creates a new product and puts it in the FakeDB Products List.
        /// </summary>
        /// <param name="name"></param>
        /// <param name="category"></param>
        /// <param name="price"></param>
        public void CreateProduct(string name, Category category, double price){
            Product product = new Product(name, category, price);
            this.Products.Add(product);
        }

    }
}
