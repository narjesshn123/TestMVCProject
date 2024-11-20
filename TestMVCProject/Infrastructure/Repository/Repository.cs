using System.Security.Cryptography;
using MinimalProject.Catalog.Domain.Primitive.Contract;
using TestMVCProject.Domain.Product;

namespace MinimalProject.Catalog.Infrastructure.Repository
{
    public abstract class Repository<TEntity, TId> : IRepository<TEntity, TId>
        where TEntity : TEntity<TId> where TId : notnull
    {

        private static readonly Dictionary<TId, TEntity> storage = new();
        static Repository()
        {
         
            var product1 = new Product(1) { Name = "Product A", Description = "Description of Product A", Price = 100 };
            var product2 = new Product(2) { Name = "Product B", Description = "Description of Product B", Price = 200 };

      
            storage.Add((TId)(object)product1.Id, (TEntity)(object)product1);
            storage.Add((TId)(object)product2.Id, (TEntity)(object)product2);
        }
        public TId Add(TEntity entity)
        {
             storage.Add(entity.Id, entity);
            return entity.Id; 
        }

        public void Delete(TEntity entity)
        {
            storage.Remove(entity.Id);                                      
        }

        public IEnumerable<TEntity> GetAll()
        {
            return storage.Values.ToList();
        }

        public TEntity GetById(TId id) => storage[id];  

        public void Update(TEntity entity) => storage[entity.Id] = entity;          
    }
}
