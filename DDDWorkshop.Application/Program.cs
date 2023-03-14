using System.Text.Json;
using DDDWorshop.Domain;

namespace DDDWorkshop.Application;

class Program
{
    static void Main(string[] args)
    {
        var applePencil = new Product("Apple Pencil");
        var applePencilItem = new Item(applePencil, 2);
        var cart = new Cart();
        cart.Add(applePencilItem);

        var sonyHeadphone = new Product("Sony Headphone");
        var sonyHeadphoneItem = new Item(sonyHeadphone, 3);
        cart.Add(sonyHeadphoneItem);

        Console.WriteLine("--------------------------------------------------------");
        Console.WriteLine("Cart = " + cart);
        List<Item> items = cart.Get();
        Console.WriteLine("--------------------------------------------------------");
        Console.WriteLine("items = " + string.Join(" , ", items.Select(item => $"{item}")));

        Console.ReadKey();
    }
}

