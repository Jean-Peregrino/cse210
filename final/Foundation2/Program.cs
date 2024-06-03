using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        //Console.WriteLine("Hello Foundation2 World!");

        Product product1 = new Product("Laptop", 101, 999.99, 1);
        Product product2 = new Product("Smartphone", 102, 799.99, 2);
        Product product3 = new Product("Tablet", 103, 499.99, 1);
        Product product4 = new Product("Smartwatch", 104, 199.99, 2);
        Product product5 = new Product("Wireless Earbuds", 105, 149.99, 1);

        Address address1 = new Address("123 Elm Street", "Boise", "Idaho", "USA");
        Address address2 = new Address("Av. Fernando Teran 510", "Lima", "Lima", "Peru");

        Customer customer1 = new Customer("Ian Tompson", address1);
        Customer customer2 = new Customer("Lucas Plada", address2);

        Order order1 = new Order(new List<Product> { product1, product2, product3 }, customer1);
        Order order2 = new Order(new List<Product> { product4, product5 }, customer2);

        Console.WriteLine("Order 1:");
        Console.WriteLine(order1.GetPackingLabel());
        Console.WriteLine(order1.GetShippingLabel());
        Console.WriteLine($"Total Price: ${order1.CalculateTotalPrice()}");

        Console.WriteLine("\nOrder2:");
        Console.WriteLine(order2.GetPackingLabel());
        Console.WriteLine(order2.GetShippingLabel());
        Console.WriteLine($"Total Price: ${order2.CalculateTotalPrice()}");

    }
}