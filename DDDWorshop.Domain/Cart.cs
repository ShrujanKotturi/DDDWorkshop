using System;
namespace DDDWorshop.Domain;

public class Cart
{
    private List<Item> _items = new();

    public void Add(Item item)
    {
        _items.Add(item);
    }

    public List<Item> Get() => _items;

    public override string ToString()
    {
        return string.Join(" , ", _items.Select(item => $"{item}"));
    }

}


