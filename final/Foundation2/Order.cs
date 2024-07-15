public class Order
{
    private List<Product> Products { get; set; }
    private Customer Customer { get; set; }

    public Order(Customer customer)
    {
        Customer = customer;
        Products = new List<Product>();
    }

    public void AddProduct(Product product)
    {
        Products.Add(product);
    }

    public decimal GetTotalCost()
    {
        decimal total = 0;
        foreach (var product in Products)
        {
            total += product.GetTotalCost();
        }
        decimal shippingCost = Customer.IsInUSA() ? 5 : 35;
        return total + shippingCost;
    }

    public string GetPackingLabel()
    {
        string label = "Packing List:\n";
        foreach (var product in Products)
        {
            label += $"{product.Name}, ID: {product.ProductId}\n";
        }
        return label;
    }

    public string GetShippingLabel()
    {
        return $"Shipping To:\n{Customer.Name}\n{Customer.Address.GetFullAddress()}";
    }
}