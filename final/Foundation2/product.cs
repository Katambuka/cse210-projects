class Product
{
    private const decimal TAX_RATE = 0.08m;

    public string Name { get; set; }
    public decimal Price { get; set; }
    public int Quantity { get; set; }
    public int ProductId { get; set; }

    public Product(string name, decimal price, int quantity, int productId)
    {
        Name = name;
        Price = price;
        Quantity = quantity;
        ProductId = productId;
    }

    public decimal GetTotalPrice()
    {
        decimal totalPrice = Price * Quantity;
        decimal tax = totalPrice * TAX_RATE;
        return totalPrice + tax;
    }
}