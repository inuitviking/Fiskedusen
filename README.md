# Fiskedusen with Fiskehandler library
## Intro
This is a simple small team school project, focused on versioning and documentation.

The namespace `Fiskedusen` is where the examples are placed (`Program.cs`), whereas the `Fiskehandler` is the class libarary.
`Fiskehandler` does not contain a `Main`, but only classes for use in other programs (e.g. `Fiskedusen`).

`Fiskehandler` works in the way that there is a "central" class where everything should be used (currently all classes are public, which should probably be changed).

## Gettings started with examples
### Adding things to the fake database
Initiate the fake database:
```c#
FakeDB db = new FakeDB();
```
Create a category:
```c#
db.CreateCategory("Cod");
```
Create a product:
```c#
db.CreateProduct("Atlantic Cod", db.Categories[0], 119.95); // In this example, Danish-ish prices were in mind
```
A campaign is probably best created this way (Remember `using System.Collections.Generic;`):
```c#
DateTime start = DateTime.Now;                                                  // Campaign start date
DateTime end = start.AddDays(30);                                               // Campaign end date
List<Category> campaignCategories = new List<Category>();                       // Initiate list containing campaign categories
campaignCategories.Add(db.Categories[0]);                                       // Add campaigns to list
db.CreateCampaign("Auguster Kampagne", start, end, 0.5, campaignCategories);    // Create campaign
```
Create a customer:
```c#
db.CreateCustomer("Jan Erik Jensen", "Vej 98", "jej@eksempel.dk");
```
Create a subscription:
```c#
db.CreateSubscription(start, end, db.Customers[0], 29.95);
```
### Displaying values from created items
Displaying categories (Remember `using System.Linq;`):
```c#
for (int i = 0; i < db.Categories.Count; i++)
{
    Console.WriteLine(db.Categories[j].Name);
}
```
Displaying products (including the calculation of campaign prices):
```c#
for (int i = 0; i < db.Products.Count; i++)
{
    double campaignPrice = Math.Round((db.Products[i].Price*db.Campaigns[0].Rate), 2);
    Console.WriteLine($"{db.Products[i].Name} - {db.Products[i].Category.Name} - {db.Products[i].Price} - {campaignPrice}");
}
```
Displaying campaign information:
```c#
Console.WriteLine("Campaign information:");
Console.WriteLine(db.Campaigns[0].Name+" | "+db.Campaigns[0].Start.ToString()+" | "+db.Campaigns[0].End.ToString()+" | "+(db.Campaigns[0].Rate*100)+"%");
Console.WriteLine("Categories regarding campaign:");
for (int i = 0; i < db.Campaigns[0].Categories.Count; i++)
{
    Console.WriteLine(db.Campaigns[0].Categories[i].Name);
}
```
Displaying customers:
```c#
Console.WriteLine("Display customers:");
for(int k = 0; k < db.Customers.Count; k++){
    Console.WriteLine(db.Customers[k].Name+" | "+db.Customers[k].Address+" | "+db.Customers[k].Email);
}
```
Displaying Subscriptions:
```c#
Console.WriteLine("Display subscriptions:");
for(int l = 0; l < db.Subscriptions.Count; l++){
    Console.WriteLine(start+" | "+end+" | "+db.Subscriptions[l].Customers.Email+" | "+db.Subscriptions[l].Price+"kr");
}
```
