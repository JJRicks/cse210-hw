using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        // Create Address and Customer
        Address address1 = new Address("1234 Main St", "Anytown", "CA", "USA");
        Customer customer1 = new Customer("John Doe", address1);

        Address address2 = new Address("5678 Park Ave", "Metropolis", "NY", "USA");
        Customer customer2 = new Customer("Alice Johnson", address2);

        Address address3 = new Address("42 Galaxy Way", "Cosmos", "TX", "USA");
        Customer customer3 = new Customer("Bob Smith", address3);

        Address address4 = new Address("99 Queen Street", "London", "LDN", "UK");
        Customer customer4 = new Customer("Charlie Brown", address4);

        // Create Products
        Product product1 = new Product("Laptop", 101, 999.99m, 1);
        Product product2 = new Product("Mouse", 102, 25.75m, 2);
        Product product3 = new Product("Smartphone", 201, 599.99m, 1);
        Product product4 = new Product("Headphones", 202, 89.99m, 1);
        Product product5 = new Product("Printer", 203, 149.99m, 1);
        Product product6 = new Product("Webcam", 204, 45.99m, 1);
        Product product7 = new Product("Desk Lamp", 205, 23.75m, 2);

        // Create Orders
        Order order1 = new Order(customer1);
        order1.AddProduct(product1);
        order1.AddProduct(product2);
        
        Order order2 = new Order(customer2);
        order2.AddProduct(product3);
        order2.AddProduct(product4);

        Order order3 = new Order(customer3);
        order3.AddProduct(product5);
        order3.AddProduct(product6);

        Order order4 = new Order(customer4);
        order4.AddProduct(product7);

        // List of orders
        List<Order> orders = new List<Order> { order1, order2, order3, order4 };

        // Output Labels and Total Costs for all orders
        foreach (Order order in orders)
        {
            Console.WriteLine(order.GetPackingLabel());
            Console.WriteLine(order.GetShippingLabel());
            Console.WriteLine($"Total Cost: ${order.GetTotalCost()}\n");
        }

        
    }
}