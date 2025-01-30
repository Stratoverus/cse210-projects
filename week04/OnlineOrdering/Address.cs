class Address
{
    private string _street;
    private string _city;
    private string _state;
    private string _country;

    public Address(string street, string city, string state, string country)
    {

    }

    public bool IsUsa(string country)
    {
        return true;
    }
}