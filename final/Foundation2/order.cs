using System;

class Order
{
    private const decimal USA_SHIPPING_COST = 5m;
    private const decimal INTERNATIONAL_SHIPPING_COST = 35m;
    private Product[] products;

    public Customer Customer { get; set; }

    public Order(Customer customer)
    {
        Customer = customer;
        products = new Product[0];
    }

    public decimal GetTotalPrice()
    {
        decimal totalPrice = 0m;

        foreach (Product product in products)
        {
            totalPrice += product.GetTotalPrice();
        }

        totalPrice += Customer.IsInUSA() ? USA_SHIPPING_COST : INTERNATIONAL_SHIPPING_COST;

        return totalPrice;
    }

    public void AddProduct(Product product)
    {
        Array.Resize(ref products, products.Length + 1);
        products[products.Length - 1] = product;
    }

    public string GetPackingLabel()
    {
        string packingLabel = "";

        foreach (Product product in products)
        {
            packingLabel += $"{product.Name} ({product.ProductId})\n";
        }

        return packingLabel.TrimEnd('\n');
    }

    public string GetShippingLabel()
    {
        return $"{Customer.Name}\n{Customer.Address}";
    }
}