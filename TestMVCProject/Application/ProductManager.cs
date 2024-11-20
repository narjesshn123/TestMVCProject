using MinimalProject.Catalog.Domain.Products;
using MinimalProject.Catalog.Infrastructure.Repository;
using TestMVCProject.Application.Dto;
using TestMVCProject.Application.Service;
using TestMVCProject.Domain.Product;

namespace TestMVCProject.Application
{
    public class ProductManager(IProductRepository productRepository) : IProductManager
    {
        public IEnumerable<Product> GetAllProducts()
        {
            var products = productRepository.GetAll().ToList();
            return products; 
        }

        public Product GetProductById(int id)
        {
            var product = productRepository.GetById(id); 
            return product;
        }
    }
}
