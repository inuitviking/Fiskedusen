using System;

namespace Fiskehandler
{
    public class Product{
        public string Name {get;set;}
        public Category Category {get;set;}
        public double Price {get;set;}

        /// <summary>
        /// Creates a new product
        /// </summary>
        /// <param name="name"></param>
        /// <param name="category"></param>
        /// <param name="price"></param>
        public Product(string name, Category category, double price){
            this.Name = name;
            this.Category = category;
            this.Price = price;
        }
    }
}