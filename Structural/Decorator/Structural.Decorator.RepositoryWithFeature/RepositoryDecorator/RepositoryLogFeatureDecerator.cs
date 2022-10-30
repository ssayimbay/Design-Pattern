using Structural.Decorator.RepositoryWithFeature.Models;
using Structural.Decorator.RepositoryWithFeature.Repositories;

namespace Structural.Decorator.RepositoryWithFeature.RepositoryDecorator
{
    public class RepositoryLogFeatureDecerator : BaseRepositoryDecorator
    {
        public RepositoryLogFeatureDecerator(IRepository repository) : base(repository)
        {
        }

        public override async Task<List<Product>> GetAll()
        {
            Console.WriteLine("GetAll running..");
            return await base.GetAll();
        }

        public override async Task<Product?> GetById(int id)
        {
            Console.WriteLine("GetById running..");
            return await base.GetById(id);
        }

        public override Task<Product> Save(Product product)
        {
            Console.WriteLine("Save running..");
            return base.Save(product);
        }

        public override Task Update(Product product)
        {
            Console.WriteLine("Update running..");
            return base.Update(product);
        }

        public override Task Remove(Product? product)
        {
            Console.WriteLine("Remove running..");
            return base.Remove(product);
        }
    }
}
