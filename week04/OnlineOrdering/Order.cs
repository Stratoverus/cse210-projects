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
        return 0;
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