using System;
namespace DDDWorshop.Domain;

public class Cart
{
    private List<Product> _products = new();

    public void Add(Product product)
    {
        _products.Add(product);
    }

    public List<Product> Get() => _products;

    public override string ToString()
    {
        return string.Join(" , ", _products.Select(product => $"{product}"));
    }

}


