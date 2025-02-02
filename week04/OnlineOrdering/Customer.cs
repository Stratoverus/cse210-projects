class Customer
{
    private string _name;
    private Address _address;
    public Customer(string name, Address address)
    {
        _name = name;
        _address = address;
    }

    public bool LiveInUsa()
    {
        return _address.IsUsa();
    }

    //Instructions don't say to include this, but I can't figure out how to not include this without breaking encapsulation
    public string CustomerName()
    {
        return _name;
    }

    public string GetFullAddress()
    {
        return _address.FullAddress();
    }
}