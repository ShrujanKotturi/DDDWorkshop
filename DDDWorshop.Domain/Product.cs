using System;
namespace DDDWorshop.Domain;

public class Product
{
	private readonly string _name;

	public Product(string name)
	{
		_name = name;
	}

	public override string ToString()
	{
		return "Name : " + _name;
	}

}
