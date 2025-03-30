using System;
using System.Collections.Generic;

namespace Program2
{
    class Program
    {
        static void Main(string[] args)
        {
            Address addressUSA = new Address("65 S 1st W", "Anytown", "ID", "USA");
            Customer customerUSA = new Customer("Jose Velastegui", addressUSA);

            Order orderUSA = new Order(customerUSA);
            orderUSA.Products.Add(new Product("Widget", "SKDKJg", 10.99m, 2));
            orderUSA.Products.Add(new Product("Gadget", "asiugf", 15.50m, 1));

            Address addressNonUSA = new Address("Calle 50", "Othertown", "PA", "Panama");
            Customer customerNonUSA = new Customer("Jane Smith", addressNonUSA);

            Order orderNonUSA = new Order(customerNonUSA);
            orderNonUSA.Products.Add(new Product("Pillow", "asfwe", 7.99m, 3));
            orderNonUSA.Products.Add(new Product("Watch", "sdfasd", 12.75m, 2));

            Console.WriteLine("Order for USA Customer:");
            Console.WriteLine(orderUSA.GetPackingLabel());
            Console.WriteLine(orderUSA.GetShippingLabel());
            Console.WriteLine("Total Cost: $" + orderUSA.CalculateTotalCost());
            Console.WriteLine();

            Console.WriteLine("Order for Non-USA Customer:");
            Console.WriteLine(orderNonUSA.GetPackingLabel());
            Console.WriteLine(orderNonUSA.GetShippingLabel());
            Console.WriteLine("Total Cost: $" + orderNonUSA.CalculateTotalCost());
        }
    }
}
