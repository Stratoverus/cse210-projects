class Order
{
    private List<Product> _products = new();
    private Customer _customer;
    private Product _product;

    public Order(Customer customer, List<Product> products)
    {
        _customer = customer;
        _products = products;
    }
    public double TotalPrice()
    {
        double price = _product.TotalCost() + ShippingCost();
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
        string label = $"Name:  ";
        return label;
    }

    public string ShowPackingLabel()
    {
        foreach (Product product in _products)
        {
            //string order = _product
        }
        string label = $"Order List:  ";
        return label;
    }

    public void DisplayLabel()
    {
        Console.WriteLine("Thank you for your order, here is the shipping label and packing label.");
        Console.WriteLine("Shipping label:");
        Console.WriteLine(ShowShippingLabel());
        Console.WriteLine("");
        Console.WriteLine("Packing Label:");
        Console.WriteLine(ShowPackingLabel());
    }
}