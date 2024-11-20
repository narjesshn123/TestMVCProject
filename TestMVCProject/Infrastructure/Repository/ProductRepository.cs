using MinimalProject.Catalog.Domain.Products;
using TestMVCProject.Domain.Product;

namespace MinimalProject.Catalog.Infrastructure.Repository
{
    public class ProductRepository: Repository<Product, int>, IProductRepository
       
    {
    }
}
