using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        //Create Address.
        Address address1 = new Address("125 Main St", "Las Flores", "CA", "USA.");
        Address address2 = new Address("455 Elm St", "Santa Elena", "ON", "Canada.");

        //Create Customers.
        Customer customer1 = new Customer("Mateo Doe", address1);
        Customer customer2 = new Customer("Lisa Taylor", address2);

        //Create Products.
        Product product1 = new Product("Product 1", "P001", 10.99m, 2);
        Product product2 = new Product("Product 2", "P002", 5.99m, 3);
        Product product3 = new Product("Product 3", "P003", 7.99m, 1);

        //create orders.
        Order order1 = new Order(customer1);
        order1.AddProduct(product1);
        order1.AddProduct(product2);

        Order order2 = new Order(customer2);
        order2.AddProduct(product2);
        order2.AddProduct(product3);

        //Show information about of orders.
        Console.WriteLine("Order 1:");
        Console.WriteLine($"Packaging Label:\n{order1.GetPackagingLabel()}");
        Console.WriteLine($"Shipping Label:\n{order1.GetShippingLabel()}");
        Console.WriteLine($"Total Cost: ${order1.CalculateCostTotal()}");

        Console.WriteLine("\nOrder 2:");
        Console.WriteLine($"Packaging Label:\n{order2.GetPackagingLabel()}");
        Console.WriteLine($"Shipping Label:\n{order2.GetShippingLabel()}");
        Console.WriteLine($"Total Cost: ${order2.CalculateCostTotal()}");
    }
}