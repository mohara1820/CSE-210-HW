using System;

class Program
{
    static void Main()
    {
        Address address1 = new Address("123 Main st", "New York", "NY", "USA");
        Customer customer1 = new Customer("Micheal Reaves", address1);

        Order order1 = new Order(customer1);
        order1.AddProduct(new Product("Laptop", "P123", 1200m, 1));
        order1.AddProduct(new Product("Mouse", "P456", 25m, 2));

        Console.WriteLine(order1.GetPackingLabel());
        Console.WriteLine(order1.GetShippingLabel());
        Console.WriteLine("Total Price: $" + order1.GetTotalPrice());
        
        Address address2 = new Address("456 Elm St", "Toronto", "ON", "Canada");
        Customer customer2 = new Customer("Jane Smith", address2);

        Order order2 = new Order(customer2);
        order2.AddProduct(new Product("Keyboard", "P789", 100m, 1));
        order2.AddProduct(new Product("Monitor", "P101", 300m, 1));

        Console.WriteLine(order2.GetPackingLabel());
        Console.WriteLine(order2.GetShippingLabel());
        Console.WriteLine("Total Price: $" + order2.GetTotalPrice());
    }
}