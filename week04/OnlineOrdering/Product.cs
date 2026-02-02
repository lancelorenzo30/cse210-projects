class Product
{
    private string _productName;
    private int _productId;
    private int _productQuantity;
    private float _productPricePerUnit;

    public Product(string name, int id, int quantity, float price)
    {
        _productName = name;
        _productId = id;
        _productQuantity = quantity;
        _productPricePerUnit = price;
    }

    public float ProductCost()
    {
        return _productQuantity * _productPricePerUnit;
    }

    public string GetName()
    {
        return _productName;
    }

    public int GetId()
    {
        return _productId;
    }
}