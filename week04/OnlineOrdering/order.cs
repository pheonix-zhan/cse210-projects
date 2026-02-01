using System.Net.Http.Headers;
using System.Reflection.Metadata.Ecma335;

public class Order
{
private Customer _customer;
private List<Product> _products = new List<Product>();


public Order(Customer customer)
{
_customer = customer;
}


public void AddProduct(Product product)
{
_products.Add(product);
}


public double CalculateTotalCost()
{
double total = 0;


foreach (Product product in _products)
{
total += product.GetTotalCost();
}


double shippingCost = _customer.LivesInUSA() ? 5 : 35; 
   return total + shippingCost;
}


public string GetPackingLabel()
{
string label = "PACKING LABEL\n";


foreach (Product product in _products)
{
label += $"{product.GetName()} (ID: {product.GetProductId()})\n";
}


return label;
}


public string GetShippingLabel()
{
return $"SHIPPING LABEL\n{_customer.GetName()}\n{_customer.GetAddress().GetFullAddress()}";
}
}