using MinimalProject.Catalog.Domain.Primitive.Contract;
using TestMVCProject.Domain.Product;

namespace MinimalProject.Catalog.Domain.Products
{
    public interface IProductRepository:IRepository<Product, int>
    {
        
    }
}
