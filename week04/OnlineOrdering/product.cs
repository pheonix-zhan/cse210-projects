
public class Product
{
    private string _name;
    private string _productId;
    private double _pricePerUnit;
    private int _quantity;

public Product(string name, string id, double price, int quantity)
    {
        name = _name;
        id = _productId;
        price = _pricePerUnit;
        quantity = _quantity;
    }

public double GetTotalCost()
    {
        return _pricePerUnit * _quantity;
    }
public string GetName()
    {
        return _name;
    }

public string GetProductId()
    {
        return _productId;
    }
}