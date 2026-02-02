using System.Reflection.Emit;

class Order
{
    private List<Product> _order = new List<Product>();
    private Customer _customer;

    public Order(Customer customer)
    {
        _customer = customer;
        _order = new List<Product>();
    }

    public void AddProduct(Product order)
    {
        _order.Add(order);
    }

    public float OrderTotalCost()
    {
        float total = 0;

        foreach (Product product in _order)
        {
            total += product.ProductCost();
        }

        if (_customer.IsInUsa())
        {
            total += 5;
        }

        else
        {
            total += 35;
        }

        return total;
    }

    public string PackingLabel()
    {
        string Packing = "";

        foreach (Product product in _order)
        {
            Packing += $"Product Name: {product.GetName()}, Product ID: {product.GetId()}";
        }
        return Packing;
    }

    public string ShippingLabel()
    {
        string shipping = "";
        shipping += $"Customer Name: {_customer.GetName()}\n";
        shipping = _customer.GetAddress() + "\n";
        return shipping;
    }
}