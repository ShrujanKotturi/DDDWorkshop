using System.Text.Json;

namespace DDDWorshop.Domain;

public class Item
{
	private readonly Product _product;
	private readonly int _quantity;

	public Item(Product product, int quantity)
	{
		_product = product;
		_quantity = quantity;
	}

    public override string? ToString()
    {
		return "Item { " + "product = " + _product.ToString() + " , quantity = " + _quantity + "}";
    }
}

