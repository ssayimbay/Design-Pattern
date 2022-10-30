using Structural.Decorator.RepositoryWithFeature.Models;

namespace Structural.Decorator.RepositoryWithFeature.Repositories;

public interface IRepository
{
    Task<Product?> GetById(int id);

    Task<List<Product>> GetAll();

    Task<Product> Save(Product product);

    Task Update(Product product);

    Task Remove(Product product);
}
