class Customer
{
    private string _customer;
    private Address _address;

    public Customer(string name, Address address)
    {
        _customer = name;
        _address = address;
    }
    
    public bool IsInUsa()
    {
        return _address.IsInUsa();
    }

    public string GetName()
    {
        return _customer;
    }

    public string GetAddress()
    {
        return _address.CompleteAddress();
    }
}