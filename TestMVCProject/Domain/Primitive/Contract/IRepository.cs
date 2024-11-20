using MinimalProject.Catalog.Domain.Products;
using TestMVCProject.Domain.Product;

namespace MinimalProject.Catalog.Domain.Primitive.Contract
{
    public interface IRepository<TEntity, TId>
    {
        TId Add(TEntity entity); 
        void Delete(TEntity entity);
        TEntity GetById(TId id);
        void Update(TEntity entity);
        IEnumerable<TEntity> GetAll();

    }
}

