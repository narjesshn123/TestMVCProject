using TestMVCProject.Domain.Product;

namespace TestMVCProject.Application.Service
{
    public interface IProductManager
    {
        IEnumerable<Product> GetAllProducts();
        Product GetProductById(int id);
    }
}
