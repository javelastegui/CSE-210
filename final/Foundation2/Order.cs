using System.Collections.Generic;

namespace Program2
{
    public class Order
    {
        public List<Product> Products { get; set; }
        public Customer Customer { get; set; }

        public Order(Customer customer)
        {
            Customer = customer;
            Products = new List<Product>();
        }

        public decimal CalculateTotalCost()
        {
            decimal total = 0;
            foreach (Product product in Products)
            {
                total += product.GetTotalCost();
            }
            total += Customer.LivesInUSA() ? 5m : 35m;
            return total;
        }

        public string GetPackingLabel()
        {
            string label = "Packing Label:\n";
            foreach (Product product in Products)
            {
                label += $"{product.Name} (ID: {product.ProductId})\n";
            }
            return label;
        }

        public string GetShippingLabel()
        {
            string label = "Shipping Label:\n";
            label += Customer.Name + "\n";
            label += Customer.Address.GetFullAddress();
            return label;
        }
    }
}
