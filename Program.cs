using System.Runtime.InteropServices;
using System.Data.Common;
using System.Collections.Generic;
using System;
using System.Linq;
using Fiskehandler;

namespace Fiskedusen
{
    class Program
    {
        static void Main(string[] args)
        {

            // Initiate fake database
            FakeDB db = new FakeDB();

            // Create a category, product, and campaigns for illustrational purposes
            db.CreateCategory("Torsk");
            db.CreateProduct("Atlanterhavstorsk", db.Categories[0], 119.95);
            DateTime start = DateTime.Now;
            DateTime end = start.AddDays(30);
            List<Category> campaignCategories = new List<Category>();
            campaignCategories.Add(db.Categories[0]);
            db.CreateCampaign("Auguster Kampagne", start, end, 0.5, campaignCategories);

            // Create customer and subsciption for illustrational purposes
            db.CreateCustomer("Jan Erik Jensen", "Vej 98", "jej@eksempel.dk");
            db.CreateSubscription(start, end, db.Customers[0], 29.95);

            // Display campaign information
            Console.WriteLine("Campaign information:");
            Console.WriteLine(db.Campaigns[0].Name+" | "+db.Campaigns[0].Start.ToString()+" | "+db.Campaigns[0].End.ToString()+" | "+(db.Campaigns[0].Rate*100)+"%");
            Console.WriteLine("Categories regarding campaign:");
            for (int i = 0; i < db.Campaigns[0].Categories.Count; i++)
            {
                Console.WriteLine(db.Campaigns[0].Categories[i].Name);
            }

            Console.WriteLine("----");

            // Display product information
            Console.WriteLine("Product Information");
            Console.WriteLine("Name - Category - Price - Campaign Price");
            for (int i = 0; i < db.Products.Count; i++)
            {
                double campaignPrice = Math.Round((db.Products[i].Price*db.Campaigns[0].Rate), 2);
                Console.WriteLine($"{db.Products[i].Name} - {db.Products[i].Category.Name} - {db.Products[i].Price} - {campaignPrice}");
            }

            Console.WriteLine("----");

            // Display categories
            Console.WriteLine("Available Categories:");
            for (int j = 0; j < db.Categories.Count; j++)
            {
                Console.WriteLine(db.Categories[j].Name);
            }

            Console.WriteLine("----");

            Console.WriteLine("Display customers:");
            for(int k = 0; k < db.Customers.Count; k++){
                Console.WriteLine(db.Customers[k].Name+" | "+db.Customers[k].Address+" | "+db.Customers[k].Email);
            }
            Console.WriteLine("Display subscriptions:");
            for(int l = 0; l < db.Subscriptions.Count; l++){
                Console.WriteLine(start+" | "+end+" | "+db.Subscriptions[l].Customers.Email+" | "+db.Subscriptions[l].Price+"kr");
            }
        }
    }
}
