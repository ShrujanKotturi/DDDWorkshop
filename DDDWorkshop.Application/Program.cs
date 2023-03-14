using System.Text.Json;
using DDDWorshop.Domain;

namespace DDDWorkshop.Application;

class Program
{
    static void Main(string[] args)
    {
        var applePencil = new Product("Apple Pencil");
        var cart = new Cart();
        cart.Add(applePencil);

        var sonyHeadphone = new Product("Sony Headphone");
        cart.Add(sonyHeadphone);

        Console.WriteLine("--------------------------------------------------------");
        Console.WriteLine("Cart = " + cart);
        List<Product> products = cart.Get();
        Console.WriteLine("--------------------------------------------------------");
        Console.WriteLine("products = " + JsonSerializer.Serialize(products));

    }
}

