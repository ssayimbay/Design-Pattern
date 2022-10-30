using Structural.Decorator.RepositoryWithFeature.Models;
using Structural.Decorator.RepositoryWithFeature.Repositories;

namespace Structural.Decorator.RepositoryWithFeature.RepositoryDecorator;

public abstract class BaseRepositoryDecorator : IRepository
{
    private readonly IRepository _repository;

    protected BaseRepositoryDecorator(IRepository repository)
    {
        _repository = repository;
    }

    public virtual async Task<List<Product>> GetAll()
    {
        return await _repository.GetAll();
    }

    public virtual async Task<Product?> GetById(int id)
    {
        return await _repository.GetById(id);
    }

    public virtual async Task Remove(Product? product)
    {
        await _repository.Remove(product);
    }

    public virtual async Task<Product> Save(Product product)
    {
        return await _repository.Save(product);
    }

    public virtual async Task Update(Product product)
    {
        await _repository.Update(product);
    }
}
