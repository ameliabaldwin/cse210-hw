using System;

class Program
{
    static void Main(string[] args)
    {
        // Order 1
        Address bobsAdd = new Address("713 Lake View Rd", "Hudson", "NH", "USA");
        Customer bobert = new Customer("Bobert", bobsAdd);
        Product product1a = new Product("A Dozen of Donuts", 032564, 5, 12.99f);
        Product product1b = new Product("Surround Bluetooth Speaker", 032565, 1, 75.49f);
        Product product1c = new Product("Loaf of Bread", 234985, 2, 8.00f);
        Discount bobsDis = new Discount("GET20OFFSALE", 0.20f);

        Order bobsOrder = new Order(bobert, bobsDis, bobsAdd);
        
        bobsOrder.AddProduct(product1a);
        bobsOrder.AddProduct(product1b);
        bobsOrder.AddProduct(product1c);

        string AmericanOrNot;
        if (bobsAdd.AreYouAmerican())
        {
            AmericanOrNot = "You are American";
        }
        else
        {
            AmericanOrNot = "You are not American";
        }

        Console.WriteLine("Bob's Order Details:");
        Console.WriteLine(AmericanOrNot);
        Console.WriteLine(bobsOrder.DisplayOrderDetails());

        // Order 2
        Address davesAdd = new Address("9345 Windfall St.", "Fourchu", "NS", "CANADA");
        Customer dave = new Customer("Dave", davesAdd);
        Product product2a = new Product("Pokemon Booster Pack", 238475, 1, 19.99f);
        Product product2b = new Product("The Official Pokemon Pocket Knife", 345890, 20, 400.99f);
        Product product2c = new Product("Maple Syrup", 238556, 2, 7.64f);
        Discount davesDis = new Discount("BOGO2SALE", 0.20f);

        Order davesOrder = new Order(dave, davesDis, davesAdd);
        
        davesOrder.AddProduct(product2a);
        davesOrder.AddProduct(product2b);
        davesOrder.AddProduct(product2c);

        if (davesAdd.AreYouAmerican())
        {
            AmericanOrNot = "You are American";
        }
        else
        {
            AmericanOrNot = "You are not American";
        }

        Console.WriteLine("\nDave's Order Details:");
        Console.WriteLine(AmericanOrNot);
        Console.WriteLine(davesOrder.DisplayOrderDetails());
    }
}