using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        // Create Address and Customer
        Address address1 = new Address("1234 Main St", "Anytown", "CA", "USA");
        Customer customer1 = new Customer("John Doe", address1);

        // Create Products
        Product product1 = new Product("Laptop", 101, 999.99m, 1);
        Product product2 = new Product("Mouse", 102, 25.75m, 2);

        // Create Order
        Order order1 = new Order(customer1);
        order1.AddProduct(product1);
        order1.AddProduct(product2);

        // Output Labels and Total Cost
        Console.WriteLine(order1.GetPackingLabel());
        Console.WriteLine(order1.GetShippingLabel());
        Console.WriteLine($"Total Cost: ${order1.GetTotalCost()}");
    }
}