using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the OnlineOrdering Project.");

        Address address1 = new Address("123 Main St", "New York", "NY", "USA");
        Customer customer1 = new Customer("John Smith", address1);


        Order order1 = new Order(customer1);
        order1.AddProduct(new Product("Book", "B100", 10.00, 2));
        order1.AddProduct(new Product("Pen", "P200", 1.50, 5));


        Console.WriteLine(order1.GetPackingLabel());
        Console.WriteLine(order1.GetShippingLabel());
        Console.WriteLine($"Total Cost: ${order1.CalculateTotalCost():0.00}\n");


        Address address2 = new Address("45 Garden Rd", "Kampala", "Central", "Uganda");
        Customer customer2 = new Customer("Sandra Nankya", address2);


        Order order2 = new Order(customer2);
        order2.AddProduct(new Product("Backpack", "BP300", 30.00, 1));
        order2.AddProduct(new Product("Water Bottle", "WB400", 12.00, 2));


        Console.WriteLine(order2.GetPackingLabel());
        Console.WriteLine(order2.GetShippingLabel());
        Console.WriteLine($"Total Cost: ${order2.CalculateTotalCost():0.00}");
    }
}