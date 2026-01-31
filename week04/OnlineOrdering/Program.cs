using System;

class Program
{
    static void Main(string[] args)
    {
        Order order1 = new Order(
            new Customer("Jame Kirk", 
                new Address("123 Elm St", "Springfield", "IL", "USA"))
        );
        order1.AddProduct(new Product("Laptop", "LP1001", 999.99, 1));
        order1.AddProduct(new Product("Mouse", "MS2002", 25.50, 2));
        order1.AddProduct(new Product("Keyboard", "KB3003", 45.00, 1));
        order1.PrintPackingLabel();
        order1.PrintShippingLabel();
        Console.WriteLine($"Total Price: ${order1.GetTotalPrice()}");

        Order order2 = new Order(
            new Customer("Jean-Luc Picard", 
                new Address("456 Oak St", "London", "", "UK"))
        );
        order2.AddProduct(new Product("Tablet", "TB4004", 499.99, 1));
        order2.AddProduct(new Product("Stylus", "ST5005", 29.99, 1));
        order2.AddProduct(new Product("Headphones", "HP6006", 19.99, 1));
        order2.PrintPackingLabel();
        order2.PrintShippingLabel();
        Console.WriteLine($"Total Price: ${order2.GetTotalPrice()}");
    }
}