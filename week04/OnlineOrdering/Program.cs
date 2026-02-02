using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the OnlineOrdering Project.");

        Address address1 = new Address("123 side St", "San Pablo City", "Laguna", "Philippines");
        Customer customer1 = new Customer("Lance Lorenzo", address1);

        Address address2 = new Address("465 Otherside St", "San Pablo City", "Laguna", "Philippines");
        Customer customer2 = new Customer("Rozenkran Lorenzo", address2);

        Product product1 = new Product("Pen", 1010, 10, 0.20f);
        Product product2 = new Product("Paper", 1011, 2, 0.34f);
        Product product3 = new Product("Ruler", 1015, 1, 0.19f);
        Product product4 = new Product("Canned Fish", 3419, 3, 0.39f);
        Product product5 = new Product("Pancake Mix", 0241, 2, 1.32f);

        Order order1 = new Order(customer1);
        order1.AddProduct(product1);
        order1.AddProduct(product2);
        order1.AddProduct(product3);

        Order order2 = new Order(customer2);
        order2.AddProduct(product4);
        order2.AddProduct(product5);

        Console.WriteLine("Order 1:");
        Console.WriteLine("Total Cost: $" + order1.OrderTotalCost());
        Console.WriteLine("Packing Label:\n" + order1.PackingLabel());
        Console.WriteLine("Shipping Label:\n" + order1.ShippingLabel());

        Console.WriteLine("-------------------------------------");

        Console.WriteLine("Order 2:");
        Console.WriteLine("Total Cost: $" + order2.OrderTotalCost());
        Console.WriteLine("Packing Label:\n" + order2.PackingLabel());
        Console.WriteLine("Shipping Label:\n" + order2.ShippingLabel());
    }
}