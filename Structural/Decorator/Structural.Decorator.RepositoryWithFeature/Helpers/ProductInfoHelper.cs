using Structural.Decorator.RepositoryWithFeature.Models;

namespace Structural.Decorator.RepositoryWithFeature.Helpers;

public static class ProductInfoHelper
{
    public static void WriteList(List<Product> products)
    {
        Console.WriteLine("---------------------------------------------------------------");

        products?.ForEach(x =>
        {
            Write(x);
        });

        Console.WriteLine("---------------------------------------------------------------\n");
    }

    public static void Write(Product? product)
    {
        Console.WriteLine($"Id : {product?.Id}  Name : {product?.Name}  Stock : {product?.Stock}  Price : {product?.Price}");
    }
}
