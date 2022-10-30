using Microsoft.Extensions.Caching.Memory;
using Structural.Decorator.RepositoryWithFeature.Models;
using Structural.Decorator.RepositoryWithFeature.Repositories;

namespace Structural.Decorator.RepositoryWithFeature.RepositoryDecorator;

public class RepositoryCacheFeatureDecorator : BaseRepositoryDecorator
{
    private readonly IMemoryCache _memoryCache;
    private const string CACHE_KEY = "key";
    public RepositoryCacheFeatureDecorator(IRepository repository) : base(repository)
    {
        var memoryCacheOptions = new MemoryCacheOptions();
        memoryCacheOptions.ExpirationScanFrequency = TimeSpan.FromMinutes(15);
        _memoryCache = new MemoryCache(memoryCacheOptions);
    }

    public override async Task<List<Product>> GetAll()
    {
        if (_memoryCache.TryGetValue(CACHE_KEY, out List<Product> result))
        {
            return (result);
        }

        await UpdateCache();
        return _memoryCache.Get<List<Product>>(CACHE_KEY);
    }

    public override async Task<Product> Save(Product product)
    {
        await base.Save(product);
        await UpdateCache();
        return product;
    }

    public override async Task<Product?> GetById(int id)
    {
        var products = await GetAll();
        return products.FirstOrDefault(x => x.Id == id);
    }

    public override async Task Remove(Product? product)
    {
        await base.Remove(product);
        await UpdateCache();
    }

    public override async Task Update(Product product)
    {
        await base.Update(product);
        await UpdateCache();
    }

    private async Task UpdateCache()
    {
        _memoryCache.Set(CACHE_KEY, await base.GetAll());
        Console.WriteLine("Cache Uptated..");
    }
}
