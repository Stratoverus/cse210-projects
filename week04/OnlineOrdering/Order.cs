class Order
{
    private List<Product> _products = new();
    private Customer customer;

    public float TotalPrice()
    {
        return 0;
    }

    public int ShippingCost()
    {
        int cost;
        if (customer.LiveInUsa())
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
        return "";
    }

    public string ShowPackingLabel()
    {
        return "";
    }
}