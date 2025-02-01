class Order
{
    private List<Product> _products = new();
    private Customer _customer;
    private Product _product;

    public float TotalPrice()
    {
        float price = _product.TotalCost() + ShippingCost();
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
        return "";
    }

    public string ShowPackingLabel()
    {
        return "";
    }
}