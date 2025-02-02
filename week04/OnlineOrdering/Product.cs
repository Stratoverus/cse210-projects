class Product
{
    private string _name;
    private int _productId;
    private double _price;
    private int _quantity;
    public Product(string name, int productId, double price, int quantity)
    {
        _name = name;
        _productId = productId;
        _price = price;
        _quantity = quantity;
    }

    public double TotalCost()
    {
        return _quantity * _price;
    }

//Might not need this with the requirements asking for a string.
    public void Display()
    {
        
    }
}