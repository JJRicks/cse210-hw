public class Product
{
    public string Name { get; set; }
    public int ProductId { get; set; }
    public decimal PricePerUnit { get; set; }
    public int Quantity { get; set; }

    public Product(string name, int productId, decimal pricePerUnit, int quantity)
    {
        Name = name;
        ProductId = productId;
        PricePerUnit = pricePerUnit;
        Quantity = quantity;
    }

    public decimal GetTotalCost()
    {
        return PricePerUnit * Quantity;
    }
}