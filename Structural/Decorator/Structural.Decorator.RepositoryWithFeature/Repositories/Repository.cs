using Structural.Decorator.RepositoryWithFeature.Models;

namespace Structural.Decorator.RepositoryWithFeature.Repositories
{
    public class Repository : IRepository
    {
        private List<Product> _products;

        public Repository()
        {
            _products = new List<Product>
            {
                new Product { Id = 1, Name = "Name1", Price = 100, Stock = 100 },
                new Product { Id = 2, Name = "Name2", Price = 200, Stock = 200 },
                new Product { Id = 3, Name = "Name3", Price = 300, Stock = 300 },
                new Product { Id = 4, Name = "Name4", Price = 400, Stock = 400 },
            };
        }

        public Task<List<Product>> GetAll()
        {
            return Task.FromResult(_products);
        }

        public Task<Product?> GetById(int id)
        {
            return Task.FromResult(_products.FirstOrDefault(x => x.Id == id));
        }

        public Task Remove(Product product)
        {
            return Task.FromResult(_products.Remove(product));
        }

        public Task<Product> Save(Product product)
        {
            _products.Add(product);
            return Task.FromResult(product);
        }

        public Task Update(Product product)
        {
            _products.ForEach(x =>
            {
                if(x.Id == product.Id)
                {
                    x.Price = product.Price;
                    x.Stock = product.Stock;
                    x.Name = product.Name;
                }
            });
            return Task.FromResult(product);
        }
    }
}
