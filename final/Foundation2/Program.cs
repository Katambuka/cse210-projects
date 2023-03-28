class Program
{
    static void Main(string[] args)
    {
        Address address = new Address("100 Main St", "Carlsbad", "CA", "10015", "USA");
        Customer customer = new Customer("James Web Space", address);
        Order order = new Order(customer);

        Product product1 = new Product("/nApple Earbuds", 9.99m, 2, 1);
        Product product2 = new Product("Gizmo", 14.99m, 1, 2);

        order.AddProduct(product1);
        order.AddProduct(product2);

        Console.WriteLine(order.GetShippingLabel());
        Console.WriteLine(order.GetPackingLabel());
        Console.WriteLine($"Total cost: {order.GetTotalPrice():C}");
    }
}