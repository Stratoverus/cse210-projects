class Order
{
    private List<Product> _products = new();
    private Customer _customer;
    private Address _address;

    public Order(Customer customer, List<Product> products)
    {
        _customer = customer;
        _products = products;
    }
    public double TotalPrice()
    {
        double price = 0;
        foreach (Product product in _products)
        {
            price += product.TotalCost();
        }
        price += ShippingCost();
        return price;
    }

    public int ShippingCost()
    {
        int cost;
        if (_customer.LiveInUsa())
        {
            cost = 5;
        }
        else
        {
            cost = 35;
        }
        return cost;
    }

    public string ShowShippingLabel()
    {
        string label = $"Name:  {_customer.CustomerName} Address: {_address.FullAddress}";
        return label;
    }

    public string ShowPackingLabel()
    {
        string productLabel = "";
        foreach (Product product in _products)
        {
            productLabel += $"{product}\n";
        }
        return $"Order List: {productLabel}";
    }

    public void DisplayLabels()
    {
        Console.WriteLine("Thank you for your order, here is the shipping label and packing label.");
        Console.WriteLine("Shipping label:");
        Console.WriteLine(ShowShippingLabel());
        Console.WriteLine("");
        Console.WriteLine("Packing Label:");
        Console.WriteLine(ShowPackingLabel());
        Console.WriteLine("");
        Console.WriteLine(TotalPrice());
    }
}