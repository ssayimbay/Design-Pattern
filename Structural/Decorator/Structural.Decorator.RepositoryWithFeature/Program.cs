
using Structural.Decorator.RepositoryWithFeature.Helpers;
using Structural.Decorator.RepositoryWithFeature.Models;
using Structural.Decorator.RepositoryWithFeature.Repositories;
using Structural.Decorator.RepositoryWithFeature.RepositoryDecorator;

IRepository repository = new Repository();
repository = new RepositoryLogFeatureDecerator(repository);
repository = new RepositoryCacheFeatureDecorator(repository);

var products = await repository.GetAll();
ProductInfoHelper.WriteList(products);

var product = await repository.GetById(1);
if (product != null)
{
    product.Name = "Test Name";
    await repository.Update(product);
    ProductInfoHelper.WriteList(products);
}
 
await repository.Save(new Product
{
    Id = 5,
    Name = "Name 5",
    Price = 500,
    Stock = 500
});

products = await repository.GetAll();
ProductInfoHelper.WriteList(products);

await repository.Remove(product);
ProductInfoHelper.WriteList(products);

products = await repository.GetAll();
ProductInfoHelper.WriteList(products);

Console.ReadLine();