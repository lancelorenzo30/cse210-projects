class Order
{
    private List<Product> _order = new List<Product>();
    private Customer _customer;

    public Order(Customer customer)
    {
        
    }

    public float OrderTotalCost()
    {
        return 0;
    }

    public string PackingLabel()
    {
        return "";
    }

    public string ShippingLabel()
    {
        return "";
    }
}