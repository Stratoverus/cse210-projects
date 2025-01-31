class Product
{
    private string _name;
    private int _productId;
    private float _price;
    private int _quantity;
    public Product(string name, int productId)
    {
        _name = name;
        _productId = productId;
    }

    public float TotalCost()
    {
        return _quantity * _price;
    }

    public void Display()
    {
        
    }
}